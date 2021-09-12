using System;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using log4net;
using log4net.Config;

namespace DescargaLco
{
    public class FtpClient
    {
        protected static ILog Logger = LogManager.GetLogger(typeof (LcoLogic));
        // The hostname or IP address of the FTP server
        private string _remoteHost;

        // The remote username
        private string _remoteUser;

        // Password for the remote user
        private string _remotePass;

        private int intentos = 20;

        public FtpClient(string remoteHost)
        {
            XmlConfigurator.Configure();
            _remoteHost = remoteHost;
            _remoteUser = "anonymous";
        }

        public FtpClient(string remoteHost, string remoteUser, string remotePassword)
        {
            _remoteHost = remoteHost;
            _remoteUser = remoteUser;
            _remotePass = remotePassword;
        }

        public string DirectoryListing()
        {
            FtpWebRequest request = (FtpWebRequest) WebRequest.Create(_remoteHost);
            request.Method = WebRequestMethods.Ftp.ListDirectory;
            request.Credentials = new NetworkCredential(_remoteUser, _remotePass);
            FtpWebResponse response = (FtpWebResponse) request.GetResponse();
            Stream responseStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(responseStream);

            string result = string.Empty;

            while (!reader.EndOfStream)
            {
                result += reader.ReadLine() + Environment.NewLine;
            }

            reader.Close();
            response.Close();
            return result;
        }



        public string FileSize(string fileUrl)
        {
            FtpWebRequest request = (FtpWebRequest) WebRequest.Create(_remoteHost + fileUrl);
            request.Method = WebRequestMethods.Ftp.GetFileSize;
            request.Credentials = new NetworkCredential(_remoteUser, _remotePass);
            FtpWebResponse response = (FtpWebResponse) request.GetResponse();
            if (response != null)
                return response.ContentLength.ToString();
            return null;
        }

        public string DirectoryListing(string folder)
        {
            int intento = 0;
            while (intento <= intentos)
            {
                try
                {
                    FtpWebRequest request = (FtpWebRequest) WebRequest.Create(_remoteHost + folder);
                    request.Method = WebRequestMethods.Ftp.ListDirectory;
                    request.Credentials = new NetworkCredential(_remoteUser, _remotePass);
                    FtpWebResponse response = (FtpWebResponse) request.GetResponse();
                    Stream responseStream = response.GetResponseStream();
                    StreamReader reader = new StreamReader(responseStream);

                    string result = string.Empty;

                    while (!reader.EndOfStream)
                    {
                        result += reader.ReadLine() + Environment.NewLine;
                    }
                    reader.Close();
                    response.Close();
                    return result;

                }
                catch (Exception ex)
                {
                    Logger.Info(ex);
                }
            }
            Logger.Error("Se intentó " + intentos + "Veces y no se pudo listar el directorio");
            return null;
        }


        public bool Download(string file, string destination)
        {
            int intento = 0;
            while (intento <= intentos)
            {
                Thread.Sleep(100);
                intento++;
                Logger.Info("Descargando " + file + ", Intento: " + intento);
                var request = (FtpWebRequest) WebRequest.Create(_remoteHost + file);
                request.Method = WebRequestMethods.Ftp.DownloadFile;
                request.Credentials = new NetworkCredential(_remoteUser, _remotePass);
                request.UseBinary = true;
                var fileName = _remoteHost + file;
                try
                {
                    var downloadResponse = (FtpWebResponse) request.GetResponse();
                    Logger.Info("getting ftp response stream for " + fileName);
                    try
                    {
                        Stream downloadStream = downloadResponse.GetResponseStream();
                        Logger.Info("File Download status: " + downloadResponse.StatusDescription.Trim());
                        Logger.Info("getting binary reader for " + fileName);
                        try
                        {
                            using (var downloadReader = new BinaryReader(downloadStream))
                            {
                                Logger.Info("writing response stream to " + destination);
                                try
                                {
                                    using (
                                        var downloadWriter =
                                            new BinaryWriter(System.IO.File.Open(destination, FileMode.Create)))
                                    {
                                        int BufferSize = 2048;
                                        var buffer = new byte[BufferSize];
                                        int readCount = downloadReader.Read(buffer, 0, BufferSize);
                                        while (readCount > 0)
                                        {
                                            downloadWriter.Write(buffer, 0, readCount);
                                            readCount = downloadReader.Read(buffer, 0, BufferSize);
                                        }
                                    }
                                    Logger.Info("successfully saved " + destination);
                                    break;
                                }
                                catch (Exception ex)
                                {
                                    Logger.Info("could not save " + destination + " b/c: " + ex.Message);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            Logger.Info("could not read " + fileName + " b/c: " + ex.Message);
                        }
                    }
                    catch (Exception ex)
                    {
                        Logger.Info("could not open download stream for " + fileName + " b/c: " + ex.Message);
                    }
                    finally
                    {
                        downloadResponse.Close();
                    }
                }
                catch (Exception ex)
                {
                    Logger.Info("could not get ftp response stream for " + fileName + " b/c: " + ex.Message);
                }
            }
            Logger.Error("Se intentó " + intentos + "Veces y no se pudo descargar el archivo");
            return false;
        }
    



        public void UploadFile(string FullPathFilename)
        {
            string filename = Path.GetFileName(FullPathFilename);

            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(_remoteHost + filename);
            request.Method = WebRequestMethods.Ftp.UploadFile;
            request.Credentials = new NetworkCredential(_remoteUser, _remotePass);

            StreamReader sourceStream = new StreamReader(FullPathFilename);
            byte[] fileContents = Encoding.UTF8.GetBytes(sourceStream.ReadToEnd());

            request.ContentLength = fileContents.Length;

            Stream requestStream = request.GetRequestStream();
            requestStream.Write(fileContents, 0, fileContents.Length);

            FtpWebResponse response = (FtpWebResponse)request.GetResponse();

            response.Close();
            requestStream.Close();
            sourceStream.Close();
        }

    }	

}

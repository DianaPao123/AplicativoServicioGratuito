using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using log4net;
using log4net.Config;

namespace DescargaLco
{
    public class DescargaFolios
    {
        protected static ILog Logger = LogManager.GetLogger(typeof(DescargaFolios));
        
        public DescargaFolios()
        {
            XmlConfigurator.Configure();
        }


        public bool DescargaFoliosFtp()
        {
            try
            {
                int indice;
                var rutaIndex = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Index.txt");
                indice = File.Exists(rutaIndex) ? int.Parse(File.ReadAllText(rutaIndex)) : 0;
                var rutaFolios = ConfigurationManager.AppSettings["UrlFolios"];
                Logger.Info("Descargando archivo " + rutaFolios);
                var request = WebRequest.Create(rutaFolios) as FtpWebRequest;
                request.Method = WebRequestMethods.Ftp.DownloadFile;
                request.UsePassive = false;
                request.Timeout = 30000;
                var respuesta = request.GetResponse();
                int contador = 1;
                var rutaTrabajo = Path.Combine(ConfigurationManager.AppSettings["RutaTrabajo"], "Folios.txt");
                using (var streamRespuesta = respuesta.GetResponseStream())
                {
                    if (streamRespuesta != null)
                    {
                        using (var lector = new StreamReader(streamRespuesta))
                        {
                            lector.ReadLine();
                            using (StreamWriter sw = new StreamWriter(rutaTrabajo, false, Encoding.ASCII))
                            {
                                while (!lector.EndOfStream)
                                {
                                    var linea = lector.ReadLine();
                                    if (contador >= indice)
                                        sw.Write(linea + "\r\n");
                                    contador++;
                                }
                            }
                        }
                    }
                }


                
                using (var con = new SqlConnection(ConfigurationManager.AppSettings["cnn"]))
                {
                    con.Open();
                    SqlCommand command = new SqlCommand("[InsertaFolios]", con);
                    command.CommandTimeout = 3600;
                    command.Parameters.AddWithValue("archivo", rutaTrabajo);
                    command.CommandType = CommandType.StoredProcedure;
                    var result = command.ExecuteScalar();
                    Logger.Info(result + " Registros");
                    File.WriteAllText(rutaIndex, contador.ToString());
                }


            }
            catch (Exception ex)
            {
                Logger.Error(
                    "No se pudo realizar la conexion FTP para descargar el archivo de folios \nMensaje: " +
                    (ex.InnerException != null
                         ? ex.InnerException.Message
                         : ex.Message));
                return false;
            }
            return true;
        }



    }
}

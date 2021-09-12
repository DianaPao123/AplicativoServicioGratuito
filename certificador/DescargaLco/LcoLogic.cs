using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using Org.BouncyCastle.Cms;
using ServicioLocalContract;
using log4net;
using log4net.Config;


namespace DescargaLco
{
    public class LcoLogic 
    {

        protected static ILog Logger = LogManager.GetLogger(typeof(LcoLogic));
        private readonly string _urlSatLco = ConfigurationManager.AppSettings["UrlSatLco"];
        private string rutaDescargas;

        public LcoLogic()
        {
            XmlConfigurator.Configure();
            rutaDescargas = ConfigurationManager.AppSettings["RutaDescargas"];
        }

        //public RfcLco SearchLCOByNoCertificado(string noCertificado)
        //{
        //    //DataSet ds = new
        //    //LCOData().SearchLCOByNoCertificado(noCertificado);
        //    try
        //    {
        //        using (var db = new NtLinkLocalServiceEntities())
        //        {
        //            db.CommandTimeout = 3600;
        //            var lco = db.RfcLco.FirstOrDefault(p => p.noCertificado == noCertificado);
        //            return lco;
        //        }
        //    }
        //    catch (Exception ee)
        //    {
        //        Logger.Error(ee.Message);
        //        return null;
        //    }
        //}

        //public RfcLco SearchLCOByRFC(string rfc)
        //{
        //    try
        //    {
        //        using (var db = new NtLinkLocalServiceEntities())
        //        {
        //            var lco = db.RfcLco.FirstOrDefault(p => p.Rfc == rfc);
        //            return lco;
        //        }
        //    }
        //    catch (Exception ee)
        //    {
        //        Logger.Error(ee.Message);
        //        return null;
        //    }
        //}



        //public bool Ejecutar()
        //{
        //    try
        //    {
        //        Logger.Info("Ejecutando stored procedure");
        //        using (var db = new NtLinkLocalServiceEntities())
        //        {
        //            db.CommandTimeout = 3600;
        //            var res =  db.InsertaLco();
        //            Logger.Info("resultado: " + res.First());
        //            return true;
        //        }
        //    }
        //    catch (Exception ee)
        //    {
        //        Logger.Error(ee);
        //        if (ee.InnerException != null)
        //            Logger.Error(ee.InnerException);
        //        return false;
        //    }

        //}

        //public bool ProcesarArchivoLcoWeb()
        //{
        //    try
        //    {
        //        using (var db = new NtLinkLocalServiceEntities())
        //        {
        //            if (this.ProcesarArchivoLcoSat())
        //            {
        //                db.CommandTimeout = 3600;
        //                var res = db.InsertaLco();
        //                Logger.Info("resultado: " + res.First());
        //                return true;
        //            }
        //            return false;
        //        }
        //    }
        //    catch (Exception ee)
        //    {
        //        Logger.Error(ee);
        //        if (ee.InnerException != null)
        //            Logger.Error(ee.InnerException);
        //        return false;
        //    }

        //}





        public bool ProcesarArchivoLcoSat()
        {
            try
            {
                int maxIntentos = 20;
                int intento = 1;
                while (intento <= maxIntentos)
                {
                    Logger.Info("intento: " + intento);
                    var archivos = this.DescargarArchivoLco(this._urlSatLco);
                    if (archivos != null && archivos.Count > 0)
                    {
                        var completos = this.DescomprimirArchivos(archivos);
                        GC.Collect();
                        if (completos!= null && completos.Count > 0)
                        {
                            var enClaro = this.ExcractLcoSignedData(completos);
                            {
                                GC.Collect();
                                if (enClaro != null && enClaro.Count > 0)
                                {
                                    var result = ParseXmlLco(enClaro);
                                    GC.Collect();
                                    if (result!= null)
                                    {
                                        var registros = InsertarLco(result);
                                        Logger.Info("Se cargó el archivo correctamente, eliminando archivos");
                                        var archivosParaBorrar =
                                            Directory.EnumerateFiles(Path.GetDirectoryName(archivos[0]), "*.XML");
                                        foreach (var s in archivosParaBorrar)
                                        {
                                            File.Delete(s);
                                        }
                                        archivosParaBorrar =
                                            Directory.EnumerateFiles(Path.GetDirectoryName(archivos[0]), "*.xml");
                                        foreach (var s in archivosParaBorrar)
                                        {
                                            File.Delete(s);
                                        }
                                        return registros;
                                    }
                                }
                            }
                        }
                        
                    }
                    else
                    {
                        
                        intento++;
                        Thread.Sleep(100);
                    }
                    
                }
                Logger.Info("Se intento descargar " + intento + " veces y todas falló");
                return false;
            }
            catch (Exception ee)
            {

                Logger.Error(ee.Message);
                if (ee.InnerException != null)
                {
                    Logger.Error(ee.InnerException.Message);
                }
                return false;
            }
        }

        public bool InsertarLco(string archivo)
        {/*
            using (var db = new NtLinkLocalServiceEntities())
            {
                Logger.Info("Llamando Stored Procedure InsertaLco() para el sitio de paga");
                db.CommandTimeout = 3600;
                var x = db.InsertaLco(archivo);
                Logger.Info("Proceso terminado: " + x.First() + " Registros insertados");
                Logger.Info("Llamando Stored Procedure InsertaLco() para el sitio gratuito");
                InsertaLco(archivo);
                return true;
            }
          */
            return true;
        }

        #region Helper Methods



        public void InsertaLco(string archivo)
        {
            Logger.Info("Ejecutando proceso proc_A_InsertaLCO() para el sitio gratuito");
            SqlConnection cnn = new SqlConnection(ConfigurationManager.AppSettings["cnn"]);
            SqlCommand Comando = new SqlCommand("[proc_A_InsertaLCO] ", cnn);
            Comando.Parameters.AddWithValue("rutaArchivo", archivo);
            Comando.CommandTimeout = 3600;
            cnn.Open();
            SqlTransaction transaccion = cnn.BeginTransaction();
            Comando.Transaction = transaccion;
            try
            {
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.ExecuteNonQuery();
                transaccion.Commit();
                Logger.Info("Proceso terminado");
            }
            catch (Exception ee)
            {
                Logger.Error(ee);
                if (ee.InnerException != null)
                {
                    Logger.Error(ee.InnerException.Message);
                }
                transaccion.Rollback();
                throw;
            }
            finally
            {
                Comando.Connection.Close();
                Comando.Dispose();
                transaccion.Dispose();
                cnn.Close();
            }
        }



        /*public bool DescargaSellos()
        {
            try
            {
                if (PersistLcoFile("CSD.txt", "CSD.txt"))
                {
                    Logger.Info("Ejecutando stored procedure");
                    using (var db = new NtLinkLocalServiceEntities())
                    {
                        db.CommandTimeout = 3600;
                        var res = db.InsertaCsd();
                        Logger.Info(res);
                        return true;
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                Logger.Error(ex);
                    if (ex.InnerException != null)
                        Logger.Error(ex.InnerException);

                return false;
            }
           
        }*/
        

        /*
        public bool DescargaFolios()
        {
            try
            {
                if (PersistLcoFile("FoliosCSD.txt", "FoliosCSD.txt"))
                {
                    Logger.Info("Ejecutando stored procedure");
                    using (var db = new NtLinkLocalServiceEntities())
                    {
                        db.CommandTimeout = 3600;
                        var res = db.InsertaCertsSat();
                        Logger.Info(res);
                        return true;
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                Logger.Error(
                    "No se pudo realizar la conexion FTP para descargar el archivo FoliosCSD.txt"+
                    (ex.InnerException != null
                         ? ex.InnerException.Message
                         : ex.Message));
                return false;
            }
           
        }
        */

        public bool DescomprimeArchivoLco(string archivoEntrada, string archivoSalida)
        {
            try
            {
                using (GZipStream instream = new GZipStream(File.OpenRead(archivoEntrada), CompressionMode.Decompress))// ArgumentException...
                {
                    using (FileStream outputStream = File.Create(archivoSalida))
                    {
                        int bufferSize = 8192, bytesRead = 0;
                        byte[] buffer = new byte[bufferSize];
                        while ((bytesRead = instream.Read(buffer, 0, bufferSize)) > 0)
                        {
                            outputStream.Write(buffer, 0, bytesRead);
                        }
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                Logger.Error(
                    "No se pudo realizar la conexion FTP para descargar el archivo de Certificados \nMensaje: " +
                    (ex.InnerException != null
                         ? ex.InnerException.Message
                         : ex.Message));
                return false;
            }
        }

        public List<string> DescomprimirArchivos(List<string> archivos)
        {
            try
            {
                List<string> res = new List<string>();
                foreach (string archivoComprimido in archivos)
                {
                    Logger.Info("Descomprimiendo el archivo" + archivoComprimido);
                    string archivoDescomprimido = archivoComprimido.Replace(".gz", "");
                    this.DescomprimeArchivoLco(archivoComprimido, archivoDescomprimido);
                    res.Add(archivoDescomprimido);
                }
                return res;
            }
            catch (Exception ee)
            {
                Logger.Error(ee);
                return null;
            }
            
        }

        public List<string> DescargarArchivoLco(string urlSatLco)
        {
            try
            {
                var lista = new List<string>();
                string nombreLco = "LCO_" + DateTime.Now.ToString("yyyy-MM-dd");
                Logger.Info("Obteniendo el archivo mas reciente de " + urlSatLco);
                var ftpClient = new FtpClient(urlSatLco);
                Logger.Info("Obteniendo la lista de archivos del SAT");
                string respuestaListing = ftpClient.DirectoryListing();

                List<string> lstLLcos = new List<string>(respuestaListing.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries));
                lstLLcos.RemoveAll(str => !str.Contains(nombreLco));
                Logger.Info("Devolvio " + lstLLcos.Count + " archivos, filtrando LCO");
                Parallel.ForEach(lstLLcos, (archivo) =>
                                               {
                                                   var ftp = new FtpClient(urlSatLco);
                                                   Logger.Info("Descargando el archivo: " + urlSatLco + archivo);
                                                   var rutaDestino = Path.Combine(rutaDescargas, nombreLco);
                                                   if (!Directory.Exists(rutaDestino))
                                                       Directory.CreateDirectory(rutaDestino);
                                                   string salida = Path.Combine(rutaDestino, archivo);
                                                   ftp.Download(archivo, salida);
                                                   lista.Add(salida);
                                                   Logger.Info("Archivo: " + salida + " guardardo");
                                               });
                
                return lista;
            }
            catch (Exception ex)
            {
                Logger.Error(
                    "No se pudo realizar la conexion FTP para descargar el archivo de Certificados \nMensaje: " +
                    (ex.InnerException != null
                         ? ex.InnerException.Message
                         : ex.Message));
                return null;
            }
            
        }


        

        public List<string> ExcractLcoSignedData(List<string> archivos )
        {
           
            foreach (string archivo in archivos)
            {
                try
                {
                    string archivoClaro = Path.Combine(Path.GetDirectoryName(archivo),
                                                       Path.ChangeExtension(archivo, ".claro.xml"));
                    var s = new CmsSignedData(new FileStream(archivo, FileMode.Open));
                    CmsProcessable cp = s.SignedContent;
                    Logger.Info("Cargando el XMLDocument");
                    FileStream st = File.Create(archivoClaro);
                    cp.Write(st);
                    st.Close();
                    cp = null;
                    //res.Add(archivoClaro);
                    GC.Collect();
                    
                }
                catch (Exception ee)
                {
                    Logger.Error(ee);
                    return null;
                }

            }
            List<string> res = new List<string>();
            foreach (string archivo in archivos)
            {
                

                string archivoClaro = Path.Combine(Path.GetDirectoryName(archivo),
                                                   Path.ChangeExtension(archivo, ".claro.xml"));
                res.Add(archivoClaro);
            }
            return res;
        }




        public string ParseXmlLco(List<string> archivos)
        {
            try
            {
                int i = 1;
                string path = Path.GetDirectoryName(archivos[0]);
                string nombre = path.Split("\\".ToCharArray()).Last().Replace("-", "");;
                nombre = Path.Combine(path, nombre + ".txt");
                StreamWriter sw = new StreamWriter(nombre, false,new UnicodeEncoding()); 
                foreach (string archivo in archivos)
                {
                    XmlReader reader = new XmlTextReader(new StreamReader(archivo,Encoding.UTF8));
                    while (reader.Read())
                    {
                        if (reader.NodeType == XmlNodeType.Element)
                        {
                            if (reader.LocalName == "Contribuyente")
                            {
                                string rfc = reader.GetAttribute("RFC");
                                while (reader.Read())
                                {
                                    if (rfc.Contains("Ñ"))
                                    {
                                        Console.WriteLine(rfc);
                                    }

                                    if (reader.NodeType == XmlNodeType.Element && reader.LocalName == "Certificado")
                                    {
                                        //if (reader.GetAttribute("EstatusCertificado") == "A")
                                        {
                                            sw.WriteLine(i.ToString() + "|" + rfc + "|" + reader.GetAttribute("ValidezObligaciones") +
                                                         "|" + reader.GetAttribute("EstatusCertificado") +
                                                         "|" + reader.GetAttribute("noCertificado") +
                                                         "|" + reader.GetAttribute("FechaFinal") +
                                                         "|" + reader.GetAttribute("FechaInicio") +
                                                         "|");

                                        }
                                        i++;

                                    }
                                    if (reader.NodeType == XmlNodeType.EndElement && reader.LocalName == "Contribuyente")
                                        break;
                                }
                            }
                        }
                    }
                    Logger.Info("Archivo para BulkInsert creado con exito.");
                    reader.Close();
                }
                sw.Close();
                return nombre;
            }
            catch (Exception ex)
            {
                Logger.Error(ex);
                return null;
            }


            
            
        }

        

        #endregion
    }
}

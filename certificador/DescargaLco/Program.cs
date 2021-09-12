using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using CommandLine;
using CommandLine.Text;
using log4net;
using log4net.Config;

namespace DescargaLco
{
    class Program
    {
        public class Opciones
        {
            [Option('f', "folder", Required = false, HelpText = "Folder donde se encuentran los archivos")]
            public string Folder { get; set; }

            [Option('x', "extension", Required = false, HelpText = "Extension de los archivos (xml o gz)")]
            public string Extension { get; set; }

            [Option('c', "comando", DefaultValue = "descarga", Required = true, HelpText = "Comando (descarga, extraer, ejecutar)")]
            public string Command { get; set; }
            [Option('a', "archivo",  Required = false, HelpText = "Archivo de texto para insertar")]
            public string Archivo { get; set; }

            [ParserState]
            public IParserState LastParserState { get; set; }

            [HelpOption]
            public string GetUsage()
            {
                return HelpText.AutoBuild(this, (HelpText current) => HelpText.DefaultParsingErrorsHandler(this, current));
            }
        }

        protected static ILog Logger = LogManager.GetLogger(typeof(LcoLogic));
        static void Main(string[] args)
        {
            XmlConfigurator.Configure();
            try
            {
                var options = new Opciones();
                if (CommandLine.Parser.Default.ParseArguments(args, options))
                {
                    if (options.Command == "descarga")
                    {
                        LcoLogic lco
                        = new LcoLogic();
                        lco.ProcesarArchivoLcoSat();
                    }
                    else if (options.Command == "extraer")
                    {
                        if (string.IsNullOrEmpty(options.Folder) || string.IsNullOrEmpty(options.Extension))
                        {
                            Console.WriteLine("Debes indicar el folder donde se encuentran los archivios y su extension +\n" + 
                                "-f \"c:\\lco\\descarga\" -x gz");
                        }
                        else if (options.Extension == "gz")
                        {
                            var archivos = Directory.EnumerateFiles(options.Folder, "*.gz");
                            LcoLogic lco = new LcoLogic();
                            var lista = lco.DescomprimirArchivos(archivos.ToList());
                            if (lista!= null && lista.Count > 0)
                            {
                                var lista2 = lco.ExcractLcoSignedData(lista);
                                if (lista2!= null && lista2.Count > 0)
                                {
                                    var result = lco.ParseXmlLco(lista2);
                                    if (result!= null)
                                    {
                                        lco.InsertarLco(result);
                                    }
                                }
                            }
                        }
                        else if (options.Extension == "xml")
                        {
                            var archivos = Directory.EnumerateFiles(options.Folder, "*.xml");
                            LcoLogic lco = new LcoLogic();
                            var lista2 = lco.ExcractLcoSignedData(archivos.ToList());
                            if (lista2 != null && lista2.Count > 0)
                            {
                                var result = lco.ParseXmlLco(lista2);
                                if (result!= null)
                                {
                                    lco.InsertarLco(result);
                                }
                            }
                        }
                    }
                    else if (options.Command == "ejecutar")
                    {
                        LcoLogic lco = new LcoLogic();
                        lco.InsertarLco(options.Archivo);
                    }
                }

            }
            catch (Exception ee)
            {

                Logger.Error(ee.Message);
                if (ee.InnerException != null)
                {
                    Logger.Error(ee.InnerException.Message);
                }
            }
#if DEBUG
          Console.ReadKey();
#endif
        }
    }
}

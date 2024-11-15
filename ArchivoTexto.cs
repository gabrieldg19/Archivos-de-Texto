using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Archivos_de_Texto
{
    class ArchivoTexto
    {
        public string Path { get; set; }
        public ArchivoTexto(string path)
        {
            Path = path;
        }
        public void CrearArchivo()
        {
            try
            {
                using (StreamWriter sw = File.CreateText(Path))
                {
                    sw.WriteLine("Línea 1: Este es un archivo de texto.");
                    sw.WriteLine("Línea 2: Manipular archivos en C# es sencillo.");
                }
                Console.WriteLine("Archivo creado y datos escritos correctamente.");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error al crear el archivo: {e.Message}");
            }
        }
        public void LeerArchivo()
        {
            try
            {
                if (File.Exists(Path))
                {
                    using (StreamReader sr = File.OpenText(Path))
                    {
                        string s;
                        while ((s = sr.ReadLine()) != null)
                        {
                            Console.WriteLine(s);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("El archivo no existe.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error al leer el archivo: {e.Message}");
            }
        }
        public void ModificarArchivo()
        {
            try
            {
                using (StreamWriter sw = File.AppendText(Path))
                {
                    sw.WriteLine("Línea 3: Añadiendo más contenido.");
                }
                Console.WriteLine("Contenido añadido correctamente.");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error al modificar el archivo: {e.Message}");
            }
        }
    }

}
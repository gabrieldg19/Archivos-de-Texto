using System;
using System.IO;
namespace Archivos_de_Texto
{
    class Program
    {
        static void Main()
        {
            string path = "archivoTexto.txt";

            // Crear una instancia de la clase ArchivoTexto
            ArchivoTexto archivo = new ArchivoTexto(path);

            try
            {
                // Crear archivo y escribir en él
                archivo.CrearArchivo();

                // Leer el archivo creado
                archivo.LeerArchivo();

                // Modificar el contenido del archivo
                archivo.ModificarArchivo();

                // Leer el archivo después de la modificación
                archivo.LeerArchivo();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ocurrió un error: {e.Message}");
            }
        }
    }
}

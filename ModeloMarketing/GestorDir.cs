using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloMarketing
{
    //Veamos que tanto aguanta esta cosa con cambios de nuevo
    public class GestorDir
    {
        private string rutaCompleta;

        public GestorDir()
        {
            //Genera una ruta completa desde raiz hasta la ruta de la carpeta bin del proyecto
            string ruta = Environment.CurrentDirectory;
            string ruta_padre = Directory.GetParent(ruta).Parent.FullName;

            // Retrocede un nivel para estar a la altura de la carpeta docs
            string rutaArchivo = @"..\docs\dir.txt";

            // Combinar con el directorio de la solución
            rutaCompleta = Path.Combine(ruta_padre, rutaArchivo);
        }

        public string buscarValorKey(string key)
        {
            string[] cadena;
            string valor = "";
            
            
            using (StreamReader sr = new StreamReader(rutaCompleta))
            {
                string line = "";
                while ((line = sr.ReadLine()) != null)
                {
                    cadena = line.Split(':');
                    if (key.Equals(cadena[0]))
                    {
                        valor = cadena[1];
                    }
                    
                }
            }
            return valor;
        }

        public void reescribirValor(string key, string value)
        {
            string tempFile = Path.GetTempFileName(); // Archivo temporal

            using (StreamReader sr = new StreamReader(rutaCompleta))
            using (StreamWriter sw = new StreamWriter(tempFile))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] partes = line.Split(':');
                    if (partes[0].Equals(key))
                    {
                        // Construimos la nueva línea con el valor modificado
                        line = partes[0] + ":" + value;
                    }
                    sw.WriteLine(line);
                }
            }

            // Reemplazamos el archivo original
            File.Copy(tempFile, rutaCompleta, true);
            File.Delete(tempFile);
        }

    }
}

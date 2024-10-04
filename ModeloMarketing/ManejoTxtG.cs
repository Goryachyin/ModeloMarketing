using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloMarketing
{
    public class ManejoTxtG
    {
        // Método para leer un archivo de texto
        public string LeerTxt(string direccion)
        {
            string texto = "";
            try
            {
                using (StreamReader sr = new StreamReader(direccion))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        texto += line;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("No se pudo leer el archivo: " + e.Message);
            }
            return texto;
        }

        // Método para escribir en un archivo de texto
        public void EscribirTxt(string direccion, string contenido)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(direccion, false)) // 'false' para sobrescribir el archivo
                {
                    sw.WriteLine(contenido);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("No se pudo escribir en el archivo: " + e.Message);
            }
        }
    }
}

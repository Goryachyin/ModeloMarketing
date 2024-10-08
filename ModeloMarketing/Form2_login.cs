using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace ModeloMarketing
{
    public partial class Form2_login : Form
    {
        public Form2_login()
        {
            InitializeComponent();
            txt_contraseña.PasswordChar = '*';
        }


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



        private void btn_InicioSesionLogin_Click(object sender, EventArgs e)
        {
            string user = txt_usuario.Text;
            string password = txt_contraseña.Text;
            GestorDir dir = new GestorDir();
            gestorSQL log = new gestorSQL();

            if (user != null && password != null)
            {
                bool verif = log.loginGeneral(user, password);
                if (verif)
                {
                    MessageBox.Show("Login exitoso");
                    dir.reescribirValor("sesionActiva", "1");
                    dir.reescribirValor("usuario", user);
                    dir.reescribirValor("password", password);
                    Form3_profile form3 = new Form3_profile();
                    form3.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.");
                }
            }

            //ManejoTxtG a = new ManejoTxtG();

            //ManejoTxtG manejoTxt = new ManejoTxtG();

            //string direccionArchivo = @"C:\Users\l15\Documents\VisualC#\ModeloMarketing\ModeloMarketing\docs\sesionActiva.txt";

            //// Se lee la dirección del archivo
            //string s1 = a.LeerTxt(@"C:\Users\l15\Documents\VisualC#\ModeloMarketing\ModeloMarketing\docs\usuario.txt");
            //string s2 = a.LeerTxt(@"C:\Users\l15\Documents\VisualC#\ModeloMarketing\ModeloMarketing\docs\contraseña.txt");

            //// Se guarda el valor de lo leído en el txt
            //string userBase = s1;
            //string claveEncriptado = s2;

            //// Encriptación de la contraseña ingresada (llamada al método estático)
            //string contraseñaEncriptada = Encriptado.Encriptacion(contraseña);

            //// Se hace la validación con comprobaciones adicionales para evitar errores
            //if (contraseñaEncriptada != null && claveEncriptado != null && contraseñaEncriptada.Equals(claveEncriptado) && usuario.Equals(userBase))
            //{
            //    MessageBox.Show("Login exitoso");
            //    Form3 form3 = new Form3();
            //    form3.Show();
            //    this.Hide();
            //    int valor = 1;

            //    string valorComoCadena = valor.ToString();

            //    manejoTxt.EscribirTxt(direccionArchivo, valorComoCadena);

            //}
            //else
            //{
            //    MessageBox.Show("Usuario o contraseña incorrecta");
            //}
        }



        public class Encriptado
        {
            public static string Encriptacion(string password)
            {
                try
                {
                    // Instancia donde se manda a llamar el método de encriptado
                    // En este caso, "SHA-256"
                    using (SHA256 sha256Hash = SHA256.Create())
                    {
                        byte[] hash = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                        StringBuilder stringHex = new StringBuilder();
                        foreach (byte b in hash)
                        {
                            string hex = b.ToString("x2");
                            stringHex.Append(hex);
                        }
                        return stringHex.ToString();
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return null;
                }
            }

            /*
        public static void Main(string[] args)
        {
            Console.WriteLine(Encriptacion("Sars#24"));
        }*/
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            Form1_main form1 = new Form1_main();
            form1.Show();
            this.Hide();
        }
    }
}

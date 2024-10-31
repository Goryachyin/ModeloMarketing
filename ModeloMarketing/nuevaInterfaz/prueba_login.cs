using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModeloMarketing.nuevaInterfaz
{
    public partial class prueba_login : Form
    {
        public prueba_login()
        {
            InitializeComponent();
            txt_contraseña.PasswordChar = '*';
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
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.");
                }
            }
        }
    }
}

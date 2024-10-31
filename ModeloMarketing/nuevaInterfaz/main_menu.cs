using ModeloMarketing.nuevaInterfaz;
using static ModeloMarketing.main_menu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModeloMarketing
{
    public partial class main_menu : Form
    {
        private Form activeForm;
        public main_menu()
        {
            InitializeComponent();
            pictureBox_logo.SizeMode = PictureBoxSizeMode.StretchImage;
            gestorSQL gestorSQL = new gestorSQL();
            GestorDir gestorDir = new GestorDir();
            string idUser = gestorDir.buscarValorKey("usuario");
            string sesionActiva = gestorDir.buscarValorKey("sesionActiva");

            if (sesionActiva.Equals("1"))
            {
                panel_control.Hide();
                

            }
            OpenChildForms(new CarruselProductos.Form1());
            
        }

        public void OpenChildForms(Form childForm)
        {
            //Las dimensiones de los Forms hijos son de 1040x600 para acoplarlo en el form main
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panel_Desktop.Controls.Add(childForm);
            this.panel_Desktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        public void CloseSesion()
        {
            GestorDir dir = new GestorDir();
            dir.reescribirValor("sesionActiva", "0");
            dir.reescribirValor("usuario", "");
            dir.reescribirValor("password", "");
        }


        private void btn_config_Click_1(object sender, EventArgs e)
        {
            OpenChildForms(new uploadProducts_prueba());
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            OpenChildForms(new perfil_prueba());
        }

        private void btnPerfil_MouseEnter(object sender, EventArgs e)
        {
            btnPerfil.BackColor = Color.FromArgb(51, 202, 255);
            btnPerfil.Font = new Font(btnPerfil.Font, FontStyle.Bold);
        }

        private void btnPerfil_MouseLeave(object sender, EventArgs e)
        {
            btnPerfil.BackColor = Color.Transparent;
            btnPerfil.Font = new Font("Segoe UI", 10, FontStyle.Regular);
        }

        private void btn_config_MouseEnter(object sender, EventArgs e)
        {
            btn_config.BackColor = Color.FromArgb(51, 202, 255);
            btn_config.Font = new Font(btn_config.Font, FontStyle.Bold);
        }

        private void btn_config_MouseLeave(object sender, EventArgs e)
        {
            btn_config.BackColor = Color.Transparent;
            btn_config.Font = new Font("Segoe UI", 10, FontStyle.Regular);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CloseSesion();
            this.Refresh();
        }

        private void btn_IniSesion_Click(object sender, EventArgs e)
        {
            OpenChildForms(new prueba_login());
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            OpenChildForms(new prueba_registro());
        }
    }
}

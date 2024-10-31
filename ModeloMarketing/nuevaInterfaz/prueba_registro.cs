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
    public partial class prueba_registro : Form
    {
        private byte[] imagenData = null;

        public prueba_registro()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            cbDay.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMonth.DropDownStyle = ComboBoxStyle.DropDownList;
            cbYear.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCarrera.DropDownStyle = ComboBoxStyle.DropDownList;

            for (int i = 1; i <= 31; i++)
            {
                cbDay.Items.Add(i.ToString());
            }

            for (int i = 1; i <= 12; i++)
            {
                cbMonth.Items.Add(i.ToString());
            }

            for (int i = 1990; i <= 2024; i++)
            {
                cbYear.Items.Add(i.ToString());
            }
        }

        private void btn_InicioSesionLogin_Click(object sender, EventArgs e)
        {
            string nombre = txf_nombre.Text;
            string noControl = txf_numControl.Text;
            string correo = txf_correo.Text;
            string password = txf_password.Text;
            string? carrera = cbCarrera.SelectedItem as string;

            string? dia = cbDay.SelectedItem as string;
            string? mes = cbMonth.SelectedItem as string;
            string? anio = cbYear.SelectedItem as string;
            string fechaMySQL = anio + "-" + mes + "-" + dia;

            gestorSQL gestorSQL = new gestorSQL();
            bool verif = gestorSQL.registrarCliente(nombre, noControl, correo, password, fechaMySQL, carrera, imagenData);

            if (verif)
            {
                this.Hide();

            }
        }

        private void profile_photo_Click(object sender, EventArgs e)
        {
            string idUser = txf_numControl.Text;
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Archivos de imagen (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                imagenData = File.ReadAllBytes(fileDialog.FileName);
                profile_photo.BackgroundImageLayout = ImageLayout.Stretch;
                MemoryStream ms = new MemoryStream(imagenData);
                profile_photo.Image = Image.FromStream(ms);
                profile_photo.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void btn_cancelarRegistro_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

using MySql.Data.MySqlClient;
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
    public partial class Form4_uploadProducts : Form
    {
        byte[] imagenData = null;
        public Form4_uploadProducts()
        {
            InitializeComponent();
            cb_size.DropDownStyle = ComboBoxStyle.DropDownList;
            byte[] imagenData = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1_main form1 = new Form1_main();
            form1.Show();
            this.Hide();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                imagenData = File.ReadAllBytes(fileDialog.FileName);
                MemoryStream ms = new MemoryStream(imagenData);
                pictureBox2.Image = Image.FromStream(ms);
                pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;


            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string nombre, precio, disponibilidad=null, descripcion, categoria, tipo, size;
            gestorSQL gestorSQL = new gestorSQL();

            if (verificarCampos())
            {
                nombre = txf_nombre.Text;
                precio = txf_precio.Text;
                descripcion = txf_descripcion.Text;
                categoria = string.Join(":", clb_categoria.CheckedItems.Cast<string>());
                tipo = string.Join(":", clb_tipo.CheckedItems.Cast<string>());
                size = cb_size.SelectedItem.ToString();

                if (checkBox1.Checked)
                {
                    disponibilidad = "0";
                }
                else if (checkBox2.Checked)
                {
                    disponibilidad = "1";
                }

                bool verif = gestorSQL.cargarProducto(imagenData,nombre,precio,disponibilidad,descripcion,categoria,tipo,size);

                if (verif)
                {
                    Form3_profile f3 = new Form3_profile();
                    this.Hide();
                    f3.Show();
                }
                //MessageBox.Show(nombre + "\n" + precio + "\n" + descripcion + "\n" + disponibilidad + "\n" + categoria + "\n" + tipo + "\n" + size);
            }
            else
            {
                MessageBox.Show("Rellene todos los campos \nInserte una imagen");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox2.Checked = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox1.Checked = false;
            }
        }

        private void txf_precio_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si el carácter presionado es un número o un punto decimal
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
                // Ignorar el carácter
            }
            else
            {
                // Si es un punto decimal, verificar que no haya otro en la cadena
                if (e.KeyChar == '.' && ((TextBox)sender).Text.IndexOf('.') > -1)
                {
                    e.Handled = true; // Ignorar el punto decimal adicional
                }
            }
        }

        private bool verificarCampos()
        {
            bool nombre = !string.IsNullOrEmpty(txf_nombre.Text);
            bool precio = !string.IsNullOrEmpty(txf_precio.Text);
            bool disponibilidad = false;

            if(checkBox1.Checked || checkBox2.Checked)
            {
                disponibilidad = true;
            }
            bool categoria = !string.IsNullOrEmpty(string.Join(":", clb_categoria.CheckedItems.Cast<string>()));
            bool tipo = !string.IsNullOrEmpty(string.Join(":", clb_tipo.CheckedItems.Cast<string>()));
            bool size = (cb_size.SelectedItem != null);
            
            bool verificado = (nombre && precio && disponibilidad && categoria && tipo && size && (imagenData != null));
            return verificado;

        }
        
    }
}

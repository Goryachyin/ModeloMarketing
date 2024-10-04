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
        public Form4_uploadProducts()
        {
            InitializeComponent();
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
                byte[] imagenData = File.ReadAllBytes(fileDialog.FileName);
                MemoryStream ms = new MemoryStream(imagenData);
                pictureBox2.Image = Image.FromStream(ms);
                pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;

                
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }
    }
}

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
    public partial class uploadProducts_prueba : Form
    {
        byte[] imagenData = null;
        public uploadProducts_prueba()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
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
    }
}

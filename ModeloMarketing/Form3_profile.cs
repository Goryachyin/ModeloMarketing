﻿using System;
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
    public partial class Form3_profile : Form
    {
        public Form3_profile()
        {
            InitializeComponent();
            GestorDir dir = new GestorDir();
            string idUser = dir.buscarValorKey("usuario");
            gestorSQL gestor = new gestorSQL();
            gestor.cargarPerfil(idUser,profile_photo,lbName,lbCarrera);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1_main form1 = new Form1_main();
            form1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1_main form1 = new Form1_main();
            form1.Show();
            this.Hide();
        }

        private void btn_Subir_Click(object sender, EventArgs e)
        {
            Form4_uploadProducts form4 = new Form4_uploadProducts();
            form4.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
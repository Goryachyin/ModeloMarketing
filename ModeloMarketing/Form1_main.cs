using static ModeloMarketing.Form2_login;
using System;
using System.IO;
using static ModeloMarketing.Form1_main;


namespace ModeloMarketing
{
    public partial class Form1_main : Form


    {

        public Form1_main()
        {
            InitializeComponent();
            ModoOscuro();
            SesionActiva();
        }

        private void btn_InicioSesion_Click(object sender, EventArgs e)
        {
            Form2_login form2 = new Form2_login();
            form2.Show();
            this.Hide();

        }

        private int currentPage = 1;

        private void button1_Click(object sender, EventArgs e)
        {
            /*currentPage = 2;
            switch (currentPage)
            {
                case 1:
                    pnl_pag01.Hide();
                    pnl_pag01.Show();
                    currentPage = 2;
                    break;
                case 2:
                    pnl_pag02.Hide();
                    pnl_pag01.Show();
                    currentPage = 1;
                    break;
            }*/
        }

        private void ckb_ModoOscuro_CheckedChanged(object sender, EventArgs e)
        {
            GestorDir dir = new GestorDir();

            if (ckb_ModoOscuro.Checked)
            {
                dir.reescribirValor("moscuro", "1");
                ModoOscuro();
            }
            else
            {
                dir.reescribirValor("moscuro", "0");
                ModoOscuro();

            }
        }

        public void CloseSesion()
        {
            GestorDir dir = new GestorDir();
            dir.reescribirValor("sesionActiva", "0");
            dir.reescribirValor("usuario", "");
            dir.reescribirValor("password","");
        }

        public void SesionActiva()
        {
            GestorDir dir = new GestorDir();

            string SA = dir.buscarValorKey("sesionActiva");

            if (SA == "0")
            {
                gpb_InicioRegistro.Visible = true;
                gpb_porfile.Visible = false;
            }
            else
            {
                gpb_porfile.Visible = true;
            }
        }

        public void ModoOscuro()
        {
            {
                GestorDir dir = new GestorDir();
                // Se lee la dirección del archivo
                string MO = dir.buscarValorKey("moscuro");

                // Se hace la validación con comprobaciones adicionales para evitar errores
                if (MO == "1")
                {

                    pnl_cabeza.BackgroundImage = Properties.Resources.block_fondoAO;
                    pnl_izquierda.BackgroundImage = Properties.Resources.block_fondoAO;
                    pnl_fondo.BackgroundImage = Properties.Resources.block_fondoBO;
                    pnl_cuerpo01.BackgroundImage = Properties.Resources.block_fondoCO;
                    pnl_cuerpo02.BackgroundImage = Properties.Resources.block_fondoCO;

                    btn_encabezado01.ForeColor = Color.FromArgb(255, 255, 255);
                    btn_encabezado02.ForeColor = Color.FromArgb(255, 255, 255);

                    //paneles
                    panel01.BackColor = Color.FromArgb(25, 25, 25);
                    panel02.BackColor = Color.FromArgb(25, 25, 25);
                    panel03.BackColor = Color.FromArgb(25, 25, 25);
                    panel04.BackColor = Color.FromArgb(25, 25, 25);
                    panel05.BackColor = Color.FromArgb(25, 25, 25);
                    panel06.BackColor = Color.FromArgb(25, 25, 25);
                    pnl_panel07.BackColor = Color.FromArgb(25, 25, 25);
                    pnl_panel08.BackColor = Color.FromArgb(25, 25, 25);
                    pnl_panel09.BackColor = Color.FromArgb(25, 25, 25);
                    pnl_panel10.BackColor = Color.FromArgb(25, 25, 25);
                    pnl_panel11.BackColor = Color.FromArgb(25, 25, 25);
                    pnl_panel12.BackColor = Color.FromArgb(25, 25, 25);

                    pnl_cuerpo01.BackColor = Color.FromArgb(25, 0, 0);
                    //checklistbox
                    clb_Filtro.BackColor = Color.FromArgb(2, 43, 125);
                    clb_Filtro.Font = new Font("Square721 BT", 9F);
                    clb_Filtro.ForeColor = Color.White;

                    clb_Categorias.BackColor = Color.FromArgb(2, 43, 125);
                    clb_Categorias.Font = new Font("Square721 BT", 9F);
                    clb_Categorias.ForeColor = Color.White;

                    ckb_ModoOscuro.Checked = true;

                }
                else
                {
                    pnl_cabeza.BackgroundImage = Properties.Resources.block_fondoA;
                    pnl_izquierda.BackgroundImage = Properties.Resources.block_fondoA;
                    pnl_fondo.BackgroundImage = Properties.Resources.block_fondoB;
                    pnl_cuerpo01.BackgroundImage = Properties.Resources.block_fondoC;
                    pnl_cuerpo02.BackgroundImage = Properties.Resources.block_fondoC;

                    btn_encabezado01.ForeColor = Color.FromArgb(14, 109, 188);
                    btn_encabezado02.ForeColor = Color.FromArgb(14, 109, 188);


                    ckb_ModoOscuro.Checked = false;
                    panel01.BackColor = Color.FromArgb(236, 236, 236);
                    panel02.BackColor = Color.FromArgb(236, 236, 236);
                    panel03.BackColor = Color.FromArgb(236, 236, 236);
                    panel04.BackColor = Color.FromArgb(236, 236, 236);
                    panel05.BackColor = Color.FromArgb(236, 236, 236);
                    panel06.BackColor = Color.FromArgb(236, 236, 236);
                    pnl_panel07.BackColor = Color.FromArgb(236, 236, 236);
                    pnl_panel08.BackColor = Color.FromArgb(236, 236, 236);
                    pnl_panel09.BackColor = Color.FromArgb(236, 236, 236);
                    pnl_panel10.BackColor = Color.FromArgb(236, 236, 236);
                    pnl_panel11.BackColor = Color.FromArgb(236, 236, 236);
                    pnl_panel12.BackColor = Color.FromArgb(236, 236, 236);
                    clb_Filtro.BackColor = Color.White;
                    clb_Filtro.Font = new Font("Square721 BT", 9F);
                    clb_Filtro.ForeColor = Color.Black;

                    clb_Categorias.BackColor = Color.White;
                    clb_Categorias.Font = new Font("Square721 BT", 9F);
                    clb_Categorias.ForeColor = Color.Black;

                }
            }
        }

        private void btn_porfile_Click(object sender, EventArgs e)
        {
            Form3_profile form3 = new Form3_profile();
            form3.Show();
            this.Hide();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            CloseSesion();


            Form1_main form1 = new Form1_main();
            form1.Show();
            this.Hide();
        }

        private void btn_Registrarse_Click(object sender, EventArgs e)
        {
            Form5_register form5 = new Form5_register();
            form5.Show();
            this.Hide();
        }

        private void btn_encabezado01_Click(object sender, EventArgs e)
        {

        }

        private void gpb_porfile_Enter(object sender, EventArgs e)
        {

        }

        private void gpb_porfile_Enter_1(object sender, EventArgs e)
        {

        }
    }
}

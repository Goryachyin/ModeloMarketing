namespace ModeloMarketing
{
    partial class main_menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel_navegation = new Panel();
            button1 = new Button();
            btnPerfil = new Button();
            btn_config = new Button();
            panel2 = new Panel();
            pictureBox_logo = new PictureBox();
            panel1 = new Panel();
            panel_Desktop = new Panel();
            panel_encabezado = new Panel();
            panel_control = new Panel();
            btn_register = new Button();
            btn_IniSesion = new Button();
            panel_navegation.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_logo).BeginInit();
            panel1.SuspendLayout();
            panel_encabezado.SuspendLayout();
            panel_control.SuspendLayout();
            SuspendLayout();
            // 
            // panel_navegation
            // 
            panel_navegation.BackColor = Color.DodgerBlue;
            panel_navegation.BackgroundImage = Properties.Resources.block_fondoA;
            panel_navegation.Controls.Add(button1);
            panel_navegation.Controls.Add(btnPerfil);
            panel_navegation.Controls.Add(btn_config);
            panel_navegation.Controls.Add(panel2);
            panel_navegation.Dock = DockStyle.Left;
            panel_navegation.Location = new Point(0, 0);
            panel_navegation.Name = "panel_navegation";
            panel_navegation.Size = new Size(146, 696);
            panel_navegation.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Red;
            button1.Image = Properties.Resources.log_out;
            button1.Location = new Point(3, 626);
            button1.Name = "button1";
            button1.Size = new Size(128, 58);
            button1.TabIndex = 5;
            button1.Text = "Cerrar Sesion";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnPerfil
            // 
            btnPerfil.BackColor = Color.Transparent;
            btnPerfil.FlatAppearance.BorderSize = 0;
            btnPerfil.FlatStyle = FlatStyle.Flat;
            btnPerfil.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPerfil.ForeColor = SystemColors.Control;
            btnPerfil.Image = Properties.Resources.user_profile;
            btnPerfil.ImageAlign = ContentAlignment.MiddleLeft;
            btnPerfil.Location = new Point(12, 131);
            btnPerfil.Name = "btnPerfil";
            btnPerfil.Size = new Size(128, 58);
            btnPerfil.TabIndex = 4;
            btnPerfil.Text = "      Perfil";
            btnPerfil.TextAlign = ContentAlignment.MiddleLeft;
            btnPerfil.UseVisualStyleBackColor = false;
            btnPerfil.Click += btnPerfil_Click;
            btnPerfil.MouseEnter += btnPerfil_MouseEnter;
            btnPerfil.MouseLeave += btnPerfil_MouseLeave;
            // 
            // btn_config
            // 
            btn_config.BackColor = Color.Transparent;
            btn_config.FlatAppearance.BorderSize = 0;
            btn_config.FlatStyle = FlatStyle.Flat;
            btn_config.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_config.ForeColor = SystemColors.Control;
            btn_config.Image = Properties.Resources.cart;
            btn_config.ImageAlign = ContentAlignment.MiddleLeft;
            btn_config.Location = new Point(12, 210);
            btn_config.Name = "btn_config";
            btn_config.Size = new Size(128, 58);
            btn_config.TabIndex = 3;
            btn_config.Text = " Subir Productos";
            btn_config.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_config.UseVisualStyleBackColor = false;
            btn_config.Click += btn_config_Click_1;
            btn_config.MouseEnter += btn_config_MouseEnter;
            btn_config.MouseLeave += btn_config_MouseLeave;
            // 
            // panel2
            // 
            panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel2.Controls.Add(pictureBox_logo);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(146, 110);
            panel2.TabIndex = 1;
            // 
            // pictureBox_logo
            // 
            pictureBox_logo.Image = Properties.Resources.logoV2;
            pictureBox_logo.Location = new Point(0, 0);
            pictureBox_logo.Name = "pictureBox_logo";
            pictureBox_logo.Size = new Size(146, 110);
            pictureBox_logo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_logo.TabIndex = 0;
            pictureBox_logo.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel_Desktop);
            panel1.Controls.Add(panel_encabezado);
            panel1.Controls.Add(panel_navegation);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1262, 696);
            panel1.TabIndex = 0;
            // 
            // panel_Desktop
            // 
            panel_Desktop.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel_Desktop.BackColor = Color.DodgerBlue;
            panel_Desktop.BackgroundImage = Properties.Resources.block_fondoC;
            panel_Desktop.Location = new Point(146, 87);
            panel_Desktop.Name = "panel_Desktop";
            panel_Desktop.Size = new Size(1116, 609);
            panel_Desktop.TabIndex = 8;
            // 
            // panel_encabezado
            // 
            panel_encabezado.BackColor = Color.DodgerBlue;
            panel_encabezado.BackgroundImage = Properties.Resources.block_fondoA;
            panel_encabezado.Controls.Add(panel_control);
            panel_encabezado.Dock = DockStyle.Top;
            panel_encabezado.Location = new Point(146, 0);
            panel_encabezado.Name = "panel_encabezado";
            panel_encabezado.Size = new Size(1116, 92);
            panel_encabezado.TabIndex = 7;
            // 
            // panel_control
            // 
            panel_control.BackColor = Color.DimGray;
            panel_control.BackgroundImage = Properties.Resources.block_fondoG;
            panel_control.Controls.Add(btn_register);
            panel_control.Controls.Add(btn_IniSesion);
            panel_control.Dock = DockStyle.Right;
            panel_control.Location = new Point(961, 0);
            panel_control.Name = "panel_control";
            panel_control.Size = new Size(155, 92);
            panel_control.TabIndex = 0;
            // 
            // btn_register
            // 
            btn_register.Location = new Point(15, 47);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(113, 29);
            btn_register.TabIndex = 1;
            btn_register.Text = "Registrar";
            btn_register.UseVisualStyleBackColor = true;
            btn_register.Click += btn_register_Click;
            // 
            // btn_IniSesion
            // 
            btn_IniSesion.Location = new Point(15, 12);
            btn_IniSesion.Name = "btn_IniSesion";
            btn_IniSesion.Size = new Size(113, 29);
            btn_IniSesion.TabIndex = 0;
            btn_IniSesion.Text = "Iniciar Sesión";
            btn_IniSesion.UseVisualStyleBackColor = true;
            btn_IniSesion.Click += btn_IniSesion_Click;
            // 
            // main_menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 696);
            Controls.Add(panel1);
            Name = "main_menu";
            Text = "Form1";
            panel_navegation.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox_logo).EndInit();
            panel1.ResumeLayout(false);
            panel_encabezado.ResumeLayout(false);
            panel_control.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_navegation;
        private Button btn_config;
        private Panel panel2;
        private PictureBox pictureBox_logo;
        private Panel panel1;
        private Panel panel_encabezado;
        private Button btnPerfil;
        private Panel panel_Desktop;
        private Button button1;
        private Panel panel_control;
        private Button btn_register;
        private Button btn_IniSesion;
    }
}
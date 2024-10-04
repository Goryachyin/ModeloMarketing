namespace ModeloMarketing
{
    partial class Form5_register
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
            panel1 = new Panel();
            panel3 = new Panel();
            cbYear = new ComboBox();
            cbMonth = new ComboBox();
            cbDay = new ComboBox();
            cbCarrera = new ComboBox();
            btn_cancelarRegistro = new Button();
            txf_numControl = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            txf_correo = new TextBox();
            label4 = new Label();
            btn_InicioSesionLogin = new Button();
            txf_password = new TextBox();
            txf_nombre = new TextBox();
            label2 = new Label();
            label1 = new Label();
            profile_photo = new PictureBox();
            panel2 = new Panel();
            label3 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)profile_photo).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(-3, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(441, 616);
            panel1.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackgroundImage = Properties.Resources.block_fondoB;
            panel3.Controls.Add(cbYear);
            panel3.Controls.Add(cbMonth);
            panel3.Controls.Add(cbDay);
            panel3.Controls.Add(cbCarrera);
            panel3.Controls.Add(btn_cancelarRegistro);
            panel3.Controls.Add(txf_numControl);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(txf_correo);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(btn_InicioSesionLogin);
            panel3.Controls.Add(txf_password);
            panel3.Controls.Add(txf_nombre);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(profile_photo);
            panel3.Location = new Point(3, 91);
            panel3.Name = "panel3";
            panel3.Size = new Size(438, 525);
            panel3.TabIndex = 1;
            // 
            // cbYear
            // 
            cbYear.FormattingEnabled = true;
            cbYear.Location = new Point(279, 363);
            cbYear.Margin = new Padding(3, 4, 3, 4);
            cbYear.Name = "cbYear";
            cbYear.Size = new Size(107, 28);
            cbYear.TabIndex = 23;
            // 
            // cbMonth
            // 
            cbMonth.FormattingEnabled = true;
            cbMonth.Location = new Point(141, 363);
            cbMonth.Margin = new Padding(3, 4, 3, 4);
            cbMonth.Name = "cbMonth";
            cbMonth.Size = new Size(102, 28);
            cbMonth.TabIndex = 22;
            // 
            // cbDay
            // 
            cbDay.FormattingEnabled = true;
            cbDay.Location = new Point(25, 363);
            cbDay.Margin = new Padding(3, 4, 3, 4);
            cbDay.Name = "cbDay";
            cbDay.Size = new Size(83, 28);
            cbDay.TabIndex = 21;
            // 
            // cbCarrera
            // 
            cbCarrera.FormattingEnabled = true;
            cbCarrera.Items.AddRange(new object[] { "Arquitectura", "Ingeniería en Sistemas Computacionales", "Ingeniería Electromecánica", "Ingeniería Bioquímica", "Ingeniería en Gestión Empresarial", "Licenciatura en Administración", "Contador Público" });
            cbCarrera.Location = new Point(26, 433);
            cbCarrera.Margin = new Padding(3, 4, 3, 4);
            cbCarrera.Name = "cbCarrera";
            cbCarrera.Size = new Size(349, 28);
            cbCarrera.TabIndex = 20;
            // 
            // btn_cancelarRegistro
            // 
            btn_cancelarRegistro.Location = new Point(79, 477);
            btn_cancelarRegistro.Name = "btn_cancelarRegistro";
            btn_cancelarRegistro.Size = new Size(94, 35);
            btn_cancelarRegistro.TabIndex = 2;
            btn_cancelarRegistro.Text = "Cancelar";
            btn_cancelarRegistro.UseVisualStyleBackColor = true;
            btn_cancelarRegistro.Click += btn_cancelarRegistro_Click;
            // 
            // txf_numControl
            // 
            txf_numControl.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txf_numControl.Location = new Point(187, 129);
            txf_numControl.Name = "txf_numControl";
            txf_numControl.Size = new Size(198, 27);
            txf_numControl.TabIndex = 19;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.HotTrack;
            label10.Location = new Point(187, 101);
            label10.Name = "label10";
            label10.Size = new Size(171, 25);
            label10.TabIndex = 18;
            label10.Text = "Numero de control";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.HotTrack;
            label9.Location = new Point(26, 397);
            label9.Name = "label9";
            label9.Size = new Size(78, 25);
            label9.TabIndex = 17;
            label9.Text = "Carrera";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.HotTrack;
            label8.Location = new Point(281, 328);
            label8.Name = "label8";
            label8.Size = new Size(48, 25);
            label8.TabIndex = 13;
            label8.Text = "Año";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.HotTrack;
            label7.Location = new Point(141, 328);
            label7.Name = "label7";
            label7.Size = new Size(50, 25);
            label7.TabIndex = 12;
            label7.Text = "Mes";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.HotTrack;
            label6.Location = new Point(25, 328);
            label6.Name = "label6";
            label6.Size = new Size(41, 25);
            label6.TabIndex = 11;
            label6.Text = "Dia";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10F);
            label5.ForeColor = SystemColors.HotTrack;
            label5.Location = new Point(26, 307);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 9;
            label5.Text = "- Edad -";
            // 
            // txf_correo
            // 
            txf_correo.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txf_correo.Location = new Point(25, 203);
            txf_correo.Name = "txf_correo";
            txf_correo.Size = new Size(361, 27);
            txf_correo.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.HotTrack;
            label4.Location = new Point(25, 175);
            label4.Name = "label4";
            label4.Size = new Size(72, 25);
            label4.TabIndex = 7;
            label4.Text = "Correo";
            // 
            // btn_InicioSesionLogin
            // 
            btn_InicioSesionLogin.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_InicioSesionLogin.Location = new Point(191, 477);
            btn_InicioSesionLogin.Name = "btn_InicioSesionLogin";
            btn_InicioSesionLogin.Size = new Size(134, 35);
            btn_InicioSesionLogin.TabIndex = 5;
            btn_InicioSesionLogin.Text = "Registrarme";
            btn_InicioSesionLogin.UseVisualStyleBackColor = true;
            btn_InicioSesionLogin.Click += btn_InicioSesionLogin_Click;
            // 
            // txf_password
            // 
            txf_password.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txf_password.Location = new Point(26, 267);
            txf_password.Name = "txf_password";
            txf_password.Size = new Size(361, 27);
            txf_password.TabIndex = 4;
            // 
            // txf_nombre
            // 
            txf_nombre.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txf_nombre.Location = new Point(187, 59);
            txf_nombre.Name = "txf_nombre";
            txf_nombre.Size = new Size(198, 27);
            txf_nombre.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(25, 239);
            label2.Name = "label2";
            label2.Size = new Size(114, 25);
            label2.TabIndex = 2;
            label2.Text = "Contraseña";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(187, 29);
            label1.Name = "label1";
            label1.Size = new Size(180, 25);
            label1.TabIndex = 1;
            label1.Text = "Nombre de Usuario";
            // 
            // profile_photo
            // 
            profile_photo.BackgroundImageLayout = ImageLayout.Zoom;
            profile_photo.Location = new Point(25, 15);
            profile_photo.Name = "profile_photo";
            profile_photo.Size = new Size(142, 141);
            profile_photo.TabIndex = 0;
            profile_photo.TabStop = false;
            profile_photo.Click += pictureBox1_Click;
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.block_fondoA;
            panel2.Controls.Add(label3);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(438, 83);
            panel2.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(128, 25);
            label3.Name = "label3";
            label3.Size = new Size(178, 36);
            label3.TabIndex = 2;
            label3.Text = "REGISTRO";
            // 
            // Form5_register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(437, 620);
            Controls.Add(panel1);
            Name = "Form5_register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form5";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)profile_photo).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Button btn_InicioSesionLogin;
        private TextBox txf_password;
        private TextBox txf_nombre;
        private Label label2;
        private Label label1;
        private PictureBox profile_photo;
        private Panel panel2;
        private Label label3;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox txf_correo;
        private Label label4;
        private Label label9;
        private TextBox txf_numControl;
        private Label label10;
        private Button btn_cancelarRegistro;
        private ComboBox cbCarrera;
        private ComboBox cbYear;
        private ComboBox cbMonth;
        private ComboBox cbDay;
    }
}
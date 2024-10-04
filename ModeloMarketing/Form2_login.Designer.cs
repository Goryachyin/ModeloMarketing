namespace ModeloMarketing
{
    partial class Form2_login
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
            button2 = new Button();
            btn_InicioSesionLogin = new Button();
            txt_contraseña = new TextBox();
            txt_usuario = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            label3 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(-3, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(326, 462);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackgroundImage = Properties.Resources.block_fondoB;
            panel3.Controls.Add(button2);
            panel3.Controls.Add(btn_InicioSesionLogin);
            panel3.Controls.Add(txt_contraseña);
            panel3.Controls.Add(txt_usuario);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(pictureBox1);
            panel3.Location = new Point(3, 68);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(323, 413);
            panel3.TabIndex = 1;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(36, 320);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(128, 22);
            button2.TabIndex = 6;
            button2.Text = "Olvide mi contraseña";
            button2.TextAlign = ContentAlignment.TopLeft;
            button2.UseVisualStyleBackColor = false;
            // 
            // btn_InicioSesionLogin
            // 
            btn_InicioSesionLogin.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_InicioSesionLogin.Location = new Point(36, 356);
            btn_InicioSesionLogin.Margin = new Padding(3, 2, 3, 2);
            btn_InicioSesionLogin.Name = "btn_InicioSesionLogin";
            btn_InicioSesionLogin.Size = new Size(117, 36);
            btn_InicioSesionLogin.TabIndex = 5;
            btn_InicioSesionLogin.Text = "Iniciar sesion";
            btn_InicioSesionLogin.UseVisualStyleBackColor = true;
            btn_InicioSesionLogin.Click += btn_InicioSesionLogin_Click;
            // 
            // txt_contraseña
            // 
            txt_contraseña.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_contraseña.Location = new Point(36, 290);
            txt_contraseña.Margin = new Padding(3, 2, 3, 2);
            txt_contraseña.Name = "txt_contraseña";
            txt_contraseña.Size = new Size(201, 23);
            txt_contraseña.TabIndex = 4;
            // 
            // txt_usuario
            // 
            txt_usuario.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_usuario.Location = new Point(36, 238);
            txt_usuario.Margin = new Padding(3, 2, 3, 2);
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(201, 23);
            txt_usuario.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(36, 269);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 2;
            label2.Text = "Contraseña";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(36, 218);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 1;
            label1.Text = "Usuario";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.icon_user256;
            pictureBox1.Location = new Point(36, 20);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(234, 192);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.block_fondoA;
            panel2.Controls.Add(label3);
            panel2.Location = new Point(3, 2);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(320, 62);
            panel2.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(23, 19);
            label3.Name = "label3";
            label3.Size = new Size(237, 29);
            label3.TabIndex = 2;
            label3.Text = "INICIO DE SESION";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(320, 479);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label1;
        private Button button2;
        private Button btn_InicioSesionLogin;
        private TextBox txt_contraseña;
        private TextBox txt_usuario;
        private Label label2;
        private Label label3;
    }
}
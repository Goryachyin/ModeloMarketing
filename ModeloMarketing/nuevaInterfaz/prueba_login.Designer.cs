﻿namespace ModeloMarketing.nuevaInterfaz
{
    partial class prueba_login
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
            panel3 = new Panel();
            button2 = new Button();
            btn_InicioSesionLogin = new Button();
            txt_contraseña = new TextBox();
            txt_usuario = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackgroundImage = Properties.Resources.block_fondoC;
            panel3.Controls.Add(button2);
            panel3.Controls.Add(btn_InicioSesionLogin);
            panel3.Controls.Add(txt_contraseña);
            panel3.Controls.Add(txt_usuario);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(pictureBox1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1022, 553);
            panel3.TabIndex = 2;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(408, 411);
            button2.Name = "button2";
            button2.Size = new Size(146, 29);
            button2.TabIndex = 6;
            button2.Text = "Olvide mi contraseña";
            button2.TextAlign = ContentAlignment.TopLeft;
            button2.UseVisualStyleBackColor = false;
            // 
            // btn_InicioSesionLogin
            // 
            btn_InicioSesionLogin.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_InicioSesionLogin.Location = new Point(455, 462);
            btn_InicioSesionLogin.Name = "btn_InicioSesionLogin";
            btn_InicioSesionLogin.Size = new Size(134, 48);
            btn_InicioSesionLogin.TabIndex = 5;
            btn_InicioSesionLogin.Text = "Iniciar sesion";
            btn_InicioSesionLogin.UseVisualStyleBackColor = true;
            btn_InicioSesionLogin.Click += btn_InicioSesionLogin_Click;
            // 
            // txt_contraseña
            // 
            txt_contraseña.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_contraseña.Location = new Point(408, 371);
            txt_contraseña.Name = "txt_contraseña";
            txt_contraseña.Size = new Size(229, 27);
            txt_contraseña.TabIndex = 4;
            // 
            // txt_usuario
            // 
            txt_usuario.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_usuario.Location = new Point(408, 301);
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(229, 27);
            txt_usuario.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(408, 343);
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
            label1.Location = new Point(408, 275);
            label1.Name = "label1";
            label1.Size = new Size(79, 25);
            label1.TabIndex = 1;
            label1.Text = "Usuario";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.icon_user256;
            pictureBox1.Location = new Point(380, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(267, 256);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // prueba_login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1022, 553);
            Controls.Add(panel3);
            Name = "prueba_login";
            Text = "Form1";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Button button2;
        private Button btn_InicioSesionLogin;
        private TextBox txt_contraseña;
        private TextBox txt_usuario;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
    }
}
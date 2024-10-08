namespace ModeloMarketing
{
    partial class Form3_profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3_profile));
            panel3 = new Panel();
            panel12 = new Panel();
            label22 = new Label();
            pnl_pag01 = new Panel();
            groupBox1 = new GroupBox();
            gpb_perfil = new GroupBox();
            richTextBox1 = new RichTextBox();
            lbCarrera = new Label();
            lbName = new Label();
            profile_photo = new PictureBox();
            panel4 = new Panel();
            label4 = new Label();
            button1 = new Button();
            panel10 = new Panel();
            label3 = new Label();
            panel2 = new Panel();
            btnEditar = new Button();
            btn_Subir = new Button();
            button2 = new Button();
            panel1 = new Panel();
            button3 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel3.SuspendLayout();
            panel12.SuspendLayout();
            pnl_pag01.SuspendLayout();
            gpb_perfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)profile_photo).BeginInit();
            panel4.SuspendLayout();
            panel10.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.GradientInactiveCaption;
            panel3.Controls.Add(panel12);
            panel3.Controls.Add(pnl_pag01);
            panel3.Controls.Add(panel2);
            panel3.Controls.Add(panel1);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1051, 580);
            panel3.TabIndex = 3;
            // 
            // panel12
            // 
            panel12.BackColor = Color.FromArgb(236, 236, 236);
            panel12.Controls.Add(label22);
            panel12.Location = new Point(163, 768);
            panel12.Name = "panel12";
            panel12.Size = new Size(862, 83);
            panel12.TabIndex = 12;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.FlatStyle = FlatStyle.Flat;
            label22.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label22.ForeColor = SystemColors.HotTrack;
            label22.Location = new Point(131, 11);
            label22.Name = "label22";
            label22.Size = new Size(658, 64);
            label22.TabIndex = 5;
            label22.Text = resources.GetString("label22.Text");
            label22.TextAlign = ContentAlignment.TopCenter;
            // 
            // pnl_pag01
            // 
            pnl_pag01.AutoScroll = true;
            pnl_pag01.BackColor = SystemColors.ButtonHighlight;
            pnl_pag01.BackgroundImage = Properties.Resources.block_fondoB;
            pnl_pag01.Controls.Add(groupBox1);
            pnl_pag01.Controls.Add(gpb_perfil);
            pnl_pag01.Controls.Add(panel4);
            pnl_pag01.Controls.Add(button1);
            pnl_pag01.Controls.Add(panel10);
            pnl_pag01.Location = new Point(165, 87);
            pnl_pag01.Name = "pnl_pag01";
            pnl_pag01.Size = new Size(885, 973);
            pnl_pag01.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.BackgroundImage = Properties.Resources.block_fondoC;
            groupBox1.Font = new Font("Segoe UI Semibold", 12.2F, FontStyle.Bold);
            groupBox1.Location = new Point(465, 25);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(357, 380);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Productos";
            // 
            // gpb_perfil
            // 
            gpb_perfil.BackColor = Color.Transparent;
            gpb_perfil.BackgroundImage = Properties.Resources.block_fondoC;
            gpb_perfil.Controls.Add(richTextBox1);
            gpb_perfil.Controls.Add(lbCarrera);
            gpb_perfil.Controls.Add(lbName);
            gpb_perfil.Controls.Add(profile_photo);
            gpb_perfil.Font = new Font("Segoe UI Semibold", 12.2F, FontStyle.Bold);
            gpb_perfil.Location = new Point(37, 25);
            gpb_perfil.Name = "gpb_perfil";
            gpb_perfil.Size = new Size(399, 380);
            gpb_perfil.TabIndex = 16;
            gpb_perfil.TabStop = false;
            gpb_perfil.Text = "Informacion de perfil";
            // 
            // richTextBox1
            // 
            richTextBox1.ImeMode = ImeMode.Disable;
            richTextBox1.Location = new Point(19, 216);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(343, 142);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            // 
            // lbCarrera
            // 
            lbCarrera.AutoSize = true;
            lbCarrera.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold);
            lbCarrera.Location = new Point(159, 77);
            lbCarrera.Name = "lbCarrera";
            lbCarrera.Size = new Size(72, 17);
            lbCarrera.TabIndex = 2;
            lbCarrera.Text = "fermo.19";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbName.Location = new Point(159, 50);
            lbName.Name = "lbName";
            lbName.Size = new Size(173, 25);
            lbName.TabIndex = 1;
            lbName.Text = "Fernando Mojica";
            lbName.Click += label2_Click;
            // 
            // profile_photo
            // 
            profile_photo.BackgroundImageLayout = ImageLayout.Zoom;
            profile_photo.BorderStyle = BorderStyle.FixedSingle;
            profile_photo.Location = new Point(19, 44);
            profile_photo.Name = "profile_photo";
            profile_photo.Size = new Size(134, 129);
            profile_photo.TabIndex = 0;
            profile_photo.TabStop = false;
            profile_photo.Click += pictureBox2_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(236, 236, 236);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(0, 419);
            panel4.Name = "panel4";
            panel4.Size = new Size(885, 75);
            panel4.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.HotTrack;
            label4.Location = new Point(131, 5);
            label4.Name = "label4";
            label4.Size = new Size(658, 64);
            label4.TabIndex = 5;
            label4.Text = resources.GetString("label4.Text");
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 10.2F);
            button1.ForeColor = SystemColors.HotTrack;
            button1.Location = new Point(464, 697);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 12;
            button1.Text = "Siguiente";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel10
            // 
            panel10.BackColor = Color.FromArgb(236, 236, 236);
            panel10.Controls.Add(label3);
            panel10.Location = new Point(0, 756);
            panel10.Name = "panel10";
            panel10.Size = new Size(862, 83);
            panel10.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.HotTrack;
            label3.Location = new Point(131, 11);
            label3.Name = "label3";
            label3.Size = new Size(658, 64);
            label3.TabIndex = 5;
            label3.Text = resources.GetString("label3.Text");
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(64, 117, 255);
            panel2.BackgroundImage = Properties.Resources.block_fondoA;
            panel2.Controls.Add(btnEditar);
            panel2.Controls.Add(btn_Subir);
            panel2.Controls.Add(button2);
            panel2.Location = new Point(3, 87);
            panel2.Name = "panel2";
            panel2.Size = new Size(155, 493);
            panel2.TabIndex = 1;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(30, 176);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 29);
            btnEditar.TabIndex = 10;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btn_Subir
            // 
            btn_Subir.Location = new Point(33, 59);
            btn_Subir.Name = "btn_Subir";
            btn_Subir.Size = new Size(94, 60);
            btn_Subir.TabIndex = 9;
            btn_Subir.Text = "Subir\r\nProducto";
            btn_Subir.UseVisualStyleBackColor = true;
            btn_Subir.Click += btn_Subir_Click;
            // 
            // button2
            // 
            button2.Location = new Point(33, 25);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 0;
            button2.Text = "Regreso";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 117, 255);
            panel1.BackgroundImage = Properties.Resources.block_fondoA;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1046, 77);
            panel1.TabIndex = 0;
            // 
            // button3
            // 
            button3.BackgroundImage = Properties.Resources.icon_search;
            button3.BackgroundImageLayout = ImageLayout.Center;
            button3.Location = new Point(866, 27);
            button3.Name = "button3";
            button3.Size = new Size(34, 29);
            button3.TabIndex = 0;
            button3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(735, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(161, 21);
            label1.Name = "label1";
            label1.Size = new Size(514, 36);
            label1.TabIndex = 1;
            label1.Text = "TEC. ACAPULCO [VENDEDORES]";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.logo;
            pictureBox1.Location = new Point(9, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(118, 61);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Form3_profile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1051, 581);
            Controls.Add(panel3);
            Name = "Form3_profile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            panel3.ResumeLayout(false);
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            pnl_pag01.ResumeLayout(false);
            gpb_perfil.ResumeLayout(false);
            gpb_perfil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)profile_photo).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Panel panel12;
        private Label label22;
        private Panel pnl_pag01;
        private Button button1;
        private Panel panel10;
        private Label label3;
        private Panel panel2;
        private Panel panel1;
        private Button button3;
        private TextBox textBox1;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel4;
        private Label label4;
        private GroupBox gpb_perfil;
        private PictureBox profile_photo;
        private Button button2;
        private Label lbName;
        private Label lbCarrera;
        private GroupBox groupBox1;
        private RichTextBox richTextBox1;
        private Button btn_Subir;
        private Button btnEditar;
    }
}
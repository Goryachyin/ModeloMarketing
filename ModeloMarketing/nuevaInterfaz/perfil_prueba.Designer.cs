namespace ModeloMarketing
{
    partial class perfil_prueba
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(perfil_prueba));
            pnl_pag01 = new Panel();
            groupBox1 = new GroupBox();
            label2 = new Label();
            gpb_perfil = new GroupBox();
            richTextBox1 = new RichTextBox();
            lbCarrera = new Label();
            lbName = new Label();
            profile_photo = new PictureBox();
            panel4 = new Panel();
            label4 = new Label();
            pnl_pag01.SuspendLayout();
            groupBox1.SuspendLayout();
            gpb_perfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)profile_photo).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_pag01
            // 
            pnl_pag01.AutoScroll = true;
            pnl_pag01.BackColor = SystemColors.ButtonHighlight;
            pnl_pag01.BackgroundImage = Properties.Resources.block_fondoB;
            pnl_pag01.Controls.Add(groupBox1);
            pnl_pag01.Controls.Add(gpb_perfil);
            pnl_pag01.Controls.Add(panel4);
            pnl_pag01.Dock = DockStyle.Fill;
            pnl_pag01.Location = new Point(0, 0);
            pnl_pag01.Name = "pnl_pag01";
            pnl_pag01.Size = new Size(1022, 553);
            pnl_pag01.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.BackgroundImage = Properties.Resources.block_fondoC;
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI Semibold", 12.2F, FontStyle.Bold);
            groupBox1.Location = new Point(536, 25);
            groupBox1.Margin = new Padding(0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(441, 418);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 0);
            label2.Name = "label2";
            label2.Size = new Size(111, 30);
            label2.TabIndex = 0;
            label2.Text = "Productos";
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
            gpb_perfil.Size = new Size(461, 418);
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
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(236, 236, 236);
            panel4.Controls.Add(label4);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 478);
            panel4.Name = "panel4";
            panel4.Size = new Size(1022, 75);
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
            // perfil_prueba
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1022, 553);
            Controls.Add(pnl_pag01);
            Name = "perfil_prueba";
            Text = "Form1";
            pnl_pag01.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            gpb_perfil.ResumeLayout(false);
            gpb_perfil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)profile_photo).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_pag01;
        private GroupBox groupBox1;
        private Label label2;
        private GroupBox gpb_perfil;
        private RichTextBox richTextBox1;
        private Label lbCarrera;
        private Label lbName;
        private PictureBox profile_photo;
        private Panel panel4;
        private Label label4;
    }
}
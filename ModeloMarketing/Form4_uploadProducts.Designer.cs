namespace ModeloMarketing
{
    partial class Form4_uploadProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4_uploadProducts));
            panel3 = new Panel();
            panel12 = new Panel();
            label22 = new Label();
            pnl_pag01 = new Panel();
            groupBox1 = new GroupBox();
            label8 = new Label();
            clb_tipo = new CheckedListBox();
            cb_size = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            clb_categoria = new CheckedListBox();
            button6 = new Button();
            button4 = new Button();
            button5 = new Button();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            txf_descripcion = new RichTextBox();
            label5 = new Label();
            txf_precio = new TextBox();
            label4 = new Label();
            txf_nombre = new TextBox();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            button1 = new Button();
            panel10 = new Panel();
            label3 = new Label();
            panel2 = new Panel();
            button2 = new Button();
            panel1 = new Panel();
            button3 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel3.SuspendLayout();
            panel12.SuspendLayout();
            pnl_pag01.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
            panel3.Size = new Size(1052, 580);
            panel3.TabIndex = 4;
            // 
            // panel12
            // 
            panel12.BackColor = Color.FromArgb(236, 236, 236);
            panel12.Controls.Add(label22);
            panel12.Location = new Point(163, 768);
            panel12.Name = "panel12";
            panel12.Size = new Size(862, 82);
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
            pnl_pag01.Controls.Add(button1);
            pnl_pag01.Controls.Add(panel10);
            pnl_pag01.Location = new Point(164, 87);
            pnl_pag01.Name = "pnl_pag01";
            pnl_pag01.Size = new Size(885, 973);
            pnl_pag01.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.BackgroundImage = Properties.Resources.block_fondoC;
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(clb_tipo);
            groupBox1.Controls.Add(cb_size);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(clb_categoria);
            groupBox1.Controls.Add(button6);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(txf_descripcion);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txf_precio);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txf_nombre);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Font = new Font("Segoe UI Semibold", 12.2F, FontStyle.Bold);
            groupBox1.Location = new Point(23, 25);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(803, 434);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informacion del producto";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label8.Location = new Point(405, 252);
            label8.Name = "label8";
            label8.Size = new Size(43, 23);
            label8.TabIndex = 32;
            label8.Text = "Tipo";
            // 
            // clb_tipo
            // 
            clb_tipo.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            clb_tipo.FormattingEnabled = true;
            clb_tipo.Items.AddRange(new object[] { "Arreglos", "Dulceria", "Comida", "Peluches", "Papeleria", "Servicios" });
            clb_tipo.Location = new Point(405, 278);
            clb_tipo.Name = "clb_tipo";
            clb_tipo.Size = new Size(141, 129);
            clb_tipo.TabIndex = 31;
            // 
            // cb_size
            // 
            cb_size.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            cb_size.FormattingEnabled = true;
            cb_size.Items.AddRange(new object[] { "Chico", "Mediano", "Grande" });
            cb_size.Location = new Point(565, 278);
            cb_size.Name = "cb_size";
            cb_size.Size = new Size(103, 31);
            cb_size.TabIndex = 30;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label7.Location = new Point(565, 250);
            label7.Name = "label7";
            label7.Size = new Size(70, 23);
            label7.TabIndex = 29;
            label7.Text = "Tamaño";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label6.Location = new Point(240, 252);
            label6.Name = "label6";
            label6.Size = new Size(84, 23);
            label6.TabIndex = 28;
            label6.Text = "Categoria";
            // 
            // clb_categoria
            // 
            clb_categoria.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            clb_categoria.FormattingEnabled = true;
            clb_categoria.Items.AddRange(new object[] { "Cualquiera", "Parejas", "Familia", "Amigos", "Maestros" });
            clb_categoria.Location = new Point(240, 278);
            clb_categoria.Name = "clb_categoria";
            clb_categoria.Size = new Size(141, 129);
            clb_categoria.TabIndex = 27;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(247, 247, 247);
            button6.FlatAppearance.BorderSize = 0;
            button6.Font = new Font("Segoe UI Semibold", 12.2F, FontStyle.Bold);
            button6.Location = new Point(54, 293);
            button6.Name = "button6";
            button6.Size = new Size(157, 43);
            button6.TabIndex = 25;
            button6.Text = "Aceptar";
            button6.TextAlign = ContentAlignment.TopCenter;
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(247, 247, 247);
            button4.FlatAppearance.BorderSize = 0;
            button4.Font = new Font("Segoe UI Semibold", 12.2F, FontStyle.Bold);
            button4.Location = new Point(54, 342);
            button4.Name = "button4";
            button4.Size = new Size(157, 43);
            button4.TabIndex = 24;
            button4.Text = "Cancelar";
            button4.TextAlign = ContentAlignment.TopCenter;
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(230, 247, 255);
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI Semibold", 8.2F, FontStyle.Bold);
            button5.Location = new Point(34, 258);
            button5.Name = "button5";
            button5.Size = new Size(200, 29);
            button5.TabIndex = 23;
            button5.Text = "[         Agregar imagen         ]";
            button5.TextAlign = ContentAlignment.TopCenter;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            checkBox2.Location = new Point(565, 84);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(170, 27);
            checkBox2.TabIndex = 21;
            checkBox2.Text = "Listo para entrega";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            checkBox1.Location = new Point(422, 84);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(124, 27);
            checkBox1.TabIndex = 20;
            checkBox1.Text = "Por encargo";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // txf_descripcion
            // 
            txf_descripcion.BorderStyle = BorderStyle.FixedSingle;
            txf_descripcion.Location = new Point(240, 146);
            txf_descripcion.Name = "txf_descripcion";
            txf_descripcion.Size = new Size(516, 101);
            txf_descripcion.TabIndex = 19;
            txf_descripcion.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label5.Location = new Point(240, 120);
            label5.Name = "label5";
            label5.Size = new Size(201, 23);
            label5.TabIndex = 18;
            label5.Text = "Descripcion del producto";
            // 
            // txf_precio
            // 
            txf_precio.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            txf_precio.Location = new Point(303, 81);
            txf_precio.Name = "txf_precio";
            txf_precio.Size = new Size(91, 30);
            txf_precio.TabIndex = 17;
            txf_precio.KeyPress += txf_precio_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label4.Location = new Point(240, 81);
            label4.Name = "label4";
            label4.Size = new Size(57, 23);
            label4.TabIndex = 16;
            label4.Text = "Precio";
            // 
            // txf_nombre
            // 
            txf_nombre.BorderStyle = BorderStyle.FixedSingle;
            txf_nombre.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            txf_nombre.Location = new Point(413, 44);
            txf_nombre.Name = "txf_nombre";
            txf_nombre.Size = new Size(343, 30);
            txf_nombre.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label2.Location = new Point(240, 47);
            label2.Name = "label2";
            label2.Size = new Size(176, 23);
            label2.TabIndex = 14;
            label2.Text = "Nombre del producto";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Location = new Point(34, 47);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(200, 200);
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
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
            panel10.Size = new Size(862, 82);
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
            panel2.Controls.Add(button2);
            panel2.Location = new Point(3, 87);
            panel2.Name = "panel2";
            panel2.Size = new Size(155, 493);
            panel2.TabIndex = 1;
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
            panel1.Size = new Size(1046, 78);
            panel1.TabIndex = 0;
            // 
            // button3
            // 
            button3.BackgroundImage = Properties.Resources.icon_search;
            button3.BackgroundImageLayout = ImageLayout.Center;
            button3.Location = new Point(866, 26);
            button3.Name = "button3";
            button3.Size = new Size(34, 29);
            button3.TabIndex = 0;
            button3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(735, 26);
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
            label1.Location = new Point(161, 22);
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
            pictureBox1.Size = new Size(118, 62);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Form4_uploadProducts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1052, 581);
            Controls.Add(panel3);
            Name = "Form4_uploadProducts";
            Text = "Form4";
            panel3.ResumeLayout(false);
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            pnl_pag01.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private GroupBox groupBox1;
        private PictureBox pictureBox2;
        private Button button1;
        private Panel panel10;
        private Label label3;
        private Panel panel2;
        private Button button2;
        private Panel panel1;
        private Button button3;
        private TextBox textBox1;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox txf_precio;
        private Label label4;
        private TextBox txf_nombre;
        private Label label2;
        private CheckBox checkBox1;
        private RichTextBox txf_descripcion;
        private Label label5;
        private CheckBox checkBox2;
        private Button button5;
        private Button button4;
        private Button button6;
        private CheckedListBox clb_categoria;
        private Label label7;
        private Label label6;
        private ComboBox cb_size;
        private CheckedListBox clb_tipo;
        private Label label8;
    }
}
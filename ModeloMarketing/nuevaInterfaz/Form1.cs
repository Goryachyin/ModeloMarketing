namespace CarruselProductos
{
    public partial class Form1 : Form
    {
        private List<CustomPanel> customPanels = new List<CustomPanel>();//esto
        private int velocidadMovimiento = 1;//esto
        public Form1()
        {
            InitializeComponent();
            //de aqui
            Panel[] paneles = { pnl_panel01, pnl_panel02, pnl_panel03, pnl_panel04, pnl_panel05, 
                pnl_panel06, pnl_panel07, pnl_panel08, pnl_panel09 }; //aqui se meten los paneles
            for (int i = 0; i < paneles.Length; i++)
            {
                customPanels.Add(new CustomPanel(paneles[i], pnl_fondo, i, velocidadMovimiento));
            }
            IniciarRecorrido();
            //a aqui

        }
        //y esta funcion
        public async void IniciarRecorrido()
        {
            while (true)
            {
                foreach (var customPanel in customPanels)
                {
                    customPanel.MoverPanel();
                }
                await Task.Delay(25); // Controla la velocidad del movimiento
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
    }
}

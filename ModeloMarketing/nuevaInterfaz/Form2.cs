using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarruselProductos
{
    public partial class Form2 : Form
    {
        private List<CustomPanel> customPanels = new List<CustomPanel>();
        private int velocidadMovimiento = 1;
        public Form2()
        {
            InitializeComponent();
            Panel[] paneles = { pnl_panelForm2_01, pnl_panelForm2_02, pnl_panelForm2_03, pnl_panelForm2_04, pnl_panelForm2_05 };
            for (int i = 0; i < paneles.Length; i++)
            {
                customPanels.Add(new CustomPanel(paneles[i], pnl_fondo, i, velocidadMovimiento));
            }
            IniciarRecorrido();


        }
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

        }
    }
}

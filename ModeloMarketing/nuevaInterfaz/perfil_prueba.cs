using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModeloMarketing
{
    public partial class perfil_prueba : Form
    {
        public perfil_prueba()
        {
            InitializeComponent();
            Panel panelScroll = new Panel();
            panelScroll.Dock = DockStyle.Fill;
            panelScroll.AutoScroll = true;
            groupBox1.Controls.Add(panelScroll);
            GestorDir dir = new GestorDir();
            string idUser = dir.buscarValorKey("usuario");
            gestorSQL gestor = new gestorSQL();
            gestor.cargarPerfil(idUser, profile_photo, lbName, lbCarrera);
            gestor.cargarProductosEnPerfil(idUser, panelScroll);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class CustomPanel
{
    public Panel Panel { get; private set; }
    private Panel fondo; 
    private int velocidadMovimiento; // Velocidad de los paneles
    private int aumentoTamaño = 20; // 
    private int index; // Índice del panel
    public CustomPanel(Panel panel, Panel fondo, int index, int velocidadMovimiento)
    {
        this.Panel = panel;
        this.fondo = fondo;
        this.index = index;
        this.velocidadMovimiento = velocidadMovimiento;

        this.Panel.MouseEnter += Panel_MouseEnter;
        this.Panel.MouseLeave += Panel_MouseLeave;
    }

    private void CambiaTamaño(bool aumentar)
    {
        int cambio = aumentar ? aumentoTamaño : -aumentoTamaño;
        int nuevoAncho = Panel.Width + cambio;
        int nuevaAltura = Panel.Height + cambio;

        int deltaX = (nuevoAncho - Panel.Width) / 2;
        int deltaY = (nuevaAltura - Panel.Height) / 2;

        Panel.Location = new Point(Panel.Location.X - deltaX, Panel.Location.Y - deltaY);
        Panel.Size = new Size(nuevoAncho, nuevaAltura);

        Application.DoEvents();
    }

    private void Panel_MouseEnter(object sender, EventArgs e)
    {
        CambiaTamaño(true); // Aumentar el tamaño
    }

    private void Panel_MouseLeave(object sender, EventArgs e)
    {
        CambiaTamaño(false); // Disminuir el tamaño
    }
    public void MoverPanel()
    {
        int PosXa = Panel.Location.X;
        int PosYa = Panel.Location.Y;
        int PosPanel = fondo.Size.Width;

        PosXa += velocidadMovimiento;
        if (PosXa > PosPanel)
        {
            PosXa = fondo.Location.X - Panel.Width - 30;
        }

        Panel.Location = new Point(PosXa, PosYa);
    }
}

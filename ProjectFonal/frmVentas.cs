using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectFonal
{
    public partial class frmVentas : Form
    {
        public frmVentas()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            this.Close();
            menu.Show();
            
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {

        }

        private void btnFactura_Click(object sender, EventArgs e)
        {
            //Llamamos al crtFactura
            ctrlUsFactura crtfactura = new ctrlUsFactura();
            //Traemos el crtFactura a este formulario
            if (pnlVentas.Contains(crtfactura) == false)
            {
                pnlVentas.Controls.Add(crtfactura);
                crtfactura.Dock = DockStyle.Fill;
                crtfactura.BringToFront();
            }
            else
            {
                crtfactura.BringToFront();
            }
        }

        private void btnRealizarVenta_Click(object sender, EventArgs e)
        {
            //Llamamos al crtProveedor
            ctrlUsVenta crtventa = new ctrlUsVenta();
            //Traemos el crtProveedor a este formulario
            if (pnlVentas.Contains(crtventa) == false)
            {
                pnlVentas.Controls.Add(crtventa);
                crtventa.Dock = DockStyle.Fill;
                crtventa.BringToFront();
            }
            else
            {
                crtventa.BringToFront();
            }
        }
    }
}

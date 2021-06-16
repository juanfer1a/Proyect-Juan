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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }
            frmUsuarios Usuarios = new frmUsuarios();
            frmInventario Inventario = new frmInventario();
            frmVentas Ventas = new frmVentas();
            frmReportes Reportes = new frmReportes();


        private void btnUsuario_Click(object sender, EventArgs e)
        {
            this.Close();
            Usuarios.Show();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            this.Close();
            Inventario.Show();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            this.Close();
            Ventas.Show();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            this.Close();
            Reportes.Show();
        }

       
    }
}

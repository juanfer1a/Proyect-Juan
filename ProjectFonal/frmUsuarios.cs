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
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void btnRegresarMenu_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            this.Close();
            menu.Show();
            
        }

        private void txtProveedor_Click(object sender, EventArgs e)
        {
            //Llamamos al crtProveedor
            ctrlUsProveedor crtproveedor = new ctrlUsProveedor();
            //Traemos el crtProveedor a este formulario
            if (pnlUsuarios.Contains(crtproveedor) == false )
            {
                pnlUsuarios.Controls.Add(crtproveedor);
                crtproveedor.Dock = DockStyle.Fill;
                crtproveedor.BringToFront();
            }
            else
            {
                crtproveedor.BringToFront();
            }
        }

        private void txtEmpleado_Click(object sender, EventArgs e)
        {
            //Llamamos al crtEmpleado
            ctrUsEmpleado crtempleado = new ctrUsEmpleado();
            //Traemos el crtEmpleado a este formulario
            if (pnlUsuarios.Contains(crtempleado) == false)
            {
                pnlUsuarios.Controls.Add(crtempleado);
                crtempleado.Dock = DockStyle.Fill;
                crtempleado.BringToFront();
            }
            else
            {
                crtempleado.BringToFront();
            }
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {

        }
    }
}

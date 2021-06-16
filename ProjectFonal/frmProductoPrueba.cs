using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace ProjectFonal
{
    public partial class frmProductoPrueba : Form
    {
        clsConexion cn = new clsConexion();
        private static string path = Application.StartupPath + @"\Categorias.json";
        public frmProductoPrueba()
        {
            InitializeComponent();

            //string categoria = "SELECT * from tblCategoria";
            ////Llenamos el datagrid con la información
            //for (int i = 0; i < cn.mostrarTabla(categoria).Rows.Count; i++)
            //{
            //    cbxCategoria.Items.Add(cn.mostrarTabla(categoria).Rows[i]["idstrCategoria"].ToString());
            //}
            for (int i = 0; i < Json.Json.findCategories().Count; i++)
            {
                cxbCategoria.Items.Add(Json.Json.findCategories()[i]);
            }

        }      

        private void btnCrearProducto_Click(object sender, EventArgs e)
        {

            var datosProducto = Json.Json.Producto(cxbCategoria.Text, txtNombreProducto.Text, 
                Convert.ToInt32(txtPrecioProducto.Text));
            Json.Json.SerializarJsonCategoria(datosProducto);
        }
    }
}

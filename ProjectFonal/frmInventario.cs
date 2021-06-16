
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Para poder usuar los Json(También descargar el Nuget)
using Newtonsoft.Json;
using System.IO;

namespace ProjectFonal
{
    public partial class frmInventario : Form
    {
        string Proveedor;
        clsConexion cn = new clsConexion();

        private static string path = Application.StartupPath + @"\Categorias.json";

        public frmInventario()
        {



            InitializeComponent();
            try
            {
                ////Mantenemos la tabla refrescada               
                //string MostrarTabla = "SELECT strNombre , intCantidad from tblIngrediente";
                ////Llenamos el datagrid con la información
                //dataGridView1.DataSource = cn.mostrarTabla(MostrarTabla);
                //Proveedor = "SELECT * from tblProveedor";
                ////Llenamos el datagrid con la información
                //for (int i = 0; i < cn.mostrarTabla(Proveedor).Rows.Count; i++)
                //{
                    
                //}


            }
            catch (Exception ex)
            {

                MessageBox.Show("No se pudo mostrar la información en el " + ex.Message);
            }
            for (int i = 0; i < Json.Json.findCategories().Count; i++)
            {
                cxbCategoria.Items.Add(Json.Json.findCategories()[i]); 
            }
        }           

        private void btnCrearInsumo_Click(object sender, EventArgs e)
        {
            var datosProducto = Json.Json.Ingrediente(cxbCategoria.Text, txtProducto.Text, txtNombreInsumo.Text);
            Json.Json.SerializarJsonCategoria(datosProducto);

        }

      
    }
}

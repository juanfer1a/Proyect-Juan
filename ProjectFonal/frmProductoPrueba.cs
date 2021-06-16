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

            string categoria = "SELECT * from tblCategoria";
            //Llenamos el datagrid con la información
            for (int i = 0; i < cn.mostrarTabla(categoria).Rows.Count; i++)
            {
                cbxCategoria.Items.Add(cn.mostrarTabla(categoria).Rows[i]["idstrCategoria"].ToString());
            }

        }



        //public static List<Json.Categoria> Producto(string nombreCategoria, string nombreProducto, int precio)
        //{
        //    bool bandera = false;
        //    var categorias = deserializeJsonFile();

        //    for (int i = 0; i < categorias.Count; i++)
        //    {
        //        if (categorias[i].Nombre == nombreCategoria)
        //        {
        //            if (categorias[i].Productos.Count == 0)
        //            {
        //                categorias[i].Productos = new List<Json.clsProducto>
        //                        {
        //                            new Json.clsProducto
        //                            {
        //                                Nombre = nombreProducto,Precio = precio

        //                            }

        //                        };

        //            }
        //            else
        //            {
        //                for (int j = 0; j < categorias[i].Productos.Count; j++)
        //                {
        //                    if (categorias[i].Productos[j].Nombre == nombreProducto)
        //                    {
        //                        bandera = true;
        //                    }
        //                }

        //                if (bandera)
        //                {
        //                    MessageBox.Show("El nombre del producto esta registrado");

        //                }

        //                else
        //                {
        //                    categorias[i].Productos.Add
        //                        (
        //                            new Json.clsProducto
        //                            {
        //                                Nombre = nombreProducto,
        //                                Precio = precio
        //                            }
        //                        );

        //                    bandera = false;
        //                }
        //            }
        //        }
        //    }






        //    return categorias;
        //}







        public static void SerializarJsonCategoria(List<Json.Categoria> categorias)
        {
            string categoriaJson = JsonConvert.SerializeObject(categorias.ToArray(), Formatting.Indented);

            File.WriteAllText(path, categoriaJson);

        }

        public static string GetProductFromFile()
        {
            string productFromFile;
            using (var reader = new StreamReader(path))
            {
                productFromFile = reader.ReadToEnd();

            }
            return productFromFile;
        }

        public static List<Json.Categoria> deserializeJsonFile()
        {
            var categoriasDeserializer = JsonConvert.DeserializeObject<List<Json.Categoria>>(GetProductFromFile());
            return categoriasDeserializer;
        }

        private void btnCrearProducto_Click(object sender, EventArgs e)
        {

            var datosProducto = Json.Json.Producto(cbxCategoria.Text, txtNombreProducto.Text, 
                Convert.ToInt32(txtPrecioProducto.Text));
            SerializarJsonCategoria(datosProducto);
        }
    }
}

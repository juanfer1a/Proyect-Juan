
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
                //Mantenemos la tabla refrescada               
                string MostrarTabla = "SELECT strNombre , intCantidad from tblIngrediente";
                //Llenamos el datagrid con la información
                dataGridView1.DataSource = cn.mostrarTabla(MostrarTabla);
                Proveedor = "SELECT * from tblProveedor";
                //Llenamos el datagrid con la información
                for (int i = 0; i < cn.mostrarTabla(Proveedor).Rows.Count; i++)
                {
                    
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("No se pudo mostrar la información en el " + ex.Message);
            }
        }

        //Creacion del documento. Json  
        private void btnGuardarJson_Click(object sender, EventArgs e)
        {
            //Enviamos los datos correpondientes del textbox
            //var datosProducto = Producto(txtCategoria.Text, txtProducto.Text, txtNombreInsumo.Text);
            //SerializarJsonCategoria(datosProducto);

        }



        //Creación del Json(mirar la carpeta en el explorador de soluciones)
        //public static List<Json.Categoria> Producto(string nombreCategoria, string nombreProducto, string nombreIngrediente)
        //{
        //    bool bandera = false;
        //    var categorias = deserializeJsonFile();

        //    for (int i = 0; i < categorias.Count; i++)
        //    {
        //        if (categorias[i].Nombre == nombreCategoria)
        //        {
        //            for (int j = 0; j < categorias[i].Productos.Count; j++)
        //            {
        //                if (categorias[i].Productos[j].Nombre == nombreProducto)
        //                {
        //                    if (categorias[i].Productos[j].Ingredientes.Count == 0)
        //                    {
        //                        categorias[i].Productos[j].Ingredientes = new List<Json.clsIngredientes>
        //                            {
        //                                new Json.clsIngredientes
        //                                {
        //                                    Nombre = nombreIngrediente
        //                                }
        //                            };

        //                    }
        //                    else
        //                    {
        //                        for (int r = 0; r < categorias[i].Productos.Count; r++)
        //                        {
        //                            for (int s = 0; s < categorias[i].Productos[j].Ingredientes.Count; s++)
        //                            {
        //                                if (categorias[i].Productos[j].Ingredientes[s].Nombre == nombreIngrediente)
        //                                {
        //                                    bandera = true;
        //                                }
        //                            }

        //                            if (bandera)
        //                            {
        //                                MessageBox.Show("El nombre del producto esta registrado");

        //                            }

        //                            else
        //                            {
        //                                categorias[i].Productos[j].Ingredientes.Add
        //                                    (
        //                                        new Json.clsIngredientes
        //                                        {
        //                                            Nombre = nombreIngrediente

        //                                        }
        //                                    );

        //                                bandera = false;
        //                            }
        //                        }

        //                    }



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

        private void btnCrearInsumo_Click(object sender, EventArgs e)
        {
            var datosProducto = Json.Json.Ingrediente(txtCategoria.Text, txtProducto.Text, txtNombreInsumo.Text);
            SerializarJsonCategoria(datosProducto);

        }
    }
}

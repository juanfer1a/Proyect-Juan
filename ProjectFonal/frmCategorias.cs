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
    public partial class frmCategorias : Form
    {

        clsConexion cn = new clsConexion();
        private static string path = Application.StartupPath + @"\Categorias.json";


        public frmCategorias()
        {
            InitializeComponent();
        }

        private void btnCrearCategoria_Click(object sender, EventArgs e)
        {
            string GuardarCategoria = "INSERT INTO tblCategoria([idstrCategoria])" +
                       "values('" + txtNombreCategoria.Text + "')";
            cn.conectarComando(GuardarCategoria);
            //var nombreCategoria = Categoria(txtNombreCategoria.Text);
            var nombreCategoria = Json.Json.Categoria(txtNombreCategoria.Text);
            SerializarJsonCategoria(nombreCategoria);


        }

       

        //public static List<Json.Categoria> Categorias(string nombreCategoria)
        //{
        //    bool bandera = false;
        //    var categorias = deserializeJsonFile();

        //    if (categorias.Count == 0)
        //    {
        //        categorias = new List<Json.Categoria>
        //            {
        //                new Json.Categoria
        //                {
        //                    Nombre = nombreCategoria

        //                }

        //            };
        //        return categorias;
        //    }

        //    else
        //    {
        //        for (int i = 0; i < categorias.Count; i++)
        //        {
        //            if (categorias[i].Nombre == nombreCategoria)
        //            {
        //                bandera = true;
        //            }
        //        }
        //        if (bandera)
        //        {
        //            MessageBox.Show("La categoria ya existe");
        //        }
        //        else
        //        {

        //            categorias.Add
        //                (
        //                    new Json.Categoria
        //                    {
        //                        Nombre = nombreCategoria
        //                    }
        //                );
        //            bandera = false;

        //        }
        //        return categorias;

        //    }

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
    }
}

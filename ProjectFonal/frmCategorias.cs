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
            //string GuardarCategoria = "INSERT INTO tblCategoria([idstrCategoria])" +
            //           "values('" + txtNombreCategoria.Text + "')";
            //cn.conectarComando(GuardarCategoria);
            //var nombreCategoria = Categoria(txtNombreCategoria.Text);
            var nombreCategoria = Json.Json.Categoria(txtNombreCategoria.Text);
            Json.Json.SerializarJsonCategoria(nombreCategoria);


        }            

    }
}

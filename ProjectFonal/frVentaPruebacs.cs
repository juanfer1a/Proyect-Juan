using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Newtonsoft.Json;
using System.IO;

namespace ProjectFonal
{
    public partial class frVentaPruebacs : MaterialForm
    {
        int posX = 21;
        int posY = 15;
        int aumentarX = 0;
        int aumentarY = 0;
        int cont = 0;
        
        private static string path = Application.StartupPath + @"\Categorias.json";
       
        string nombre;

        public frVentaPruebacs()
        {
            InitializeComponent();

            var categoria = deserializeJsonFile();
            foreach (var item in categoria)
            {
                Button btnPrueba = new System.Windows.Forms.Button();
                nombre = item.Nombre;
                panel1.Controls.Add(btnPrueba);
                btnPrueba.Location = new System.Drawing.Point(posX, posY);
                btnPrueba.Name = "btnPrueba";
                btnPrueba.Size = new System.Drawing.Size(130, 54);
                //btnPrueba.TabIndex = 0;
                btnPrueba.Text = nombre;
                btnPrueba.UseVisualStyleBackColor = true;
                posX += 136;
                cont++;

            }
            //this.button6.Location = new System.Drawing.Point(157, 15);
            //this.button6.Name = "button6";
            //this.button6.Size = new System.Drawing.Size(130, 54);
            //this.button6.TabIndex = 3;
            //this.button6.Text = "button6";
            //this.button6.UseVisualStyleBackColor = true;
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
            var categorias = JsonConvert.DeserializeObject<List<Json.Categoria>>(GetProductFromFile());
            return categorias;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFonal.Json
{
    public class clsProducto
    {
        private string nombre;
        private int precio;
        private List<clsIngredientes> ingredientes = new List<clsIngredientes>();

        public string Nombre { get => nombre; set => nombre = value; }
        public int Precio { get => precio; set => precio = value; }
        public List<clsIngredientes> Ingredientes { get => ingredientes; set => ingredientes = value; }

        public clsProducto()
        {
            this.nombre = "";
            this.precio = 0;
            this.ingredientes = new List<clsIngredientes>();

        }

        //public clsProducto(string nombre, int precio, List<clsIngredientes> ingredientes)
        //{
        //    this.nombre = nombre;
        //    this.precio = precio;
        //    this.ingredientes = ingredientes;
        //}
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFonal.Json
{
    public class Categoria
    {
        private string nombre;
        private List<clsProducto> productos = new List<clsProducto>();
        

        public Categoria()
        {
            this.nombre = "";
            
            this.productos = new List<clsProducto>();

        }

        public string Nombre { get => nombre; set => nombre = value; }
        public List<clsProducto> Productos { get => productos; set => productos = value; }
    }
}

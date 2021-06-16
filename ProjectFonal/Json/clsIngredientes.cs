using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFonal.Json
{
    public class clsIngredientes
    {
        string nombre;
        string unidad;
        double cantidad;

        public clsIngredientes()
        {
            Nombre = "";
            Unidad = "";
            Cantidad = 0;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Unidad { get => unidad; set => unidad = value; }
        public double Cantidad { get => cantidad; set => cantidad = value; }
    }
}

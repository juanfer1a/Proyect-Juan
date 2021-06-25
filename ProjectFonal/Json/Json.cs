using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace ProjectFonal.Json
{
    class Json
    {
        private static string path = Application.StartupPath + @"\Categorias.json";
        private List<Categoria> categorias = new List<Categoria>();
        private List<clsProducto> productos = new List<clsProducto>();
        private List<clsIngredientes> ingredientes = new List<clsIngredientes>();

        public Json(List<Categoria> categorias, List<clsProducto> productos, List<clsIngredientes> ingredientes)
        {
            this.categorias = categorias;
            this.productos = productos;
            this.ingredientes = ingredientes;
        }

        public string Path { get => path; set => path = value; }
        public List<Categoria> Categorias { get => categorias; set => categorias = value; }
        public List<clsProducto> Productos { get => productos; set => productos = value; }
        public List<clsIngredientes> Ingredientes { get => ingredientes; set => ingredientes = value; }


        public static List<string> findCategories()
        {
            List<string> lista = new List<string>();
            var categories = deserializeJsonFile();
            for (int i = 0; i < categories.Count; i++)
            {
                lista.Add(categories[i].Nombre);
            }
            return lista;
        }

        public static List<string> findProducts(string categorie)
        {
            List<string> lista = new List<string>();
            var categories = deserializeJsonFile();
            for (int i = 0; i < categories.Count; i++)
            {
                if (categories[i].Nombre == categorie)
                {
                    for (int j = 0; j < categories[i].Productos.Count; j++)
                    {
                        lista.Add(categories[i].Productos[j].Nombre);
                    }
                }
            }
            return lista;
        }



        public static List<Categoria> Categoria(string nombreCategoria)
        {
            bool bandera = false;
            var categorias = deserializeJsonFile();

            if (categorias.Count == 0)
            {
                categorias = new List<Categoria>
                    {
                        new Categoria
                        {
                            Nombre = nombreCategoria

                        }

                    };
                return categorias;
            }

            else
            {
                for (int i = 0; i < categorias.Count; i++)
                {
                    if (categorias[i].Nombre == nombreCategoria)
                    {
                        bandera = true;
                    }
                }
                if (bandera)
                {
                    MessageBox.Show("La categoria ya existe");
                }
                else
                {

                    categorias.Add
                        (
                            new Categoria
                            {
                                Nombre = nombreCategoria
                            }
                        );
                    bandera = false;

                }
                return categorias;

            }

        }


        public static List<Categoria> Producto(string nombreCategoria, string nombreProducto, int precio)
        {
            bool bandera = false;
            var categorias = deserializeJsonFile();

            for (int i = 0; i < categorias.Count; i++)
            {
                if (categorias[i].Nombre == nombreCategoria)
                {
                    if (categorias[i].Productos.Count == 0)
                    {
                        categorias[i].Productos = new List<clsProducto>
                                {
                                    new clsProducto
                                    {
                                        Nombre = nombreProducto,Precio = precio

                                    }

                                };

                    }
                    else
                    {
                        for (int j = 0; j < categorias[i].Productos.Count; j++)
                        {
                            if (categorias[i].Productos[j].Nombre == nombreProducto)
                            {
                                bandera = true;
                            }
                        }

                        if (bandera)
                        {
                            MessageBox.Show("El nombre del producto esta registrado");

                        }

                        else
                        {
                            categorias[i].Productos.Add
                                (
                                    new clsProducto
                                    {
                                        Nombre = nombreProducto,
                                        Precio = precio
                                    }
                                );

                            bandera = false;
                        }
                    }
                }
            }

            return categorias;
        }

        public static List<Categoria> Ingrediente(string nombreCategoria, string nombreProducto, string nombreIngrediente, double cantidad)
        {
            bool bandera = false;
            var categorias = deserializeJsonFile();

            for (int i = 0; i < categorias.Count; i++)
            {
                if (categorias[i].Nombre == nombreCategoria)
                {
                    for (int j = 0; j < categorias[i].Productos.Count; j++)
                    {
                        if (categorias[i].Productos[j].Nombre == nombreProducto)
                        {
                            if (categorias[i].Productos[j].Ingredientes.Count == 0)
                            {
                                categorias[i].Productos[j].Ingredientes = new List<clsIngredientes>
                                    {
                                        new clsIngredientes
                                        {
                                            Nombre = nombreIngrediente,
                                            Cantidad = cantidad
                                        }
                                    };

                            }
                            else
                            {
                                for (int k = 0; k < categorias[i].Productos[j].Ingredientes.Count; k++)
                                {
                                    if (categorias[i].Productos[j].Ingredientes[k].Nombre == nombreIngrediente)
                                    {
                                        bandera = true;
                                    }
                                }

                                if (bandera == false)
                                {
                                    categorias[i].Productos[j].Ingredientes.Add
                                        (
                                            new clsIngredientes
                                            {
                                                Nombre = nombreIngrediente,
                                                Cantidad = cantidad
                                            }
                                        );

                                    bandera = false;
                                }

                                else
                                {
                                    MessageBox.Show("El producto ya cuenta con este ingrediente");
                                }
                            }
                        }
                    }

                }
            }

            return categorias;
        }


        public static void SerializarJsonCategoria(List<Categoria> categorias)
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

        public static List<Categoria> deserializeJsonFile()
        {
            var categoriasDeserializer = JsonConvert.DeserializeObject<List<Categoria>>(GetProductFromFile());
            return categoriasDeserializer;
        }

    }
}

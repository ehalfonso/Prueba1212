using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Proyecto_EstructuraDeDatos_Encinas_Sillas.LogicaDeArreglos
{
    public class ManejadorArreglos
    {
        private ProductoParaMascota[] productos;
        public int tamañoMaximo;
        private int indiceActual;

        public ManejadorArreglos(int capacidadMaxima)
        {
            tamañoMaximo = capacidadMaxima;
            productos = new ProductoParaMascota[capacidadMaxima];
            indiceActual = 0;
        }

        public ProductoParaMascota[] Productos
        {
            get { return productos; }
        }

        public bool EstaVacio()
        {
            return indiceActual == 0;
        }

        public void AgregarProducto(string nombre, double precio)
        {
            if (indiceActual < tamañoMaximo)
            {
                productos[indiceActual] = new ProductoParaMascota(nombre, precio);
                indiceActual++;
            }
            else
            {
                MessageBox.Show("No se pueden agregar más productos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ModificarProducto(string nombre, double precio, int indice)
        {
            if (indice >= 0 && indice < tamañoMaximo)
            {
                productos[indice] = new ProductoParaMascota(nombre, precio);
            }
            else
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void EliminarProducto(int Id)
        {
            if (Id >= 0 && Id < tamañoMaximo)
            {
                productos[Id] = null;
            }
            else
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ListarProductos(DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();
            for (int i = 0; i < tamañoMaximo; i++)
            {
                var producto = productos[i];
                if (producto != null)
                {
                    dataGridView.Rows.Add(i, producto.Nombre, producto.Precio);
                }
                else
                {
                    dataGridView.Rows.Add(i, "(vacío)", "(vacío)");
                }
            }
        }
    }
}



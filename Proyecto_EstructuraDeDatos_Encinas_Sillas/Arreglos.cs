using Proyecto_EstructuraDeDatos_Encinas_Sillas.Formularios;
using Proyecto_EstructuraDeDatos_Encinas_Sillas.Formularios.NewFolder;
using Proyecto_EstructuraDeDatos_Encinas_Sillas.LogicaDeArreglos;
using Proyecto_EstructuraDeDatos_Encinas_Sillas.LogicaDeColas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_EstructuraDeDatos_Encinas_Sillas
{
    public partial class Arreglos : Form
    {
        public ManejadorArreglos arreglo1;

        public Arreglos()
        {
            InitializeComponent();
            InicializarArreglo();
            gridContendor.Columns.Add("Id", "Id");
            gridContendor.Columns.Add("Nombre", "Nombre");
            gridContendor.Columns.Add("Precio", "Precio");
            Reload();

            Console.WriteLine($"Longitud de arreglo1: {arreglo1.tamañoMaximo}");
        }
        private void InicializarArreglo()
        {
            using (var longitudForm = new LongitudParaArreglo())
            {
                if (longitudForm.ShowDialog() == DialogResult.OK)
                {
                    arreglo1 = new ManejadorArreglos(longitudForm.Longitud1);
                }
                else
                {
                    Close();
                }
            }
        }

        private void MenuPrincipal_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            this.Hide();
            menu.Show();
        }

        private void CerrarApp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Agregar_Click(object sender, EventArgs e)
        {
            FormularioArreglo formulario = new FormularioArreglo();

            DialogResult resultado = formulario.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                string nombre = formulario.Nombre;
                double precio = formulario.Precio;

                arreglo1.AgregarProducto(nombre, precio);

                Reload();
            }
        }



        public void Modificar_Click(object sender, EventArgs e)
        {
            int indiceSeleccionado = gridContendor.SelectedCells[0].RowIndex;

            if (indiceSeleccionado >= 0 && indiceSeleccionado < arreglo1.tamañoMaximo)
            {
                FormularioArreglo formulario = new FormularioArreglo();
                formulario.Nombre = arreglo1.Productos[indiceSeleccionado]?.Nombre;
                formulario.Precio = arreglo1.Productos[indiceSeleccionado]?.Precio ?? 0;

                DialogResult resultado = formulario.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    string nuevoNombre = formulario.Nombre;
                    double nuevoPrecio = formulario.Precio;

                    arreglo1.ModificarProducto(nuevoNombre, nuevoPrecio, indiceSeleccionado);

                    Reload();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un producto para modificar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Contenedor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void Eliminar_Click(object sender, EventArgs e)
        {
            int indiceSeleccionado = gridContendor.SelectedCells[0].RowIndex;

            if (indiceSeleccionado >= 0 && indiceSeleccionado < arreglo1.tamañoMaximo)
            {
                arreglo1.EliminarProducto(indiceSeleccionado);

                Reload();
            }
            else
            {
                MessageBox.Show("Seleccione un producto para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void Reload()
        {
            arreglo1.ListarProductos(gridContendor);
        }

        private void OrdenarAscendente_Click(object sender, EventArgs e)
        {
            if (arreglo1 != null)
            {
                arreglo1.OrdenarPorPrecioAscendente();

                arreglo1.ListarProductos(gridContendor); 
            }
            else
            {
                MessageBox.Show("Error: No se encontró la instancia de ManejadorArreglos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OrdenarDescendente_Click(object sender, EventArgs e)
        {
            if (arreglo1 != null)
            {
                arreglo1.OrdenarPorPrecioDescendente();

                arreglo1.ListarProductos(gridContendor); 
            }
            else
            {
                MessageBox.Show("Error: No se encontró la instancia de ManejadorArreglos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

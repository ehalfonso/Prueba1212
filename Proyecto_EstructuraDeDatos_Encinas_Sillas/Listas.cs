using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_EstructuraDeDatos_Encinas_Sillas.Formularios;
using Proyecto_EstructuraDeDatos_Encinas_Sillas.LogicaDeListas;

namespace Proyecto_EstructuraDeDatos_Encinas_Sillas
{
    public partial class Listas : Form
    {
        ListaDeAlimento lista = new ListaDeAlimento();
        public Listas()
        {
            InitializeComponent();
        }

        private void CerrarApp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MenuPrincipal_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            this.Hide();
            menu.Show();
        }

        private void Modificar_Click(object sender, EventArgs e)
        {
            if (lista.ListaVacia())
            {
                MessageBox.Show("La Lista Se Encuentra Vacía!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

            }
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            if (lista.ListaVacia())
            {
                MessageBox.Show("La Lista Se Encuentra Vacía!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                lista.EliminarAlimento();
                RefrescarLista();
                MessageBox.Show("Ultimo Elemento En Lista Eliminado", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void OrdenarAscendente_Click(object sender, EventArgs e)
        {
            if (lista.ListaVacia())
            {
                MessageBox.Show("La Lista Se Encuentra Vacía!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                lista.OrdenarAsecendente();
                RefrescarLista();
                MessageBox.Show("Lista re-organizada", "List", MessageBoxButtons.OK);
            }
        }

        private void OrdenarDescendente_Click(object sender, EventArgs e)
        {
            if (lista.ListaVacia())
            {
                MessageBox.Show("La Lista Se Encuentra Vacía!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                
            }
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            FormularioListas formulario = new FormularioListas();
            DialogResult resultado = formulario.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                lista.IngresarAlimento(formulario.AgregarAlimento());
                formulario.Close();
                RefrescarLista();
            }
            else
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void RefrescarLista()
        {
            Contenedor.Clear();
            int cantidad = lista.ContadorDatosEnLista();
            AlimentoParaMascotas[] arreglo = lista.Listar();
            for (int i = 0; i < cantidad; i++)
            {
                Contenedor.Items.Add(Convert.ToString(arreglo[i].NombreAlimento));
                Contenedor.Items.Add(Convert.ToString(arreglo[i].RazaMascota));
                Contenedor.Items.Add(Convert.ToString(arreglo[i].Precio));
                Contenedor.Items.Add(arreglo[i].Existencia == true ? "Con Existencia" : "Sin Existencia");
            }
        }
    }
}

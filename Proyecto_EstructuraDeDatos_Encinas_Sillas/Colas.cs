using Proyecto_EstructuraDeDatos_Encinas_Sillas.Formularios;
using Proyecto_EstructuraDeDatos_Encinas_Sillas.LogicaDeColas;
using Proyecto_EstructuraDeDatos_Encinas_Sillas.LogicaDeListas;
using System;
using System.Collections;
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
    public partial class Colas : Form
    {
        ColaDeEspera cola = new ColaDeEspera();
        public Colas()
        {
            InitializeComponent();
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

        private void Agregar_Click(object sender, EventArgs e)
        {
            FormularioColas formulario = new FormularioColas();
            DialogResult resultado = formulario.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                cola.IngresarEnCola(formulario.AgregarEnCola());
                formulario.Close();
                Reload();
            }
            else
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Reload()
        {
            Contenedor.Clear();
            int cantidad = cola.MascotasEnCola();
            MascotasEnEspera[] arreglo = cola.Listar();
            for (int i = 0; i < cantidad; i++)
            {
                Contenedor.Items.Add(Convert.ToString(arreglo[i].Nombre));
                Contenedor.Items.Add(Convert.ToString(arreglo[i].Raza));
                Contenedor.Items.Add(Convert.ToString(arreglo[i].Encargo));
            }
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            if (cola.ColaVacia())
            {
                MessageBox.Show("La Cola Se Encuentra Vacía!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MascotasEnEspera mascotaLiberada = cola.Pop();
                MessageBox.Show($"Raza: {mascotaLiberada.Raza}, Nombre: {mascotaLiberada.Nombre} Liberado","Eliminado De Cola",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                Reload();
            }
        }
    }
}

using Proyecto_EstructuraDeDatos_Encinas_Sillas.Formularios;
using Proyecto_EstructuraDeDatos_Encinas_Sillas.LogicaDePilas;
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
    public partial class Pilas : Form
    {
        public RegistroAtencion registroAtencion;
        public Pilas()
        {
            InitializeComponent();
            registroAtencion = new RegistroAtencion();
            InicializarDataGridView();
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
            registroAtencion.AgregarMascota("Nombre", DateTime.Now, DateTime.Now, "Notas");
            ActualizarDataGridView();

        }

        private void Modificar_Click(object sender, EventArgs e)
        {
            if (gridContenedor.SelectedRows.Count > 0)
            {
                // Obtener la posición de la fila seleccionada
                int index = gridContenedor.SelectedRows[0].Index;

                // Mostrar el formulario de modificación con los datos de la fila seleccionada
                MostrarFormularioModificacion(index);
            }
            else
            {
                MessageBox.Show("Seleccione una mascota para modificar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            registroAtencion.EliminarMascota();
            ActualizarDataGridView();

        }
        private void MostrarFormularioModificacion(int index)
        {
            FormularioDePila formularioModificacion = new FormularioDePila();

            RegistroMascota mascotaSeleccionada = registroAtencion.ObtenerMascotasAtendidas()[index];

            formularioModificacion.Nombre = mascotaSeleccionada.Nombre;
            formularioModificacion.HoraLlegada = mascotaSeleccionada.HoraLlegada;
            formularioModificacion.HoraAtencion = mascotaSeleccionada.HoraAtencion;
            formularioModificacion.Notas = mascotaSeleccionada.Notas;

            DialogResult resultado = formularioModificacion.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                registroAtencion.ModificarMascota(index, formularioModificacion.Nombre, formularioModificacion.HoraLlegada, formularioModificacion.HoraAtencion, formularioModificacion.Notas);

                ActualizarDataGridView();
            }
        }
        private void InicializarDataGridView()
        {
            gridContenedor.ColumnCount = 4;
            gridContenedor.Columns[0].Name = "Nombre";
            gridContenedor.Columns[1].Name = "HoraLlegada";
            gridContenedor.Columns[2].Name = "HoraAtencion";
            gridContenedor.Columns[3].Name = "Notas";
        }
        private void ActualizarDataGridView()
        {
            gridContenedor.Rows.Clear();

            var mascotas = registroAtencion.ObtenerMascotasAtendidas();
            foreach (var mascota in mascotas)
            {
                gridContenedor.Rows.Add(mascota.Nombre, mascota.HoraLlegada, mascota.HoraAtencion, mascota.Notas);
            }
        }

        //public void ModificarMascota(int index, string nombre, DateTime horaLlegada, DateTime horaAtencion, string notas)
        //{
        //    if (index >= 0 && index < pilaMascotas.Count)
        //    {
        //        // Modificar la mascota en la posición especificada
        //        RegistroMascota mascotaActual = pilaMascotas.ElementAt(index);
        //        mascotaActual.Nombre = nombre;
        //        mascotaActual.HoraLlegada = horaLlegada;
        //        mascotaActual.HoraAtencion = horaAtencion;
        //        mascotaActual.Notas = notas;
        //    }
        //}

        //public void EliminarMascota(int index)
        //{
        //    if (index >= 0 && index < pilaMascotas.Count)
        //    {
        //        // Eliminar la mascota en la posición especificada
        //        pilaMascotas.ElementAt(index);
        //    }
        //}


    }
}

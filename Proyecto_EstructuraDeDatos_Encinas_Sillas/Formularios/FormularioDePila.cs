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

namespace Proyecto_EstructuraDeDatos_Encinas_Sillas.Formularios
{

    public partial class FormularioDePila : Form
    {
        private RegistroAtencion registroAtencion;
        public string Nombre { get; set; }
        public DateTime HoraLlegada { get; set; }
        public DateTime HoraAtencion { get; set; }
        public string Notas { get; set; }

        
        private int indice = -1; 

        public FormularioDePila()
        {
            InitializeComponent();
            registroAtencion = new RegistroAtencion();
            InicializarDataGridView();
        }
        private void InicializarDataGridView()
        {
           
        }
        private void ActualizarDataGridView()
        {
            
        }
        private void txtBoxNombre_TextChanged(object sender, EventArgs e)
        {
            txtBoxNombre.Focus();
        }

        private void txtBoxRaza_TextChanged(object sender, EventArgs e)
        {
            txtBoxRaza.Focus();
        }

        private void txtBoxPendiente_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Confirmar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBoxNombre.Text))
            {
                string nombre = txtBoxNombre.Text;
                DateTime horaLlegada = DateTime.Now;
                DateTime horaAtencion = DateTime.Now;
                string notas = txtBoxPendiente.Text;

                registroAtencion.AgregarMascota(nombre, horaLlegada, horaAtencion, notas);

                ActualizarDataGridView();

                MessageBox.Show("Mascota registrada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos(); 
            }
            else
            {
                MessageBox.Show("Ingrese un nombre válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            var evento = MessageBox.Show("¿Está seguro que desea cancelar el agregado?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (evento == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void LimpiarCampos()
        {
            txtBoxNombre.Text = string.Empty;
            txtBoxPendiente.Text = string.Empty;
        }


    }
}

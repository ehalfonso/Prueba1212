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

namespace Proyecto_EstructuraDeDatos_Encinas_Sillas.Formularios
{
    public partial class FormularioColas : Form
    {
        MascotasEnEspera mascota = new MascotasEnEspera();
        public FormularioColas()
        {
            InitializeComponent();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            var evento = MessageBox.Show("¿Esta seguro que desea cancelar el agregado?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (evento == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Titulo_Click(object sender, EventArgs e)
        {
            txtBoxNombre.Focus();
        }

        private void NombreMascota_Click(object sender, EventArgs e)
        {
            txtBoxNombre.Focus();
        }

        private void Raza_Click(object sender, EventArgs e)
        {
            txtBoxRaza.Focus();
        }

        private void Encargo_Click(object sender, EventArgs e)
        {
            txtBoxPendiente.Focus();
        }

        private void Confirmar_Click(object sender, EventArgs e)
        {
            if (txtBoxNombre.Text == string.Empty || txtBoxPendiente.Text == string.Empty || txtBoxRaza.Text == string.Empty)
            {
                MessageBox.Show("Necesitas Ingresar todos los datos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    mascota.Nombre = txtBoxNombre.Text;
                    mascota.Raza = txtBoxRaza.Text;
                    mascota.Encargo = txtBoxPendiente.Text;
                    this.DialogResult = DialogResult.OK;
                }
                catch
                {
                    MessageBox.Show("", "Error De Dato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public MascotasEnEspera AgregarEnCola()
        {
            return mascota;
        }
    }
}

using Proyecto_EstructuraDeDatos_Encinas_Sillas.LogicaDeListas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_EstructuraDeDatos_Encinas_Sillas.Formularios
{
    public partial class FormularioListas : Form
    {
        AlimentoParaMascotas Alimento = new AlimentoParaMascotas();
        public FormularioListas()
        {
            InitializeComponent();
        }

        private void Titulo_Click(object sender, EventArgs e)
        {
            txtBoxTipoMascota.Focus();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            var evento = MessageBox.Show("¿Esta seguro que desea cancelar el agregado?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (evento == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void RazaDeMascota_Click(object sender, EventArgs e)
        {
            txtBoxTipoMascota.Focus();
        }

        private void NombreAlimento_Click(object sender, EventArgs e)
        {
            txtBoxNombre.Focus();
        }

        private void PrecioAlimento_Click(object sender, EventArgs e)
        {
            txtBoxPrecio.Focus();
        }

        private void Existencia_Click(object sender, EventArgs e)
        {
            radioBtnSi.Select();
        }

        private void Confirmar_Click(object sender, EventArgs e)
        {
            if(txtBoxNombre.Text == string.Empty || txtBoxNombre.Text == string.Empty || txtBoxPrecio.Text == string.Empty)
            {
                MessageBox.Show("Necesitas Ingresar todos los datos", "Advertencia", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else 
            {
                try
                {
                    double validacionPrecio = double.Parse(txtBoxPrecio.Text);
                    if (radioBtnSi.Checked)
                    {
                        Alimento.Existencia = true;
                        Alimento.Precio = validacionPrecio;
                        Alimento.NombreAlimento = txtBoxNombre.Text;
                        Alimento.RazaMascota = txtBoxTipoMascota.Text;
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        Alimento.Existencia = false;
                        Alimento.Precio = validacionPrecio;
                        Alimento.NombreAlimento = txtBoxNombre.Text;
                        Alimento.RazaMascota = txtBoxTipoMascota.Text;
                        this.DialogResult = DialogResult.OK;
                    }
                }
                catch
                {
                    MessageBox.Show("Solo se aceptan datos númericos en el precio", "Error De Dato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public AlimentoParaMascotas AgregarAlimento()
        {
            return Alimento;
        }
    }
}

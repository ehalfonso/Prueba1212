using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_EstructuraDeDatos_Encinas_Sillas.Formularios.NewFolder
{
    public partial class LongitudParaArreglo : Form
    {
        public int Longitud1 { get; private set; }
        public LongitudParaArreglo()
        {
            InitializeComponent();
        }

        private void txtBoxNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void Confirmar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtBoxNombre.Text, out int longitud))
            {
                Longitud1 = longitud;
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese una longitud válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

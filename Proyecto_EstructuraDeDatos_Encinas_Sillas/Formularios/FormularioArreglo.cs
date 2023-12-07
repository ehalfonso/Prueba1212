﻿using Proyecto_EstructuraDeDatos_Encinas_Sillas.LogicaDeArreglos;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Proyecto_EstructuraDeDatos_Encinas_Sillas.Formularios
{
    public partial class FormularioArreglo : Form
    {
        private ManejadorArreglos manejadorProductos = new ManejadorArreglos(5);
        public string Nombre { get; set; }
        public double Precio { get; set; }

        public FormularioArreglo()
        {
            InitializeComponent();
        }


        private void Cancelar_Click(object sender, EventArgs e)
        {
            var evento = MessageBox.Show("¿Estás seguro que desea cancelar el agregado?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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

        private void Precio_Click(object sender, EventArgs e)
        {
            txtBoxPrecio.Focus();
        }

        private void Confirmar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBoxNombre.Text) && double.TryParse(txtBoxPrecio.Text, out double precio))
            {
                Nombre = txtBoxNombre.Text;
                Precio = precio;

                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Ingrese un nombre válido y un precio numérico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Cancelar_Click_1(object sender, EventArgs e)
        {

        }

        private void txtBoxNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void Confirmar_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBoxNombre.Text) && double.TryParse(txtBoxPrecio.Text, out double precio))
            {
                Nombre = txtBoxNombre.Text;
                Precio = precio;

                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Ingrese un nombre válido y un precio numérico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
}

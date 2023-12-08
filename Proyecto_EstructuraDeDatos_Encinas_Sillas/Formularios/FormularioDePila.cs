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

        private string nombreActual;
        private string notasActual;

        public int indice = -1;

       

        public string ObtenerNombre()
        {
            return Nombre.Text;
        }

        public string ObtenerNotas()
        {
            return txtBoxNota.Text;
        }


        public FormularioDePila(RegistroAtencion registro)
        {
            InitializeComponent();
            registroAtencion = registro;
            InicializarDataGridView();
        }
        public FormularioDePila(RegistroAtencion registro, string nombreActual, string notasActual) : this(registro)
        {
            InitializeComponent();

            this.nombreActual = nombreActual;
            this.notasActual = notasActual;

            Nombre.Text = nombreActual;
            txtBoxNota.Text = notasActual;
        }

        private void InicializarDataGridView()
        {
        }

        private void Confirmar_Click(object sender, EventArgs e)
        {


            nombreActual = ObtenerNombre();
            notasActual = ObtenerNotas();

            DialogResult = DialogResult.OK;
            Close();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            var evento = MessageBox.Show("¿Esta seguro que desea cancelar el agregado?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (evento == DialogResult.Yes)
            {
                this.Close();
            }
        }

        

    }
}

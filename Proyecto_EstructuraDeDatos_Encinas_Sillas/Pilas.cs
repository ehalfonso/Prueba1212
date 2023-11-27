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
        public Pilas()
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
    }
}

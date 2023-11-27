namespace Proyecto_EstructuraDeDatos_Encinas_Sillas
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Arreglos_Click(object sender, EventArgs e)
        {
            Arreglos menu = new Arreglos();
            this.Hide();
            menu.Show();
        }

        private void Listas_Click(object sender, EventArgs e)
        {
            Listas menu = new Listas();
            this.Hide();
            menu.Show();
        }

        private void Pilas_Click(object sender, EventArgs e)
        {
            Pilas menu = new Pilas();
            this.Hide();
            menu.Show();
        }

        private void Colas_Click(object sender, EventArgs e)
        {
            Colas menu = new Colas();
            this.Hide();
            menu.Show();
        }
    }
}
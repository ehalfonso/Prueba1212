namespace Proyecto_EstructuraDeDatos_Encinas_Sillas
{
    partial class Listas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Listas));
            panel1 = new Panel();
            MenuPrincipal = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            CerrarApp = new Button();
            Agregar = new Button();
            Modificar = new Button();
            OrdenarAscendente = new Button();
            OrdenarDescendente = new Button();
            Eliminar = new Button();
            Titulo = new Label();
            Contenedor = new ListView();
            Nombre = new ColumnHeader();
            RazaDeMascota = new ColumnHeader();
            Precio = new ColumnHeader();
            Existencia = new ColumnHeader();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Controls.Add(MenuPrincipal);
            panel1.Location = new Point(23, 291);
            panel1.Name = "panel1";
            panel1.Size = new Size(244, 147);
            panel1.TabIndex = 0;
            // 
            // MenuPrincipal
            // 
            MenuPrincipal.BackColor = Color.FromArgb(52, 73, 94);
            MenuPrincipal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            MenuPrincipal.ForeColor = SystemColors.ControlLightLight;
            MenuPrincipal.Location = new Point(77, 71);
            MenuPrincipal.Name = "MenuPrincipal";
            MenuPrincipal.Size = new Size(95, 60);
            MenuPrincipal.TabIndex = 8;
            MenuPrincipal.Text = "Menú Principal";
            MenuPrincipal.UseVisualStyleBackColor = false;
            MenuPrincipal.Click += MenuPrincipal_Click;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Zoom;
            panel2.Location = new Point(288, 291);
            panel2.Name = "panel2";
            panel2.Size = new Size(238, 147);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.BackgroundImageLayout = ImageLayout.Zoom;
            panel3.Controls.Add(CerrarApp);
            panel3.Location = new Point(552, 291);
            panel3.Name = "panel3";
            panel3.Size = new Size(219, 147);
            panel3.TabIndex = 2;
            // 
            // CerrarApp
            // 
            CerrarApp.BackColor = Color.FromArgb(52, 73, 94);
            CerrarApp.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            CerrarApp.ForeColor = SystemColors.ControlLightLight;
            CerrarApp.Location = new Point(65, 71);
            CerrarApp.Name = "CerrarApp";
            CerrarApp.Size = new Size(95, 60);
            CerrarApp.TabIndex = 9;
            CerrarApp.Text = "Cerrar App";
            CerrarApp.UseVisualStyleBackColor = false;
            CerrarApp.Click += CerrarApp_Click;
            // 
            // Agregar
            // 
            Agregar.BackColor = Color.FromArgb(46, 204, 113);
            Agregar.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Agregar.ForeColor = SystemColors.ControlLightLight;
            Agregar.Location = new Point(123, 65);
            Agregar.Name = "Agregar";
            Agregar.Size = new Size(133, 52);
            Agregar.TabIndex = 3;
            Agregar.Text = "Agregar";
            Agregar.UseVisualStyleBackColor = false;
            Agregar.Click += Agregar_Click;
            // 
            // Modificar
            // 
            Modificar.BackColor = Color.FromArgb(52, 152, 219);
            Modificar.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Modificar.ForeColor = SystemColors.ControlLightLight;
            Modificar.Location = new Point(12, 136);
            Modificar.Name = "Modificar";
            Modificar.Size = new Size(133, 52);
            Modificar.TabIndex = 4;
            Modificar.Text = "Modificar";
            Modificar.UseVisualStyleBackColor = false;
            Modificar.Click += Modificar_Click;
            // 
            // OrdenarAscendente
            // 
            OrdenarAscendente.BackColor = Color.Gold;
            OrdenarAscendente.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            OrdenarAscendente.ForeColor = SystemColors.ControlLightLight;
            OrdenarAscendente.Location = new Point(228, 136);
            OrdenarAscendente.Name = "OrdenarAscendente";
            OrdenarAscendente.Size = new Size(133, 52);
            OrdenarAscendente.TabIndex = 5;
            OrdenarAscendente.Text = "Ordenar Ascendente";
            OrdenarAscendente.UseVisualStyleBackColor = false;
            OrdenarAscendente.Click += OrdenarAscendente_Click;
            // 
            // OrdenarDescendente
            // 
            OrdenarDescendente.BackColor = Color.Gold;
            OrdenarDescendente.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            OrdenarDescendente.ForeColor = SystemColors.ControlLightLight;
            OrdenarDescendente.Location = new Point(228, 205);
            OrdenarDescendente.Name = "OrdenarDescendente";
            OrdenarDescendente.Size = new Size(133, 52);
            OrdenarDescendente.TabIndex = 6;
            OrdenarDescendente.Text = "Ordenar Descendente";
            OrdenarDescendente.UseVisualStyleBackColor = false;
            OrdenarDescendente.Click += OrdenarDescendente_Click;
            // 
            // Eliminar
            // 
            Eliminar.BackColor = Color.FromArgb(217, 83, 79);
            Eliminar.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Eliminar.ForeColor = SystemColors.ControlLightLight;
            Eliminar.Location = new Point(12, 205);
            Eliminar.Name = "Eliminar";
            Eliminar.Size = new Size(133, 52);
            Eliminar.TabIndex = 7;
            Eliminar.Text = "Eliminar";
            Eliminar.UseVisualStyleBackColor = false;
            Eliminar.Click += Eliminar_Click;
            // 
            // Titulo
            // 
            Titulo.AutoSize = true;
            Titulo.Font = new Font("Segoe UI Black", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Titulo.ForeColor = SystemColors.ControlLightLight;
            Titulo.Location = new Point(346, 9);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(120, 47);
            Titulo.TabIndex = 8;
            Titulo.Text = "Listas";
            // 
            // Contenedor
            // 
            Contenedor.Columns.AddRange(new ColumnHeader[] { Nombre, RazaDeMascota, Precio, Existencia });
            Contenedor.Location = new Point(509, 65);
            Contenedor.Name = "Contenedor";
            Contenedor.Size = new Size(262, 220);
            Contenedor.TabIndex = 9;
            Contenedor.UseCompatibleStateImageBehavior = false;
            // 
            // Listas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(52, 73, 94);
            ClientSize = new Size(800, 450);
            Controls.Add(Contenedor);
            Controls.Add(Titulo);
            Controls.Add(Eliminar);
            Controls.Add(OrdenarDescendente);
            Controls.Add(OrdenarAscendente);
            Controls.Add(Modificar);
            Controls.Add(Agregar);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Listas";
            Text = "Listas";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button Agregar;
        private Button Modificar;
        private Button OrdenarAscendente;
        private Button OrdenarDescendente;
        private Button Eliminar;
        private Button MenuPrincipal;
        private Button CerrarApp;
        private Label Titulo;
        private ListView Contenedor;
        private ColumnHeader Nombre;
        private ColumnHeader RazaDeMascota;
        private ColumnHeader Precio;
        private ColumnHeader Existencia;
    }
}
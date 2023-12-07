namespace Proyecto_EstructuraDeDatos_Encinas_Sillas.Formularios
{
    partial class FormularioDePila
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioDePila));
            txtBoxPendiente = new TextBox();
            txtBoxRaza = new TextBox();
            txtBoxNombre = new TextBox();
            Encargo = new Label();
            Raza = new Label();
            Titulo = new Label();
            NombreMascota = new Label();
            panel2 = new Panel();
            Cancelar = new Button();
            panel1 = new Panel();
            Confirmar = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtBoxPendiente
            // 
            txtBoxPendiente.Location = new Point(137, 121);
            txtBoxPendiente.Name = "txtBoxPendiente";
            txtBoxPendiente.PlaceholderText = "Pendiente Con La Mascota";
            txtBoxPendiente.Size = new Size(149, 23);
            txtBoxPendiente.TabIndex = 35;
            txtBoxPendiente.TextChanged += txtBoxPendiente_TextChanged;
            // 
            // txtBoxRaza
            // 
            txtBoxRaza.Location = new Point(137, 92);
            txtBoxRaza.Name = "txtBoxRaza";
            txtBoxRaza.PlaceholderText = "Raza De La Mascota";
            txtBoxRaza.Size = new Size(149, 23);
            txtBoxRaza.TabIndex = 34;
            txtBoxRaza.TextChanged += txtBoxRaza_TextChanged;
            // 
            // txtBoxNombre
            // 
            txtBoxNombre.Location = new Point(137, 63);
            txtBoxNombre.Name = "txtBoxNombre";
            txtBoxNombre.PlaceholderText = "Nombre De La Mascota";
            txtBoxNombre.Size = new Size(149, 23);
            txtBoxNombre.TabIndex = 33;
            txtBoxNombre.TextChanged += txtBoxNombre_TextChanged;
            // 
            // Encargo
            // 
            Encargo.AutoSize = true;
            Encargo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Encargo.ForeColor = SystemColors.ControlLightLight;
            Encargo.Location = new Point(19, 127);
            Encargo.Name = "Encargo";
            Encargo.Size = new Size(118, 17);
            Encargo.TabIndex = 32;
            Encargo.Text = "Hora De Atencion";
            // 
            // Raza
            // 
            Raza.AutoSize = true;
            Raza.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Raza.ForeColor = SystemColors.ControlLightLight;
            Raza.Location = new Point(19, 98);
            Raza.Name = "Raza";
            Raza.Size = new Size(111, 17);
            Raza.TabIndex = 31;
            Raza.Text = "Hora De Llegada";
            // 
            // Titulo
            // 
            Titulo.AutoSize = true;
            Titulo.BackColor = SystemColors.ActiveCaption;
            Titulo.Cursor = Cursors.Hand;
            Titulo.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Titulo.ForeColor = SystemColors.ControlLightLight;
            Titulo.Location = new Point(37, 9);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(228, 40);
            Titulo.TabIndex = 29;
            Titulo.Text = "Agregar En Pila";
            // 
            // NombreMascota
            // 
            NombreMascota.AutoSize = true;
            NombreMascota.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            NombreMascota.ForeColor = SystemColors.ControlLightLight;
            NombreMascota.Location = new Point(19, 69);
            NombreMascota.Name = "NombreMascota";
            NombreMascota.Size = new Size(62, 17);
            NombreMascota.TabIndex = 30;
            NombreMascota.Text = "Nombre:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Zoom;
            panel2.Controls.Add(Cancelar);
            panel2.Location = new Point(12, 254);
            panel2.Name = "panel2";
            panel2.Size = new Size(107, 100);
            panel2.TabIndex = 28;
            // 
            // Cancelar
            // 
            Cancelar.BackColor = Color.Red;
            Cancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Cancelar.ForeColor = SystemColors.ControlLightLight;
            Cancelar.Location = new Point(3, 52);
            Cancelar.Name = "Cancelar";
            Cancelar.Size = new Size(95, 34);
            Cancelar.TabIndex = 4;
            Cancelar.Text = "Cancelar";
            Cancelar.UseVisualStyleBackColor = false;
            Cancelar.Click += Cancelar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Controls.Add(Confirmar);
            panel1.Location = new Point(170, 253);
            panel1.Name = "panel1";
            panel1.Size = new Size(110, 101);
            panel1.TabIndex = 27;
            // 
            // Confirmar
            // 
            Confirmar.BackColor = Color.Orange;
            Confirmar.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Confirmar.ForeColor = SystemColors.ControlLightLight;
            Confirmar.Location = new Point(8, 52);
            Confirmar.Name = "Confirmar";
            Confirmar.Size = new Size(95, 34);
            Confirmar.TabIndex = 3;
            Confirmar.Text = "Confirmar";
            Confirmar.UseVisualStyleBackColor = false;
            Confirmar.Click += Confirmar_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(137, 154);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Pendiente Con La Mascota";
            textBox1.Size = new Size(149, 23);
            textBox1.TabIndex = 37;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(19, 160);
            label1.Name = "label1";
            label1.Size = new Size(38, 17);
            label1.TabIndex = 36;
            label1.Text = "Nota";
            // 
            // FormularioDePila
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(292, 366);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(txtBoxPendiente);
            Controls.Add(txtBoxRaza);
            Controls.Add(txtBoxNombre);
            Controls.Add(Encargo);
            Controls.Add(Raza);
            Controls.Add(Titulo);
            Controls.Add(NombreMascota);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormularioDePila";
            Text = "FormularioDePila";
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBoxPendiente;
        private TextBox txtBoxRaza;
        private TextBox txtBoxNombre;
        private Label Encargo;
        private Label Raza;
        private Label Titulo;
        private Label NombreMascota;
        private Panel panel2;
        private Button Cancelar;
        private Panel panel1;
        private Button Confirmar;
        private TextBox textBox1;
        private Label label1;
    }
}
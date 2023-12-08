namespace Proyecto_EstructuraDeDatos_Encinas_Sillas.Formularios
{
    partial class FormularioArreglo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioArreglo));
            Titulo = new Label();
            NombreAlimento = new Label();
            txtBoxPrecio = new TextBox();
            PrecioAlimento = new Label();
            txtBoxNombre = new TextBox();
            panel2 = new Panel();
            Cancelar = new Button();
            panel1 = new Panel();
            Confirmar = new Button();
            InsertarAlFinal = new Button();
            InsertarEnMedio = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Titulo
            // 
            Titulo.AutoSize = true;
            Titulo.Cursor = Cursors.Hand;
            Titulo.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Titulo.ForeColor = SystemColors.ControlLightLight;
            Titulo.Location = new Point(12, 9);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(257, 40);
            Titulo.TabIndex = 3;
            Titulo.Text = "Agregar Producto";
            // 
            // NombreAlimento
            // 
            NombreAlimento.AutoSize = true;
            NombreAlimento.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            NombreAlimento.ForeColor = SystemColors.ControlLightLight;
            NombreAlimento.Location = new Point(0, 65);
            NombreAlimento.Name = "NombreAlimento";
            NombreAlimento.Size = new Size(141, 17);
            NombreAlimento.TabIndex = 17;
            NombreAlimento.Text = "Nombre de Producto:";
            // 
            // txtBoxPrecio
            // 
            txtBoxPrecio.Location = new Point(134, 105);
            txtBoxPrecio.Name = "txtBoxPrecio";
            txtBoxPrecio.PlaceholderText = "Precio De Producto";
            txtBoxPrecio.Size = new Size(149, 23);
            txtBoxPrecio.TabIndex = 24;
            txtBoxPrecio.TextChanged += txtBoxPrecio_TextChanged;
            // 
            // PrecioAlimento
            // 
            PrecioAlimento.AutoSize = true;
            PrecioAlimento.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            PrecioAlimento.ForeColor = SystemColors.ControlLightLight;
            PrecioAlimento.Location = new Point(15, 111);
            PrecioAlimento.Name = "PrecioAlimento";
            PrecioAlimento.Size = new Size(50, 17);
            PrecioAlimento.TabIndex = 18;
            PrecioAlimento.Text = "Precio:";
            // 
            // txtBoxNombre
            // 
            txtBoxNombre.Location = new Point(147, 59);
            txtBoxNombre.Name = "txtBoxNombre";
            txtBoxNombre.PlaceholderText = "Nombre De Producto";
            txtBoxNombre.Size = new Size(122, 23);
            txtBoxNombre.TabIndex = 23;
            txtBoxNombre.TextChanged += txtBoxNombre_TextChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Zoom;
            panel2.Controls.Add(Cancelar);
            panel2.Location = new Point(12, 191);
            panel2.Name = "panel2";
            panel2.Size = new Size(107, 100);
            panel2.TabIndex = 26;
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
            Cancelar.Click += Cancelar_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Controls.Add(Confirmar);
            panel1.Location = new Point(177, 190);
            panel1.Name = "panel1";
            panel1.Size = new Size(110, 101);
            panel1.TabIndex = 25;
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
            Confirmar.Click += Confirmar_Click_1;
            // 
            // InsertarAlFinal
            // 
            InsertarAlFinal.BackColor = Color.Orange;
            InsertarAlFinal.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            InsertarAlFinal.ForeColor = SystemColors.ControlLightLight;
            InsertarAlFinal.Location = new Point(365, 242);
            InsertarAlFinal.Name = "InsertarAlFinal";
            InsertarAlFinal.Size = new Size(133, 35);
            InsertarAlFinal.TabIndex = 4;
            InsertarAlFinal.Text = "Insertar Al final";
            InsertarAlFinal.UseVisualStyleBackColor = false;
            InsertarAlFinal.Click += InsertarAlFinal_Click;
            // 
            // InsertarEnMedio
            // 
            InsertarEnMedio.BackColor = Color.Orange;
            InsertarEnMedio.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            InsertarEnMedio.ForeColor = SystemColors.ControlLightLight;
            InsertarEnMedio.Location = new Point(532, 242);
            InsertarEnMedio.Name = "InsertarEnMedio";
            InsertarEnMedio.Size = new Size(190, 34);
            InsertarEnMedio.TabIndex = 27;
            InsertarEnMedio.Text = "Insertar En el Medio";
            InsertarEnMedio.UseVisualStyleBackColor = false;
            InsertarEnMedio.Click += InsertarEnMedio_Click;
            // 
            // FormularioArreglo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(847, 319);
            Controls.Add(InsertarEnMedio);
            Controls.Add(InsertarAlFinal);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(txtBoxPrecio);
            Controls.Add(txtBoxNombre);
            Controls.Add(PrecioAlimento);
            Controls.Add(NombreAlimento);
            Controls.Add(Titulo);
            Name = "FormularioArreglo";
            Text = "FormularioArreglo";
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Titulo;
        private Label NombreAlimento;
        private TextBox txtBoxPrecio;
        private Label PrecioAlimento;
        private TextBox txtBoxNombre;
        private Panel panel2;
        private Button Cancelar;
        private Panel panel1;
        private Button Confirmar;
        private Button InsertarAlFinal;
        private Button InsertarEnMedio;
    }
}
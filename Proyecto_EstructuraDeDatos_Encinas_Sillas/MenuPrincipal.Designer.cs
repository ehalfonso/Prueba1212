namespace Proyecto_EstructuraDeDatos_Encinas_Sillas
{
    partial class MenuPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            label1 = new Label();
            panel1 = new Panel();
            Pilas = new Button();
            Colas = new Button();
            Arreglos = new Button();
            Listas = new Button();
            Salir = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 30F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(187, 20);
            label1.Name = "label1";
            label1.Size = new Size(414, 54);
            label1.TabIndex = 0;
            label1.Text = "Estructura De Datos";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Location = new Point(239, 89);
            panel1.Name = "panel1";
            panel1.Size = new Size(296, 290);
            panel1.TabIndex = 1;
            // 
            // Pilas
            // 
            Pilas.BackColor = Color.DarkSlateBlue;
            Pilas.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Pilas.ForeColor = SystemColors.ControlLightLight;
            Pilas.Location = new Point(563, 114);
            Pilas.Name = "Pilas";
            Pilas.Size = new Size(109, 48);
            Pilas.TabIndex = 2;
            Pilas.Text = "Pilas";
            Pilas.UseVisualStyleBackColor = false;
            Pilas.Click += Pilas_Click;
            // 
            // Colas
            // 
            Colas.BackColor = Color.DarkBlue;
            Colas.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Colas.ForeColor = SystemColors.ControlLightLight;
            Colas.Location = new Point(563, 295);
            Colas.Name = "Colas";
            Colas.Size = new Size(109, 47);
            Colas.TabIndex = 3;
            Colas.Text = "Colas";
            Colas.UseVisualStyleBackColor = false;
            Colas.Click += Colas_Click;
            // 
            // Arreglos
            // 
            Arreglos.BackColor = Color.Orange;
            Arreglos.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Arreglos.ForeColor = SystemColors.ControlLightLight;
            Arreglos.Location = new Point(98, 114);
            Arreglos.Name = "Arreglos";
            Arreglos.Size = new Size(109, 48);
            Arreglos.TabIndex = 4;
            Arreglos.Text = "Arreglos";
            Arreglos.UseVisualStyleBackColor = false;
            Arreglos.Click += Arreglos_Click;
            // 
            // Listas
            // 
            Listas.BackColor = Color.OliveDrab;
            Listas.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Listas.ForeColor = SystemColors.ControlLightLight;
            Listas.Location = new Point(98, 294);
            Listas.Name = "Listas";
            Listas.Size = new Size(109, 48);
            Listas.TabIndex = 5;
            Listas.Text = "Listas";
            Listas.UseVisualStyleBackColor = false;
            Listas.Click += Listas_Click;
            // 
            // Salir
            // 
            Salir.BackColor = Color.Red;
            Salir.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Salir.ForeColor = SystemColors.ControlLightLight;
            Salir.Location = new Point(326, 390);
            Salir.Name = "Salir";
            Salir.Size = new Size(109, 48);
            Salir.TabIndex = 6;
            Salir.Text = "Salir";
            Salir.UseVisualStyleBackColor = false;
            Salir.Click += Salir_Click;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(52, 73, 94);
            ClientSize = new Size(800, 450);
            Controls.Add(Salir);
            Controls.Add(Listas);
            Controls.Add(Arreglos);
            Controls.Add(Colas);
            Controls.Add(Pilas);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "MenuPrincipal";
            Text = "MenuPrincipal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Button Pilas;
        private Button Colas;
        private Button Arreglos;
        private Button Listas;
        private Button Salir;
    }
}
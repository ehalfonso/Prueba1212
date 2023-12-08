namespace Proyecto_EstructuraDeDatos_Encinas_Sillas.Formularios.NewFolder
{
    partial class LongitudParaArreglo
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
            txtBoxNombre = new TextBox();
            Confirmar = new Button();
            Longitud = new Label();
            SuspendLayout();
            // 
            // txtBoxNombre
            // 
            txtBoxNombre.Location = new Point(170, 63);
            txtBoxNombre.Name = "txtBoxNombre";
            txtBoxNombre.PlaceholderText = "Nombre De La Mascota";
            txtBoxNombre.Size = new Size(149, 23);
            txtBoxNombre.TabIndex = 25;
            txtBoxNombre.TextChanged += txtBoxNombre_TextChanged;
            // 
            // Confirmar
            // 
            Confirmar.BackColor = Color.Orange;
            Confirmar.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Confirmar.ForeColor = SystemColors.ControlLightLight;
            Confirmar.Location = new Point(202, 220);
            Confirmar.Name = "Confirmar";
            Confirmar.Size = new Size(95, 34);
            Confirmar.TabIndex = 26;
            Confirmar.Text = "Confirmar";
            Confirmar.UseVisualStyleBackColor = false;
            Confirmar.Click += Confirmar_Click;
            // 
            // Longitud
            // 
            Longitud.AutoSize = true;
            Longitud.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Longitud.ForeColor = SystemColors.ControlLightLight;
            Longitud.Location = new Point(12, 63);
            Longitud.Name = "Longitud";
            Longitud.Size = new Size(64, 17);
            Longitud.TabIndex = 27;
            Longitud.Text = "Longitud";
            // 
            // LongitudParaArreglo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(347, 296);
            Controls.Add(Longitud);
            Controls.Add(Confirmar);
            Controls.Add(txtBoxNombre);
            Name = "LongitudParaArreglo";
            Text = "LongitudParaArreglo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBoxNombre;
        private Button Confirmar;
        private Label Longitud;
    }
}
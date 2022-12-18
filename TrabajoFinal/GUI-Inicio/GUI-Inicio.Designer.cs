namespace TrabajoFinal
{
    partial class GUI_Inicio
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
            this.Buton_Restaurante = new System.Windows.Forms.Button();
            this.Button_Cliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Buton_Restaurante
            // 
            this.Buton_Restaurante.Location = new System.Drawing.Point(138, 22);
            this.Buton_Restaurante.Name = "Buton_Restaurante";
            this.Buton_Restaurante.Size = new System.Drawing.Size(91, 98);
            this.Buton_Restaurante.TabIndex = 1;
            this.Buton_Restaurante.Text = "Acceso empleados del restaurante";
            this.Buton_Restaurante.UseVisualStyleBackColor = true;
            this.Buton_Restaurante.Click += new System.EventHandler(this.Buton_Restaurante_Click);
            // 
            // Button_Cliente
            // 
            this.Button_Cliente.BackgroundImage = global::TrabajoFinal.Properties.Resources.QR2;
            this.Button_Cliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button_Cliente.Location = new System.Drawing.Point(12, 22);
            this.Button_Cliente.Name = "Button_Cliente";
            this.Button_Cliente.Size = new System.Drawing.Size(106, 98);
            this.Button_Cliente.TabIndex = 0;
            this.Button_Cliente.Text = "Cliente";
            this.Button_Cliente.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Button_Cliente.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Button_Cliente.UseVisualStyleBackColor = true;
            this.Button_Cliente.Click += new System.EventHandler(this.Button_Cliente_Click);
            // 
            // GUI_Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 141);
            this.Controls.Add(this.Buton_Restaurante);
            this.Controls.Add(this.Button_Cliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "GUI_Inicio";
            this.Text = "GUI_Inicio";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Button_Cliente;
        private System.Windows.Forms.Button Buton_Restaurante;
    }
}
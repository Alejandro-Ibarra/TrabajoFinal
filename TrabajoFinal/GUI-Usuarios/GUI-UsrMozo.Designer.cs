namespace TrabajoFinal
{
    partial class GUI_UsrMozo
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
            this.TextBox_Nombre = new System.Windows.Forms.TextBox();
            this.TextBox_Apellido = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TextBox_Nombre
            // 
            this.TextBox_Nombre.Location = new System.Drawing.Point(49, 13);
            this.TextBox_Nombre.Name = "TextBox_Nombre";
            this.TextBox_Nombre.Size = new System.Drawing.Size(100, 20);
            this.TextBox_Nombre.TabIndex = 0;
            // 
            // TextBox_Apellido
            // 
            this.TextBox_Apellido.Location = new System.Drawing.Point(207, 13);
            this.TextBox_Apellido.Name = "TextBox_Apellido";
            this.TextBox_Apellido.Size = new System.Drawing.Size(100, 20);
            this.TextBox_Apellido.TabIndex = 1;
            // 
            // GUI_UsrMozo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TextBox_Apellido);
            this.Controls.Add(this.TextBox_Nombre);
            this.Name = "GUI_UsrMozo";
            this.Text = "GUI_UsrMozo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox_Nombre;
        private System.Windows.Forms.TextBox TextBox_Apellido;
    }
}
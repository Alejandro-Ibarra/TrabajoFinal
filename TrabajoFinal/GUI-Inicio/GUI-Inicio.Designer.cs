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
            this.Button_Cliente = new System.Windows.Forms.Button();
            this.Buton_Restaurante = new System.Windows.Forms.Button();
            this.Pruebas = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Button_Cliente
            // 
            this.Button_Cliente.Location = new System.Drawing.Point(26, 24);
            this.Button_Cliente.Name = "Button_Cliente";
            this.Button_Cliente.Size = new System.Drawing.Size(75, 23);
            this.Button_Cliente.TabIndex = 0;
            this.Button_Cliente.Text = "Cliente";
            this.Button_Cliente.UseVisualStyleBackColor = true;
            this.Button_Cliente.Click += new System.EventHandler(this.Button_Cliente_Click);
            // 
            // Buton_Restaurante
            // 
            this.Buton_Restaurante.Location = new System.Drawing.Point(138, 24);
            this.Buton_Restaurante.Name = "Buton_Restaurante";
            this.Buton_Restaurante.Size = new System.Drawing.Size(75, 23);
            this.Buton_Restaurante.TabIndex = 1;
            this.Buton_Restaurante.Text = "Restaurante";
            this.Buton_Restaurante.UseVisualStyleBackColor = true;
            this.Buton_Restaurante.Click += new System.EventHandler(this.Buton_Restaurante_Click);
            // 
            // Pruebas
            // 
            this.Pruebas.Location = new System.Drawing.Point(26, 92);
            this.Pruebas.Name = "Pruebas";
            this.Pruebas.Size = new System.Drawing.Size(75, 23);
            this.Pruebas.TabIndex = 2;
            this.Pruebas.Text = "Pruebas";
            this.Pruebas.UseVisualStyleBackColor = true;
            this.Pruebas.Click += new System.EventHandler(this.Pruebas_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(138, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(138, 136);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // GUI_Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 192);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Pruebas);
            this.Controls.Add(this.Buton_Restaurante);
            this.Controls.Add(this.Button_Cliente);
            this.Name = "GUI_Inicio";
            this.Text = "GUI_Inicio";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Button_Cliente;
        private System.Windows.Forms.Button Buton_Restaurante;
        private System.Windows.Forms.Button Pruebas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
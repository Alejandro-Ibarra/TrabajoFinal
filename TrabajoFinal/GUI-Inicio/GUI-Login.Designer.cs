namespace TrabajoFinal
{
    partial class GUI_Login
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBox_Pass = new System.Windows.Forms.TextBox();
            this.Button_Aceptar = new System.Windows.Forms.Button();
            this.Button_Cancelar = new System.Windows.Forms.Button();
            this.TextBox_DNI = new TrabajoFinal.UC_ValDNI();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Contraseña";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "DNI";
            // 
            // TextBox_Pass
            // 
            this.TextBox_Pass.Location = new System.Drawing.Point(67, 87);
            this.TextBox_Pass.Name = "TextBox_Pass";
            this.TextBox_Pass.Size = new System.Drawing.Size(100, 20);
            this.TextBox_Pass.TabIndex = 2;
            // 
            // Button_Aceptar
            // 
            this.Button_Aceptar.Location = new System.Drawing.Point(26, 137);
            this.Button_Aceptar.Name = "Button_Aceptar";
            this.Button_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.Button_Aceptar.TabIndex = 3;
            this.Button_Aceptar.Text = "Aceptar";
            this.Button_Aceptar.UseVisualStyleBackColor = true;
            this.Button_Aceptar.Click += new System.EventHandler(this.Button_Aceptar_Click);
            // 
            // Button_Cancelar
            // 
            this.Button_Cancelar.Location = new System.Drawing.Point(124, 137);
            this.Button_Cancelar.Name = "Button_Cancelar";
            this.Button_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Button_Cancelar.TabIndex = 4;
            this.Button_Cancelar.Text = "Cancelar";
            this.Button_Cancelar.UseVisualStyleBackColor = true;
            this.Button_Cancelar.Click += new System.EventHandler(this.Button_Cancelar_Click);
            // 
            // TextBox_DNI
            // 
            this.TextBox_DNI.Location = new System.Drawing.Point(67, 26);
            this.TextBox_DNI.Name = "TextBox_DNI";
            this.TextBox_DNI.Size = new System.Drawing.Size(100, 20);
            this.TextBox_DNI.TabIndex = 1;
            // 
            // GUI_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 206);
            this.Controls.Add(this.TextBox_DNI);
            this.Controls.Add(this.Button_Cancelar);
            this.Controls.Add(this.Button_Aceptar);
            this.Controls.Add(this.TextBox_Pass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "GUI_Login";
            this.Text = "GUI_Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBox_Pass;
        private System.Windows.Forms.Button Button_Aceptar;
        private UC_ValDNI TextBox_DNI;
        private System.Windows.Forms.Button Button_Cancelar;
    }
}
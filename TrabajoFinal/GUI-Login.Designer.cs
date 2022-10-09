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
            this.TextBox_DNI = new System.Windows.Forms.TextBox();
            this.TextBox_Pass = new System.Windows.Forms.TextBox();
            this.Button_Aceptar = new System.Windows.Forms.Button();
            this.Button_Cancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.RadioButton_Mozo = new System.Windows.Forms.RadioButton();
            this.RadioButton_Cocina = new System.Windows.Forms.RadioButton();
            this.RadioButton_Admin = new System.Windows.Forms.RadioButton();
            this.UC_ValDNI = new TrabajoFinal.UserControl.UC_ValDNI();
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
            // TextBox_DNI
            // 
            this.TextBox_DNI.Location = new System.Drawing.Point(67, 25);
            this.TextBox_DNI.Name = "TextBox_DNI";
            this.TextBox_DNI.Size = new System.Drawing.Size(100, 20);
            this.TextBox_DNI.TabIndex = 38;
            // 
            // TextBox_Pass
            // 
            this.TextBox_Pass.Location = new System.Drawing.Point(67, 87);
            this.TextBox_Pass.Name = "TextBox_Pass";
            this.TextBox_Pass.Size = new System.Drawing.Size(100, 20);
            this.TextBox_Pass.TabIndex = 39;
            // 
            // Button_Aceptar
            // 
            this.Button_Aceptar.Location = new System.Drawing.Point(28, 171);
            this.Button_Aceptar.Name = "Button_Aceptar";
            this.Button_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.Button_Aceptar.TabIndex = 40;
            this.Button_Aceptar.Text = "Aceptar";
            this.Button_Aceptar.UseVisualStyleBackColor = true;
            this.Button_Aceptar.Click += new System.EventHandler(this.Button_Aceptar_Click);
            // 
            // Button_Cancelar
            // 
            this.Button_Cancelar.Location = new System.Drawing.Point(126, 171);
            this.Button_Cancelar.Name = "Button_Cancelar";
            this.Button_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Button_Cancelar.TabIndex = 41;
            this.Button_Cancelar.Text = "Cancelar";
            this.Button_Cancelar.UseVisualStyleBackColor = true;
            this.Button_Cancelar.Click += new System.EventHandler(this.Button_Cancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Seleccione el tipo de cuenta que desea usar";
            // 
            // RadioButton_Mozo
            // 
            this.RadioButton_Mozo.AutoSize = true;
            this.RadioButton_Mozo.Location = new System.Drawing.Point(28, 148);
            this.RadioButton_Mozo.Name = "RadioButton_Mozo";
            this.RadioButton_Mozo.Size = new System.Drawing.Size(51, 17);
            this.RadioButton_Mozo.TabIndex = 43;
            this.RadioButton_Mozo.TabStop = true;
            this.RadioButton_Mozo.Text = "Mozo";
            this.RadioButton_Mozo.UseVisualStyleBackColor = true;
            // 
            // RadioButton_Cocina
            // 
            this.RadioButton_Cocina.AutoSize = true;
            this.RadioButton_Cocina.Location = new System.Drawing.Point(97, 148);
            this.RadioButton_Cocina.Name = "RadioButton_Cocina";
            this.RadioButton_Cocina.Size = new System.Drawing.Size(58, 17);
            this.RadioButton_Cocina.TabIndex = 44;
            this.RadioButton_Cocina.TabStop = true;
            this.RadioButton_Cocina.Text = "Cocina";
            this.RadioButton_Cocina.UseVisualStyleBackColor = true;
            // 
            // RadioButton_Admin
            // 
            this.RadioButton_Admin.AutoSize = true;
            this.RadioButton_Admin.Location = new System.Drawing.Point(175, 148);
            this.RadioButton_Admin.Name = "RadioButton_Admin";
            this.RadioButton_Admin.Size = new System.Drawing.Size(54, 17);
            this.RadioButton_Admin.TabIndex = 45;
            this.RadioButton_Admin.TabStop = true;
            this.RadioButton_Admin.Text = "Admin";
            this.RadioButton_Admin.UseVisualStyleBackColor = true;
            // 
            // UC_ValDNI
            // 
            this.UC_ValDNI.Location = new System.Drawing.Point(175, 25);
            this.UC_ValDNI.Name = "UC_ValDNI";
            this.UC_ValDNI.Size = new System.Drawing.Size(100, 20);
            this.UC_ValDNI.TabIndex = 46;
            // 
            // GUI_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 228);
            this.Controls.Add(this.UC_ValDNI);
            this.Controls.Add(this.RadioButton_Admin);
            this.Controls.Add(this.RadioButton_Cocina);
            this.Controls.Add(this.RadioButton_Mozo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Button_Cancelar);
            this.Controls.Add(this.Button_Aceptar);
            this.Controls.Add(this.TextBox_Pass);
            this.Controls.Add(this.TextBox_DNI);
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
        private System.Windows.Forms.TextBox TextBox_DNI;
        private System.Windows.Forms.TextBox TextBox_Pass;
        private System.Windows.Forms.Button Button_Aceptar;
        private System.Windows.Forms.Button Button_Cancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton RadioButton_Mozo;
        private System.Windows.Forms.RadioButton RadioButton_Cocina;
        private System.Windows.Forms.RadioButton RadioButton_Admin;
        private UserControl.UC_ValDNI UC_ValDNI;
    }
}
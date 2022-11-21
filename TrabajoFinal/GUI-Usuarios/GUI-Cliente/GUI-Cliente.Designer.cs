namespace TrabajoFinal
{
    partial class GUI_Cliente
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
            this.Boton_Entrada = new System.Windows.Forms.Button();
            this.Boton_PlatoPrincipal = new System.Windows.Forms.Button();
            this.Boton_Postre = new System.Windows.Forms.Button();
            this.Boton_Extras = new System.Windows.Forms.Button();
            this.Boton_Bebidas = new System.Windows.Forms.Button();
            this.Grilla_PedidosCliente = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Boton_Pagar = new System.Windows.Forms.Button();
            this.TextBox_Nombre = new System.Windows.Forms.TextBox();
            this.TextBox_Mail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Boton_Aceptar = new System.Windows.Forms.Button();
            this.Boton_Rechazar = new System.Windows.Forms.Button();
            this.Boton_Cancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla_PedidosCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // Boton_Entrada
            // 
            this.Boton_Entrada.Location = new System.Drawing.Point(46, 95);
            this.Boton_Entrada.Name = "Boton_Entrada";
            this.Boton_Entrada.Size = new System.Drawing.Size(75, 23);
            this.Boton_Entrada.TabIndex = 0;
            this.Boton_Entrada.Text = "Entrada";
            this.Boton_Entrada.UseVisualStyleBackColor = true;
            this.Boton_Entrada.Click += new System.EventHandler(this.Boton_Entrada_Click);
            // 
            // Boton_PlatoPrincipal
            // 
            this.Boton_PlatoPrincipal.Location = new System.Drawing.Point(46, 148);
            this.Boton_PlatoPrincipal.Name = "Boton_PlatoPrincipal";
            this.Boton_PlatoPrincipal.Size = new System.Drawing.Size(93, 23);
            this.Boton_PlatoPrincipal.TabIndex = 1;
            this.Boton_PlatoPrincipal.Text = "Plato Principal";
            this.Boton_PlatoPrincipal.UseVisualStyleBackColor = true;
            this.Boton_PlatoPrincipal.Click += new System.EventHandler(this.Boton_PlatoPrincipal_Click);
            // 
            // Boton_Postre
            // 
            this.Boton_Postre.Location = new System.Drawing.Point(162, 95);
            this.Boton_Postre.Name = "Boton_Postre";
            this.Boton_Postre.Size = new System.Drawing.Size(75, 23);
            this.Boton_Postre.TabIndex = 2;
            this.Boton_Postre.Text = "Postre";
            this.Boton_Postre.UseVisualStyleBackColor = true;
            this.Boton_Postre.Click += new System.EventHandler(this.Boton_Postre_Click);
            // 
            // Boton_Extras
            // 
            this.Boton_Extras.Location = new System.Drawing.Point(277, 95);
            this.Boton_Extras.Name = "Boton_Extras";
            this.Boton_Extras.Size = new System.Drawing.Size(75, 23);
            this.Boton_Extras.TabIndex = 3;
            this.Boton_Extras.Text = "Extras";
            this.Boton_Extras.UseVisualStyleBackColor = true;
            this.Boton_Extras.Click += new System.EventHandler(this.Boton_Extras_Click);
            // 
            // Boton_Bebidas
            // 
            this.Boton_Bebidas.Location = new System.Drawing.Point(162, 148);
            this.Boton_Bebidas.Name = "Boton_Bebidas";
            this.Boton_Bebidas.Size = new System.Drawing.Size(75, 23);
            this.Boton_Bebidas.TabIndex = 4;
            this.Boton_Bebidas.Text = "Bebidas";
            this.Boton_Bebidas.UseVisualStyleBackColor = true;
            this.Boton_Bebidas.Click += new System.EventHandler(this.Boton_Bebidas_Click);
            // 
            // Grilla_PedidosCliente
            // 
            this.Grilla_PedidosCliente.AllowUserToAddRows = false;
            this.Grilla_PedidosCliente.AllowUserToDeleteRows = false;
            this.Grilla_PedidosCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grilla_PedidosCliente.Location = new System.Drawing.Point(37, 177);
            this.Grilla_PedidosCliente.Name = "Grilla_PedidosCliente";
            this.Grilla_PedidosCliente.ReadOnly = true;
            this.Grilla_PedidosCliente.Size = new System.Drawing.Size(656, 335);
            this.Grilla_PedidosCliente.TabIndex = 5;
            this.Grilla_PedidosCliente.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Grilla_PedidosCliente_MouseClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(725, 361);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(118, 32);
            this.textBox1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(722, 333);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "MontoTotal";
            // 
            // Boton_Pagar
            // 
            this.Boton_Pagar.Location = new System.Drawing.Point(725, 464);
            this.Boton_Pagar.Name = "Boton_Pagar";
            this.Boton_Pagar.Size = new System.Drawing.Size(75, 48);
            this.Boton_Pagar.TabIndex = 8;
            this.Boton_Pagar.Text = "Pagar";
            this.Boton_Pagar.UseVisualStyleBackColor = true;
            this.Boton_Pagar.Click += new System.EventHandler(this.Boton_Pagar_Click);
            // 
            // TextBox_Nombre
            // 
            this.TextBox_Nombre.Enabled = false;
            this.TextBox_Nombre.Location = new System.Drawing.Point(46, 43);
            this.TextBox_Nombre.Name = "TextBox_Nombre";
            this.TextBox_Nombre.Size = new System.Drawing.Size(100, 20);
            this.TextBox_Nombre.TabIndex = 9;
            // 
            // TextBox_Mail
            // 
            this.TextBox_Mail.Enabled = false;
            this.TextBox_Mail.Location = new System.Drawing.Point(189, 43);
            this.TextBox_Mail.Name = "TextBox_Mail";
            this.TextBox_Mail.Size = new System.Drawing.Size(163, 20);
            this.TextBox_Mail.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(186, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "E-Mail";
            // 
            // Boton_Aceptar
            // 
            this.Boton_Aceptar.Location = new System.Drawing.Point(725, 177);
            this.Boton_Aceptar.Name = "Boton_Aceptar";
            this.Boton_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.Boton_Aceptar.TabIndex = 13;
            this.Boton_Aceptar.Text = "Aceptar";
            this.Boton_Aceptar.UseVisualStyleBackColor = true;
            this.Boton_Aceptar.Click += new System.EventHandler(this.Boton_Aceptar_Click);
            // 
            // Boton_Rechazar
            // 
            this.Boton_Rechazar.Location = new System.Drawing.Point(725, 223);
            this.Boton_Rechazar.Name = "Boton_Rechazar";
            this.Boton_Rechazar.Size = new System.Drawing.Size(75, 23);
            this.Boton_Rechazar.TabIndex = 14;
            this.Boton_Rechazar.Text = "Rechazar";
            this.Boton_Rechazar.UseVisualStyleBackColor = true;
            this.Boton_Rechazar.Click += new System.EventHandler(this.Boton_Rechazar_Click);
            // 
            // Boton_Cancelar
            // 
            this.Boton_Cancelar.Location = new System.Drawing.Point(725, 273);
            this.Boton_Cancelar.Name = "Boton_Cancelar";
            this.Boton_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Boton_Cancelar.TabIndex = 17;
            this.Boton_Cancelar.Text = "Cancelar";
            this.Boton_Cancelar.UseVisualStyleBackColor = true;
            this.Boton_Cancelar.Click += new System.EventHandler(this.Boton_Cancelar_Click);
            // 
            // GUI_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 558);
            this.Controls.Add(this.Boton_Cancelar);
            this.Controls.Add(this.Boton_Rechazar);
            this.Controls.Add(this.Boton_Aceptar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextBox_Mail);
            this.Controls.Add(this.TextBox_Nombre);
            this.Controls.Add(this.Boton_Pagar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Grilla_PedidosCliente);
            this.Controls.Add(this.Boton_Bebidas);
            this.Controls.Add(this.Boton_Extras);
            this.Controls.Add(this.Boton_Postre);
            this.Controls.Add(this.Boton_PlatoPrincipal);
            this.Controls.Add(this.Boton_Entrada);
            this.Name = "GUI_Cliente";
            this.Text = "GUI_Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.Grilla_PedidosCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Boton_Entrada;
        private System.Windows.Forms.Button Boton_PlatoPrincipal;
        private System.Windows.Forms.Button Boton_Postre;
        private System.Windows.Forms.Button Boton_Extras;
        private System.Windows.Forms.Button Boton_Bebidas;
        private System.Windows.Forms.DataGridView Grilla_PedidosCliente;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Boton_Pagar;
        private System.Windows.Forms.TextBox TextBox_Nombre;
        private System.Windows.Forms.TextBox TextBox_Mail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Boton_Aceptar;
        private System.Windows.Forms.Button Boton_Rechazar;
        private System.Windows.Forms.Button Boton_Cancelar;
    }
}
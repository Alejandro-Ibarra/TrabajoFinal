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
            this.Boton_CerrarSesion = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla_PedidosCliente)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // Boton_Entrada
            // 
            this.Boton_Entrada.BackColor = System.Drawing.Color.AliceBlue;
            this.Boton_Entrada.Location = new System.Drawing.Point(11, 14);
            this.Boton_Entrada.Name = "Boton_Entrada";
            this.Boton_Entrada.Size = new System.Drawing.Size(75, 38);
            this.Boton_Entrada.TabIndex = 0;
            this.Boton_Entrada.Text = "Entrada";
            this.Boton_Entrada.UseVisualStyleBackColor = false;
            this.Boton_Entrada.Click += new System.EventHandler(this.Boton_Entrada_Click);
            // 
            // Boton_PlatoPrincipal
            // 
            this.Boton_PlatoPrincipal.BackColor = System.Drawing.Color.AliceBlue;
            this.Boton_PlatoPrincipal.Location = new System.Drawing.Point(106, 14);
            this.Boton_PlatoPrincipal.Name = "Boton_PlatoPrincipal";
            this.Boton_PlatoPrincipal.Size = new System.Drawing.Size(93, 38);
            this.Boton_PlatoPrincipal.TabIndex = 1;
            this.Boton_PlatoPrincipal.Text = "Plato Principal";
            this.Boton_PlatoPrincipal.UseVisualStyleBackColor = false;
            this.Boton_PlatoPrincipal.Click += new System.EventHandler(this.Boton_PlatoPrincipal_Click);
            // 
            // Boton_Postre
            // 
            this.Boton_Postre.BackColor = System.Drawing.Color.AliceBlue;
            this.Boton_Postre.Location = new System.Drawing.Point(220, 14);
            this.Boton_Postre.Name = "Boton_Postre";
            this.Boton_Postre.Size = new System.Drawing.Size(75, 38);
            this.Boton_Postre.TabIndex = 2;
            this.Boton_Postre.Text = "Postre";
            this.Boton_Postre.UseVisualStyleBackColor = false;
            this.Boton_Postre.Click += new System.EventHandler(this.Boton_Postre_Click);
            // 
            // Boton_Extras
            // 
            this.Boton_Extras.BackColor = System.Drawing.Color.AliceBlue;
            this.Boton_Extras.Location = new System.Drawing.Point(106, 17);
            this.Boton_Extras.Name = "Boton_Extras";
            this.Boton_Extras.Size = new System.Drawing.Size(75, 38);
            this.Boton_Extras.TabIndex = 3;
            this.Boton_Extras.Text = "Extras";
            this.Boton_Extras.UseVisualStyleBackColor = false;
            this.Boton_Extras.Click += new System.EventHandler(this.Boton_Extras_Click);
            // 
            // Boton_Bebidas
            // 
            this.Boton_Bebidas.BackColor = System.Drawing.Color.AliceBlue;
            this.Boton_Bebidas.Location = new System.Drawing.Point(9, 17);
            this.Boton_Bebidas.Name = "Boton_Bebidas";
            this.Boton_Bebidas.Size = new System.Drawing.Size(75, 38);
            this.Boton_Bebidas.TabIndex = 4;
            this.Boton_Bebidas.Text = "Bebidas";
            this.Boton_Bebidas.UseVisualStyleBackColor = false;
            this.Boton_Bebidas.Click += new System.EventHandler(this.Boton_Bebidas_Click);
            // 
            // Grilla_PedidosCliente
            // 
            this.Grilla_PedidosCliente.AllowUserToAddRows = false;
            this.Grilla_PedidosCliente.AllowUserToDeleteRows = false;
            this.Grilla_PedidosCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grilla_PedidosCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grilla_PedidosCliente.Location = new System.Drawing.Point(28, 213);
            this.Grilla_PedidosCliente.Name = "Grilla_PedidosCliente";
            this.Grilla_PedidosCliente.ReadOnly = true;
            this.Grilla_PedidosCliente.RowHeadersVisible = false;
            this.Grilla_PedidosCliente.Size = new System.Drawing.Size(665, 335);
            this.Grilla_PedidosCliente.TabIndex = 5;
            this.Grilla_PedidosCliente.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Grilla_PedidosCliente_MouseClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 34);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(118, 32);
            this.textBox1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "MontoTotal";
            // 
            // Boton_Pagar
            // 
            this.Boton_Pagar.BackColor = System.Drawing.Color.Honeydew;
            this.Boton_Pagar.Location = new System.Drawing.Point(144, 19);
            this.Boton_Pagar.Name = "Boton_Pagar";
            this.Boton_Pagar.Size = new System.Drawing.Size(75, 48);
            this.Boton_Pagar.TabIndex = 8;
            this.Boton_Pagar.Text = "Pagar";
            this.Boton_Pagar.UseVisualStyleBackColor = false;
            this.Boton_Pagar.Click += new System.EventHandler(this.Boton_Pagar_Click);
            // 
            // TextBox_Nombre
            // 
            this.TextBox_Nombre.Enabled = false;
            this.TextBox_Nombre.Location = new System.Drawing.Point(18, 36);
            this.TextBox_Nombre.Name = "TextBox_Nombre";
            this.TextBox_Nombre.Size = new System.Drawing.Size(276, 20);
            this.TextBox_Nombre.TabIndex = 9;
            // 
            // TextBox_Mail
            // 
            this.TextBox_Mail.Enabled = false;
            this.TextBox_Mail.Location = new System.Drawing.Point(359, 36);
            this.TextBox_Mail.Name = "TextBox_Mail";
            this.TextBox_Mail.Size = new System.Drawing.Size(260, 20);
            this.TextBox_Mail.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(15, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(356, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "E-Mail";
            // 
            // Boton_Aceptar
            // 
            this.Boton_Aceptar.BackColor = System.Drawing.Color.Honeydew;
            this.Boton_Aceptar.Enabled = false;
            this.Boton_Aceptar.Location = new System.Drawing.Point(15, 20);
            this.Boton_Aceptar.Name = "Boton_Aceptar";
            this.Boton_Aceptar.Size = new System.Drawing.Size(75, 40);
            this.Boton_Aceptar.TabIndex = 13;
            this.Boton_Aceptar.Text = "Aceptar";
            this.Boton_Aceptar.UseVisualStyleBackColor = false;
            this.Boton_Aceptar.Click += new System.EventHandler(this.Boton_Aceptar_Click);
            // 
            // Boton_Rechazar
            // 
            this.Boton_Rechazar.BackColor = System.Drawing.Color.LightYellow;
            this.Boton_Rechazar.Enabled = false;
            this.Boton_Rechazar.Location = new System.Drawing.Point(15, 66);
            this.Boton_Rechazar.Name = "Boton_Rechazar";
            this.Boton_Rechazar.Size = new System.Drawing.Size(75, 40);
            this.Boton_Rechazar.TabIndex = 14;
            this.Boton_Rechazar.Text = "Rechazar";
            this.Boton_Rechazar.UseVisualStyleBackColor = false;
            this.Boton_Rechazar.Click += new System.EventHandler(this.Boton_Rechazar_Click);
            // 
            // Boton_Cancelar
            // 
            this.Boton_Cancelar.BackColor = System.Drawing.Color.Linen;
            this.Boton_Cancelar.Location = new System.Drawing.Point(15, 112);
            this.Boton_Cancelar.Name = "Boton_Cancelar";
            this.Boton_Cancelar.Size = new System.Drawing.Size(75, 40);
            this.Boton_Cancelar.TabIndex = 17;
            this.Boton_Cancelar.Text = "Cancelar";
            this.Boton_Cancelar.UseVisualStyleBackColor = false;
            this.Boton_Cancelar.Click += new System.EventHandler(this.Boton_Cancelar_Click);
            // 
            // Boton_CerrarSesion
            // 
            this.Boton_CerrarSesion.BackColor = System.Drawing.Color.Linen;
            this.Boton_CerrarSesion.Location = new System.Drawing.Point(873, 12);
            this.Boton_CerrarSesion.Name = "Boton_CerrarSesion";
            this.Boton_CerrarSesion.Size = new System.Drawing.Size(99, 34);
            this.Boton_CerrarSesion.TabIndex = 18;
            this.Boton_CerrarSesion.Text = "Cerrar sesión";
            this.Boton_CerrarSesion.UseVisualStyleBackColor = false;
            this.Boton_CerrarSesion.Click += new System.EventHandler(this.Boton_CerrarSesion_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.Boton_Pagar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(729, 467);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 82);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(174)))), ((int)(((byte)(228)))));
            this.groupBox2.Controls.Add(this.Boton_Cancelar);
            this.groupBox2.Controls.Add(this.Boton_Rechazar);
            this.groupBox2.Controls.Add(this.Boton_Aceptar);
            this.groupBox2.Location = new System.Drawing.Point(729, 248);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(106, 163);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Acciones";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.Boton_Postre);
            this.groupBox3.Controls.Add(this.Boton_PlatoPrincipal);
            this.groupBox3.Controls.Add(this.Boton_Entrada);
            this.groupBox3.Location = new System.Drawing.Point(87, 131);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(305, 64);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.Boton_Bebidas);
            this.groupBox4.Controls.Add(this.Boton_Extras);
            this.groupBox4.Location = new System.Drawing.Point(421, 128);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(193, 66);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(174)))), ((int)(((byte)(228)))));
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.TextBox_Mail);
            this.groupBox5.Controls.Add(this.TextBox_Nombre);
            this.groupBox5.Location = new System.Drawing.Point(28, 21);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(665, 67);
            this.groupBox5.TabIndex = 23;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Cliente";
            // 
            // GUI_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TrabajoFinal.Properties.Resources.BlueShade2;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Boton_CerrarSesion);
            this.Controls.Add(this.Grilla_PedidosCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "GUI_Cliente";
            this.Text = "GUI_Cliente";
            this.Load += new System.EventHandler(this.GUI_Cliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grilla_PedidosCliente)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button Boton_CerrarSesion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
    }
}
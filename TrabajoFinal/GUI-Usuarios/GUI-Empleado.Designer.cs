namespace TrabajoFinal
{
    partial class GUI_UsrEmpleado
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
            this.GridView_Pedidos = new System.Windows.Forms.DataGridView();
            this.Boton_EnPreparacion = new System.Windows.Forms.Button();
            this.Boton_EnEntrega = new System.Windows.Forms.Button();
            this.Boton_Entregado = new System.Windows.Forms.Button();
            this.Boton_Retirado = new System.Windows.Forms.Button();
            this.Boton_VerificacionPlato = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Pedidos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridView_Pedidos
            // 
            this.GridView_Pedidos.AllowUserToAddRows = false;
            this.GridView_Pedidos.AllowUserToDeleteRows = false;
            this.GridView_Pedidos.AllowUserToResizeColumns = false;
            this.GridView_Pedidos.AllowUserToResizeRows = false;
            this.GridView_Pedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridView_Pedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView_Pedidos.Location = new System.Drawing.Point(12, 24);
            this.GridView_Pedidos.Name = "GridView_Pedidos";
            this.GridView_Pedidos.ReadOnly = true;
            this.GridView_Pedidos.RowHeadersVisible = false;
            this.GridView_Pedidos.Size = new System.Drawing.Size(960, 436);
            this.GridView_Pedidos.TabIndex = 4;
            this.GridView_Pedidos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GridView_Pedidos_MouseClick);
            // 
            // Boton_EnPreparacion
            // 
            this.Boton_EnPreparacion.BackColor = System.Drawing.Color.AliceBlue;
            this.Boton_EnPreparacion.Enabled = false;
            this.Boton_EnPreparacion.Location = new System.Drawing.Point(217, 27);
            this.Boton_EnPreparacion.Name = "Boton_EnPreparacion";
            this.Boton_EnPreparacion.Size = new System.Drawing.Size(117, 34);
            this.Boton_EnPreparacion.TabIndex = 5;
            this.Boton_EnPreparacion.Text = "En preparacion";
            this.Boton_EnPreparacion.UseVisualStyleBackColor = false;
            this.Boton_EnPreparacion.Click += new System.EventHandler(this.Boton_EnPreparacion_Click);
            // 
            // Boton_EnEntrega
            // 
            this.Boton_EnEntrega.BackColor = System.Drawing.Color.AliceBlue;
            this.Boton_EnEntrega.Enabled = false;
            this.Boton_EnEntrega.Location = new System.Drawing.Point(425, 27);
            this.Boton_EnEntrega.Name = "Boton_EnEntrega";
            this.Boton_EnEntrega.Size = new System.Drawing.Size(117, 34);
            this.Boton_EnEntrega.TabIndex = 6;
            this.Boton_EnEntrega.Text = "En entrega";
            this.Boton_EnEntrega.UseVisualStyleBackColor = false;
            this.Boton_EnEntrega.Click += new System.EventHandler(this.Boton_EnEntrega_Click);
            // 
            // Boton_Entregado
            // 
            this.Boton_Entregado.BackColor = System.Drawing.Color.AliceBlue;
            this.Boton_Entregado.Enabled = false;
            this.Boton_Entregado.Location = new System.Drawing.Point(638, 27);
            this.Boton_Entregado.Name = "Boton_Entregado";
            this.Boton_Entregado.Size = new System.Drawing.Size(117, 34);
            this.Boton_Entregado.TabIndex = 7;
            this.Boton_Entregado.Text = "Entregado";
            this.Boton_Entregado.UseVisualStyleBackColor = false;
            this.Boton_Entregado.Click += new System.EventHandler(this.Boton_Entregado_Click);
            // 
            // Boton_Retirado
            // 
            this.Boton_Retirado.BackColor = System.Drawing.Color.AliceBlue;
            this.Boton_Retirado.Enabled = false;
            this.Boton_Retirado.Location = new System.Drawing.Point(834, 27);
            this.Boton_Retirado.Name = "Boton_Retirado";
            this.Boton_Retirado.Size = new System.Drawing.Size(117, 34);
            this.Boton_Retirado.TabIndex = 8;
            this.Boton_Retirado.Text = "Retirado";
            this.Boton_Retirado.UseVisualStyleBackColor = false;
            this.Boton_Retirado.Click += new System.EventHandler(this.Boton_Retirado_Click);
            // 
            // Boton_VerificacionPlato
            // 
            this.Boton_VerificacionPlato.BackColor = System.Drawing.Color.AliceBlue;
            this.Boton_VerificacionPlato.Enabled = false;
            this.Boton_VerificacionPlato.Location = new System.Drawing.Point(8, 27);
            this.Boton_VerificacionPlato.Name = "Boton_VerificacionPlato";
            this.Boton_VerificacionPlato.Size = new System.Drawing.Size(117, 34);
            this.Boton_VerificacionPlato.TabIndex = 9;
            this.Boton_VerificacionPlato.Text = "Verificar plato";
            this.Boton_VerificacionPlato.UseVisualStyleBackColor = false;
            this.Boton_VerificacionPlato.Click += new System.EventHandler(this.Boton_VerificacionPlato_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(174)))), ((int)(((byte)(228)))));
            this.groupBox1.Controls.Add(this.Boton_VerificacionPlato);
            this.groupBox1.Controls.Add(this.Boton_Retirado);
            this.groupBox1.Controls.Add(this.Boton_Entregado);
            this.groupBox1.Controls.Add(this.Boton_EnEntrega);
            this.groupBox1.Controls.Add(this.Boton_EnPreparacion);
            this.groupBox1.Location = new System.Drawing.Point(12, 479);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(960, 78);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Acciones";
            // 
            // GUI_UsrEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TrabajoFinal.Properties.Resources.BlueShade2;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GridView_Pedidos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "GUI_UsrEmpleado";
            this.Text = "GUI_UsrCocina";
            this.Load += new System.EventHandler(this.GUI_UsrCocina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Pedidos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView GridView_Pedidos;
        private System.Windows.Forms.Button Boton_EnPreparacion;
        private System.Windows.Forms.Button Boton_EnEntrega;
        private System.Windows.Forms.Button Boton_Entregado;
        private System.Windows.Forms.Button Boton_Retirado;
        private System.Windows.Forms.Button Boton_VerificacionPlato;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
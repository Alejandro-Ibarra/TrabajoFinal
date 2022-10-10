
namespace TrabajoFinal
{
    partial class GUI_AdminBebidas
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
            this.Grilla_Bebidas = new System.Windows.Forms.DataGridView();
            this.Boton_Modificar = new System.Windows.Forms.Button();
            this.Boton_Baja = new System.Windows.Forms.Button();
            this.Boton_Alta = new System.Windows.Forms.Button();
            this.Nombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ComboBox_Envases = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ComboBox_Marca = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.UC_ValPrecio = new TrabajoFinal.UserControl.UC_ValCod();
            this.UC_ValStock = new TrabajoFinal.UserControl.UC_ValCod();
            this.UC_ValGraduacion = new TrabajoFinal.UserControl.UC_ValCod();
            this.UC_ValNomb = new TrabajoFinal.UserControl.UC_ValNombApe();
            this.UC_ValCod = new TrabajoFinal.UserControl.UC_ValCod();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla_Bebidas)).BeginInit();
            this.SuspendLayout();
            // 
            // Grilla_Bebidas
            // 
            this.Grilla_Bebidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grilla_Bebidas.Location = new System.Drawing.Point(12, 317);
            this.Grilla_Bebidas.Name = "Grilla_Bebidas";
            this.Grilla_Bebidas.Size = new System.Drawing.Size(744, 384);
            this.Grilla_Bebidas.TabIndex = 0;
            this.Grilla_Bebidas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Grilla_Bebidas_MouseClick);
            // 
            // Boton_Modificar
            // 
            this.Boton_Modificar.Location = new System.Drawing.Point(490, 261);
            this.Boton_Modificar.Name = "Boton_Modificar";
            this.Boton_Modificar.Size = new System.Drawing.Size(75, 23);
            this.Boton_Modificar.TabIndex = 20;
            this.Boton_Modificar.Text = "Modificar";
            this.Boton_Modificar.UseVisualStyleBackColor = true;
            this.Boton_Modificar.Click += new System.EventHandler(this.Boton_Modificar_Click);
            // 
            // Boton_Baja
            // 
            this.Boton_Baja.Location = new System.Drawing.Point(341, 261);
            this.Boton_Baja.Name = "Boton_Baja";
            this.Boton_Baja.Size = new System.Drawing.Size(75, 23);
            this.Boton_Baja.TabIndex = 19;
            this.Boton_Baja.Text = "Baja";
            this.Boton_Baja.UseVisualStyleBackColor = true;
            this.Boton_Baja.Click += new System.EventHandler(this.Boton_Baja_Click);
            // 
            // Boton_Alta
            // 
            this.Boton_Alta.Location = new System.Drawing.Point(157, 261);
            this.Boton_Alta.Name = "Boton_Alta";
            this.Boton_Alta.Size = new System.Drawing.Size(75, 23);
            this.Boton_Alta.TabIndex = 18;
            this.Boton_Alta.Text = "Alta";
            this.Boton_Alta.UseVisualStyleBackColor = true;
            this.Boton_Alta.Click += new System.EventHandler(this.Boton_Alta_Click);
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(203, 55);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(44, 13);
            this.Nombre.TabIndex = 22;
            this.Nombre.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(344, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Stock";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Graduacion Alcoholica";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(485, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Precio";
            // 
            // ComboBox_Envases
            // 
            this.ComboBox_Envases.FormattingEnabled = true;
            this.ComboBox_Envases.Location = new System.Drawing.Point(347, 86);
            this.ComboBox_Envases.Name = "ComboBox_Envases";
            this.ComboBox_Envases.Size = new System.Drawing.Size(121, 21);
            this.ComboBox_Envases.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(344, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Tipo de envase";
            // 
            // ComboBox_Marca
            // 
            this.ComboBox_Marca.FormattingEnabled = true;
            this.ComboBox_Marca.Location = new System.Drawing.Point(488, 86);
            this.ComboBox_Marca.Name = "ComboBox_Marca";
            this.ComboBox_Marca.Size = new System.Drawing.Size(121, 21);
            this.ComboBox_Marca.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(485, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Marca";
            // 
            // UC_ValPrecio
            // 
            this.UC_ValPrecio.Location = new System.Drawing.Point(488, 169);
            this.UC_ValPrecio.Name = "UC_ValPrecio";
            this.UC_ValPrecio.Size = new System.Drawing.Size(100, 20);
            this.UC_ValPrecio.TabIndex = 32;
            // 
            // UC_ValStock
            // 
            this.UC_ValStock.Location = new System.Drawing.Point(347, 169);
            this.UC_ValStock.Name = "UC_ValStock";
            this.UC_ValStock.Size = new System.Drawing.Size(100, 20);
            this.UC_ValStock.TabIndex = 30;
            // 
            // UC_ValGraduacion
            // 
            this.UC_ValGraduacion.Location = new System.Drawing.Point(206, 169);
            this.UC_ValGraduacion.Name = "UC_ValGraduacion";
            this.UC_ValGraduacion.Size = new System.Drawing.Size(100, 20);
            this.UC_ValGraduacion.TabIndex = 29;
            // 
            // UC_ValNomb
            // 
            this.UC_ValNomb.Location = new System.Drawing.Point(206, 87);
            this.UC_ValNomb.Name = "UC_ValNomb";
            this.UC_ValNomb.Size = new System.Drawing.Size(100, 20);
            this.UC_ValNomb.TabIndex = 21;
            // 
            // UC_ValCod
            // 
            this.UC_ValCod.Location = new System.Drawing.Point(50, 86);
            this.UC_ValCod.Name = "UC_ValCod";
            this.UC_ValCod.Size = new System.Drawing.Size(100, 20);
            this.UC_ValCod.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Codigo";
            // 
            // GUI_AdminBebidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 713);
            this.Controls.Add(this.UC_ValCod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ComboBox_Marca);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ComboBox_Envases);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.UC_ValPrecio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.UC_ValStock);
            this.Controls.Add(this.UC_ValGraduacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.UC_ValNomb);
            this.Controls.Add(this.Boton_Modificar);
            this.Controls.Add(this.Boton_Baja);
            this.Controls.Add(this.Boton_Alta);
            this.Controls.Add(this.Grilla_Bebidas);
            this.Name = "GUI_AdminBebidas";
            this.Text = "GUI_AdminBebidas";
            this.Load += new System.EventHandler(this.GUI_AdminBebidas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grilla_Bebidas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Grilla_Bebidas;
        private System.Windows.Forms.Button Boton_Modificar;
        private System.Windows.Forms.Button Boton_Baja;
        private System.Windows.Forms.Button Boton_Alta;
        private System.Windows.Forms.Label Nombre;
        private UserControl.UC_ValNombApe UC_ValNomb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private UserControl.UC_ValCod UC_ValGraduacion;
        private UserControl.UC_ValCod UC_ValStock;
        private UserControl.UC_ValCod UC_ValPrecio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ComboBox_Envases;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ComboBox_Marca;
        private System.Windows.Forms.Label label6;
        private UserControl.UC_ValCod UC_ValCod;
        private System.Windows.Forms.Label label2;
    }
}

namespace TrabajoFinal
{
    partial class GUI_Gerente_Extras
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
            this.label4 = new System.Windows.Forms.Label();
            this.ComboBox_Proveedor = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.UC_ValStock = new TrabajoFinal.UC_ValCod();
            this.label1 = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.UC_ValNomb = new TrabajoFinal.UC_ValNombApe();
            this.Boton_Modificar = new System.Windows.Forms.Button();
            this.Boton_Baja = new System.Windows.Forms.Button();
            this.Boton_Alta = new System.Windows.Forms.Button();
            this.Grilla_Ingredientes = new System.Windows.Forms.DataGridView();
            this.ComboBox_Tipo = new System.Windows.Forms.ComboBox();
            this.RadioButton_Inactivo = new System.Windows.Forms.RadioButton();
            this.RadioButton_Activo = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla_Ingredientes)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(311, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 78;
            this.label4.Text = "Tipo";
            // 
            // ComboBox_Proveedor
            // 
            this.ComboBox_Proveedor.FormattingEnabled = true;
            this.ComboBox_Proveedor.Location = new System.Drawing.Point(158, 166);
            this.ComboBox_Proveedor.Name = "ComboBox_Proveedor";
            this.ComboBox_Proveedor.Size = new System.Drawing.Size(121, 21);
            this.ComboBox_Proveedor.TabIndex = 72;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(155, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 71;
            this.label6.Text = "Proveedor";
            // 
            // UC_ValStock
            // 
            this.UC_ValStock.Location = new System.Drawing.Point(314, 86);
            this.UC_ValStock.Name = "UC_ValStock";
            this.UC_ValStock.Size = new System.Drawing.Size(100, 20);
            this.UC_ValStock.TabIndex = 70;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(311, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 69;
            this.label1.Text = "Stock";
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(155, 54);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(44, 13);
            this.Nombre.TabIndex = 68;
            this.Nombre.Text = "Nombre";
            // 
            // UC_ValNomb
            // 
            this.UC_ValNomb.Location = new System.Drawing.Point(158, 86);
            this.UC_ValNomb.Name = "UC_ValNomb";
            this.UC_ValNomb.Size = new System.Drawing.Size(100, 20);
            this.UC_ValNomb.TabIndex = 67;
            // 
            // Boton_Modificar
            // 
            this.Boton_Modificar.Location = new System.Drawing.Point(489, 238);
            this.Boton_Modificar.Name = "Boton_Modificar";
            this.Boton_Modificar.Size = new System.Drawing.Size(75, 23);
            this.Boton_Modificar.TabIndex = 66;
            this.Boton_Modificar.Text = "Modificar";
            this.Boton_Modificar.UseVisualStyleBackColor = true;
            this.Boton_Modificar.Click += new System.EventHandler(this.Boton_Modificar_Click);
            // 
            // Boton_Baja
            // 
            this.Boton_Baja.Location = new System.Drawing.Point(342, 238);
            this.Boton_Baja.Name = "Boton_Baja";
            this.Boton_Baja.Size = new System.Drawing.Size(75, 23);
            this.Boton_Baja.TabIndex = 65;
            this.Boton_Baja.Text = "Baja";
            this.Boton_Baja.UseVisualStyleBackColor = true;
            this.Boton_Baja.Click += new System.EventHandler(this.Boton_Baja_Click);
            // 
            // Boton_Alta
            // 
            this.Boton_Alta.Location = new System.Drawing.Point(158, 238);
            this.Boton_Alta.Name = "Boton_Alta";
            this.Boton_Alta.Size = new System.Drawing.Size(75, 23);
            this.Boton_Alta.TabIndex = 64;
            this.Boton_Alta.Text = "Alta";
            this.Boton_Alta.UseVisualStyleBackColor = true;
            this.Boton_Alta.Click += new System.EventHandler(this.Boton_Alta_Click);
            // 
            // Grilla_Ingredientes
            // 
            this.Grilla_Ingredientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grilla_Ingredientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grilla_Ingredientes.Location = new System.Drawing.Point(131, 297);
            this.Grilla_Ingredientes.Name = "Grilla_Ingredientes";
            this.Grilla_Ingredientes.ReadOnly = true;
            this.Grilla_Ingredientes.Size = new System.Drawing.Size(646, 231);
            this.Grilla_Ingredientes.TabIndex = 63;
            this.Grilla_Ingredientes.Click += new System.EventHandler(this.Grilla_Ingredientes_Click);
            // 
            // ComboBox_Tipo
            // 
            this.ComboBox_Tipo.FormattingEnabled = true;
            this.ComboBox_Tipo.Location = new System.Drawing.Point(314, 166);
            this.ComboBox_Tipo.Name = "ComboBox_Tipo";
            this.ComboBox_Tipo.Size = new System.Drawing.Size(121, 21);
            this.ComboBox_Tipo.TabIndex = 79;
            // 
            // RadioButton_Inactivo
            // 
            this.RadioButton_Inactivo.AutoSize = true;
            this.RadioButton_Inactivo.Location = new System.Drawing.Point(489, 163);
            this.RadioButton_Inactivo.Name = "RadioButton_Inactivo";
            this.RadioButton_Inactivo.Size = new System.Drawing.Size(63, 17);
            this.RadioButton_Inactivo.TabIndex = 81;
            this.RadioButton_Inactivo.TabStop = true;
            this.RadioButton_Inactivo.Text = "Inactivo";
            this.RadioButton_Inactivo.UseVisualStyleBackColor = true;
            // 
            // RadioButton_Activo
            // 
            this.RadioButton_Activo.AutoSize = true;
            this.RadioButton_Activo.Checked = true;
            this.RadioButton_Activo.Location = new System.Drawing.Point(489, 134);
            this.RadioButton_Activo.Name = "RadioButton_Activo";
            this.RadioButton_Activo.Size = new System.Drawing.Size(55, 17);
            this.RadioButton_Activo.TabIndex = 80;
            this.RadioButton_Activo.TabStop = true;
            this.RadioButton_Activo.Text = "Activo";
            this.RadioButton_Activo.UseVisualStyleBackColor = true;
            // 
            // GUI_Gerente_Extras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.RadioButton_Inactivo);
            this.Controls.Add(this.RadioButton_Activo);
            this.Controls.Add(this.ComboBox_Tipo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ComboBox_Proveedor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.UC_ValStock);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.UC_ValNomb);
            this.Controls.Add(this.Boton_Modificar);
            this.Controls.Add(this.Boton_Baja);
            this.Controls.Add(this.Boton_Alta);
            this.Controls.Add(this.Grilla_Ingredientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "GUI_Gerente_Extras";
            this.Text = "GUI_AdminExtras";
            this.Load += new System.EventHandler(this.GUI_AdminExtras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grilla_Ingredientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ComboBox_Proveedor;
        private System.Windows.Forms.Label label6;
        private UC_ValCod UC_ValStock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Nombre;
        private UC_ValNombApe UC_ValNomb;
        private System.Windows.Forms.Button Boton_Modificar;
        private System.Windows.Forms.Button Boton_Baja;
        private System.Windows.Forms.Button Boton_Alta;
        private System.Windows.Forms.DataGridView Grilla_Ingredientes;
        private System.Windows.Forms.ComboBox ComboBox_Tipo;
        private System.Windows.Forms.RadioButton RadioButton_Inactivo;
        private System.Windows.Forms.RadioButton RadioButton_Activo;
    }
}

namespace TrabajoFinal
{
    partial class GUI_Gerente_Ingredientes
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
            this.RadioButton_Si = new System.Windows.Forms.RadioButton();
            this.RadioButton_No = new System.Windows.Forms.RadioButton();
            this.ComboBox_Tipo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla_Ingredientes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ComboBox_Proveedor
            // 
            this.ComboBox_Proveedor.FormattingEnabled = true;
            this.ComboBox_Proveedor.Location = new System.Drawing.Point(281, 40);
            this.ComboBox_Proveedor.Name = "ComboBox_Proveedor";
            this.ComboBox_Proveedor.Size = new System.Drawing.Size(183, 21);
            this.ComboBox_Proveedor.TabIndex = 55;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(278, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 54;
            this.label6.Text = "Proveedor";
            // 
            // UC_ValStock
            // 
            this.UC_ValStock.Location = new System.Drawing.Point(212, 92);
            this.UC_ValStock.Name = "UC_ValStock";
            this.UC_ValStock.Size = new System.Drawing.Size(100, 20);
            this.UC_ValStock.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(209, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "Stock";
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(4, 23);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(44, 13);
            this.Nombre.TabIndex = 45;
            this.Nombre.Text = "Nombre";
            // 
            // UC_ValNomb
            // 
            this.UC_ValNomb.Location = new System.Drawing.Point(7, 41);
            this.UC_ValNomb.Name = "UC_ValNomb";
            this.UC_ValNomb.Size = new System.Drawing.Size(243, 20);
            this.UC_ValNomb.TabIndex = 44;
            // 
            // Boton_Modificar
            // 
            this.Boton_Modificar.BackColor = System.Drawing.Color.Linen;
            this.Boton_Modificar.Location = new System.Drawing.Point(19, 108);
            this.Boton_Modificar.Name = "Boton_Modificar";
            this.Boton_Modificar.Size = new System.Drawing.Size(75, 36);
            this.Boton_Modificar.TabIndex = 43;
            this.Boton_Modificar.Text = "Modificar";
            this.Boton_Modificar.UseVisualStyleBackColor = false;
            this.Boton_Modificar.Click += new System.EventHandler(this.Boton_Modificar_Click);
            // 
            // Boton_Baja
            // 
            this.Boton_Baja.BackColor = System.Drawing.Color.LightYellow;
            this.Boton_Baja.Location = new System.Drawing.Point(19, 65);
            this.Boton_Baja.Name = "Boton_Baja";
            this.Boton_Baja.Size = new System.Drawing.Size(75, 36);
            this.Boton_Baja.TabIndex = 42;
            this.Boton_Baja.Text = "Eliminar";
            this.Boton_Baja.UseVisualStyleBackColor = false;
            this.Boton_Baja.Click += new System.EventHandler(this.Boton_Baja_Click);
            // 
            // Boton_Alta
            // 
            this.Boton_Alta.BackColor = System.Drawing.Color.Honeydew;
            this.Boton_Alta.Location = new System.Drawing.Point(19, 21);
            this.Boton_Alta.Name = "Boton_Alta";
            this.Boton_Alta.Size = new System.Drawing.Size(75, 36);
            this.Boton_Alta.TabIndex = 41;
            this.Boton_Alta.Text = "Agregar";
            this.Boton_Alta.UseVisualStyleBackColor = false;
            this.Boton_Alta.Click += new System.EventHandler(this.Boton_Alta_Click);
            // 
            // Grilla_Ingredientes
            // 
            this.Grilla_Ingredientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grilla_Ingredientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grilla_Ingredientes.Location = new System.Drawing.Point(12, 23);
            this.Grilla_Ingredientes.Name = "Grilla_Ingredientes";
            this.Grilla_Ingredientes.ReadOnly = true;
            this.Grilla_Ingredientes.Size = new System.Drawing.Size(948, 287);
            this.Grilla_Ingredientes.TabIndex = 40;
            this.Grilla_Ingredientes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Grilla_Ingredientes_MouseClick);
            // 
            // RadioButton_Si
            // 
            this.RadioButton_Si.AutoSize = true;
            this.RadioButton_Si.Checked = true;
            this.RadioButton_Si.Location = new System.Drawing.Point(13, 19);
            this.RadioButton_Si.Name = "RadioButton_Si";
            this.RadioButton_Si.Size = new System.Drawing.Size(34, 17);
            this.RadioButton_Si.TabIndex = 58;
            this.RadioButton_Si.TabStop = true;
            this.RadioButton_Si.Text = "Si";
            this.RadioButton_Si.UseVisualStyleBackColor = true;
            // 
            // RadioButton_No
            // 
            this.RadioButton_No.AutoSize = true;
            this.RadioButton_No.Location = new System.Drawing.Point(13, 43);
            this.RadioButton_No.Name = "RadioButton_No";
            this.RadioButton_No.Size = new System.Drawing.Size(41, 17);
            this.RadioButton_No.TabIndex = 59;
            this.RadioButton_No.Text = "NO";
            this.RadioButton_No.UseVisualStyleBackColor = true;
            // 
            // ComboBox_Tipo
            // 
            this.ComboBox_Tipo.FormattingEnabled = true;
            this.ComboBox_Tipo.Location = new System.Drawing.Point(7, 94);
            this.ComboBox_Tipo.Name = "ComboBox_Tipo";
            this.ComboBox_Tipo.Size = new System.Drawing.Size(167, 21);
            this.ComboBox_Tipo.TabIndex = 62;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 61;
            this.label4.Text = "Tipo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RadioButton_No);
            this.groupBox1.Controls.Add(this.RadioButton_Si);
            this.groupBox1.Location = new System.Drawing.Point(354, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(93, 66);
            this.groupBox1.TabIndex = 63;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Refrigeración";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(174)))), ((int)(((byte)(228)))));
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.ComboBox_Tipo);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.ComboBox_Proveedor);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.UC_ValStock);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.Nombre);
            this.groupBox2.Controls.Add(this.UC_ValNomb);
            this.groupBox2.Location = new System.Drawing.Point(26, 371);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(476, 156);
            this.groupBox2.TabIndex = 64;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del Ingrediente";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(174)))), ((int)(((byte)(228)))));
            this.groupBox3.Controls.Add(this.Boton_Modificar);
            this.groupBox3.Controls.Add(this.Boton_Baja);
            this.groupBox3.Controls.Add(this.Boton_Alta);
            this.groupBox3.Location = new System.Drawing.Point(533, 371);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(114, 156);
            this.groupBox3.TabIndex = 65;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Acciones";
            // 
            // GUI_Gerente_Ingredientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TrabajoFinal.Properties.Resources.BlueShade2;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Grilla_Ingredientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "GUI_Gerente_Ingredientes";
            this.Text = "GUI_AdminIngredientes";
            this.Load += new System.EventHandler(this.GUI_AdminIngredientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grilla_Ingredientes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
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
        private System.Windows.Forms.RadioButton RadioButton_Si;
        private System.Windows.Forms.RadioButton RadioButton_No;
        private System.Windows.Forms.ComboBox ComboBox_Tipo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}
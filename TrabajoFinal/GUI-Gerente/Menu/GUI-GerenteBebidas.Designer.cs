
namespace TrabajoFinal
{
    partial class GUI_Gerente_Bebidas
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
            this.RadioButton_Activo = new System.Windows.Forms.RadioButton();
            this.RadioButton_Inactivo = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Boton_Cancelar = new System.Windows.Forms.Button();
            this.Boton_ConfDatBebidas = new System.Windows.Forms.Button();
            this.UC_ValPrecio = new TrabajoFinal.UC_ValCod();
            this.UC_ValStock = new TrabajoFinal.UC_ValCod();
            this.UC_ValGraduacion = new TrabajoFinal.UC_ValCod();
            this.UC_ValNomb = new TrabajoFinal.UC_ValNombApe();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla_Bebidas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Grilla_Bebidas
            // 
            this.Grilla_Bebidas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grilla_Bebidas.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.Grilla_Bebidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grilla_Bebidas.Location = new System.Drawing.Point(12, 21);
            this.Grilla_Bebidas.Name = "Grilla_Bebidas";
            this.Grilla_Bebidas.ReadOnly = true;
            this.Grilla_Bebidas.RowHeadersVisible = false;
            this.Grilla_Bebidas.Size = new System.Drawing.Size(828, 350);
            this.Grilla_Bebidas.TabIndex = 0;
            this.Grilla_Bebidas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Grilla_Bebidas_MouseClick);
            // 
            // Boton_Modificar
            // 
            this.Boton_Modificar.BackColor = System.Drawing.Color.LightYellow;
            this.Boton_Modificar.Location = new System.Drawing.Point(22, 68);
            this.Boton_Modificar.Name = "Boton_Modificar";
            this.Boton_Modificar.Size = new System.Drawing.Size(75, 36);
            this.Boton_Modificar.TabIndex = 20;
            this.Boton_Modificar.Text = "Modificar";
            this.Boton_Modificar.UseVisualStyleBackColor = false;
            this.Boton_Modificar.Click += new System.EventHandler(this.Boton_Modificar_Click);
            // 
            // Boton_Baja
            // 
            this.Boton_Baja.BackColor = System.Drawing.Color.Linen;
            this.Boton_Baja.Location = new System.Drawing.Point(22, 111);
            this.Boton_Baja.Name = "Boton_Baja";
            this.Boton_Baja.Size = new System.Drawing.Size(75, 35);
            this.Boton_Baja.TabIndex = 19;
            this.Boton_Baja.Text = "Eliminar";
            this.Boton_Baja.UseVisualStyleBackColor = false;
            this.Boton_Baja.Click += new System.EventHandler(this.Boton_Baja_Click);
            // 
            // Boton_Alta
            // 
            this.Boton_Alta.BackColor = System.Drawing.Color.Honeydew;
            this.Boton_Alta.Location = new System.Drawing.Point(22, 23);
            this.Boton_Alta.Name = "Boton_Alta";
            this.Boton_Alta.Size = new System.Drawing.Size(75, 37);
            this.Boton_Alta.TabIndex = 18;
            this.Boton_Alta.Text = "Agregar";
            this.Boton_Alta.UseVisualStyleBackColor = false;
            this.Boton_Alta.Click += new System.EventHandler(this.Boton_Alta_Click);
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(8, 26);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(44, 13);
            this.Nombre.TabIndex = 22;
            this.Nombre.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Stock";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Graduacion Alcoholica";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(328, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Precio";
            // 
            // ComboBox_Envases
            // 
            this.ComboBox_Envases.Enabled = false;
            this.ComboBox_Envases.FormattingEnabled = true;
            this.ComboBox_Envases.Location = new System.Drawing.Point(256, 45);
            this.ComboBox_Envases.Name = "ComboBox_Envases";
            this.ComboBox_Envases.Size = new System.Drawing.Size(209, 21);
            this.ComboBox_Envases.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(253, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Tipo de envase";
            // 
            // ComboBox_Marca
            // 
            this.ComboBox_Marca.Enabled = false;
            this.ComboBox_Marca.FormattingEnabled = true;
            this.ComboBox_Marca.Location = new System.Drawing.Point(496, 45);
            this.ComboBox_Marca.Name = "ComboBox_Marca";
            this.ComboBox_Marca.Size = new System.Drawing.Size(164, 21);
            this.ComboBox_Marca.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(493, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Marca";
            // 
            // RadioButton_Activo
            // 
            this.RadioButton_Activo.AutoSize = true;
            this.RadioButton_Activo.Checked = true;
            this.RadioButton_Activo.Enabled = false;
            this.RadioButton_Activo.Location = new System.Drawing.Point(13, 10);
            this.RadioButton_Activo.Name = "RadioButton_Activo";
            this.RadioButton_Activo.Size = new System.Drawing.Size(55, 17);
            this.RadioButton_Activo.TabIndex = 38;
            this.RadioButton_Activo.TabStop = true;
            this.RadioButton_Activo.Text = "Activo";
            this.RadioButton_Activo.UseVisualStyleBackColor = true;
            // 
            // RadioButton_Inactivo
            // 
            this.RadioButton_Inactivo.AutoSize = true;
            this.RadioButton_Inactivo.Enabled = false;
            this.RadioButton_Inactivo.Location = new System.Drawing.Point(13, 39);
            this.RadioButton_Inactivo.Name = "RadioButton_Inactivo";
            this.RadioButton_Inactivo.Size = new System.Drawing.Size(63, 17);
            this.RadioButton_Inactivo.TabIndex = 39;
            this.RadioButton_Inactivo.TabStop = true;
            this.RadioButton_Inactivo.Text = "Inactivo";
            this.RadioButton_Inactivo.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(174)))), ((int)(((byte)(228)))));
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ComboBox_Marca);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.ComboBox_Envases);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.UC_ValPrecio);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.UC_ValStock);
            this.groupBox1.Controls.Add(this.UC_ValGraduacion);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Nombre);
            this.groupBox1.Controls.Add(this.UC_ValNomb);
            this.groupBox1.Location = new System.Drawing.Point(12, 391);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(675, 158);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de las bebidas";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RadioButton_Inactivo);
            this.groupBox2.Controls.Add(this.RadioButton_Activo);
            this.groupBox2.Location = new System.Drawing.Point(496, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(84, 64);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(99, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "%";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(174)))), ((int)(((byte)(228)))));
            this.groupBox3.Controls.Add(this.Boton_Modificar);
            this.groupBox3.Controls.Add(this.Boton_Baja);
            this.groupBox3.Controls.Add(this.Boton_Alta);
            this.groupBox3.Location = new System.Drawing.Point(855, 121);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(117, 158);
            this.groupBox3.TabIndex = 41;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Acciones";
            // 
            // Boton_Cancelar
            // 
            this.Boton_Cancelar.BackColor = System.Drawing.Color.Linen;
            this.Boton_Cancelar.Enabled = false;
            this.Boton_Cancelar.Location = new System.Drawing.Point(698, 484);
            this.Boton_Cancelar.Name = "Boton_Cancelar";
            this.Boton_Cancelar.Size = new System.Drawing.Size(75, 34);
            this.Boton_Cancelar.TabIndex = 88;
            this.Boton_Cancelar.Text = "Cancelar";
            this.Boton_Cancelar.UseVisualStyleBackColor = false;
            this.Boton_Cancelar.Click += new System.EventHandler(this.Boton_Cancelar_Click);
            // 
            // Boton_ConfDatBebidas
            // 
            this.Boton_ConfDatBebidas.BackColor = System.Drawing.Color.Honeydew;
            this.Boton_ConfDatBebidas.Enabled = false;
            this.Boton_ConfDatBebidas.Location = new System.Drawing.Point(698, 424);
            this.Boton_ConfDatBebidas.Name = "Boton_ConfDatBebidas";
            this.Boton_ConfDatBebidas.Size = new System.Drawing.Size(75, 50);
            this.Boton_ConfDatBebidas.TabIndex = 87;
            this.Boton_ConfDatBebidas.Text = "Confirmar datos de la bebida";
            this.Boton_ConfDatBebidas.UseVisualStyleBackColor = false;
            this.Boton_ConfDatBebidas.Click += new System.EventHandler(this.Boton_ConfDatBebidas_Click);
            // 
            // UC_ValPrecio
            // 
            this.UC_ValPrecio.Enabled = false;
            this.UC_ValPrecio.Location = new System.Drawing.Point(331, 109);
            this.UC_ValPrecio.Name = "UC_ValPrecio";
            this.UC_ValPrecio.Size = new System.Drawing.Size(100, 20);
            this.UC_ValPrecio.TabIndex = 32;
            // 
            // UC_ValStock
            // 
            this.UC_ValStock.Enabled = false;
            this.UC_ValStock.Location = new System.Drawing.Point(177, 109);
            this.UC_ValStock.Name = "UC_ValStock";
            this.UC_ValStock.Size = new System.Drawing.Size(100, 20);
            this.UC_ValStock.TabIndex = 30;
            // 
            // UC_ValGraduacion
            // 
            this.UC_ValGraduacion.Enabled = false;
            this.UC_ValGraduacion.Location = new System.Drawing.Point(11, 109);
            this.UC_ValGraduacion.Name = "UC_ValGraduacion";
            this.UC_ValGraduacion.Size = new System.Drawing.Size(82, 20);
            this.UC_ValGraduacion.TabIndex = 29;
            // 
            // UC_ValNomb
            // 
            this.UC_ValNomb.Enabled = false;
            this.UC_ValNomb.Location = new System.Drawing.Point(11, 45);
            this.UC_ValNomb.Name = "UC_ValNomb";
            this.UC_ValNomb.Size = new System.Drawing.Size(211, 20);
            this.UC_ValNomb.TabIndex = 21;
            // 
            // GUI_Gerente_Bebidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.BackgroundImage = global::TrabajoFinal.Properties.Resources.BlueShade2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.Boton_Cancelar);
            this.Controls.Add(this.Boton_ConfDatBebidas);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Grilla_Bebidas);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "GUI_Gerente_Bebidas";
            this.Text = "GUI_AdminBebidas";
            this.Load += new System.EventHandler(this.GUI_AdminBebidas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grilla_Bebidas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Grilla_Bebidas;
        private System.Windows.Forms.Button Boton_Modificar;
        private System.Windows.Forms.Button Boton_Baja;
        private System.Windows.Forms.Button Boton_Alta;
        private System.Windows.Forms.Label Nombre;
        private UC_ValNombApe UC_ValNomb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private UC_ValCod UC_ValGraduacion;
        private UC_ValCod UC_ValStock;
        private UC_ValCod UC_ValPrecio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ComboBox_Envases;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ComboBox_Marca;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton RadioButton_Activo;
        private System.Windows.Forms.RadioButton RadioButton_Inactivo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Boton_Cancelar;
        private System.Windows.Forms.Button Boton_ConfDatBebidas;
    }
}
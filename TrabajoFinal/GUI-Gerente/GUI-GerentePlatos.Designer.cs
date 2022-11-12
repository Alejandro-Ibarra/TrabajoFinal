
namespace TrabajoFinal
{
    partial class GUI_Gerente_Platos
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
            this.Boton_Alta = new System.Windows.Forms.Button();
            this.ComboBox_TipoPlato = new System.Windows.Forms.ComboBox();
            this.ComboBox_ClasePlato = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DataGridView_TodosIngredientes = new System.Windows.Forms.DataGridView();
            this.DataGridView_SeleccionIngredientes = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_TodosIngredientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_SeleccionIngredientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Boton_Alta
            // 
            this.Boton_Alta.Location = new System.Drawing.Point(289, 26);
            this.Boton_Alta.Name = "Boton_Alta";
            this.Boton_Alta.Size = new System.Drawing.Size(107, 23);
            this.Boton_Alta.TabIndex = 0;
            this.Boton_Alta.Text = "Alta de platos";
            this.Boton_Alta.UseVisualStyleBackColor = true;
            this.Boton_Alta.Click += new System.EventHandler(this.Boton_Alta_Click);
            // 
            // ComboBox_TipoPlato
            // 
            this.ComboBox_TipoPlato.FormattingEnabled = true;
            this.ComboBox_TipoPlato.Location = new System.Drawing.Point(29, 89);
            this.ComboBox_TipoPlato.Name = "ComboBox_TipoPlato";
            this.ComboBox_TipoPlato.Size = new System.Drawing.Size(121, 21);
            this.ComboBox_TipoPlato.TabIndex = 1;
            this.ComboBox_TipoPlato.Visible = false;
            // 
            // ComboBox_ClasePlato
            // 
            this.ComboBox_ClasePlato.FormattingEnabled = true;
            this.ComboBox_ClasePlato.Location = new System.Drawing.Point(207, 92);
            this.ComboBox_ClasePlato.Name = "ComboBox_ClasePlato";
            this.ComboBox_ClasePlato.Size = new System.Drawing.Size(121, 21);
            this.ComboBox_ClasePlato.TabIndex = 2;
            this.ComboBox_ClasePlato.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tipo de plato";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Clase de plato";
            // 
            // DataGridView_TodosIngredientes
            // 
            this.DataGridView_TodosIngredientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_TodosIngredientes.Location = new System.Drawing.Point(29, 142);
            this.DataGridView_TodosIngredientes.Name = "DataGridView_TodosIngredientes";
            this.DataGridView_TodosIngredientes.Size = new System.Drawing.Size(425, 193);
            this.DataGridView_TodosIngredientes.TabIndex = 5;
            this.DataGridView_TodosIngredientes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DataGridView_TodosIngredientes_MouseClick);
            // 
            // DataGridView_SeleccionIngredientes
            // 
            this.DataGridView_SeleccionIngredientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_SeleccionIngredientes.Location = new System.Drawing.Point(514, 142);
            this.DataGridView_SeleccionIngredientes.Name = "DataGridView_SeleccionIngredientes";
            this.DataGridView_SeleccionIngredientes.Size = new System.Drawing.Size(418, 193);
            this.DataGridView_SeleccionIngredientes.TabIndex = 6;
            this.DataGridView_SeleccionIngredientes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DataGridView_SeleccionIngredientes_MouseClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(514, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 372);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(418, 193);
            this.dataGridView1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ingredientes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(511, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Ingredientes seleccionados";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 356);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Platos";
            // 
            // GUI_Gerente_Platos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 591);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DataGridView_SeleccionIngredientes);
            this.Controls.Add(this.DataGridView_TodosIngredientes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ComboBox_ClasePlato);
            this.Controls.Add(this.ComboBox_TipoPlato);
            this.Controls.Add(this.Boton_Alta);
            this.Name = "GUI_Gerente_Platos";
            this.Text = "GUI_AdminPlatos";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_TodosIngredientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_SeleccionIngredientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Boton_Alta;
        private System.Windows.Forms.ComboBox ComboBox_TipoPlato;
        private System.Windows.Forms.ComboBox ComboBox_ClasePlato;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DataGridView_TodosIngredientes;
        private System.Windows.Forms.DataGridView DataGridView_SeleccionIngredientes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

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
            this.Label_TipoPlato = new System.Windows.Forms.Label();
            this.Label_ClasePlato = new System.Windows.Forms.Label();
            this.DataGridView_TodosIngredientes = new System.Windows.Forms.DataGridView();
            this.DataGridView_SeleccionIngredientes = new System.Windows.Forms.DataGridView();
            this.Boton_Guardar = new System.Windows.Forms.Button();
            this.DataGridView_Platos = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label_GrillaSeleccionados = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Boton_ConfirmarPrecio = new System.Windows.Forms.Button();
            this.Boton_ContinuarTipoPlato = new System.Windows.Forms.Button();
            this.Boton_ContinuarClasePlato = new System.Windows.Forms.Button();
            this.Boton_ConfirmalIngPrincipal = new System.Windows.Forms.Button();
            this.Boton_ConfirmarIngredientes = new System.Windows.Forms.Button();
            this.TextBox_Precio = new System.Windows.Forms.TextBox();
            this.ComboBox_IngredientePrincipal = new System.Windows.Forms.ComboBox();
            this.TextBox_Resumen = new System.Windows.Forms.TextBox();
            this.Boton_ModificarPlatos = new System.Windows.Forms.Button();
            this.Boton_EliminarPlato = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_TodosIngredientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_SeleccionIngredientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Platos)).BeginInit();
            this.SuspendLayout();
            // 
            // Boton_Alta
            // 
            this.Boton_Alta.Location = new System.Drawing.Point(62, 23);
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
            this.ComboBox_ClasePlato.Location = new System.Drawing.Point(377, 89);
            this.ComboBox_ClasePlato.Name = "ComboBox_ClasePlato";
            this.ComboBox_ClasePlato.Size = new System.Drawing.Size(121, 21);
            this.ComboBox_ClasePlato.TabIndex = 2;
            this.ComboBox_ClasePlato.Visible = false;
            // 
            // Label_TipoPlato
            // 
            this.Label_TipoPlato.AutoSize = true;
            this.Label_TipoPlato.Location = new System.Drawing.Point(26, 67);
            this.Label_TipoPlato.Name = "Label_TipoPlato";
            this.Label_TipoPlato.Size = new System.Drawing.Size(69, 13);
            this.Label_TipoPlato.TabIndex = 3;
            this.Label_TipoPlato.Text = "Tipo de plato";
            this.Label_TipoPlato.Visible = false;
            // 
            // Label_ClasePlato
            // 
            this.Label_ClasePlato.AutoSize = true;
            this.Label_ClasePlato.Location = new System.Drawing.Point(374, 64);
            this.Label_ClasePlato.Name = "Label_ClasePlato";
            this.Label_ClasePlato.Size = new System.Drawing.Size(74, 13);
            this.Label_ClasePlato.TabIndex = 4;
            this.Label_ClasePlato.Text = "Clase de plato";
            this.Label_ClasePlato.Visible = false;
            // 
            // DataGridView_TodosIngredientes
            // 
            this.DataGridView_TodosIngredientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_TodosIngredientes.Location = new System.Drawing.Point(29, 142);
            this.DataGridView_TodosIngredientes.MultiSelect = false;
            this.DataGridView_TodosIngredientes.Name = "DataGridView_TodosIngredientes";
            this.DataGridView_TodosIngredientes.ReadOnly = true;
            this.DataGridView_TodosIngredientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView_TodosIngredientes.Size = new System.Drawing.Size(425, 193);
            this.DataGridView_TodosIngredientes.TabIndex = 5;
            this.DataGridView_TodosIngredientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_TodosIngredientes_CellContentClick);
            this.DataGridView_TodosIngredientes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DataGridView_TodosIngredientes_MouseClick);
            // 
            // DataGridView_SeleccionIngredientes
            // 
            this.DataGridView_SeleccionIngredientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_SeleccionIngredientes.Location = new System.Drawing.Point(514, 142);
            this.DataGridView_SeleccionIngredientes.MultiSelect = false;
            this.DataGridView_SeleccionIngredientes.Name = "DataGridView_SeleccionIngredientes";
            this.DataGridView_SeleccionIngredientes.ReadOnly = true;
            this.DataGridView_SeleccionIngredientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView_SeleccionIngredientes.Size = new System.Drawing.Size(418, 193);
            this.DataGridView_SeleccionIngredientes.TabIndex = 6;
            this.DataGridView_SeleccionIngredientes.Visible = false;
            this.DataGridView_SeleccionIngredientes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DataGridView_SeleccionIngredientes_MouseClick);
            // 
            // Boton_Guardar
            // 
            this.Boton_Guardar.Location = new System.Drawing.Point(825, 556);
            this.Boton_Guardar.Name = "Boton_Guardar";
            this.Boton_Guardar.Size = new System.Drawing.Size(107, 23);
            this.Boton_Guardar.TabIndex = 7;
            this.Boton_Guardar.Text = "Guardar Plato";
            this.Boton_Guardar.UseVisualStyleBackColor = true;
            this.Boton_Guardar.Visible = false;
            this.Boton_Guardar.Click += new System.EventHandler(this.Button_Guardar_Click);
            // 
            // DataGridView_Platos
            // 
            this.DataGridView_Platos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_Platos.Location = new System.Drawing.Point(29, 372);
            this.DataGridView_Platos.MultiSelect = false;
            this.DataGridView_Platos.Name = "DataGridView_Platos";
            this.DataGridView_Platos.ReadOnly = true;
            this.DataGridView_Platos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView_Platos.Size = new System.Drawing.Size(425, 193);
            this.DataGridView_Platos.TabIndex = 9;
            this.DataGridView_Platos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DataGridView_Platos_MouseClick);
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
            // label_GrillaSeleccionados
            // 
            this.label_GrillaSeleccionados.AutoSize = true;
            this.label_GrillaSeleccionados.Location = new System.Drawing.Point(511, 126);
            this.label_GrillaSeleccionados.Name = "label_GrillaSeleccionados";
            this.label_GrillaSeleccionados.Size = new System.Drawing.Size(136, 13);
            this.label_GrillaSeleccionados.TabIndex = 11;
            this.label_GrillaSeleccionados.Text = "Ingredientes seleccionados";
            this.label_GrillaSeleccionados.Visible = false;
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
            // Boton_ConfirmarPrecio
            // 
            this.Boton_ConfirmarPrecio.Location = new System.Drawing.Point(616, 386);
            this.Boton_ConfirmarPrecio.Name = "Boton_ConfirmarPrecio";
            this.Boton_ConfirmarPrecio.Size = new System.Drawing.Size(120, 23);
            this.Boton_ConfirmarPrecio.TabIndex = 13;
            this.Boton_ConfirmarPrecio.Text = "Confirmar Precio";
            this.Boton_ConfirmarPrecio.UseVisualStyleBackColor = true;
            this.Boton_ConfirmarPrecio.Visible = false;
            this.Boton_ConfirmarPrecio.Click += new System.EventHandler(this.Boton_ConfirmarPrecio_Click);
            // 
            // Boton_ContinuarTipoPlato
            // 
            this.Boton_ContinuarTipoPlato.Location = new System.Drawing.Point(171, 87);
            this.Boton_ContinuarTipoPlato.Name = "Boton_ContinuarTipoPlato";
            this.Boton_ContinuarTipoPlato.Size = new System.Drawing.Size(87, 23);
            this.Boton_ContinuarTipoPlato.TabIndex = 14;
            this.Boton_ContinuarTipoPlato.Text = "Continuar";
            this.Boton_ContinuarTipoPlato.UseVisualStyleBackColor = true;
            this.Boton_ContinuarTipoPlato.Visible = false;
            this.Boton_ContinuarTipoPlato.Click += new System.EventHandler(this.Boton_ContinuarTipoPlato_Click);
            // 
            // Boton_ContinuarClasePlato
            // 
            this.Boton_ContinuarClasePlato.Location = new System.Drawing.Point(514, 87);
            this.Boton_ContinuarClasePlato.Name = "Boton_ContinuarClasePlato";
            this.Boton_ContinuarClasePlato.Size = new System.Drawing.Size(87, 23);
            this.Boton_ContinuarClasePlato.TabIndex = 15;
            this.Boton_ContinuarClasePlato.Text = "Continuar";
            this.Boton_ContinuarClasePlato.UseVisualStyleBackColor = true;
            this.Boton_ContinuarClasePlato.Visible = false;
            this.Boton_ContinuarClasePlato.Click += new System.EventHandler(this.Boton_ContinuarClasePlato_Click);
            // 
            // Boton_ConfirmalIngPrincipal
            // 
            this.Boton_ConfirmalIngPrincipal.Location = new System.Drawing.Point(616, 358);
            this.Boton_ConfirmalIngPrincipal.Name = "Boton_ConfirmalIngPrincipal";
            this.Boton_ConfirmalIngPrincipal.Size = new System.Drawing.Size(157, 23);
            this.Boton_ConfirmalIngPrincipal.TabIndex = 16;
            this.Boton_ConfirmalIngPrincipal.Text = "Confirmar ingrediente principal";
            this.Boton_ConfirmalIngPrincipal.UseVisualStyleBackColor = true;
            this.Boton_ConfirmalIngPrincipal.Visible = false;
            this.Boton_ConfirmalIngPrincipal.Click += new System.EventHandler(this.Boton_ConfirmalIngPrincipal_Click);
            // 
            // Boton_ConfirmarIngredientes
            // 
            this.Boton_ConfirmarIngredientes.Location = new System.Drawing.Point(653, 116);
            this.Boton_ConfirmarIngredientes.Name = "Boton_ConfirmarIngredientes";
            this.Boton_ConfirmarIngredientes.Size = new System.Drawing.Size(120, 23);
            this.Boton_ConfirmarIngredientes.TabIndex = 17;
            this.Boton_ConfirmarIngredientes.Text = "Confirmar Ingredientes";
            this.Boton_ConfirmarIngredientes.UseVisualStyleBackColor = true;
            this.Boton_ConfirmarIngredientes.Visible = false;
            this.Boton_ConfirmarIngredientes.Click += new System.EventHandler(this.Boton_ConfirmarIngredientes_Click);
            // 
            // TextBox_Precio
            // 
            this.TextBox_Precio.Location = new System.Drawing.Point(467, 386);
            this.TextBox_Precio.Name = "TextBox_Precio";
            this.TextBox_Precio.Size = new System.Drawing.Size(121, 20);
            this.TextBox_Precio.TabIndex = 18;
            this.TextBox_Precio.Visible = false;
            // 
            // ComboBox_IngredientePrincipal
            // 
            this.ComboBox_IngredientePrincipal.FormattingEnabled = true;
            this.ComboBox_IngredientePrincipal.Location = new System.Drawing.Point(467, 358);
            this.ComboBox_IngredientePrincipal.Name = "ComboBox_IngredientePrincipal";
            this.ComboBox_IngredientePrincipal.Size = new System.Drawing.Size(121, 21);
            this.ComboBox_IngredientePrincipal.TabIndex = 19;
            this.ComboBox_IngredientePrincipal.Visible = false;
            // 
            // TextBox_Resumen
            // 
            this.TextBox_Resumen.Location = new System.Drawing.Point(467, 415);
            this.TextBox_Resumen.Multiline = true;
            this.TextBox_Resumen.Name = "TextBox_Resumen";
            this.TextBox_Resumen.Size = new System.Drawing.Size(474, 135);
            this.TextBox_Resumen.TabIndex = 20;
            this.TextBox_Resumen.Visible = false;
            // 
            // Boton_ModificarPlatos
            // 
            this.Boton_ModificarPlatos.Location = new System.Drawing.Point(215, 23);
            this.Boton_ModificarPlatos.Name = "Boton_ModificarPlatos";
            this.Boton_ModificarPlatos.Size = new System.Drawing.Size(107, 23);
            this.Boton_ModificarPlatos.TabIndex = 21;
            this.Boton_ModificarPlatos.Text = "Modificar  platos";
            this.Boton_ModificarPlatos.UseVisualStyleBackColor = true;
            this.Boton_ModificarPlatos.Click += new System.EventHandler(this.Boton_ModificarPlatos_Click);
            // 
            // Boton_EliminarPlato
            // 
            this.Boton_EliminarPlato.Location = new System.Drawing.Point(377, 23);
            this.Boton_EliminarPlato.Name = "Boton_EliminarPlato";
            this.Boton_EliminarPlato.Size = new System.Drawing.Size(107, 23);
            this.Boton_EliminarPlato.TabIndex = 22;
            this.Boton_EliminarPlato.Text = "Eliminar Plato";
            this.Boton_EliminarPlato.UseVisualStyleBackColor = true;
            this.Boton_EliminarPlato.Click += new System.EventHandler(this.Boton_EliminarPlato_Click);
            // 
            // GUI_Gerente_Platos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 591);
            this.Controls.Add(this.Boton_EliminarPlato);
            this.Controls.Add(this.Boton_ModificarPlatos);
            this.Controls.Add(this.TextBox_Resumen);
            this.Controls.Add(this.ComboBox_IngredientePrincipal);
            this.Controls.Add(this.TextBox_Precio);
            this.Controls.Add(this.Boton_ConfirmarIngredientes);
            this.Controls.Add(this.Boton_ConfirmalIngPrincipal);
            this.Controls.Add(this.Boton_ContinuarClasePlato);
            this.Controls.Add(this.Boton_ContinuarTipoPlato);
            this.Controls.Add(this.Boton_ConfirmarPrecio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_GrillaSeleccionados);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DataGridView_Platos);
            this.Controls.Add(this.Boton_Guardar);
            this.Controls.Add(this.DataGridView_SeleccionIngredientes);
            this.Controls.Add(this.DataGridView_TodosIngredientes);
            this.Controls.Add(this.Label_ClasePlato);
            this.Controls.Add(this.Label_TipoPlato);
            this.Controls.Add(this.ComboBox_ClasePlato);
            this.Controls.Add(this.ComboBox_TipoPlato);
            this.Controls.Add(this.Boton_Alta);
            this.Name = "GUI_Gerente_Platos";
            this.Text = "GUI_AdminPlatos";
            this.Load += new System.EventHandler(this.GUI_Gerente_Platos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_TodosIngredientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_SeleccionIngredientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Platos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Boton_Alta;
        private System.Windows.Forms.ComboBox ComboBox_TipoPlato;
        private System.Windows.Forms.ComboBox ComboBox_ClasePlato;
        private System.Windows.Forms.Label Label_TipoPlato;
        private System.Windows.Forms.Label Label_ClasePlato;
        private System.Windows.Forms.DataGridView DataGridView_TodosIngredientes;
        private System.Windows.Forms.DataGridView DataGridView_SeleccionIngredientes;
        private System.Windows.Forms.Button Boton_Guardar;
        private System.Windows.Forms.DataGridView DataGridView_Platos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_GrillaSeleccionados;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Boton_ConfirmarPrecio;
        private System.Windows.Forms.Button Boton_ContinuarTipoPlato;
        private System.Windows.Forms.Button Boton_ContinuarClasePlato;
        private System.Windows.Forms.Button Boton_ConfirmalIngPrincipal;
        private System.Windows.Forms.Button Boton_ConfirmarIngredientes;
        private System.Windows.Forms.TextBox TextBox_Precio;
        private System.Windows.Forms.ComboBox ComboBox_IngredientePrincipal;
        private System.Windows.Forms.TextBox TextBox_Resumen;
        private System.Windows.Forms.Button Boton_ModificarPlatos;
        private System.Windows.Forms.Button Boton_EliminarPlato;
    }
}

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
            this.label3 = new System.Windows.Forms.Label();
            this.label_GrillaSeleccionados = new System.Windows.Forms.Label();
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
            this.RadioButton_Activo = new System.Windows.Forms.RadioButton();
            this.RadioButton_Inactivo = new System.Windows.Forms.RadioButton();
            this.DataGridView_Platos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Boton_Cancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_TodosIngredientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_SeleccionIngredientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Platos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Boton_Alta
            // 
            this.Boton_Alta.BackColor = System.Drawing.Color.Honeydew;
            this.Boton_Alta.Location = new System.Drawing.Point(20, 23);
            this.Boton_Alta.Name = "Boton_Alta";
            this.Boton_Alta.Size = new System.Drawing.Size(70, 35);
            this.Boton_Alta.TabIndex = 0;
            this.Boton_Alta.Text = "Agregar";
            this.Boton_Alta.UseVisualStyleBackColor = false;
            this.Boton_Alta.Click += new System.EventHandler(this.Boton_Alta_Click);
            // 
            // ComboBox_TipoPlato
            // 
            this.ComboBox_TipoPlato.FormattingEnabled = true;
            this.ComboBox_TipoPlato.Location = new System.Drawing.Point(23, 255);
            this.ComboBox_TipoPlato.Name = "ComboBox_TipoPlato";
            this.ComboBox_TipoPlato.Size = new System.Drawing.Size(121, 21);
            this.ComboBox_TipoPlato.TabIndex = 1;
            this.ComboBox_TipoPlato.Visible = false;
            // 
            // ComboBox_ClasePlato
            // 
            this.ComboBox_ClasePlato.FormattingEnabled = true;
            this.ComboBox_ClasePlato.Location = new System.Drawing.Point(235, 255);
            this.ComboBox_ClasePlato.Name = "ComboBox_ClasePlato";
            this.ComboBox_ClasePlato.Size = new System.Drawing.Size(121, 21);
            this.ComboBox_ClasePlato.TabIndex = 2;
            this.ComboBox_ClasePlato.Visible = false;
            // 
            // Label_TipoPlato
            // 
            this.Label_TipoPlato.AutoSize = true;
            this.Label_TipoPlato.BackColor = System.Drawing.Color.Transparent;
            this.Label_TipoPlato.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label_TipoPlato.Location = new System.Drawing.Point(20, 237);
            this.Label_TipoPlato.Name = "Label_TipoPlato";
            this.Label_TipoPlato.Size = new System.Drawing.Size(69, 13);
            this.Label_TipoPlato.TabIndex = 3;
            this.Label_TipoPlato.Text = "Tipo de plato";
            this.Label_TipoPlato.Visible = false;
            // 
            // Label_ClasePlato
            // 
            this.Label_ClasePlato.AutoSize = true;
            this.Label_ClasePlato.BackColor = System.Drawing.Color.Transparent;
            this.Label_ClasePlato.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label_ClasePlato.Location = new System.Drawing.Point(232, 237);
            this.Label_ClasePlato.Name = "Label_ClasePlato";
            this.Label_ClasePlato.Size = new System.Drawing.Size(74, 13);
            this.Label_ClasePlato.TabIndex = 4;
            this.Label_ClasePlato.Text = "Clase de plato";
            this.Label_ClasePlato.Visible = false;
            // 
            // DataGridView_TodosIngredientes
            // 
            this.DataGridView_TodosIngredientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView_TodosIngredientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_TodosIngredientes.Location = new System.Drawing.Point(23, 312);
            this.DataGridView_TodosIngredientes.MultiSelect = false;
            this.DataGridView_TodosIngredientes.Name = "DataGridView_TodosIngredientes";
            this.DataGridView_TodosIngredientes.ReadOnly = true;
            this.DataGridView_TodosIngredientes.RowHeadersVisible = false;
            this.DataGridView_TodosIngredientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView_TodosIngredientes.Size = new System.Drawing.Size(225, 185);
            this.DataGridView_TodosIngredientes.TabIndex = 5;
            this.DataGridView_TodosIngredientes.Visible = false;
            this.DataGridView_TodosIngredientes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DataGridView_TodosIngredientes_MouseClick);
            // 
            // DataGridView_SeleccionIngredientes
            // 
            this.DataGridView_SeleccionIngredientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView_SeleccionIngredientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_SeleccionIngredientes.Location = new System.Drawing.Point(299, 312);
            this.DataGridView_SeleccionIngredientes.MultiSelect = false;
            this.DataGridView_SeleccionIngredientes.Name = "DataGridView_SeleccionIngredientes";
            this.DataGridView_SeleccionIngredientes.ReadOnly = true;
            this.DataGridView_SeleccionIngredientes.RowHeadersVisible = false;
            this.DataGridView_SeleccionIngredientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView_SeleccionIngredientes.Size = new System.Drawing.Size(211, 193);
            this.DataGridView_SeleccionIngredientes.TabIndex = 6;
            this.DataGridView_SeleccionIngredientes.Visible = false;
            this.DataGridView_SeleccionIngredientes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DataGridView_SeleccionIngredientes_MouseClick);
            // 
            // Boton_Guardar
            // 
            this.Boton_Guardar.BackColor = System.Drawing.Color.Honeydew;
            this.Boton_Guardar.Location = new System.Drawing.Point(769, 502);
            this.Boton_Guardar.Name = "Boton_Guardar";
            this.Boton_Guardar.Size = new System.Drawing.Size(88, 47);
            this.Boton_Guardar.TabIndex = 7;
            this.Boton_Guardar.Text = "Confirmar datos del plato";
            this.Boton_Guardar.UseVisualStyleBackColor = false;
            this.Boton_Guardar.Visible = false;
            this.Boton_Guardar.Click += new System.EventHandler(this.Button_Guardar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(24, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ingredientes";
            this.label3.Visible = false;
            // 
            // label_GrillaSeleccionados
            // 
            this.label_GrillaSeleccionados.AutoSize = true;
            this.label_GrillaSeleccionados.BackColor = System.Drawing.Color.Transparent;
            this.label_GrillaSeleccionados.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_GrillaSeleccionados.Location = new System.Drawing.Point(300, 293);
            this.label_GrillaSeleccionados.Name = "label_GrillaSeleccionados";
            this.label_GrillaSeleccionados.Size = new System.Drawing.Size(136, 13);
            this.label_GrillaSeleccionados.TabIndex = 11;
            this.label_GrillaSeleccionados.Text = "Ingredientes seleccionados";
            this.label_GrillaSeleccionados.Visible = false;
            // 
            // Boton_ConfirmarPrecio
            // 
            this.Boton_ConfirmarPrecio.BackColor = System.Drawing.Color.AliceBlue;
            this.Boton_ConfirmarPrecio.Location = new System.Drawing.Point(597, 281);
            this.Boton_ConfirmarPrecio.Name = "Boton_ConfirmarPrecio";
            this.Boton_ConfirmarPrecio.Size = new System.Drawing.Size(120, 23);
            this.Boton_ConfirmarPrecio.TabIndex = 13;
            this.Boton_ConfirmarPrecio.Text = "Confirmar Precio";
            this.Boton_ConfirmarPrecio.UseVisualStyleBackColor = false;
            this.Boton_ConfirmarPrecio.Visible = false;
            this.Boton_ConfirmarPrecio.Click += new System.EventHandler(this.Boton_ConfirmarPrecio_Click);
            // 
            // Boton_ContinuarTipoPlato
            // 
            this.Boton_ContinuarTipoPlato.BackColor = System.Drawing.Color.AliceBlue;
            this.Boton_ContinuarTipoPlato.Location = new System.Drawing.Point(150, 253);
            this.Boton_ContinuarTipoPlato.Name = "Boton_ContinuarTipoPlato";
            this.Boton_ContinuarTipoPlato.Size = new System.Drawing.Size(62, 23);
            this.Boton_ContinuarTipoPlato.TabIndex = 14;
            this.Boton_ContinuarTipoPlato.Text = "Continuar";
            this.Boton_ContinuarTipoPlato.UseVisualStyleBackColor = false;
            this.Boton_ContinuarTipoPlato.Visible = false;
            this.Boton_ContinuarTipoPlato.Click += new System.EventHandler(this.Boton_ContinuarTipoPlato_Click);
            // 
            // Boton_ContinuarClasePlato
            // 
            this.Boton_ContinuarClasePlato.BackColor = System.Drawing.Color.AliceBlue;
            this.Boton_ContinuarClasePlato.Location = new System.Drawing.Point(362, 251);
            this.Boton_ContinuarClasePlato.Name = "Boton_ContinuarClasePlato";
            this.Boton_ContinuarClasePlato.Size = new System.Drawing.Size(62, 23);
            this.Boton_ContinuarClasePlato.TabIndex = 15;
            this.Boton_ContinuarClasePlato.Text = "Continuar";
            this.Boton_ContinuarClasePlato.UseVisualStyleBackColor = false;
            this.Boton_ContinuarClasePlato.Visible = false;
            this.Boton_ContinuarClasePlato.Click += new System.EventHandler(this.Boton_ContinuarClasePlato_Click);
            // 
            // Boton_ConfirmalIngPrincipal
            // 
            this.Boton_ConfirmalIngPrincipal.BackColor = System.Drawing.Color.AliceBlue;
            this.Boton_ConfirmalIngPrincipal.Location = new System.Drawing.Point(597, 253);
            this.Boton_ConfirmalIngPrincipal.Name = "Boton_ConfirmalIngPrincipal";
            this.Boton_ConfirmalIngPrincipal.Size = new System.Drawing.Size(157, 23);
            this.Boton_ConfirmalIngPrincipal.TabIndex = 16;
            this.Boton_ConfirmalIngPrincipal.Text = "Confirmar ingrediente principal";
            this.Boton_ConfirmalIngPrincipal.UseVisualStyleBackColor = false;
            this.Boton_ConfirmalIngPrincipal.Visible = false;
            this.Boton_ConfirmalIngPrincipal.Click += new System.EventHandler(this.Boton_ConfirmalIngPrincipal_Click);
            // 
            // Boton_ConfirmarIngredientes
            // 
            this.Boton_ConfirmarIngredientes.BackColor = System.Drawing.Color.AliceBlue;
            this.Boton_ConfirmarIngredientes.Location = new System.Drawing.Point(390, 526);
            this.Boton_ConfirmarIngredientes.Name = "Boton_ConfirmarIngredientes";
            this.Boton_ConfirmarIngredientes.Size = new System.Drawing.Size(120, 23);
            this.Boton_ConfirmarIngredientes.TabIndex = 17;
            this.Boton_ConfirmarIngredientes.Text = "Confirmar Ingredientes";
            this.Boton_ConfirmarIngredientes.UseVisualStyleBackColor = false;
            this.Boton_ConfirmarIngredientes.Visible = false;
            this.Boton_ConfirmarIngredientes.Click += new System.EventHandler(this.Boton_ConfirmarIngredientes_Click);
            // 
            // TextBox_Precio
            // 
            this.TextBox_Precio.Location = new System.Drawing.Point(448, 281);
            this.TextBox_Precio.Name = "TextBox_Precio";
            this.TextBox_Precio.Size = new System.Drawing.Size(121, 20);
            this.TextBox_Precio.TabIndex = 18;
            this.TextBox_Precio.Visible = false;
            // 
            // ComboBox_IngredientePrincipal
            // 
            this.ComboBox_IngredientePrincipal.FormattingEnabled = true;
            this.ComboBox_IngredientePrincipal.Location = new System.Drawing.Point(448, 253);
            this.ComboBox_IngredientePrincipal.Name = "ComboBox_IngredientePrincipal";
            this.ComboBox_IngredientePrincipal.Size = new System.Drawing.Size(121, 21);
            this.ComboBox_IngredientePrincipal.TabIndex = 19;
            this.ComboBox_IngredientePrincipal.Visible = false;
            // 
            // TextBox_Resumen
            // 
            this.TextBox_Resumen.Location = new System.Drawing.Point(533, 370);
            this.TextBox_Resumen.Multiline = true;
            this.TextBox_Resumen.Name = "TextBox_Resumen";
            this.TextBox_Resumen.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBox_Resumen.Size = new System.Drawing.Size(380, 107);
            this.TextBox_Resumen.TabIndex = 20;
            this.TextBox_Resumen.Visible = false;
            this.TextBox_Resumen.TextChanged += new System.EventHandler(this.TextBox_Resumen_TextChanged);
            // 
            // Boton_ModificarPlatos
            // 
            this.Boton_ModificarPlatos.BackColor = System.Drawing.Color.LightYellow;
            this.Boton_ModificarPlatos.Location = new System.Drawing.Point(22, 64);
            this.Boton_ModificarPlatos.Name = "Boton_ModificarPlatos";
            this.Boton_ModificarPlatos.Size = new System.Drawing.Size(68, 34);
            this.Boton_ModificarPlatos.TabIndex = 21;
            this.Boton_ModificarPlatos.Text = "Modificar";
            this.Boton_ModificarPlatos.UseVisualStyleBackColor = false;
            this.Boton_ModificarPlatos.Click += new System.EventHandler(this.Boton_ModificarPlatos_Click);
            // 
            // Boton_EliminarPlato
            // 
            this.Boton_EliminarPlato.BackColor = System.Drawing.Color.Linen;
            this.Boton_EliminarPlato.Location = new System.Drawing.Point(22, 104);
            this.Boton_EliminarPlato.Name = "Boton_EliminarPlato";
            this.Boton_EliminarPlato.Size = new System.Drawing.Size(69, 34);
            this.Boton_EliminarPlato.TabIndex = 22;
            this.Boton_EliminarPlato.Text = "Eliminar";
            this.Boton_EliminarPlato.UseVisualStyleBackColor = false;
            this.Boton_EliminarPlato.Click += new System.EventHandler(this.Boton_EliminarPlato_Click);
            // 
            // RadioButton_Activo
            // 
            this.RadioButton_Activo.AutoSize = true;
            this.RadioButton_Activo.Checked = true;
            this.RadioButton_Activo.Location = new System.Drawing.Point(10, 33);
            this.RadioButton_Activo.Name = "RadioButton_Activo";
            this.RadioButton_Activo.Size = new System.Drawing.Size(55, 17);
            this.RadioButton_Activo.TabIndex = 23;
            this.RadioButton_Activo.TabStop = true;
            this.RadioButton_Activo.Text = "Activo";
            this.RadioButton_Activo.UseVisualStyleBackColor = true;
            this.RadioButton_Activo.Visible = false;
            // 
            // RadioButton_Inactivo
            // 
            this.RadioButton_Inactivo.AutoSize = true;
            this.RadioButton_Inactivo.Location = new System.Drawing.Point(10, 56);
            this.RadioButton_Inactivo.Name = "RadioButton_Inactivo";
            this.RadioButton_Inactivo.Size = new System.Drawing.Size(63, 17);
            this.RadioButton_Inactivo.TabIndex = 24;
            this.RadioButton_Inactivo.Text = "Inactivo";
            this.RadioButton_Inactivo.UseVisualStyleBackColor = true;
            this.RadioButton_Inactivo.Visible = false;
            // 
            // DataGridView_Platos
            // 
            this.DataGridView_Platos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView_Platos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_Platos.Cursor = System.Windows.Forms.Cursors.Default;
            this.DataGridView_Platos.Location = new System.Drawing.Point(12, 21);
            this.DataGridView_Platos.MultiSelect = false;
            this.DataGridView_Platos.Name = "DataGridView_Platos";
            this.DataGridView_Platos.ReadOnly = true;
            this.DataGridView_Platos.RowHeadersVisible = false;
            this.DataGridView_Platos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView_Platos.Size = new System.Drawing.Size(826, 177);
            this.DataGridView_Platos.TabIndex = 9;
            this.DataGridView_Platos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DataGridView_Platos_MouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(174)))), ((int)(((byte)(228)))));
            this.groupBox1.Controls.Add(this.RadioButton_Inactivo);
            this.groupBox1.Controls.Add(this.RadioButton_Activo);
            this.groupBox1.Location = new System.Drawing.Point(784, 255);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(81, 80);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estado del Plato";
            this.groupBox1.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(174)))), ((int)(((byte)(228)))));
            this.groupBox2.Controls.Add(this.Boton_EliminarPlato);
            this.groupBox2.Controls.Add(this.Boton_ModificarPlatos);
            this.groupBox2.Controls.Add(this.Boton_Alta);
            this.groupBox2.Location = new System.Drawing.Point(864, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(108, 153);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Acciones";
            // 
            // Boton_Cancelar
            // 
            this.Boton_Cancelar.BackColor = System.Drawing.Color.Linen;
            this.Boton_Cancelar.Location = new System.Drawing.Point(867, 502);
            this.Boton_Cancelar.Name = "Boton_Cancelar";
            this.Boton_Cancelar.Size = new System.Drawing.Size(88, 47);
            this.Boton_Cancelar.TabIndex = 28;
            this.Boton_Cancelar.Text = "Cancelar";
            this.Boton_Cancelar.UseVisualStyleBackColor = false;
            this.Boton_Cancelar.Visible = false;
            this.Boton_Cancelar.Click += new System.EventHandler(this.Boton_Cancelar_Click);
            // 
            // GUI_Gerente_Platos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TrabajoFinal.Properties.Resources.BlueShade2;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.Boton_Cancelar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TextBox_Resumen);
            this.Controls.Add(this.ComboBox_IngredientePrincipal);
            this.Controls.Add(this.TextBox_Precio);
            this.Controls.Add(this.Boton_ConfirmarIngredientes);
            this.Controls.Add(this.Boton_ConfirmalIngPrincipal);
            this.Controls.Add(this.Boton_ContinuarClasePlato);
            this.Controls.Add(this.Boton_ContinuarTipoPlato);
            this.Controls.Add(this.Boton_ConfirmarPrecio);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "GUI_Gerente_Platos";
            this.Text = "GUI_AdminPlatos";
            this.Load += new System.EventHandler(this.GUI_Gerente_Platos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_TodosIngredientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_SeleccionIngredientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Platos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_GrillaSeleccionados;
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
        private System.Windows.Forms.RadioButton RadioButton_Activo;
        private System.Windows.Forms.RadioButton RadioButton_Inactivo;
        private System.Windows.Forms.DataGridView DataGridView_Platos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Boton_Cancelar;
    }
}
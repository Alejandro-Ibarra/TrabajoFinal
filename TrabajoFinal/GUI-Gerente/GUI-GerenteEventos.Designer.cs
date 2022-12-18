
namespace TrabajoFinal
{
    partial class GUI_Gerente_Eventos
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
            this.Calendario = new System.Windows.Forms.MonthCalendar();
            this.ComboBox_Horarios = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Boton_AgregarInvitados = new System.Windows.Forms.Button();
            this.Boton_VerificarDisp = new System.Windows.Forms.Button();
            this.Boton_ConfirmarEvento = new System.Windows.Forms.Button();
            this.Grilla_DeClientes = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.Grilla_Eventos = new System.Windows.Forms.DataGridView();
            this.Boton_EliminarEvento = new System.Windows.Forms.Button();
            this.Boton_ModificarInvitados = new System.Windows.Forms.Button();
            this.Boton_GuardarCambiosListaInv = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.uC_ValCod1 = new TrabajoFinal.UC_ValCod();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.uC_ValNombApe1 = new TrabajoFinal.UC_ValNombApe();
            this.uC_ValidarMail1 = new TrabajoFinal.UC_ValidarMail();
            this.Boton_ModificarEvento = new System.Windows.Forms.Button();
            this.Boton_AgregarEvento = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Boton_Cancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla_DeClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla_Eventos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Calendario
            // 
            this.Calendario.Location = new System.Drawing.Point(5, 28);
            this.Calendario.MaxSelectionCount = 1;
            this.Calendario.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.Calendario.Name = "Calendario";
            this.Calendario.TabIndex = 0;
            // 
            // ComboBox_Horarios
            // 
            this.ComboBox_Horarios.FormattingEnabled = true;
            this.ComboBox_Horarios.Location = new System.Drawing.Point(274, 46);
            this.ComboBox_Horarios.Name = "ComboBox_Horarios";
            this.ComboBox_Horarios.Size = new System.Drawing.Size(95, 21);
            this.ComboBox_Horarios.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(271, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cantidad de personas\r\n(Max 50)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "E-Mail";
            // 
            // Boton_AgregarInvitados
            // 
            this.Boton_AgregarInvitados.Location = new System.Drawing.Point(118, 67);
            this.Boton_AgregarInvitados.Name = "Boton_AgregarInvitados";
            this.Boton_AgregarInvitados.Size = new System.Drawing.Size(109, 24);
            this.Boton_AgregarInvitados.TabIndex = 9;
            this.Boton_AgregarInvitados.Text = "Agregar Invitados";
            this.Boton_AgregarInvitados.UseVisualStyleBackColor = true;
            this.Boton_AgregarInvitados.Click += new System.EventHandler(this.Boton_AgregarInvitados_Click);
            // 
            // Boton_VerificarDisp
            // 
            this.Boton_VerificarDisp.Location = new System.Drawing.Point(274, 151);
            this.Boton_VerificarDisp.Name = "Boton_VerificarDisp";
            this.Boton_VerificarDisp.Size = new System.Drawing.Size(119, 39);
            this.Boton_VerificarDisp.TabIndex = 10;
            this.Boton_VerificarDisp.Text = "Verificar disponibilidad";
            this.Boton_VerificarDisp.UseVisualStyleBackColor = true;
            this.Boton_VerificarDisp.Click += new System.EventHandler(this.Boton_VerificarDisp_Click);
            // 
            // Boton_ConfirmarEvento
            // 
            this.Boton_ConfirmarEvento.Location = new System.Drawing.Point(874, 507);
            this.Boton_ConfirmarEvento.Name = "Boton_ConfirmarEvento";
            this.Boton_ConfirmarEvento.Size = new System.Drawing.Size(98, 42);
            this.Boton_ConfirmarEvento.TabIndex = 14;
            this.Boton_ConfirmarEvento.Text = "Confirmar evento";
            this.Boton_ConfirmarEvento.UseVisualStyleBackColor = true;
            this.Boton_ConfirmarEvento.Click += new System.EventHandler(this.Boton_ConfirmarEvento_Click);
            // 
            // Grilla_DeClientes
            // 
            this.Grilla_DeClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grilla_DeClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grilla_DeClientes.Location = new System.Drawing.Point(9, 97);
            this.Grilla_DeClientes.Name = "Grilla_DeClientes";
            this.Grilla_DeClientes.ReadOnly = true;
            this.Grilla_DeClientes.Size = new System.Drawing.Size(504, 135);
            this.Grilla_DeClientes.TabIndex = 15;
            this.Grilla_DeClientes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Grilla_DeClientes_MouseClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(271, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Seleccione el turno";
            // 
            // Grilla_Eventos
            // 
            this.Grilla_Eventos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grilla_Eventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grilla_Eventos.Location = new System.Drawing.Point(12, 12);
            this.Grilla_Eventos.MultiSelect = false;
            this.Grilla_Eventos.Name = "Grilla_Eventos";
            this.Grilla_Eventos.ReadOnly = true;
            this.Grilla_Eventos.Size = new System.Drawing.Size(411, 537);
            this.Grilla_Eventos.TabIndex = 18;
            this.Grilla_Eventos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Grilla_Eventos_MouseClick);
            // 
            // Boton_EliminarEvento
            // 
            this.Boton_EliminarEvento.Location = new System.Drawing.Point(11, 117);
            this.Boton_EliminarEvento.Name = "Boton_EliminarEvento";
            this.Boton_EliminarEvento.Size = new System.Drawing.Size(96, 42);
            this.Boton_EliminarEvento.TabIndex = 19;
            this.Boton_EliminarEvento.Text = "Eliminar";
            this.Boton_EliminarEvento.UseVisualStyleBackColor = true;
            this.Boton_EliminarEvento.Click += new System.EventHandler(this.Boton_EliminarEvento_Click);
            // 
            // Boton_ModificarInvitados
            // 
            this.Boton_ModificarInvitados.Location = new System.Drawing.Point(241, 67);
            this.Boton_ModificarInvitados.Name = "Boton_ModificarInvitados";
            this.Boton_ModificarInvitados.Size = new System.Drawing.Size(107, 24);
            this.Boton_ModificarInvitados.TabIndex = 20;
            this.Boton_ModificarInvitados.Text = "Modificar Invitados";
            this.Boton_ModificarInvitados.UseVisualStyleBackColor = true;
            this.Boton_ModificarInvitados.Click += new System.EventHandler(this.Boton_ModificarInvitados_Click);
            // 
            // Boton_GuardarCambiosListaInv
            // 
            this.Boton_GuardarCambiosListaInv.Enabled = false;
            this.Boton_GuardarCambiosListaInv.Location = new System.Drawing.Point(9, 238);
            this.Boton_GuardarCambiosListaInv.Name = "Boton_GuardarCambiosListaInv";
            this.Boton_GuardarCambiosListaInv.Size = new System.Drawing.Size(121, 36);
            this.Boton_GuardarCambiosListaInv.TabIndex = 23;
            this.Boton_GuardarCambiosListaInv.Text = "Guardar cambios en lista de invitados";
            this.Boton_GuardarCambiosListaInv.UseVisualStyleBackColor = true;
            this.Boton_GuardarCambiosListaInv.Click += new System.EventHandler(this.Boton_GuardarCambiosListaInv_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.uC_ValCod1);
            this.groupBox1.Controls.Add(this.Boton_VerificarDisp);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ComboBox_Horarios);
            this.groupBox1.Controls.Add(this.Calendario);
            this.groupBox1.Location = new System.Drawing.Point(566, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 202);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consulta de disponibilidad";
            // 
            // uC_ValCod1
            // 
            this.uC_ValCod1.Location = new System.Drawing.Point(274, 111);
            this.uC_ValCod1.Name = "uC_ValCod1";
            this.uC_ValCod1.Size = new System.Drawing.Size(100, 20);
            this.uC_ValCod1.TabIndex = 11;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Boton_GuardarCambiosListaInv);
            this.groupBox2.Controls.Add(this.Boton_ModificarInvitados);
            this.groupBox2.Controls.Add(this.Grilla_DeClientes);
            this.groupBox2.Controls.Add(this.uC_ValNombApe1);
            this.groupBox2.Controls.Add(this.uC_ValidarMail1);
            this.groupBox2.Controls.Add(this.Boton_AgregarInvitados);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(459, 223);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(519, 280);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Invitados";
            // 
            // uC_ValNombApe1
            // 
            this.uC_ValNombApe1.Location = new System.Drawing.Point(9, 36);
            this.uC_ValNombApe1.Name = "uC_ValNombApe1";
            this.uC_ValNombApe1.Size = new System.Drawing.Size(218, 20);
            this.uC_ValNombApe1.TabIndex = 13;
            // 
            // uC_ValidarMail1
            // 
            this.uC_ValidarMail1.Location = new System.Drawing.Point(241, 36);
            this.uC_ValidarMail1.Name = "uC_ValidarMail1";
            this.uC_ValidarMail1.Size = new System.Drawing.Size(272, 20);
            this.uC_ValidarMail1.TabIndex = 12;
            // 
            // Boton_ModificarEvento
            // 
            this.Boton_ModificarEvento.Location = new System.Drawing.Point(11, 69);
            this.Boton_ModificarEvento.Name = "Boton_ModificarEvento";
            this.Boton_ModificarEvento.Size = new System.Drawing.Size(96, 42);
            this.Boton_ModificarEvento.TabIndex = 26;
            this.Boton_ModificarEvento.Text = "Modificar";
            this.Boton_ModificarEvento.UseVisualStyleBackColor = true;
            this.Boton_ModificarEvento.Click += new System.EventHandler(this.Boton_ModificarEvento_Click);
            // 
            // Boton_AgregarEvento
            // 
            this.Boton_AgregarEvento.Location = new System.Drawing.Point(11, 21);
            this.Boton_AgregarEvento.Name = "Boton_AgregarEvento";
            this.Boton_AgregarEvento.Size = new System.Drawing.Size(96, 42);
            this.Boton_AgregarEvento.TabIndex = 27;
            this.Boton_AgregarEvento.Text = "Agregar";
            this.Boton_AgregarEvento.UseVisualStyleBackColor = true;
            this.Boton_AgregarEvento.Click += new System.EventHandler(this.Boton_AgregarEvento_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Boton_AgregarEvento);
            this.groupBox3.Controls.Add(this.Boton_ModificarEvento);
            this.groupBox3.Controls.Add(this.Boton_EliminarEvento);
            this.groupBox3.Location = new System.Drawing.Point(439, 28);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(118, 173);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Acciones";
            // 
            // Boton_Cancelar
            // 
            this.Boton_Cancelar.Location = new System.Drawing.Point(468, 507);
            this.Boton_Cancelar.Name = "Boton_Cancelar";
            this.Boton_Cancelar.Size = new System.Drawing.Size(98, 42);
            this.Boton_Cancelar.TabIndex = 29;
            this.Boton_Cancelar.Text = "Cancelar";
            this.Boton_Cancelar.UseVisualStyleBackColor = true;
            this.Boton_Cancelar.Click += new System.EventHandler(this.Boton_Cancelar_Click);
            // 
            // GUI_Gerente_Eventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TrabajoFinal.Properties.Resources.BlueShade2;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.Boton_Cancelar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Grilla_Eventos);
            this.Controls.Add(this.Boton_ConfirmarEvento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "GUI_Gerente_Eventos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "GUI_AdminEventos";
            this.Load += new System.EventHandler(this.GUI_Gerente_Eventos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grilla_DeClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla_Eventos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar Calendario;
        private System.Windows.Forms.ComboBox ComboBox_Horarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Boton_AgregarInvitados;
        private System.Windows.Forms.Button Boton_VerificarDisp;
        private UC_ValCod uC_ValCod1;
        private UC_ValidarMail uC_ValidarMail1;
        private UC_ValNombApe uC_ValNombApe1;
        private System.Windows.Forms.Button Boton_ConfirmarEvento;
        private System.Windows.Forms.DataGridView Grilla_DeClientes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView Grilla_Eventos;
        private System.Windows.Forms.Button Boton_EliminarEvento;
        private System.Windows.Forms.Button Boton_ModificarInvitados;
        private System.Windows.Forms.Button Boton_GuardarCambiosListaInv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Boton_ModificarEvento;
        private System.Windows.Forms.Button Boton_AgregarEvento;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Boton_Cancelar;
    }
}
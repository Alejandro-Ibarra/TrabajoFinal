
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
            this.label5 = new System.Windows.Forms.Label();
            this.Grilla_Eventos = new System.Windows.Forms.DataGridView();
            this.Boton_EliminarEvento = new System.Windows.Forms.Button();
            this.Boton_ModificarInvitados = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Boton_ModificarEvento = new System.Windows.Forms.Button();
            this.uC_ValCod2 = new TrabajoFinal.UC_ValCod();
            this.uC_ValNombApe1 = new TrabajoFinal.UC_ValNombApe();
            this.uC_ValidarMail1 = new TrabajoFinal.UC_ValidarMail();
            this.uC_ValCod1 = new TrabajoFinal.UC_ValCod();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla_DeClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla_Eventos)).BeginInit();
            this.SuspendLayout();
            // 
            // Calendario
            // 
            this.Calendario.Location = new System.Drawing.Point(18, 31);
            this.Calendario.MaxSelectionCount = 1;
            this.Calendario.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.Calendario.Name = "Calendario";
            this.Calendario.TabIndex = 0;
            // 
            // ComboBox_Horarios
            // 
            this.ComboBox_Horarios.FormattingEnabled = true;
            this.ComboBox_Horarios.Location = new System.Drawing.Point(18, 220);
            this.ComboBox_Horarios.Name = "ComboBox_Horarios";
            this.ComboBox_Horarios.Size = new System.Drawing.Size(119, 21);
            this.ComboBox_Horarios.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cantidad de personas\r\n(Max 50)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(299, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(299, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "E-Mail";
            // 
            // Boton_AgregarInvitados
            // 
            this.Boton_AgregarInvitados.Location = new System.Drawing.Point(577, 71);
            this.Boton_AgregarInvitados.Name = "Boton_AgregarInvitados";
            this.Boton_AgregarInvitados.Size = new System.Drawing.Size(71, 38);
            this.Boton_AgregarInvitados.TabIndex = 9;
            this.Boton_AgregarInvitados.Text = "Agregar Invitados";
            this.Boton_AgregarInvitados.UseVisualStyleBackColor = true;
            this.Boton_AgregarInvitados.Click += new System.EventHandler(this.Boton_AgregarInvitados_Click);
            // 
            // Boton_VerificarDisp
            // 
            this.Boton_VerificarDisp.Location = new System.Drawing.Point(18, 247);
            this.Boton_VerificarDisp.Name = "Boton_VerificarDisp";
            this.Boton_VerificarDisp.Size = new System.Drawing.Size(119, 39);
            this.Boton_VerificarDisp.TabIndex = 10;
            this.Boton_VerificarDisp.Text = "Verificar disponibilidad";
            this.Boton_VerificarDisp.UseVisualStyleBackColor = true;
            this.Boton_VerificarDisp.Click += new System.EventHandler(this.Boton_VerificarDisp_Click);
            // 
            // Boton_ConfirmarEvento
            // 
            this.Boton_ConfirmarEvento.Location = new System.Drawing.Point(670, 267);
            this.Boton_ConfirmarEvento.Name = "Boton_ConfirmarEvento";
            this.Boton_ConfirmarEvento.Size = new System.Drawing.Size(107, 66);
            this.Boton_ConfirmarEvento.TabIndex = 14;
            this.Boton_ConfirmarEvento.Text = "Confirmar evento";
            this.Boton_ConfirmarEvento.UseVisualStyleBackColor = true;
            this.Boton_ConfirmarEvento.Click += new System.EventHandler(this.Boton_ConfirmarEvento_Click);
            // 
            // Grilla_DeClientes
            // 
            this.Grilla_DeClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grilla_DeClientes.Location = new System.Drawing.Point(302, 115);
            this.Grilla_DeClientes.Name = "Grilla_DeClientes";
            this.Grilla_DeClientes.Size = new System.Drawing.Size(475, 146);
            this.Grilla_DeClientes.TabIndex = 15;
            this.Grilla_DeClientes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Grilla_DeClientes_MouseClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Seleccione el turno";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Seleccione la fecha";
            // 
            // Grilla_Eventos
            // 
            this.Grilla_Eventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grilla_Eventos.Location = new System.Drawing.Point(18, 332);
            this.Grilla_Eventos.Name = "Grilla_Eventos";
            this.Grilla_Eventos.Size = new System.Drawing.Size(456, 192);
            this.Grilla_Eventos.TabIndex = 18;
            this.Grilla_Eventos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Grilla_Eventos_MouseClick);
            // 
            // Boton_EliminarEvento
            // 
            this.Boton_EliminarEvento.Location = new System.Drawing.Point(491, 332);
            this.Boton_EliminarEvento.Name = "Boton_EliminarEvento";
            this.Boton_EliminarEvento.Size = new System.Drawing.Size(105, 40);
            this.Boton_EliminarEvento.TabIndex = 19;
            this.Boton_EliminarEvento.Text = "Eliminar evento";
            this.Boton_EliminarEvento.UseVisualStyleBackColor = true;
            this.Boton_EliminarEvento.Click += new System.EventHandler(this.Boton_EliminarEvento_Click);
            // 
            // Boton_ModificarInvitados
            // 
            this.Boton_ModificarInvitados.Location = new System.Drawing.Point(670, 71);
            this.Boton_ModificarInvitados.Name = "Boton_ModificarInvitados";
            this.Boton_ModificarInvitados.Size = new System.Drawing.Size(107, 38);
            this.Boton_ModificarInvitados.TabIndex = 20;
            this.Boton_ModificarInvitados.Text = "Modificar Invitados";
            this.Boton_ModificarInvitados.UseVisualStyleBackColor = true;
            this.Boton_ModificarInvitados.Click += new System.EventHandler(this.Boton_ModificarInvitados_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(574, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Cod. Cliente";
            // 
            // Boton_ModificarEvento
            // 
            this.Boton_ModificarEvento.Location = new System.Drawing.Point(302, 267);
            this.Boton_ModificarEvento.Name = "Boton_ModificarEvento";
            this.Boton_ModificarEvento.Size = new System.Drawing.Size(121, 43);
            this.Boton_ModificarEvento.TabIndex = 23;
            this.Boton_ModificarEvento.Text = "Guardar cambios en lista de invitados";
            this.Boton_ModificarEvento.UseVisualStyleBackColor = true;
            this.Boton_ModificarEvento.Click += new System.EventHandler(this.Boton_ModificarEvento_Click);
            // 
            // uC_ValCod2
            // 
            this.uC_ValCod2.Enabled = false;
            this.uC_ValCod2.Location = new System.Drawing.Point(577, 36);
            this.uC_ValCod2.Name = "uC_ValCod2";
            this.uC_ValCod2.Size = new System.Drawing.Size(61, 20);
            this.uC_ValCod2.TabIndex = 22;
            // 
            // uC_ValNombApe1
            // 
            this.uC_ValNombApe1.Location = new System.Drawing.Point(302, 36);
            this.uC_ValNombApe1.Name = "uC_ValNombApe1";
            this.uC_ValNombApe1.Size = new System.Drawing.Size(237, 20);
            this.uC_ValNombApe1.TabIndex = 13;
            // 
            // uC_ValidarMail1
            // 
            this.uC_ValidarMail1.Location = new System.Drawing.Point(302, 89);
            this.uC_ValidarMail1.Name = "uC_ValidarMail1";
            this.uC_ValidarMail1.Size = new System.Drawing.Size(237, 20);
            this.uC_ValidarMail1.TabIndex = 12;
            // 
            // uC_ValCod1
            // 
            this.uC_ValCod1.Location = new System.Drawing.Point(159, 247);
            this.uC_ValCod1.Name = "uC_ValCod1";
            this.uC_ValCod1.Size = new System.Drawing.Size(100, 20);
            this.uC_ValCod1.TabIndex = 11;
            // 
            // GUI_Gerente_Eventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 578);
            this.Controls.Add(this.Boton_ModificarEvento);
            this.Controls.Add(this.uC_ValCod2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Boton_ModificarInvitados);
            this.Controls.Add(this.Boton_EliminarEvento);
            this.Controls.Add(this.Grilla_Eventos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Grilla_DeClientes);
            this.Controls.Add(this.Boton_ConfirmarEvento);
            this.Controls.Add(this.uC_ValNombApe1);
            this.Controls.Add(this.uC_ValidarMail1);
            this.Controls.Add(this.uC_ValCod1);
            this.Controls.Add(this.Boton_VerificarDisp);
            this.Controls.Add(this.Boton_AgregarInvitados);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ComboBox_Horarios);
            this.Controls.Add(this.Calendario);
            this.Name = "GUI_Gerente_Eventos";
            this.Text = "GUI_AdminEventos";
            ((System.ComponentModel.ISupportInitialize)(this.Grilla_DeClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla_Eventos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView Grilla_Eventos;
        private System.Windows.Forms.Button Boton_EliminarEvento;
        private System.Windows.Forms.Button Boton_ModificarInvitados;
        private System.Windows.Forms.Label label6;
        private UC_ValCod uC_ValCod2;
        private System.Windows.Forms.Button Boton_ModificarEvento;
    }
}
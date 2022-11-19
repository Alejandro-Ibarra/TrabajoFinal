
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.ComboBox_Horarios = new System.Windows.Forms.ComboBox();
            this.TextBox_CantPersonas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TextBox_Nombre = new System.Windows.Forms.TextBox();
            this.TextBox_Mail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Boton_Agregar = new System.Windows.Forms.Button();
            this.Boton_VerificarDisp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(42, 47);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // ComboBox_Horarios
            // 
            this.ComboBox_Horarios.FormattingEnabled = true;
            this.ComboBox_Horarios.Location = new System.Drawing.Point(42, 238);
            this.ComboBox_Horarios.Name = "ComboBox_Horarios";
            this.ComboBox_Horarios.Size = new System.Drawing.Size(248, 21);
            this.ComboBox_Horarios.TabIndex = 1;
            // 
            // TextBox_CantPersonas
            // 
            this.TextBox_CantPersonas.Location = new System.Drawing.Point(100, 306);
            this.TextBox_CantPersonas.Name = "TextBox_CantPersonas";
            this.TextBox_CantPersonas.Size = new System.Drawing.Size(100, 20);
            this.TextBox_CantPersonas.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cantidad de personas (Max 50)";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(361, 126);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(387, 298);
            this.dataGridView1.TabIndex = 4;
            // 
            // TextBox_Nombre
            // 
            this.TextBox_Nombre.Location = new System.Drawing.Point(361, 47);
            this.TextBox_Nombre.Name = "TextBox_Nombre";
            this.TextBox_Nombre.Size = new System.Drawing.Size(263, 20);
            this.TextBox_Nombre.TabIndex = 5;
            // 
            // TextBox_Mail
            // 
            this.TextBox_Mail.Location = new System.Drawing.Point(361, 100);
            this.TextBox_Mail.Name = "TextBox_Mail";
            this.TextBox_Mail.Size = new System.Drawing.Size(263, 20);
            this.TextBox_Mail.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(358, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(358, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "E-Mail";
            // 
            // Boton_Agregar
            // 
            this.Boton_Agregar.Location = new System.Drawing.Point(659, 63);
            this.Boton_Agregar.Name = "Boton_Agregar";
            this.Boton_Agregar.Size = new System.Drawing.Size(71, 54);
            this.Boton_Agregar.TabIndex = 9;
            this.Boton_Agregar.Text = "Agregar";
            this.Boton_Agregar.UseVisualStyleBackColor = true;
            this.Boton_Agregar.Click += new System.EventHandler(this.Boton_Agregar_Click);
            // 
            // Boton_VerificarDisp
            // 
            this.Boton_VerificarDisp.Location = new System.Drawing.Point(90, 356);
            this.Boton_VerificarDisp.Name = "Boton_VerificarDisp";
            this.Boton_VerificarDisp.Size = new System.Drawing.Size(119, 39);
            this.Boton_VerificarDisp.TabIndex = 10;
            this.Boton_VerificarDisp.Text = "Verificar disponibilidad";
            this.Boton_VerificarDisp.UseVisualStyleBackColor = true;
            this.Boton_VerificarDisp.Click += new System.EventHandler(this.Boton_VerificarDisp_Click);
            // 
            // GUI_Gerente_Eventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Boton_VerificarDisp);
            this.Controls.Add(this.Boton_Agregar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextBox_Mail);
            this.Controls.Add(this.TextBox_Nombre);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBox_CantPersonas);
            this.Controls.Add(this.ComboBox_Horarios);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "GUI_Gerente_Eventos";
            this.Text = "GUI_AdminEventos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.ComboBox ComboBox_Horarios;
        private System.Windows.Forms.TextBox TextBox_CantPersonas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox TextBox_Nombre;
        private System.Windows.Forms.TextBox TextBox_Mail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Boton_Agregar;
        private System.Windows.Forms.Button Boton_VerificarDisp;
    }
}
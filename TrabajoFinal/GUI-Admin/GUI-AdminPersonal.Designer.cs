﻿
namespace TrabajoFinal
{
    partial class GUI_Administrar_Personal
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
            this.UC_ValApe = new TrabajoFinal.UserControl.UC_ValNombApe();
            this.UC_ValNomb = new TrabajoFinal.UserControl.UC_ValNombApe();
            this.label1 = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.UC_ValCod = new TrabajoFinal.UserControl.UC_ValCod();
            this.UC_ValDNI = new TrabajoFinal.UserControl.UC_ValDNI();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Pass = new System.Windows.Forms.TextBox();
            this.RadioButton_Cocinero = new System.Windows.Forms.RadioButton();
            this.RadioButton_Mozo = new System.Windows.Forms.RadioButton();
            this.Grilla_Cocineros = new System.Windows.Forms.DataGridView();
            this.Grilla_Mozos = new System.Windows.Forms.DataGridView();
            this.Boton_Alta = new System.Windows.Forms.Button();
            this.Boton_Baja = new System.Windows.Forms.Button();
            this.Boton_Modificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla_Cocineros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla_Mozos)).BeginInit();
            this.SuspendLayout();
            // 
            // UC_ValApe
            // 
            this.UC_ValApe.Location = new System.Drawing.Point(261, 69);
            this.UC_ValApe.Name = "UC_ValApe";
            this.UC_ValApe.Size = new System.Drawing.Size(100, 20);
            this.UC_ValApe.TabIndex = 0;
            // 
            // UC_ValNomb
            // 
            this.UC_ValNomb.Location = new System.Drawing.Point(261, 137);
            this.UC_ValNomb.Name = "UC_ValNomb";
            this.UC_ValNomb.Size = new System.Drawing.Size(100, 20);
            this.UC_ValNomb.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(258, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Apellido";
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(258, 105);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(44, 13);
            this.Nombre.TabIndex = 3;
            this.Nombre.Text = "Nombre";
            // 
            // UC_ValCod
            // 
            this.UC_ValCod.Location = new System.Drawing.Point(77, 68);
            this.UC_ValCod.Name = "UC_ValCod";
            this.UC_ValCod.Size = new System.Drawing.Size(100, 20);
            this.UC_ValCod.TabIndex = 4;
            // 
            // UC_ValDNI
            // 
            this.UC_ValDNI.Location = new System.Drawing.Point(77, 136);
            this.UC_ValDNI.Name = "UC_ValDNI";
            this.UC_ValDNI.Size = new System.Drawing.Size(100, 20);
            this.UC_ValDNI.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Codigo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "DNI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(415, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Contraseña";
            // 
            // textBox_Pass
            // 
            this.textBox_Pass.Location = new System.Drawing.Point(418, 68);
            this.textBox_Pass.Name = "textBox_Pass";
            this.textBox_Pass.Size = new System.Drawing.Size(100, 20);
            this.textBox_Pass.TabIndex = 10;
            // 
            // RadioButton_Cocinero
            // 
            this.RadioButton_Cocinero.AutoSize = true;
            this.RadioButton_Cocinero.Checked = true;
            this.RadioButton_Cocinero.Location = new System.Drawing.Point(418, 113);
            this.RadioButton_Cocinero.Name = "RadioButton_Cocinero";
            this.RadioButton_Cocinero.Size = new System.Drawing.Size(67, 17);
            this.RadioButton_Cocinero.TabIndex = 11;
            this.RadioButton_Cocinero.TabStop = true;
            this.RadioButton_Cocinero.Text = "Cocinero";
            this.RadioButton_Cocinero.UseVisualStyleBackColor = true;
            // 
            // RadioButton_Mozo
            // 
            this.RadioButton_Mozo.AutoSize = true;
            this.RadioButton_Mozo.Location = new System.Drawing.Point(418, 136);
            this.RadioButton_Mozo.Name = "RadioButton_Mozo";
            this.RadioButton_Mozo.Size = new System.Drawing.Size(51, 17);
            this.RadioButton_Mozo.TabIndex = 12;
            this.RadioButton_Mozo.Text = "Mozo";
            this.RadioButton_Mozo.UseVisualStyleBackColor = true;
            // 
            // Grilla_Cocineros
            // 
            this.Grilla_Cocineros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grilla_Cocineros.Location = new System.Drawing.Point(50, 254);
            this.Grilla_Cocineros.Name = "Grilla_Cocineros";
            this.Grilla_Cocineros.Size = new System.Drawing.Size(240, 150);
            this.Grilla_Cocineros.TabIndex = 13;
            this.Grilla_Cocineros.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Grilla_Cocineros_MouseClick);
            // 
            // Grilla_Mozos
            // 
            this.Grilla_Mozos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grilla_Mozos.Location = new System.Drawing.Point(345, 254);
            this.Grilla_Mozos.Name = "Grilla_Mozos";
            this.Grilla_Mozos.Size = new System.Drawing.Size(240, 150);
            this.Grilla_Mozos.TabIndex = 14;
            this.Grilla_Mozos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Grilla_Mozos_MouseClick);
            // 
            // Boton_Alta
            // 
            this.Boton_Alta.Location = new System.Drawing.Point(77, 197);
            this.Boton_Alta.Name = "Boton_Alta";
            this.Boton_Alta.Size = new System.Drawing.Size(75, 23);
            this.Boton_Alta.TabIndex = 15;
            this.Boton_Alta.Text = "Alta";
            this.Boton_Alta.UseVisualStyleBackColor = true;
            this.Boton_Alta.Click += new System.EventHandler(this.Boton_Alta_Click);
            // 
            // Boton_Baja
            // 
            this.Boton_Baja.Location = new System.Drawing.Point(261, 197);
            this.Boton_Baja.Name = "Boton_Baja";
            this.Boton_Baja.Size = new System.Drawing.Size(75, 23);
            this.Boton_Baja.TabIndex = 16;
            this.Boton_Baja.Text = "Baja";
            this.Boton_Baja.UseVisualStyleBackColor = true;
            this.Boton_Baja.Click += new System.EventHandler(this.Boton_Baja_Click);
            // 
            // Boton_Modificar
            // 
            this.Boton_Modificar.Location = new System.Drawing.Point(410, 197);
            this.Boton_Modificar.Name = "Boton_Modificar";
            this.Boton_Modificar.Size = new System.Drawing.Size(75, 23);
            this.Boton_Modificar.TabIndex = 17;
            this.Boton_Modificar.Text = "Modificar";
            this.Boton_Modificar.UseVisualStyleBackColor = true;
            this.Boton_Modificar.Click += new System.EventHandler(this.Boton_Modificar_Click);
            // 
            // GUI_Administrar_Personal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Boton_Modificar);
            this.Controls.Add(this.Boton_Baja);
            this.Controls.Add(this.Boton_Alta);
            this.Controls.Add(this.Grilla_Mozos);
            this.Controls.Add(this.Grilla_Cocineros);
            this.Controls.Add(this.RadioButton_Mozo);
            this.Controls.Add(this.RadioButton_Cocinero);
            this.Controls.Add(this.textBox_Pass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UC_ValDNI);
            this.Controls.Add(this.UC_ValCod);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UC_ValNomb);
            this.Controls.Add(this.UC_ValApe);
            this.Name = "GUI_Administrar_Personal";
            this.Text = "GUI_AdminPersonal";
            ((System.ComponentModel.ISupportInitialize)(this.Grilla_Cocineros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla_Mozos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControl.UC_ValNombApe UC_ValApe;
        private UserControl.UC_ValNombApe UC_ValNomb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Nombre;
        private UserControl.UC_ValCod UC_ValCod;
        private UserControl.UC_ValDNI UC_ValDNI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Pass;
        private System.Windows.Forms.RadioButton RadioButton_Cocinero;
        private System.Windows.Forms.RadioButton RadioButton_Mozo;
        private System.Windows.Forms.DataGridView Grilla_Cocineros;
        private System.Windows.Forms.DataGridView Grilla_Mozos;
        private System.Windows.Forms.Button Boton_Alta;
        private System.Windows.Forms.Button Boton_Baja;
        private System.Windows.Forms.Button Boton_Modificar;
    }
}
﻿
namespace TrabajoFinal
{
    partial class GUI_BackUp
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
            this.DataGridView_BackUps = new System.Windows.Forms.DataGridView();
            this.Boton_BackUp = new System.Windows.Forms.Button();
            this.Boton_Restore = new System.Windows.Forms.Button();
            this.TextBox_Usuario = new System.Windows.Forms.TextBox();
            this.TextBox_Tipo = new System.Windows.Forms.TextBox();
            this.TextBox_FechHora = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBox_Cod = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TextBox_Ruta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TextBox_NombArchivo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_BackUps)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView_BackUps
            // 
            this.DataGridView_BackUps.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView_BackUps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_BackUps.Location = new System.Drawing.Point(12, 12);
            this.DataGridView_BackUps.Name = "DataGridView_BackUps";
            this.DataGridView_BackUps.ReadOnly = true;
            this.DataGridView_BackUps.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView_BackUps.Size = new System.Drawing.Size(920, 225);
            this.DataGridView_BackUps.TabIndex = 0;
            this.DataGridView_BackUps.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DataGridView_BackUps_MouseClick);
            // 
            // Boton_BackUp
            // 
            this.Boton_BackUp.Location = new System.Drawing.Point(98, 299);
            this.Boton_BackUp.Name = "Boton_BackUp";
            this.Boton_BackUp.Size = new System.Drawing.Size(75, 23);
            this.Boton_BackUp.TabIndex = 1;
            this.Boton_BackUp.Text = "Backup";
            this.Boton_BackUp.UseVisualStyleBackColor = true;
            this.Boton_BackUp.Click += new System.EventHandler(this.Boton_BackUp_Click);
            // 
            // Boton_Restore
            // 
            this.Boton_Restore.Location = new System.Drawing.Point(217, 299);
            this.Boton_Restore.Name = "Boton_Restore";
            this.Boton_Restore.Size = new System.Drawing.Size(75, 23);
            this.Boton_Restore.TabIndex = 2;
            this.Boton_Restore.Text = "Restore";
            this.Boton_Restore.UseVisualStyleBackColor = true;
            this.Boton_Restore.Click += new System.EventHandler(this.Boton_Restore_Click);
            // 
            // TextBox_Usuario
            // 
            this.TextBox_Usuario.Enabled = false;
            this.TextBox_Usuario.Location = new System.Drawing.Point(255, 355);
            this.TextBox_Usuario.Name = "TextBox_Usuario";
            this.TextBox_Usuario.Size = new System.Drawing.Size(127, 20);
            this.TextBox_Usuario.TabIndex = 3;
            // 
            // TextBox_Tipo
            // 
            this.TextBox_Tipo.Enabled = false;
            this.TextBox_Tipo.Location = new System.Drawing.Point(575, 355);
            this.TextBox_Tipo.Name = "TextBox_Tipo";
            this.TextBox_Tipo.Size = new System.Drawing.Size(134, 20);
            this.TextBox_Tipo.TabIndex = 4;
            // 
            // TextBox_FechHora
            // 
            this.TextBox_FechHora.Enabled = false;
            this.TextBox_FechHora.Location = new System.Drawing.Point(420, 355);
            this.TextBox_FechHora.Name = "TextBox_FechHora";
            this.TextBox_FechHora.Size = new System.Drawing.Size(124, 20);
            this.TextBox_FechHora.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(572, 334);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tipo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(420, 339);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Fecha y hora";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Codigo";
            // 
            // TextBox_Cod
            // 
            this.TextBox_Cod.Enabled = false;
            this.TextBox_Cod.Location = new System.Drawing.Point(100, 355);
            this.TextBox_Cod.Name = "TextBox_Cod";
            this.TextBox_Cod.Size = new System.Drawing.Size(116, 20);
            this.TextBox_Cod.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(100, 419);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ruta";
            // 
            // TextBox_Ruta
            // 
            this.TextBox_Ruta.Enabled = false;
            this.TextBox_Ruta.Location = new System.Drawing.Point(103, 440);
            this.TextBox_Ruta.Name = "TextBox_Ruta";
            this.TextBox_Ruta.Size = new System.Drawing.Size(420, 20);
            this.TextBox_Ruta.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(566, 419);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Nombre del Archivo";
            // 
            // TextBox_NombArchivo
            // 
            this.TextBox_NombArchivo.Enabled = false;
            this.TextBox_NombArchivo.Location = new System.Drawing.Point(569, 440);
            this.TextBox_NombArchivo.Name = "TextBox_NombArchivo";
            this.TextBox_NombArchivo.Size = new System.Drawing.Size(231, 20);
            this.TextBox_NombArchivo.TabIndex = 13;
            // 
            // GUI_BackUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TextBox_NombArchivo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TextBox_Ruta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TextBox_Cod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBox_FechHora);
            this.Controls.Add(this.TextBox_Tipo);
            this.Controls.Add(this.TextBox_Usuario);
            this.Controls.Add(this.Boton_Restore);
            this.Controls.Add(this.Boton_BackUp);
            this.Controls.Add(this.DataGridView_BackUps);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "GUI_BackUp";
            this.Text = "GUI_BackUp";
            this.Load += new System.EventHandler(this.GUI_BackUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_BackUps)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridView_BackUps;
        private System.Windows.Forms.Button Boton_BackUp;
        private System.Windows.Forms.Button Boton_Restore;
        private System.Windows.Forms.TextBox TextBox_Usuario;
        private System.Windows.Forms.TextBox TextBox_Tipo;
        private System.Windows.Forms.TextBox TextBox_FechHora;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextBox_Cod;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TextBox_Ruta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TextBox_NombArchivo;
    }
}
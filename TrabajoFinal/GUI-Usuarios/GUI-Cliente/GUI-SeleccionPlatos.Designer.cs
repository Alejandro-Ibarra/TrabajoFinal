﻿
namespace TrabajoFinal
{
    partial class GUI_SeleccionPlatos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_SeleccionPlatos));
            this.GridView_TodosIng = new System.Windows.Forms.DataGridView();
            this.GridView_IngSelec = new System.Windows.Forms.DataGridView();
            this.GridView_PlatoSelec = new System.Windows.Forms.DataGridView();
            this.GridView_TodosPlatos = new System.Windows.Forms.DataGridView();
            this.Boton_Sugerir = new System.Windows.Forms.Button();
            this.Boton_ConfirmarPedido = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Boton_QuitarPlato = new System.Windows.Forms.Button();
            this.Boton_AgregarPlato = new System.Windows.Forms.Button();
            this.Boton_QuitarIng = new System.Windows.Forms.Button();
            this.Boton_AgregarIng = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_TodosIng)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_IngSelec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_PlatoSelec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_TodosPlatos)).BeginInit();
            this.SuspendLayout();
            // 
            // GridView_TodosIng
            // 
            this.GridView_TodosIng.AllowUserToAddRows = false;
            this.GridView_TodosIng.AllowUserToDeleteRows = false;
            this.GridView_TodosIng.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridView_TodosIng.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView_TodosIng.Location = new System.Drawing.Point(27, 24);
            this.GridView_TodosIng.Name = "GridView_TodosIng";
            this.GridView_TodosIng.ReadOnly = true;
            this.GridView_TodosIng.Size = new System.Drawing.Size(391, 174);
            this.GridView_TodosIng.TabIndex = 0;
            // 
            // GridView_IngSelec
            // 
            this.GridView_IngSelec.AllowUserToAddRows = false;
            this.GridView_IngSelec.AllowUserToDeleteRows = false;
            this.GridView_IngSelec.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridView_IngSelec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView_IngSelec.Location = new System.Drawing.Point(540, 24);
            this.GridView_IngSelec.Name = "GridView_IngSelec";
            this.GridView_IngSelec.ReadOnly = true;
            this.GridView_IngSelec.Size = new System.Drawing.Size(391, 174);
            this.GridView_IngSelec.TabIndex = 1;
            // 
            // GridView_PlatoSelec
            // 
            this.GridView_PlatoSelec.AllowUserToAddRows = false;
            this.GridView_PlatoSelec.AllowUserToDeleteRows = false;
            this.GridView_PlatoSelec.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridView_PlatoSelec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView_PlatoSelec.Location = new System.Drawing.Point(540, 233);
            this.GridView_PlatoSelec.Name = "GridView_PlatoSelec";
            this.GridView_PlatoSelec.ReadOnly = true;
            this.GridView_PlatoSelec.Size = new System.Drawing.Size(391, 193);
            this.GridView_PlatoSelec.TabIndex = 2;
            // 
            // GridView_TodosPlatos
            // 
            this.GridView_TodosPlatos.AllowUserToAddRows = false;
            this.GridView_TodosPlatos.AllowUserToDeleteRows = false;
            this.GridView_TodosPlatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridView_TodosPlatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView_TodosPlatos.Location = new System.Drawing.Point(27, 233);
            this.GridView_TodosPlatos.Name = "GridView_TodosPlatos";
            this.GridView_TodosPlatos.ReadOnly = true;
            this.GridView_TodosPlatos.Size = new System.Drawing.Size(391, 183);
            this.GridView_TodosPlatos.TabIndex = 3;
            this.GridView_TodosPlatos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GridView_TodosPlatos_MouseClick);
            // 
            // Boton_Sugerir
            // 
            this.Boton_Sugerir.Location = new System.Drawing.Point(407, 204);
            this.Boton_Sugerir.Name = "Boton_Sugerir";
            this.Boton_Sugerir.Size = new System.Drawing.Size(146, 23);
            this.Boton_Sugerir.TabIndex = 32;
            this.Boton_Sugerir.Text = "Sugerir";
            this.Boton_Sugerir.UseVisualStyleBackColor = true;
            this.Boton_Sugerir.Click += new System.EventHandler(this.Boton_Sugerir_Click);
            // 
            // Boton_ConfirmarPedido
            // 
            this.Boton_ConfirmarPedido.Location = new System.Drawing.Point(596, 462);
            this.Boton_ConfirmarPedido.Name = "Boton_ConfirmarPedido";
            this.Boton_ConfirmarPedido.Size = new System.Drawing.Size(82, 65);
            this.Boton_ConfirmarPedido.TabIndex = 33;
            this.Boton_ConfirmarPedido.Text = "Confirmar pedido";
            this.Boton_ConfirmarPedido.UseVisualStyleBackColor = true;
            this.Boton_ConfirmarPedido.Click += new System.EventHandler(this.Boton_ConfirmarPedido_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(27, 473);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(391, 54);
            this.textBox1.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 451);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Descripción";
            // 
            // Boton_QuitarPlato
            // 
            this.Boton_QuitarPlato.BackgroundImage = global::TrabajoFinal.Properties.Resources.Izq;
            this.Boton_QuitarPlato.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Boton_QuitarPlato.Location = new System.Drawing.Point(441, 329);
            this.Boton_QuitarPlato.Name = "Boton_QuitarPlato";
            this.Boton_QuitarPlato.Size = new System.Drawing.Size(65, 70);
            this.Boton_QuitarPlato.TabIndex = 31;
            this.Boton_QuitarPlato.Text = "Quitar";
            this.Boton_QuitarPlato.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Boton_QuitarPlato.UseVisualStyleBackColor = true;
            this.Boton_QuitarPlato.Click += new System.EventHandler(this.Boton_QuitarPlato_Click);
            // 
            // Boton_AgregarPlato
            // 
            this.Boton_AgregarPlato.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Boton_AgregarPlato.BackgroundImage")));
            this.Boton_AgregarPlato.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Boton_AgregarPlato.Location = new System.Drawing.Point(441, 253);
            this.Boton_AgregarPlato.Name = "Boton_AgregarPlato";
            this.Boton_AgregarPlato.Size = new System.Drawing.Size(65, 70);
            this.Boton_AgregarPlato.TabIndex = 30;
            this.Boton_AgregarPlato.Text = "Agregar";
            this.Boton_AgregarPlato.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Boton_AgregarPlato.UseVisualStyleBackColor = true;
            this.Boton_AgregarPlato.Click += new System.EventHandler(this.Boton_AgregarPlato_Click);
            // 
            // Boton_QuitarIng
            // 
            this.Boton_QuitarIng.BackgroundImage = global::TrabajoFinal.Properties.Resources.Izq;
            this.Boton_QuitarIng.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Boton_QuitarIng.Location = new System.Drawing.Point(441, 112);
            this.Boton_QuitarIng.Name = "Boton_QuitarIng";
            this.Boton_QuitarIng.Size = new System.Drawing.Size(65, 70);
            this.Boton_QuitarIng.TabIndex = 29;
            this.Boton_QuitarIng.Text = "Quitar";
            this.Boton_QuitarIng.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Boton_QuitarIng.UseVisualStyleBackColor = true;
            this.Boton_QuitarIng.Click += new System.EventHandler(this.Boton_QuitarIng_Click);
            // 
            // Boton_AgregarIng
            // 
            this.Boton_AgregarIng.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Boton_AgregarIng.BackgroundImage")));
            this.Boton_AgregarIng.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Boton_AgregarIng.Location = new System.Drawing.Point(441, 39);
            this.Boton_AgregarIng.Name = "Boton_AgregarIng";
            this.Boton_AgregarIng.Size = new System.Drawing.Size(65, 70);
            this.Boton_AgregarIng.TabIndex = 28;
            this.Boton_AgregarIng.Text = "Agregar";
            this.Boton_AgregarIng.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Boton_AgregarIng.UseVisualStyleBackColor = true;
            this.Boton_AgregarIng.Click += new System.EventHandler(this.Boton_AgregarIng_Click);
            // 
            // GUI_SeleccionPlatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TrabajoFinal.Properties.Resources.BlueShade2;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Boton_ConfirmarPedido);
            this.Controls.Add(this.Boton_Sugerir);
            this.Controls.Add(this.Boton_QuitarPlato);
            this.Controls.Add(this.Boton_AgregarPlato);
            this.Controls.Add(this.Boton_QuitarIng);
            this.Controls.Add(this.Boton_AgregarIng);
            this.Controls.Add(this.GridView_TodosPlatos);
            this.Controls.Add(this.GridView_PlatoSelec);
            this.Controls.Add(this.GridView_IngSelec);
            this.Controls.Add(this.GridView_TodosIng);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "GUI_SeleccionPlatos";
            this.Text = "GUI_SeleccionPlatos";
            this.Load += new System.EventHandler(this.GUI_SeleccionPlatos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridView_TodosIng)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_IngSelec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_PlatoSelec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_TodosPlatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridView_TodosIng;
        private System.Windows.Forms.DataGridView GridView_IngSelec;
        private System.Windows.Forms.DataGridView GridView_PlatoSelec;
        private System.Windows.Forms.DataGridView GridView_TodosPlatos;
        private System.Windows.Forms.Button Boton_QuitarIng;
        private System.Windows.Forms.Button Boton_AgregarIng;
        private System.Windows.Forms.Button Boton_QuitarPlato;
        private System.Windows.Forms.Button Boton_AgregarPlato;
        private System.Windows.Forms.Button Boton_Sugerir;
        private System.Windows.Forms.Button Boton_ConfirmarPedido;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}
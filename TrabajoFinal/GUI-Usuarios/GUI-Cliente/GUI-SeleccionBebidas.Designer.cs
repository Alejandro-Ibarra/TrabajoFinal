
namespace TrabajoFinal
{
    partial class GUI_SeleccionBebidas
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
            this.Boton_Confirmar = new System.Windows.Forms.Button();
            this.Boton_QuitarBebida = new System.Windows.Forms.Button();
            this.Boton_AgregarBebida = new System.Windows.Forms.Button();
            this.GridView_BebidasSelec = new System.Windows.Forms.DataGridView();
            this.GridView_TodosBebidas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_BebidasSelec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_TodosBebidas)).BeginInit();
            this.SuspendLayout();
            // 
            // Boton_Confirmar
            // 
            this.Boton_Confirmar.Location = new System.Drawing.Point(262, 246);
            this.Boton_Confirmar.Name = "Boton_Confirmar";
            this.Boton_Confirmar.Size = new System.Drawing.Size(146, 23);
            this.Boton_Confirmar.TabIndex = 39;
            this.Boton_Confirmar.Text = "Confirmar";
            this.Boton_Confirmar.UseVisualStyleBackColor = true;
            this.Boton_Confirmar.Click += new System.EventHandler(this.Boton_Confirmar_Click);
            // 
            // Boton_QuitarBebida
            // 
            this.Boton_QuitarBebida.Location = new System.Drawing.Point(291, 161);
            this.Boton_QuitarBebida.Name = "Boton_QuitarBebida";
            this.Boton_QuitarBebida.Size = new System.Drawing.Size(65, 23);
            this.Boton_QuitarBebida.TabIndex = 38;
            this.Boton_QuitarBebida.Text = "Quitar";
            this.Boton_QuitarBebida.UseVisualStyleBackColor = true;
            this.Boton_QuitarBebida.Click += new System.EventHandler(this.Boton_QuitarBebida_Click);
            // 
            // Boton_AgregarBebida
            // 
            this.Boton_AgregarBebida.Location = new System.Drawing.Point(291, 132);
            this.Boton_AgregarBebida.Name = "Boton_AgregarBebida";
            this.Boton_AgregarBebida.Size = new System.Drawing.Size(65, 23);
            this.Boton_AgregarBebida.TabIndex = 37;
            this.Boton_AgregarBebida.Text = "Agregar";
            this.Boton_AgregarBebida.UseVisualStyleBackColor = true;
            this.Boton_AgregarBebida.Click += new System.EventHandler(this.Boton_AgregarBebida_Click);
            // 
            // GridView_BebidasSelec
            // 
            this.GridView_BebidasSelec.AllowUserToAddRows = false;
            this.GridView_BebidasSelec.AllowUserToDeleteRows = false;
            this.GridView_BebidasSelec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView_BebidasSelec.Location = new System.Drawing.Point(445, 36);
            this.GridView_BebidasSelec.Name = "GridView_BebidasSelec";
            this.GridView_BebidasSelec.ReadOnly = true;
            this.GridView_BebidasSelec.Size = new System.Drawing.Size(205, 251);
            this.GridView_BebidasSelec.TabIndex = 36;
            // 
            // GridView_TodosBebidas
            // 
            this.GridView_TodosBebidas.AllowUserToAddRows = false;
            this.GridView_TodosBebidas.AllowUserToDeleteRows = false;
            this.GridView_TodosBebidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView_TodosBebidas.Location = new System.Drawing.Point(26, 36);
            this.GridView_TodosBebidas.Name = "GridView_TodosBebidas";
            this.GridView_TodosBebidas.ReadOnly = true;
            this.GridView_TodosBebidas.Size = new System.Drawing.Size(205, 251);
            this.GridView_TodosBebidas.TabIndex = 35;
            // 
            // GUI_SeleccionBebidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 323);
            this.Controls.Add(this.Boton_Confirmar);
            this.Controls.Add(this.Boton_QuitarBebida);
            this.Controls.Add(this.Boton_AgregarBebida);
            this.Controls.Add(this.GridView_BebidasSelec);
            this.Controls.Add(this.GridView_TodosBebidas);
            this.Name = "GUI_SeleccionBebidas";
            this.Text = "GUI_SeleccionBebidas";
            ((System.ComponentModel.ISupportInitialize)(this.GridView_BebidasSelec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_TodosBebidas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Boton_Confirmar;
        private System.Windows.Forms.Button Boton_QuitarBebida;
        private System.Windows.Forms.Button Boton_AgregarBebida;
        private System.Windows.Forms.DataGridView GridView_BebidasSelec;
        private System.Windows.Forms.DataGridView GridView_TodosBebidas;
    }
}

namespace TrabajoFinal
{
    partial class GUI_SeleccionExtras
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
            this.Boton_QuitarIng = new System.Windows.Forms.Button();
            this.Boton_AgregarExtra = new System.Windows.Forms.Button();
            this.GridView_ExtrasSelec = new System.Windows.Forms.DataGridView();
            this.GridView_TodosExtras = new System.Windows.Forms.DataGridView();
            this.Boton_Confirmar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_ExtrasSelec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_TodosExtras)).BeginInit();
            this.SuspendLayout();
            // 
            // Boton_QuitarIng
            // 
            this.Boton_QuitarIng.Location = new System.Drawing.Point(483, 172);
            this.Boton_QuitarIng.Name = "Boton_QuitarIng";
            this.Boton_QuitarIng.Size = new System.Drawing.Size(65, 23);
            this.Boton_QuitarIng.TabIndex = 33;
            this.Boton_QuitarIng.Text = "Quitar";
            this.Boton_QuitarIng.UseVisualStyleBackColor = true;
            this.Boton_QuitarIng.Click += new System.EventHandler(this.Boton_QuitarExtras_Click);
            // 
            // Boton_AgregarExtra
            // 
            this.Boton_AgregarExtra.Location = new System.Drawing.Point(483, 143);
            this.Boton_AgregarExtra.Name = "Boton_AgregarExtra";
            this.Boton_AgregarExtra.Size = new System.Drawing.Size(65, 23);
            this.Boton_AgregarExtra.TabIndex = 32;
            this.Boton_AgregarExtra.Text = "Agregar";
            this.Boton_AgregarExtra.UseVisualStyleBackColor = true;
            this.Boton_AgregarExtra.Click += new System.EventHandler(this.Boton_AgregarExtra_Click);
            // 
            // GridView_ExtrasSelec
            // 
            this.GridView_ExtrasSelec.AllowUserToAddRows = false;
            this.GridView_ExtrasSelec.AllowUserToDeleteRows = false;
            this.GridView_ExtrasSelec.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridView_ExtrasSelec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView_ExtrasSelec.Location = new System.Drawing.Point(592, 28);
            this.GridView_ExtrasSelec.Name = "GridView_ExtrasSelec";
            this.GridView_ExtrasSelec.ReadOnly = true;
            this.GridView_ExtrasSelec.Size = new System.Drawing.Size(346, 251);
            this.GridView_ExtrasSelec.TabIndex = 31;
            // 
            // GridView_TodosExtras
            // 
            this.GridView_TodosExtras.AllowUserToAddRows = false;
            this.GridView_TodosExtras.AllowUserToDeleteRows = false;
            this.GridView_TodosExtras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridView_TodosExtras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView_TodosExtras.Location = new System.Drawing.Point(28, 28);
            this.GridView_TodosExtras.Name = "GridView_TodosExtras";
            this.GridView_TodosExtras.ReadOnly = true;
            this.GridView_TodosExtras.Size = new System.Drawing.Size(408, 251);
            this.GridView_TodosExtras.TabIndex = 30;
            // 
            // Boton_Confirmar
            // 
            this.Boton_Confirmar.Location = new System.Drawing.Point(463, 256);
            this.Boton_Confirmar.Name = "Boton_Confirmar";
            this.Boton_Confirmar.Size = new System.Drawing.Size(109, 23);
            this.Boton_Confirmar.TabIndex = 34;
            this.Boton_Confirmar.Text = "Confirmar";
            this.Boton_Confirmar.UseVisualStyleBackColor = true;
            this.Boton_Confirmar.Click += new System.EventHandler(this.Boton_Confirmar_Click);
            // 
            // GUI_SeleccionExtras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.Boton_Confirmar);
            this.Controls.Add(this.Boton_QuitarIng);
            this.Controls.Add(this.Boton_AgregarExtra);
            this.Controls.Add(this.GridView_ExtrasSelec);
            this.Controls.Add(this.GridView_TodosExtras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "GUI_SeleccionExtras";
            this.Text = "GUI_SeleccionExtras";
            this.Load += new System.EventHandler(this.GUI_SeleccionExtras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridView_ExtrasSelec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_TodosExtras)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Boton_QuitarIng;
        private System.Windows.Forms.Button Boton_AgregarExtra;
        private System.Windows.Forms.DataGridView GridView_ExtrasSelec;
        private System.Windows.Forms.DataGridView GridView_TodosExtras;
        private System.Windows.Forms.Button Boton_Confirmar;
    }
}
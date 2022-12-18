
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_SeleccionBebidas));
            this.Boton_Confirmar = new System.Windows.Forms.Button();
            this.GridView_BebidasSelec = new System.Windows.Forms.DataGridView();
            this.GridView_TodosBebidas = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Boton_QuitarBebida = new System.Windows.Forms.Button();
            this.Boton_AgregarBebida = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_BebidasSelec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_TodosBebidas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Boton_Confirmar
            // 
            this.Boton_Confirmar.Location = new System.Drawing.Point(851, 500);
            this.Boton_Confirmar.Name = "Boton_Confirmar";
            this.Boton_Confirmar.Size = new System.Drawing.Size(110, 50);
            this.Boton_Confirmar.TabIndex = 39;
            this.Boton_Confirmar.Text = "Confirmar Pedido Bebidas";
            this.Boton_Confirmar.UseVisualStyleBackColor = true;
            this.Boton_Confirmar.Click += new System.EventHandler(this.Boton_Confirmar_Click);
            // 
            // GridView_BebidasSelec
            // 
            this.GridView_BebidasSelec.AllowUserToAddRows = false;
            this.GridView_BebidasSelec.AllowUserToDeleteRows = false;
            this.GridView_BebidasSelec.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridView_BebidasSelec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView_BebidasSelec.Location = new System.Drawing.Point(539, 17);
            this.GridView_BebidasSelec.Name = "GridView_BebidasSelec";
            this.GridView_BebidasSelec.ReadOnly = true;
            this.GridView_BebidasSelec.Size = new System.Drawing.Size(420, 450);
            this.GridView_BebidasSelec.TabIndex = 36;
            // 
            // GridView_TodosBebidas
            // 
            this.GridView_TodosBebidas.AllowUserToAddRows = false;
            this.GridView_TodosBebidas.AllowUserToDeleteRows = false;
            this.GridView_TodosBebidas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridView_TodosBebidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView_TodosBebidas.Location = new System.Drawing.Point(11, 17);
            this.GridView_TodosBebidas.Name = "GridView_TodosBebidas";
            this.GridView_TodosBebidas.ReadOnly = true;
            this.GridView_TodosBebidas.Size = new System.Drawing.Size(420, 450);
            this.GridView_TodosBebidas.TabIndex = 35;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Boton_QuitarBebida);
            this.groupBox1.Controls.Add(this.Boton_AgregarBebida);
            this.groupBox1.Controls.Add(this.GridView_BebidasSelec);
            this.groupBox1.Controls.Add(this.GridView_TodosBebidas);
            this.groupBox1.Location = new System.Drawing.Point(7, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(970, 480);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            // 
            // Boton_QuitarBebida
            // 
            this.Boton_QuitarBebida.BackColor = System.Drawing.SystemColors.Control;
            this.Boton_QuitarBebida.BackgroundImage = global::TrabajoFinal.Properties.Resources.Izq;
            this.Boton_QuitarBebida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Boton_QuitarBebida.Location = new System.Drawing.Point(453, 279);
            this.Boton_QuitarBebida.Name = "Boton_QuitarBebida";
            this.Boton_QuitarBebida.Size = new System.Drawing.Size(65, 70);
            this.Boton_QuitarBebida.TabIndex = 38;
            this.Boton_QuitarBebida.Text = "Quitar Bebida";
            this.Boton_QuitarBebida.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Boton_QuitarBebida.UseVisualStyleBackColor = false;
            this.Boton_QuitarBebida.Click += new System.EventHandler(this.Boton_QuitarBebida_Click);
            // 
            // Boton_AgregarBebida
            // 
            this.Boton_AgregarBebida.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Boton_AgregarBebida.BackgroundImage")));
            this.Boton_AgregarBebida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Boton_AgregarBebida.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Boton_AgregarBebida.Location = new System.Drawing.Point(453, 186);
            this.Boton_AgregarBebida.Name = "Boton_AgregarBebida";
            this.Boton_AgregarBebida.Size = new System.Drawing.Size(65, 70);
            this.Boton_AgregarBebida.TabIndex = 37;
            this.Boton_AgregarBebida.Text = "Agregar Bebida";
            this.Boton_AgregarBebida.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Boton_AgregarBebida.UseVisualStyleBackColor = true;
            this.Boton_AgregarBebida.Click += new System.EventHandler(this.Boton_AgregarBebida_Click);
            // 
            // GUI_SeleccionBebidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TrabajoFinal.Properties.Resources.BlueShade2;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Boton_Confirmar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "GUI_SeleccionBebidas";
            this.Text = "GUI_SeleccionBebidas";
            this.Load += new System.EventHandler(this.GUI_SeleccionBebidas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridView_BebidasSelec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_TodosBebidas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Boton_Confirmar;
        private System.Windows.Forms.Button Boton_QuitarBebida;
        private System.Windows.Forms.Button Boton_AgregarBebida;
        private System.Windows.Forms.DataGridView GridView_BebidasSelec;
        private System.Windows.Forms.DataGridView GridView_TodosBebidas;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
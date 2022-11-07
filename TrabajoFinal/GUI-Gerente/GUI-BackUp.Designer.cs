
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
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_BackUps)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView_BackUps
            // 
            this.DataGridView_BackUps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_BackUps.Location = new System.Drawing.Point(12, 51);
            this.DataGridView_BackUps.Name = "DataGridView_BackUps";
            this.DataGridView_BackUps.Size = new System.Drawing.Size(1063, 206);
            this.DataGridView_BackUps.TabIndex = 0;
            // 
            // Boton_BackUp
            // 
            this.Boton_BackUp.Location = new System.Drawing.Point(310, 304);
            this.Boton_BackUp.Name = "Boton_BackUp";
            this.Boton_BackUp.Size = new System.Drawing.Size(75, 23);
            this.Boton_BackUp.TabIndex = 1;
            this.Boton_BackUp.Text = "Backup";
            this.Boton_BackUp.UseVisualStyleBackColor = true;
            this.Boton_BackUp.Click += new System.EventHandler(this.Boton_BackUp_Click);
            // 
            // Boton_Restore
            // 
            this.Boton_Restore.Location = new System.Drawing.Point(594, 304);
            this.Boton_Restore.Name = "Boton_Restore";
            this.Boton_Restore.Size = new System.Drawing.Size(75, 23);
            this.Boton_Restore.TabIndex = 2;
            this.Boton_Restore.Text = "Restore";
            this.Boton_Restore.UseVisualStyleBackColor = true;
            this.Boton_Restore.Click += new System.EventHandler(this.Boton_Restore_Click);
            // 
            // GUI_BackUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 448);
            this.Controls.Add(this.Boton_Restore);
            this.Controls.Add(this.Boton_BackUp);
            this.Controls.Add(this.DataGridView_BackUps);
            this.Name = "GUI_BackUp";
            this.Text = "GUI_BackUp";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_BackUps)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridView_BackUps;
        private System.Windows.Forms.Button Boton_BackUp;
        private System.Windows.Forms.Button Boton_Restore;
    }
}

namespace TrabajoFinal
{
    partial class GUI_Admin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Grilla_PermisosNoAsignados = new System.Windows.Forms.DataGridView();
            this.Grilla_PermisosAsignados = new System.Windows.Forms.DataGridView();
            this.Grilla_Roles = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla_PermisosNoAsignados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla_PermisosAsignados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla_Roles)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Roles";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(301, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Permisos Asignados";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(457, 270);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 23);
            this.button2.TabIndex = 27;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(457, 241);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Grilla_PermisosNoAsignados
            // 
            this.Grilla_PermisosNoAsignados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grilla_PermisosNoAsignados.Location = new System.Drawing.Point(535, 133);
            this.Grilla_PermisosNoAsignados.Name = "Grilla_PermisosNoAsignados";
            this.Grilla_PermisosNoAsignados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grilla_PermisosNoAsignados.Size = new System.Drawing.Size(205, 293);
            this.Grilla_PermisosNoAsignados.TabIndex = 25;
            // 
            // Grilla_PermisosAsignados
            // 
            this.Grilla_PermisosAsignados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grilla_PermisosAsignados.Location = new System.Drawing.Point(256, 133);
            this.Grilla_PermisosAsignados.Name = "Grilla_PermisosAsignados";
            this.Grilla_PermisosAsignados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grilla_PermisosAsignados.Size = new System.Drawing.Size(195, 293);
            this.Grilla_PermisosAsignados.TabIndex = 24;
            // 
            // Grilla_Roles
            // 
            this.Grilla_Roles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grilla_Roles.Location = new System.Drawing.Point(12, 133);
            this.Grilla_Roles.Name = "Grilla_Roles";
            this.Grilla_Roles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grilla_Roles.Size = new System.Drawing.Size(196, 293);
            this.Grilla_Roles.TabIndex = 23;
            this.Grilla_Roles.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Grilla_Roles_MouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(580, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Permisos No Asignados";
            // 
            // GUI_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 516);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Grilla_PermisosNoAsignados);
            this.Controls.Add(this.Grilla_PermisosAsignados);
            this.Controls.Add(this.Grilla_Roles);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GUI_Admin";
            this.Text = "GUI_Admin";
            this.Load += new System.EventHandler(this.GUI_Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grilla_PermisosNoAsignados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla_PermisosAsignados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla_Roles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView Grilla_PermisosNoAsignados;
        private System.Windows.Forms.DataGridView Grilla_PermisosAsignados;
        private System.Windows.Forms.DataGridView Grilla_Roles;
        private System.Windows.Forms.Label label3;
    }
}
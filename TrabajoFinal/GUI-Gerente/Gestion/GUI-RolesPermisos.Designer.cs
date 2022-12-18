
namespace TrabajoFinal
{
    partial class GUI_RolesPermisos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_RolesPermisos));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Grilla_PermisosNoAsignados = new System.Windows.Forms.DataGridView();
            this.Grilla_PermisosAsignados = new System.Windows.Forms.DataGridView();
            this.Grilla_Roles = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.Boton_CrearRol = new System.Windows.Forms.Button();
            this.uC_ValCod1 = new TrabajoFinal.UC_ValCod();
            this.uC_ValNombApe1 = new TrabajoFinal.UC_ValNombApe();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla_PermisosNoAsignados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla_PermisosAsignados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla_Roles)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Roles";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Permisos Asignados";
            // 
            // Grilla_PermisosNoAsignados
            // 
            this.Grilla_PermisosNoAsignados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grilla_PermisosNoAsignados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grilla_PermisosNoAsignados.Location = new System.Drawing.Point(372, 38);
            this.Grilla_PermisosNoAsignados.Name = "Grilla_PermisosNoAsignados";
            this.Grilla_PermisosNoAsignados.ReadOnly = true;
            this.Grilla_PermisosNoAsignados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grilla_PermisosNoAsignados.Size = new System.Drawing.Size(280, 476);
            this.Grilla_PermisosNoAsignados.TabIndex = 25;
            // 
            // Grilla_PermisosAsignados
            // 
            this.Grilla_PermisosAsignados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grilla_PermisosAsignados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grilla_PermisosAsignados.Location = new System.Drawing.Point(13, 38);
            this.Grilla_PermisosAsignados.Name = "Grilla_PermisosAsignados";
            this.Grilla_PermisosAsignados.ReadOnly = true;
            this.Grilla_PermisosAsignados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grilla_PermisosAsignados.Size = new System.Drawing.Size(280, 476);
            this.Grilla_PermisosAsignados.TabIndex = 24;
            // 
            // Grilla_Roles
            // 
            this.Grilla_Roles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grilla_Roles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grilla_Roles.Location = new System.Drawing.Point(21, 41);
            this.Grilla_Roles.Name = "Grilla_Roles";
            this.Grilla_Roles.ReadOnly = true;
            this.Grilla_Roles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grilla_Roles.Size = new System.Drawing.Size(243, 356);
            this.Grilla_Roles.TabIndex = 23;
            this.Grilla_Roles.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Grilla_Roles_MouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(369, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Permisos No Asignados";
            // 
            // Boton_CrearRol
            // 
            this.Boton_CrearRol.BackColor = System.Drawing.Color.Honeydew;
            this.Boton_CrearRol.Location = new System.Drawing.Point(146, 44);
            this.Boton_CrearRol.Name = "Boton_CrearRol";
            this.Boton_CrearRol.Size = new System.Drawing.Size(69, 64);
            this.Boton_CrearRol.TabIndex = 29;
            this.Boton_CrearRol.Text = "Crear Nuevo Rol";
            this.Boton_CrearRol.UseVisualStyleBackColor = false;
            this.Boton_CrearRol.Click += new System.EventHandler(this.Boton_CrearRol_Click);
            // 
            // uC_ValCod1
            // 
            this.uC_ValCod1.Location = new System.Drawing.Point(9, 44);
            this.uC_ValCod1.Name = "uC_ValCod1";
            this.uC_ValCod1.Size = new System.Drawing.Size(109, 20);
            this.uC_ValCod1.TabIndex = 30;
            // 
            // uC_ValNombApe1
            // 
            this.uC_ValNombApe1.Location = new System.Drawing.Point(9, 91);
            this.uC_ValNombApe1.Name = "uC_ValNombApe1";
            this.uC_ValNombApe1.Size = new System.Drawing.Size(109, 20);
            this.uC_ValNombApe1.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Código";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Descripción";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(174)))), ((int)(((byte)(228)))));
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.uC_ValNombApe1);
            this.groupBox1.Controls.Add(this.uC_ValCod1);
            this.groupBox1.Controls.Add(this.Boton_CrearRol);
            this.groupBox1.Location = new System.Drawing.Point(21, 422);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 127);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nuevo Rol";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(174)))), ((int)(((byte)(228)))));
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.Grilla_PermisosNoAsignados);
            this.groupBox2.Controls.Add(this.Grilla_PermisosAsignados);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(308, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(664, 533);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Permisos del Rol";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(299, 266);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 70);
            this.button2.TabIndex = 27;
            this.button2.Text = "Quitar Permisos";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::TrabajoFinal.Properties.Resources.Izq;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(299, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 70);
            this.button1.TabIndex = 26;
            this.button1.Text = "Agregar Permisos";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GUI_RolesPermisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TrabajoFinal.Properties.Resources.BlueShade2;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Grilla_Roles);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "GUI_RolesPermisos";
            this.Text = "GUI_Admin";
            this.Load += new System.EventHandler(this.GUI_Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grilla_PermisosNoAsignados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla_PermisosAsignados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla_Roles)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView Grilla_PermisosNoAsignados;
        private System.Windows.Forms.DataGridView Grilla_PermisosAsignados;
        private System.Windows.Forms.DataGridView Grilla_Roles;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Boton_CrearRol;
        private UC_ValCod uC_ValCod1;
        private UC_ValNombApe uC_ValNombApe1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}
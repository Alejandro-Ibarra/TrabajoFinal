
namespace TrabajoFinal
{
    partial class GUI_Gerente_Personal
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
            this.Nombre = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Pass = new System.Windows.Forms.TextBox();
            this.Grilla_Usuarios = new System.Windows.Forms.DataGridView();
            this.Grilla_RolesAsignados = new System.Windows.Forms.DataGridView();
            this.Boton_Alta = new System.Windows.Forms.Button();
            this.Boton_Baja = new System.Windows.Forms.Button();
            this.Boton_Modificar = new System.Windows.Forms.Button();
            this.GroupBox_Turno = new System.Windows.Forms.GroupBox();
            this.RadioButton_Noche = new System.Windows.Forms.RadioButton();
            this.RadioButton_Tarde = new System.Windows.Forms.RadioButton();
            this.RadioButton_Mañana = new System.Windows.Forms.RadioButton();
            this.Grilla_RolesNoAsignados = new System.Windows.Forms.DataGridView();
            this.Boton_Agregar = new System.Windows.Forms.Button();
            this.Boton_Quitar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RadioButton_Cocinero = new System.Windows.Forms.RadioButton();
            this.RadioButton_Mozo = new System.Windows.Forms.RadioButton();
            this.Boton_MostrarPsw = new System.Windows.Forms.Button();
            this.UC_ValDNI = new TrabajoFinal.UC_ValDNI();
            this.UC_ValNomb = new TrabajoFinal.UC_ValNombApe();
            this.UC_ValApe = new TrabajoFinal.UC_ValNombApe();
            this.treeView1 = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla_Usuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla_RolesAsignados)).BeginInit();
            this.GroupBox_Turno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla_RolesNoAsignados)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Apellido";
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(141, 80);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(44, 13);
            this.Nombre.TabIndex = 3;
            this.Nombre.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "DNI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Contraseña";
            // 
            // textBox_Pass
            // 
            this.textBox_Pass.Location = new System.Drawing.Point(12, 112);
            this.textBox_Pass.Name = "textBox_Pass";
            this.textBox_Pass.Size = new System.Drawing.Size(100, 20);
            this.textBox_Pass.TabIndex = 10;
            this.textBox_Pass.UseSystemPasswordChar = true;
            // 
            // Grilla_Usuarios
            // 
            this.Grilla_Usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grilla_Usuarios.Location = new System.Drawing.Point(12, 170);
            this.Grilla_Usuarios.Name = "Grilla_Usuarios";
            this.Grilla_Usuarios.Size = new System.Drawing.Size(613, 172);
            this.Grilla_Usuarios.TabIndex = 13;
            this.Grilla_Usuarios.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Grilla_Usuarios_MouseClick);
            // 
            // Grilla_RolesAsignados
            // 
            this.Grilla_RolesAsignados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grilla_RolesAsignados.Location = new System.Drawing.Point(12, 371);
            this.Grilla_RolesAsignados.Name = "Grilla_RolesAsignados";
            this.Grilla_RolesAsignados.Size = new System.Drawing.Size(232, 140);
            this.Grilla_RolesAsignados.TabIndex = 14;
            // 
            // Boton_Alta
            // 
            this.Boton_Alta.Location = new System.Drawing.Point(502, 41);
            this.Boton_Alta.Name = "Boton_Alta";
            this.Boton_Alta.Size = new System.Drawing.Size(75, 23);
            this.Boton_Alta.TabIndex = 15;
            this.Boton_Alta.Text = "Alta";
            this.Boton_Alta.UseVisualStyleBackColor = true;
            this.Boton_Alta.Click += new System.EventHandler(this.Boton_Alta_Click);
            // 
            // Boton_Baja
            // 
            this.Boton_Baja.Location = new System.Drawing.Point(502, 70);
            this.Boton_Baja.Name = "Boton_Baja";
            this.Boton_Baja.Size = new System.Drawing.Size(75, 23);
            this.Boton_Baja.TabIndex = 16;
            this.Boton_Baja.Text = "Baja";
            this.Boton_Baja.UseVisualStyleBackColor = true;
            this.Boton_Baja.Click += new System.EventHandler(this.Boton_Baja_Click);
            // 
            // Boton_Modificar
            // 
            this.Boton_Modificar.Location = new System.Drawing.Point(502, 99);
            this.Boton_Modificar.Name = "Boton_Modificar";
            this.Boton_Modificar.Size = new System.Drawing.Size(75, 23);
            this.Boton_Modificar.TabIndex = 17;
            this.Boton_Modificar.Text = "Modificar";
            this.Boton_Modificar.UseVisualStyleBackColor = true;
            this.Boton_Modificar.Click += new System.EventHandler(this.Boton_Modificar_Click);
            // 
            // GroupBox_Turno
            // 
            this.GroupBox_Turno.Controls.Add(this.RadioButton_Noche);
            this.GroupBox_Turno.Controls.Add(this.RadioButton_Tarde);
            this.GroupBox_Turno.Controls.Add(this.RadioButton_Mañana);
            this.GroupBox_Turno.Location = new System.Drawing.Point(274, 17);
            this.GroupBox_Turno.Name = "GroupBox_Turno";
            this.GroupBox_Turno.Size = new System.Drawing.Size(99, 101);
            this.GroupBox_Turno.TabIndex = 19;
            this.GroupBox_Turno.TabStop = false;
            this.GroupBox_Turno.Text = "Turno";
            // 
            // RadioButton_Noche
            // 
            this.RadioButton_Noche.AutoSize = true;
            this.RadioButton_Noche.Location = new System.Drawing.Point(16, 67);
            this.RadioButton_Noche.Name = "RadioButton_Noche";
            this.RadioButton_Noche.Size = new System.Drawing.Size(57, 17);
            this.RadioButton_Noche.TabIndex = 13;
            this.RadioButton_Noche.Text = "Noche";
            this.RadioButton_Noche.UseVisualStyleBackColor = true;
            // 
            // RadioButton_Tarde
            // 
            this.RadioButton_Tarde.AutoSize = true;
            this.RadioButton_Tarde.Location = new System.Drawing.Point(16, 42);
            this.RadioButton_Tarde.Name = "RadioButton_Tarde";
            this.RadioButton_Tarde.Size = new System.Drawing.Size(53, 17);
            this.RadioButton_Tarde.TabIndex = 11;
            this.RadioButton_Tarde.Text = "Tarde";
            this.RadioButton_Tarde.UseVisualStyleBackColor = true;
            // 
            // RadioButton_Mañana
            // 
            this.RadioButton_Mañana.AutoSize = true;
            this.RadioButton_Mañana.Checked = true;
            this.RadioButton_Mañana.Location = new System.Drawing.Point(16, 19);
            this.RadioButton_Mañana.Name = "RadioButton_Mañana";
            this.RadioButton_Mañana.Size = new System.Drawing.Size(64, 17);
            this.RadioButton_Mañana.TabIndex = 12;
            this.RadioButton_Mañana.TabStop = true;
            this.RadioButton_Mañana.Text = "Mañana";
            this.RadioButton_Mañana.UseVisualStyleBackColor = true;
            // 
            // Grilla_RolesNoAsignados
            // 
            this.Grilla_RolesNoAsignados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grilla_RolesNoAsignados.Location = new System.Drawing.Point(366, 371);
            this.Grilla_RolesNoAsignados.Name = "Grilla_RolesNoAsignados";
            this.Grilla_RolesNoAsignados.Size = new System.Drawing.Size(211, 140);
            this.Grilla_RolesNoAsignados.TabIndex = 20;
            // 
            // Boton_Agregar
            // 
            this.Boton_Agregar.Location = new System.Drawing.Point(274, 422);
            this.Boton_Agregar.Name = "Boton_Agregar";
            this.Boton_Agregar.Size = new System.Drawing.Size(65, 23);
            this.Boton_Agregar.TabIndex = 21;
            this.Boton_Agregar.Text = "Agregar";
            this.Boton_Agregar.UseVisualStyleBackColor = true;
            this.Boton_Agregar.Click += new System.EventHandler(this.Boton_Agregar_Click);
            // 
            // Boton_Quitar
            // 
            this.Boton_Quitar.Location = new System.Drawing.Point(274, 451);
            this.Boton_Quitar.Name = "Boton_Quitar";
            this.Boton_Quitar.Size = new System.Drawing.Size(65, 23);
            this.Boton_Quitar.TabIndex = 22;
            this.Boton_Quitar.Text = "Quitar";
            this.Boton_Quitar.UseVisualStyleBackColor = true;
            this.Boton_Quitar.Click += new System.EventHandler(this.Boton_Quitar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Usuarios";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(406, 355);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Roles No Asignados";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(54, 355);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Roles Asignados";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RadioButton_Cocinero);
            this.groupBox1.Controls.Add(this.RadioButton_Mozo);
            this.groupBox1.Location = new System.Drawing.Point(379, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(99, 76);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rol";
            // 
            // RadioButton_Cocinero
            // 
            this.RadioButton_Cocinero.AutoSize = true;
            this.RadioButton_Cocinero.Location = new System.Drawing.Point(16, 42);
            this.RadioButton_Cocinero.Name = "RadioButton_Cocinero";
            this.RadioButton_Cocinero.Size = new System.Drawing.Size(67, 17);
            this.RadioButton_Cocinero.TabIndex = 11;
            this.RadioButton_Cocinero.Text = "Cocinero";
            this.RadioButton_Cocinero.UseVisualStyleBackColor = true;
            // 
            // RadioButton_Mozo
            // 
            this.RadioButton_Mozo.AutoSize = true;
            this.RadioButton_Mozo.Checked = true;
            this.RadioButton_Mozo.Location = new System.Drawing.Point(16, 19);
            this.RadioButton_Mozo.Name = "RadioButton_Mozo";
            this.RadioButton_Mozo.Size = new System.Drawing.Size(51, 17);
            this.RadioButton_Mozo.TabIndex = 12;
            this.RadioButton_Mozo.TabStop = true;
            this.RadioButton_Mozo.Text = "Mozo";
            this.RadioButton_Mozo.UseVisualStyleBackColor = true;
            // 
            // Boton_MostrarPsw
            // 
            this.Boton_MostrarPsw.Location = new System.Drawing.Point(379, 99);
            this.Boton_MostrarPsw.Name = "Boton_MostrarPsw";
            this.Boton_MostrarPsw.Size = new System.Drawing.Size(99, 23);
            this.Boton_MostrarPsw.TabIndex = 31;
            this.Boton_MostrarPsw.Text = "Mostrar psw";
            this.Boton_MostrarPsw.UseVisualStyleBackColor = true;
            this.Boton_MostrarPsw.Click += new System.EventHandler(this.Boton_MostrarPsw_Click);
            // 
            // UC_ValDNI
            // 
            this.UC_ValDNI.Location = new System.Drawing.Point(12, 48);
            this.UC_ValDNI.Name = "UC_ValDNI";
            this.UC_ValDNI.Size = new System.Drawing.Size(100, 20);
            this.UC_ValDNI.TabIndex = 5;
            // 
            // UC_ValNomb
            // 
            this.UC_ValNomb.Location = new System.Drawing.Point(144, 112);
            this.UC_ValNomb.Name = "UC_ValNomb";
            this.UC_ValNomb.Size = new System.Drawing.Size(100, 20);
            this.UC_ValNomb.TabIndex = 1;
            // 
            // UC_ValApe
            // 
            this.UC_ValApe.Location = new System.Drawing.Point(144, 48);
            this.UC_ValApe.Name = "UC_ValApe";
            this.UC_ValApe.Size = new System.Drawing.Size(100, 20);
            this.UC_ValApe.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.Location = new System.Drawing.Point(706, 54);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(267, 457);
            this.treeView1.TabIndex = 32;
            // 
            // GUI_Gerente_Personal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 536);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.Boton_MostrarPsw);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Boton_Quitar);
            this.Controls.Add(this.Boton_Agregar);
            this.Controls.Add(this.Grilla_RolesNoAsignados);
            this.Controls.Add(this.GroupBox_Turno);
            this.Controls.Add(this.Boton_Modificar);
            this.Controls.Add(this.Boton_Baja);
            this.Controls.Add(this.Boton_Alta);
            this.Controls.Add(this.Grilla_RolesAsignados);
            this.Controls.Add(this.Grilla_Usuarios);
            this.Controls.Add(this.textBox_Pass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UC_ValDNI);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UC_ValNomb);
            this.Controls.Add(this.UC_ValApe);
            this.Name = "GUI_Gerente_Personal";
            this.Text = "GUI_AdminPersonal";
            this.Load += new System.EventHandler(this.GUI_Administrar_Personal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grilla_Usuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla_RolesAsignados)).EndInit();
            this.GroupBox_Turno.ResumeLayout(false);
            this.GroupBox_Turno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla_RolesNoAsignados)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UC_ValNombApe UC_ValApe;
        private UC_ValNombApe UC_ValNomb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Nombre;
        private UC_ValDNI UC_ValDNI;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Pass;
        private System.Windows.Forms.DataGridView Grilla_Usuarios;
        private System.Windows.Forms.DataGridView Grilla_RolesAsignados;
        private System.Windows.Forms.Button Boton_Alta;
        private System.Windows.Forms.Button Boton_Baja;
        private System.Windows.Forms.Button Boton_Modificar;
        private System.Windows.Forms.GroupBox GroupBox_Turno;
        private System.Windows.Forms.RadioButton RadioButton_Noche;
        private System.Windows.Forms.RadioButton RadioButton_Tarde;
        private System.Windows.Forms.RadioButton RadioButton_Mañana;
        private System.Windows.Forms.DataGridView Grilla_RolesNoAsignados;
        private System.Windows.Forms.Button Boton_Agregar;
        private System.Windows.Forms.Button Boton_Quitar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RadioButton_Cocinero;
        private System.Windows.Forms.RadioButton RadioButton_Mozo;
        private System.Windows.Forms.Button Boton_MostrarPsw;
        private System.Windows.Forms.TreeView treeView1;
    }
}
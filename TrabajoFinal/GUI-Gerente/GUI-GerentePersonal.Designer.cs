
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
            this.label2 = new System.Windows.Forms.Label();
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
            this.UC_ValDNI = new TrabajoFinal.UC_ValDNI();
            this.UC_ValCod = new TrabajoFinal.UC_ValCod();
            this.UC_ValNomb = new TrabajoFinal.UC_ValNombApe();
            this.UC_ValApe = new TrabajoFinal.UC_ValNombApe();
            this.Grilla_RolesNoAsignados = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla_Usuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla_RolesAsignados)).BeginInit();
            this.GroupBox_Turno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla_RolesNoAsignados)).BeginInit();
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
            this.Nombre.Location = new System.Drawing.Point(271, 16);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(44, 13);
            this.Nombre.TabIndex = 3;
            this.Nombre.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Codigo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "DNI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(141, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Contraseña";
            // 
            // textBox_Pass
            // 
            this.textBox_Pass.Location = new System.Drawing.Point(144, 105);
            this.textBox_Pass.Name = "textBox_Pass";
            this.textBox_Pass.Size = new System.Drawing.Size(100, 20);
            this.textBox_Pass.TabIndex = 10;
            // 
            // Grilla_Usuarios
            // 
            this.Grilla_Usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grilla_Usuarios.Location = new System.Drawing.Point(12, 170);
            this.Grilla_Usuarios.Name = "Grilla_Usuarios";
            this.Grilla_Usuarios.Size = new System.Drawing.Size(613, 193);
            this.Grilla_Usuarios.TabIndex = 13;
            this.Grilla_Usuarios.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Grilla_Cocineros_MouseClick);
            // 
            // Grilla_RolesAsignados
            // 
            this.Grilla_RolesAsignados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grilla_RolesAsignados.Location = new System.Drawing.Point(74, 387);
            this.Grilla_RolesAsignados.Name = "Grilla_RolesAsignados";
            this.Grilla_RolesAsignados.Size = new System.Drawing.Size(179, 119);
            this.Grilla_RolesAsignados.TabIndex = 14;
            this.Grilla_RolesAsignados.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Grilla_Mozos_MouseClick);
            // 
            // Boton_Alta
            // 
            this.Boton_Alta.Location = new System.Drawing.Point(274, 83);
            this.Boton_Alta.Name = "Boton_Alta";
            this.Boton_Alta.Size = new System.Drawing.Size(75, 23);
            this.Boton_Alta.TabIndex = 15;
            this.Boton_Alta.Text = "Alta";
            this.Boton_Alta.UseVisualStyleBackColor = true;
            this.Boton_Alta.Click += new System.EventHandler(this.Boton_Alta_Click);
            // 
            // Boton_Baja
            // 
            this.Boton_Baja.Location = new System.Drawing.Point(274, 112);
            this.Boton_Baja.Name = "Boton_Baja";
            this.Boton_Baja.Size = new System.Drawing.Size(75, 23);
            this.Boton_Baja.TabIndex = 16;
            this.Boton_Baja.Text = "Baja";
            this.Boton_Baja.UseVisualStyleBackColor = true;
            this.Boton_Baja.Click += new System.EventHandler(this.Boton_Baja_Click);
            // 
            // Boton_Modificar
            // 
            this.Boton_Modificar.Location = new System.Drawing.Point(274, 141);
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
            this.GroupBox_Turno.Location = new System.Drawing.Point(398, 16);
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
            // UC_ValDNI
            // 
            this.UC_ValDNI.Location = new System.Drawing.Point(12, 105);
            this.UC_ValDNI.Name = "UC_ValDNI";
            this.UC_ValDNI.Size = new System.Drawing.Size(100, 20);
            this.UC_ValDNI.TabIndex = 5;
            // 
            // UC_ValCod
            // 
            this.UC_ValCod.Location = new System.Drawing.Point(12, 48);
            this.UC_ValCod.Name = "UC_ValCod";
            this.UC_ValCod.Size = new System.Drawing.Size(100, 20);
            this.UC_ValCod.TabIndex = 4;
            // 
            // UC_ValNomb
            // 
            this.UC_ValNomb.Location = new System.Drawing.Point(274, 48);
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
            // Grilla_RolesNoAsignados
            // 
            this.Grilla_RolesNoAsignados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grilla_RolesNoAsignados.Location = new System.Drawing.Point(371, 387);
            this.Grilla_RolesNoAsignados.Name = "Grilla_RolesNoAsignados";
            this.Grilla_RolesNoAsignados.Size = new System.Drawing.Size(179, 119);
            this.Grilla_RolesNoAsignados.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(274, 422);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(274, 451);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
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
            this.label6.Location = new System.Drawing.Point(411, 371);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Roles No Asignados";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(116, 371);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Roles Asignados";
            // 
            // GUI_Gerente_Personal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 518);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
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
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UC_ValDNI);
            this.Controls.Add(this.UC_ValCod);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UC_ValNombApe UC_ValApe;
        private UC_ValNombApe UC_ValNomb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Nombre;
        private UC_ValCod UC_ValCod;
        private UC_ValDNI UC_ValDNI;
        private System.Windows.Forms.Label label2;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}
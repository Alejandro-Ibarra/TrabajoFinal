
namespace TrabajoFinal
{
    partial class GUI_MenuPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStrip_Admin = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStrip_Personal = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStrip_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStrip_Ingredientes = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStrip_Bebidas = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStrip_Platos = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStrip_Evento = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStrip_Extras = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStrip_Mesas = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStrip_BackUp = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStrip_Roles = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStrip_Cocinero = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStrip_Mozo = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStrip_CerrarSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStrip_Metricas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStrip_Admin,
            this.ToolStrip_Cocinero,
            this.ToolStrip_Mozo,
            this.ToolStrip_CerrarSesion});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(840, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStrip_Admin
            // 
            this.ToolStrip_Admin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStrip_Personal,
            this.ToolStrip_Menu,
            this.ToolStrip_Evento,
            this.ToolStrip_Extras,
            this.ToolStrip_Mesas,
            this.ToolStrip_BackUp,
            this.ToolStrip_Roles,
            this.ToolStrip_Metricas});
            this.ToolStrip_Admin.Name = "ToolStrip_Admin";
            this.ToolStrip_Admin.Size = new System.Drawing.Size(55, 20);
            this.ToolStrip_Admin.Text = "Admin";
            this.ToolStrip_Admin.Visible = false;
            // 
            // ToolStrip_Personal
            // 
            this.ToolStrip_Personal.Name = "ToolStrip_Personal";
            this.ToolStrip_Personal.Size = new System.Drawing.Size(180, 22);
            this.ToolStrip_Personal.Text = "Personal";
            this.ToolStrip_Personal.Visible = false;
            this.ToolStrip_Personal.Click += new System.EventHandler(this.ToolStrip_Personal_Click);
            // 
            // ToolStrip_Menu
            // 
            this.ToolStrip_Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStrip_Ingredientes,
            this.ToolStrip_Bebidas,
            this.ToolStrip_Platos});
            this.ToolStrip_Menu.Name = "ToolStrip_Menu";
            this.ToolStrip_Menu.Size = new System.Drawing.Size(180, 22);
            this.ToolStrip_Menu.Text = "Menu";
            this.ToolStrip_Menu.Visible = false;
            // 
            // ToolStrip_Ingredientes
            // 
            this.ToolStrip_Ingredientes.Name = "ToolStrip_Ingredientes";
            this.ToolStrip_Ingredientes.Size = new System.Drawing.Size(139, 22);
            this.ToolStrip_Ingredientes.Text = "Ingredientes";
            this.ToolStrip_Ingredientes.Visible = false;
            this.ToolStrip_Ingredientes.Click += new System.EventHandler(this.ToolStrip_Ingredientes_Click);
            // 
            // ToolStrip_Bebidas
            // 
            this.ToolStrip_Bebidas.Name = "ToolStrip_Bebidas";
            this.ToolStrip_Bebidas.Size = new System.Drawing.Size(139, 22);
            this.ToolStrip_Bebidas.Text = "Bebidas";
            this.ToolStrip_Bebidas.Visible = false;
            this.ToolStrip_Bebidas.Click += new System.EventHandler(this.ToolStrip_Bebidas_Click);
            // 
            // ToolStrip_Platos
            // 
            this.ToolStrip_Platos.Name = "ToolStrip_Platos";
            this.ToolStrip_Platos.Size = new System.Drawing.Size(139, 22);
            this.ToolStrip_Platos.Text = "Platos";
            this.ToolStrip_Platos.Visible = false;
            this.ToolStrip_Platos.Click += new System.EventHandler(this.ToolStrip_Platos_Click);
            // 
            // ToolStrip_Evento
            // 
            this.ToolStrip_Evento.Name = "ToolStrip_Evento";
            this.ToolStrip_Evento.Size = new System.Drawing.Size(180, 22);
            this.ToolStrip_Evento.Text = "Eventos";
            this.ToolStrip_Evento.Visible = false;
            this.ToolStrip_Evento.Click += new System.EventHandler(this.ToolStrip_Evento_Click);
            // 
            // ToolStrip_Extras
            // 
            this.ToolStrip_Extras.Name = "ToolStrip_Extras";
            this.ToolStrip_Extras.Size = new System.Drawing.Size(180, 22);
            this.ToolStrip_Extras.Text = "Extras";
            this.ToolStrip_Extras.Visible = false;
            this.ToolStrip_Extras.Click += new System.EventHandler(this.ToolStrip_Extras_Click);
            // 
            // ToolStrip_Mesas
            // 
            this.ToolStrip_Mesas.Name = "ToolStrip_Mesas";
            this.ToolStrip_Mesas.Size = new System.Drawing.Size(180, 22);
            this.ToolStrip_Mesas.Text = "Mesas";
            this.ToolStrip_Mesas.Visible = false;
            this.ToolStrip_Mesas.Click += new System.EventHandler(this.ToolStrip_Mesas_Click);
            // 
            // ToolStrip_BackUp
            // 
            this.ToolStrip_BackUp.Name = "ToolStrip_BackUp";
            this.ToolStrip_BackUp.Size = new System.Drawing.Size(180, 22);
            this.ToolStrip_BackUp.Text = "BackUp/Restore";
            this.ToolStrip_BackUp.Click += new System.EventHandler(this.ToolStrip_BackUp_Click);
            // 
            // ToolStrip_Roles
            // 
            this.ToolStrip_Roles.Name = "ToolStrip_Roles";
            this.ToolStrip_Roles.Size = new System.Drawing.Size(180, 22);
            this.ToolStrip_Roles.Text = "Roles/Permisos";
            this.ToolStrip_Roles.Click += new System.EventHandler(this.ToolStrip_Roles_Click);
            // 
            // ToolStrip_Cocinero
            // 
            this.ToolStrip_Cocinero.Name = "ToolStrip_Cocinero";
            this.ToolStrip_Cocinero.Size = new System.Drawing.Size(67, 20);
            this.ToolStrip_Cocinero.Text = "Cocinero";
            this.ToolStrip_Cocinero.Visible = false;
            this.ToolStrip_Cocinero.Click += new System.EventHandler(this.ToolStrip_Cocinero_Click);
            // 
            // ToolStrip_Mozo
            // 
            this.ToolStrip_Mozo.Name = "ToolStrip_Mozo";
            this.ToolStrip_Mozo.Size = new System.Drawing.Size(49, 20);
            this.ToolStrip_Mozo.Text = "Mozo";
            this.ToolStrip_Mozo.Visible = false;
            this.ToolStrip_Mozo.Click += new System.EventHandler(this.ToolStrip_Mozo_Click);
            // 
            // ToolStrip_CerrarSesion
            // 
            this.ToolStrip_CerrarSesion.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ToolStrip_CerrarSesion.Name = "ToolStrip_CerrarSesion";
            this.ToolStrip_CerrarSesion.Size = new System.Drawing.Size(88, 20);
            this.ToolStrip_CerrarSesion.Text = "Cerrar Sesion";
            this.ToolStrip_CerrarSesion.Click += new System.EventHandler(this.ToolStrip_CerrarSesion_Click);
            // 
            // ToolStrip_Metricas
            // 
            this.ToolStrip_Metricas.Name = "ToolStrip_Metricas";
            this.ToolStrip_Metricas.Size = new System.Drawing.Size(180, 22);
            this.ToolStrip_Metricas.Text = "Metricas";
            this.ToolStrip_Metricas.Click += new System.EventHandler(this.ToolStrip_Metricas_Click);
            // 
            // GUI_MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 521);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GUI_MenuPrincipal";
            this.Text = "GUI_MenuPrincipal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStrip_Admin;
        private System.Windows.Forms.ToolStripMenuItem ToolStrip_Personal;
        private System.Windows.Forms.ToolStripMenuItem ToolStrip_Menu;
        private System.Windows.Forms.ToolStripMenuItem ToolStrip_Ingredientes;
        private System.Windows.Forms.ToolStripMenuItem ToolStrip_Bebidas;
        private System.Windows.Forms.ToolStripMenuItem ToolStrip_Platos;
        private System.Windows.Forms.ToolStripMenuItem ToolStrip_Evento;
        private System.Windows.Forms.ToolStripMenuItem ToolStrip_Extras;
        private System.Windows.Forms.ToolStripMenuItem ToolStrip_Mesas;
        private System.Windows.Forms.ToolStripMenuItem ToolStrip_Cocinero;
        private System.Windows.Forms.ToolStripMenuItem ToolStrip_Mozo;
        private System.Windows.Forms.ToolStripMenuItem ToolStrip_BackUp;
        private System.Windows.Forms.ToolStripMenuItem ToolStrip_Roles;
        private System.Windows.Forms.ToolStripMenuItem ToolStrip_CerrarSesion;
        private System.Windows.Forms.ToolStripMenuItem ToolStrip_Metricas;
    }
}
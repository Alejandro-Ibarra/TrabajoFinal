
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_MenuPrincipal));
            this.Panel = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Toolstrip_Admin = new System.Windows.Forms.ToolStripMenuItem();
            this.Toolstrip_Personal = new System.Windows.Forms.ToolStripMenuItem();
            this.Toolstrip_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Toolstrip_Ingredientes = new System.Windows.Forms.ToolStripMenuItem();
            this.Toolstrip_Platos = new System.Windows.Forms.ToolStripMenuItem();
            this.Toolstrip_Bebidas = new System.Windows.Forms.ToolStripMenuItem();
            this.Toolstrip_Extras = new System.Windows.Forms.ToolStripMenuItem();
            this.Toolstrip_Eventos = new System.Windows.Forms.ToolStripMenuItem();
            this.Toolstrip_Backup = new System.Windows.Forms.ToolStripMenuItem();
            this.Toolstrip_Roles = new System.Windows.Forms.ToolStripMenuItem();
            this.Toolstrip_Metricas = new System.Windows.Forms.ToolStripMenuItem();
            this.Toolstrip_Cocinero = new System.Windows.Forms.ToolStripMenuItem();
            this.Toolstrip_Mozo = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStrip_CerrarSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel
            // 
            this.Panel.BackColor = System.Drawing.SystemColors.Control;
            this.Panel.BackgroundImage = global::TrabajoFinal.Properties.Resources.BlueShade2;
            this.Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel.Location = new System.Drawing.Point(0, 24);
            this.Panel.Margin = new System.Windows.Forms.Padding(0);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(1000, 600);
            this.Panel.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Toolstrip_Admin,
            this.Toolstrip_Cocinero,
            this.Toolstrip_Mozo,
            this.ToolStrip_CerrarSesion});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1000, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Toolstrip_Admin
            // 
            this.Toolstrip_Admin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Toolstrip_Personal,
            this.Toolstrip_Menu,
            this.Toolstrip_Eventos,
            this.Toolstrip_Backup,
            this.Toolstrip_Roles,
            this.Toolstrip_Metricas});
            this.Toolstrip_Admin.Name = "Toolstrip_Admin";
            this.Toolstrip_Admin.Size = new System.Drawing.Size(55, 20);
            this.Toolstrip_Admin.Text = "Admin";
            this.Toolstrip_Admin.Visible = false;
            // 
            // Toolstrip_Personal
            // 
            this.Toolstrip_Personal.Name = "Toolstrip_Personal";
            this.Toolstrip_Personal.Size = new System.Drawing.Size(158, 22);
            this.Toolstrip_Personal.Text = "Personal";
            this.Toolstrip_Personal.Click += new System.EventHandler(this.Toolstrip_Personal_Click);
            // 
            // Toolstrip_Menu
            // 
            this.Toolstrip_Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Toolstrip_Ingredientes,
            this.Toolstrip_Platos,
            this.Toolstrip_Bebidas,
            this.Toolstrip_Extras});
            this.Toolstrip_Menu.Name = "Toolstrip_Menu";
            this.Toolstrip_Menu.Size = new System.Drawing.Size(158, 22);
            this.Toolstrip_Menu.Text = "Menu";
            // 
            // Toolstrip_Ingredientes
            // 
            this.Toolstrip_Ingredientes.Name = "Toolstrip_Ingredientes";
            this.Toolstrip_Ingredientes.Size = new System.Drawing.Size(139, 22);
            this.Toolstrip_Ingredientes.Text = "Ingredientes";
            this.Toolstrip_Ingredientes.Visible = false;
            this.Toolstrip_Ingredientes.Click += new System.EventHandler(this.Toolstrip_Ingredientes_Click);
            // 
            // Toolstrip_Platos
            // 
            this.Toolstrip_Platos.Name = "Toolstrip_Platos";
            this.Toolstrip_Platos.Size = new System.Drawing.Size(139, 22);
            this.Toolstrip_Platos.Text = "Platos";
            this.Toolstrip_Platos.Visible = false;
            this.Toolstrip_Platos.Click += new System.EventHandler(this.Toolstrip_Platos_Click);
            // 
            // Toolstrip_Bebidas
            // 
            this.Toolstrip_Bebidas.Name = "Toolstrip_Bebidas";
            this.Toolstrip_Bebidas.Size = new System.Drawing.Size(139, 22);
            this.Toolstrip_Bebidas.Text = "Bebidas";
            this.Toolstrip_Bebidas.Visible = false;
            this.Toolstrip_Bebidas.Click += new System.EventHandler(this.Toolstrip_Bebidas_Click);
            // 
            // Toolstrip_Extras
            // 
            this.Toolstrip_Extras.Name = "Toolstrip_Extras";
            this.Toolstrip_Extras.Size = new System.Drawing.Size(139, 22);
            this.Toolstrip_Extras.Text = "Extras";
            this.Toolstrip_Extras.Visible = false;
            this.Toolstrip_Extras.Click += new System.EventHandler(this.Toolstrip_Extras_Click);
            // 
            // Toolstrip_Eventos
            // 
            this.Toolstrip_Eventos.Name = "Toolstrip_Eventos";
            this.Toolstrip_Eventos.Size = new System.Drawing.Size(158, 22);
            this.Toolstrip_Eventos.Text = "Eventos";
            this.Toolstrip_Eventos.Visible = false;
            this.Toolstrip_Eventos.Click += new System.EventHandler(this.Toolstrip_Eventos_Click);
            // 
            // Toolstrip_Backup
            // 
            this.Toolstrip_Backup.Name = "Toolstrip_Backup";
            this.Toolstrip_Backup.Size = new System.Drawing.Size(158, 22);
            this.Toolstrip_Backup.Text = "BackUp/Restore";
            this.Toolstrip_Backup.Click += new System.EventHandler(this.Toolstrip_Backup_Click);
            // 
            // Toolstrip_Roles
            // 
            this.Toolstrip_Roles.Name = "Toolstrip_Roles";
            this.Toolstrip_Roles.Size = new System.Drawing.Size(158, 22);
            this.Toolstrip_Roles.Text = "Roles/Permisos";
            this.Toolstrip_Roles.Click += new System.EventHandler(this.Toolstrip_Roles_Click);
            // 
            // Toolstrip_Metricas
            // 
            this.Toolstrip_Metricas.Name = "Toolstrip_Metricas";
            this.Toolstrip_Metricas.Size = new System.Drawing.Size(158, 22);
            this.Toolstrip_Metricas.Text = "Metricas";
            this.Toolstrip_Metricas.Click += new System.EventHandler(this.Toolstrip_Metricas_Click);
            // 
            // Toolstrip_Cocinero
            // 
            this.Toolstrip_Cocinero.Name = "Toolstrip_Cocinero";
            this.Toolstrip_Cocinero.Size = new System.Drawing.Size(67, 20);
            this.Toolstrip_Cocinero.Text = "Cocinero";
            this.Toolstrip_Cocinero.Visible = false;
            this.Toolstrip_Cocinero.Click += new System.EventHandler(this.Toolstrip_Cocinero_Click);
            // 
            // Toolstrip_Mozo
            // 
            this.Toolstrip_Mozo.Name = "Toolstrip_Mozo";
            this.Toolstrip_Mozo.Size = new System.Drawing.Size(49, 20);
            this.Toolstrip_Mozo.Text = "Mozo";
            this.Toolstrip_Mozo.Visible = false;
            this.Toolstrip_Mozo.Click += new System.EventHandler(this.Toolstrip_Mozo_Click);
            // 
            // ToolStrip_CerrarSesion
            // 
            this.ToolStrip_CerrarSesion.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ToolStrip_CerrarSesion.Name = "ToolStrip_CerrarSesion";
            this.ToolStrip_CerrarSesion.Size = new System.Drawing.Size(87, 20);
            this.ToolStrip_CerrarSesion.Text = "Cerrar sesion";
            this.ToolStrip_CerrarSesion.Click += new System.EventHandler(this.ToolStrip_CerrarSesion_Click);
            // 
            // GUI_MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1000, 624);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IsMdiContainer = true;
            this.Name = "GUI_MenuPrincipal";
            this.Text = "GUI_MenuPrincipal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Toolstrip_Admin;
        private System.Windows.Forms.ToolStripMenuItem Toolstrip_Personal;
        private System.Windows.Forms.ToolStripMenuItem Toolstrip_Menu;
        private System.Windows.Forms.ToolStripMenuItem Toolstrip_Ingredientes;
        private System.Windows.Forms.ToolStripMenuItem Toolstrip_Platos;
        private System.Windows.Forms.ToolStripMenuItem Toolstrip_Bebidas;
        private System.Windows.Forms.ToolStripMenuItem Toolstrip_Extras;
        private System.Windows.Forms.ToolStripMenuItem Toolstrip_Eventos;
        private System.Windows.Forms.ToolStripMenuItem Toolstrip_Backup;
        private System.Windows.Forms.ToolStripMenuItem Toolstrip_Roles;
        private System.Windows.Forms.ToolStripMenuItem Toolstrip_Metricas;
        private System.Windows.Forms.ToolStripMenuItem Toolstrip_Cocinero;
        private System.Windows.Forms.ToolStripMenuItem Toolstrip_Mozo;
        private System.Windows.Forms.ToolStripMenuItem ToolStrip_CerrarSesion;
    }
}
namespace TrabajoFinal
{
    partial class GUI_UsrAdmin
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
            this.PersonalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BebidasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IngredientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PlatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExtrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EventoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MesasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TurnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PersonalToolStripMenuItem,
            this.menuToolStripMenuItem,
            this.EventoToolStripMenuItem,
            this.salonToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // PersonalToolStripMenuItem
            // 
            this.PersonalToolStripMenuItem.Name = "PersonalToolStripMenuItem";
            this.PersonalToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.PersonalToolStripMenuItem.Text = "Personal";
            this.PersonalToolStripMenuItem.Click += new System.EventHandler(this.PersonalToolStripMenuItem_Click);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BebidasToolStripMenuItem,
            this.IngredientesToolStripMenuItem,
            this.PlatosToolStripMenuItem,
            this.ExtrasToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // BebidasToolStripMenuItem
            // 
            this.BebidasToolStripMenuItem.Name = "BebidasToolStripMenuItem";
            this.BebidasToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.BebidasToolStripMenuItem.Text = "Bebidas";
            this.BebidasToolStripMenuItem.Click += new System.EventHandler(this.BebidasToolStripMenuItem_Click);
            // 
            // IngredientesToolStripMenuItem
            // 
            this.IngredientesToolStripMenuItem.Name = "IngredientesToolStripMenuItem";
            this.IngredientesToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.IngredientesToolStripMenuItem.Text = "Ingredientes";
            this.IngredientesToolStripMenuItem.Click += new System.EventHandler(this.IngredientesToolStripMenuItem_Click);
            // 
            // PlatosToolStripMenuItem
            // 
            this.PlatosToolStripMenuItem.Name = "PlatosToolStripMenuItem";
            this.PlatosToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.PlatosToolStripMenuItem.Text = "Platos";
            this.PlatosToolStripMenuItem.Click += new System.EventHandler(this.PlatosToolStripMenuItem_Click);
            // 
            // ExtrasToolStripMenuItem
            // 
            this.ExtrasToolStripMenuItem.Name = "ExtrasToolStripMenuItem";
            this.ExtrasToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.ExtrasToolStripMenuItem.Text = "Extras";
            this.ExtrasToolStripMenuItem.Click += new System.EventHandler(this.ExtrasToolStripMenuItem_Click);
            // 
            // EventoToolStripMenuItem
            // 
            this.EventoToolStripMenuItem.Name = "EventoToolStripMenuItem";
            this.EventoToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.EventoToolStripMenuItem.Text = "Evento";
            this.EventoToolStripMenuItem.Click += new System.EventHandler(this.EventoToolStripMenuItem_Click);
            // 
            // salonToolStripMenuItem
            // 
            this.salonToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MesasToolStripMenuItem,
            this.TurnosToolStripMenuItem});
            this.salonToolStripMenuItem.Name = "salonToolStripMenuItem";
            this.salonToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.salonToolStripMenuItem.Text = "Salon";
            // 
            // MesasToolStripMenuItem
            // 
            this.MesasToolStripMenuItem.Name = "MesasToolStripMenuItem";
            this.MesasToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.MesasToolStripMenuItem.Text = "Mesas";
            this.MesasToolStripMenuItem.Click += new System.EventHandler(this.MesasToolStripMenuItem_Click);
            // 
            // TurnosToolStripMenuItem
            // 
            this.TurnosToolStripMenuItem.Name = "TurnosToolStripMenuItem";
            this.TurnosToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.TurnosToolStripMenuItem.Text = "Turnos";
            this.TurnosToolStripMenuItem.Click += new System.EventHandler(this.TurnosToolStripMenuItem_Click);
            // 
            // GUI_UsrAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GUI_UsrAdmin";
            this.Text = "GUI_Inicio";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem PersonalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BebidasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem IngredientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PlatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExtrasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EventoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MesasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TurnosToolStripMenuItem;
    }
}



namespace TrabajoFinal
{
    partial class GUI_AdminMesas
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
            this.Panel_Up = new System.Windows.Forms.Panel();
            this.Panel_Centro = new System.Windows.Forms.Panel();
            this.Panel_Izq = new System.Windows.Forms.Panel();
            this.Button_CrearMesa = new System.Windows.Forms.Button();
            this.Panel_Izq.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Up
            // 
            this.Panel_Up.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Up.Location = new System.Drawing.Point(0, 0);
            this.Panel_Up.Name = "Panel_Up";
            this.Panel_Up.Size = new System.Drawing.Size(915, 100);
            this.Panel_Up.TabIndex = 0;
            // 
            // Panel_Centro
            // 
            this.Panel_Centro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Centro.Location = new System.Drawing.Point(0, 100);
            this.Panel_Centro.Name = "Panel_Centro";
            this.Panel_Centro.Size = new System.Drawing.Size(915, 621);
            this.Panel_Centro.TabIndex = 1;
            // 
            // Panel_Izq
            // 
            this.Panel_Izq.Controls.Add(this.Button_CrearMesa);
            this.Panel_Izq.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel_Izq.Location = new System.Drawing.Point(0, 100);
            this.Panel_Izq.Name = "Panel_Izq";
            this.Panel_Izq.Size = new System.Drawing.Size(200, 621);
            this.Panel_Izq.TabIndex = 2;
            // 
            // Button_CrearMesa
            // 
            this.Button_CrearMesa.Location = new System.Drawing.Point(26, 33);
            this.Button_CrearMesa.Name = "Button_CrearMesa";
            this.Button_CrearMesa.Size = new System.Drawing.Size(120, 45);
            this.Button_CrearMesa.TabIndex = 0;
            this.Button_CrearMesa.Text = "button1";
            this.Button_CrearMesa.UseVisualStyleBackColor = true;
            this.Button_CrearMesa.Click += new System.EventHandler(this.Button_CrearMesa_Click);
            // 
            // GUI_AdminMesas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 721);
            this.Controls.Add(this.Panel_Izq);
            this.Controls.Add(this.Panel_Centro);
            this.Controls.Add(this.Panel_Up);
            this.Name = "GUI_AdminMesas";
            this.Text = "GUI_AdminMesas";
            this.Panel_Izq.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Up;
        private System.Windows.Forms.Panel Panel_Centro;
        private System.Windows.Forms.Panel Panel_Izq;
        private System.Windows.Forms.Button Button_CrearMesa;
    }
}
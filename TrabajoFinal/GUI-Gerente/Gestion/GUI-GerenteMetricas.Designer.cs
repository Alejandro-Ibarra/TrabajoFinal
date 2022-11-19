
namespace TrabajoFinal
{
    partial class GUI_Gerente_Metricas
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Chart_Platos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Chart_Bebidas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.Chart_Platos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chart_Bebidas)).BeginInit();
            this.SuspendLayout();
            // 
            // Chart_Platos
            // 
            chartArea1.Name = "ChartArea1";
            this.Chart_Platos.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Chart_Platos.Legends.Add(legend1);
            this.Chart_Platos.Location = new System.Drawing.Point(56, 123);
            this.Chart_Platos.Name = "Chart_Platos";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.Chart_Platos.Series.Add(series1);
            this.Chart_Platos.Size = new System.Drawing.Size(304, 300);
            this.Chart_Platos.TabIndex = 0;
            this.Chart_Platos.Text = "chart1";
            // 
            // Chart_Bebidas
            // 
            chartArea2.Name = "ChartArea1";
            this.Chart_Bebidas.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.Chart_Bebidas.Legends.Add(legend2);
            this.Chart_Bebidas.Location = new System.Drawing.Point(441, 123);
            this.Chart_Bebidas.Name = "Chart_Bebidas";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.Chart_Bebidas.Series.Add(series2);
            this.Chart_Bebidas.Size = new System.Drawing.Size(300, 300);
            this.Chart_Bebidas.TabIndex = 1;
            this.Chart_Bebidas.Text = "chart1";
            // 
            // GUI_Gerente_Metricas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Chart_Bebidas);
            this.Controls.Add(this.Chart_Platos);
            this.Name = "GUI_Gerente_Metricas";
            this.Text = "GUI_GerenteMetricas";
            ((System.ComponentModel.ISupportInitialize)(this.Chart_Platos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chart_Bebidas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart Chart_Platos;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart_Bebidas;
    }
}
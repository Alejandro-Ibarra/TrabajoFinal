using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoFinal
{
    public partial class GUI_BackUp : Form
    {
        public GUI_BackUp()
        {
            InitializeComponent();
            CargarDatagrid();
        }


        private void Boton_BackUp_Click(object sender, EventArgs e)
        {
            string restaurante = Application.StartupPath + @"\Restaurante.xml";
            string backup = Application.StartupPath + @"\Backups\Restaurante-BK-" + DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + ".xml";
            System.IO.File.Copy(restaurante, backup, true);
            MessageBox.Show("BackUp created succesfully");
        }

        private void Boton_Restore_Click(object sender, EventArgs e)
        {

            int fila = DataGridView_BackUps.CurrentCell.RowIndex;
            int columna = DataGridView_BackUps.CurrentCell.ColumnIndex;

            string backup = DataGridView_BackUps.Rows[fila].Cells[columna].Value.ToString();

            string restaurante = Application.StartupPath + @"\Restaurante.xml";

            System.IO.File.Copy(backup, restaurante, true);
            MessageBox.Show("BackUp restored succesfully");
        }

        private void CargarDatagrid()
        {

            String[] Archivos = Directory.GetFiles(Application.StartupPath + @"\Backups");
            String[] Archivos1 = Directory.GetFiles(Application.StartupPath + @"\Backups\");


            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Archivos");

            foreach (string arch in Archivos)
            {
                dataTable.Rows.Add(arch);
            }
            DataGridView_BackUps.DataSource = dataTable;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] files = System.IO.Directory.GetFiles(@"C:\Users\Usuario\Documents\Visual Studio 2012\Projects\TrabajoFinal\TrabajoFinal\bin\Debug");
            
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Name");
            
            foreach (string file in files)
            {
                dataTable.Rows.Add(file);
            }
 
        }




        private string[] getFiles()
        {
            string[] files = System.IO.Directory.GetFiles(@"C:\Users\Usuario\Documents\Visual Studio 2013\Projects\TrabajoFinal\TrabajoFinal\bin\Debug");
            return files;
        }







    }
}

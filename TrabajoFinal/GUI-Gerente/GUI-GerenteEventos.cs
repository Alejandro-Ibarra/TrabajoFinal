using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Abstraction;
using BussinesEntity;

namespace TrabajoFinal
{
    public partial class GUI_Gerente_Eventos : Form
    {
        public GUI_Gerente_Eventos()
        {
            InitializeComponent();
            CargarControles();
            listaEventos = new List<BEEvento>();
        }

        List<BEEvento> listaEventos;

        private void Boton_VerificarDisp_Click(object sender, EventArgs e)
        {

        }


        private void Boton_Agregar_Click(object sender, EventArgs e)
        {

        }

        private void CargarControles()
        {
            try
            {
                ComboBox_Horarios.DataSource = CargarComboHorario();

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private List<string> CargarComboHorario()
        {
            try
            {
                List<string> Horarios = new List<string>();
                Horarios.Add("12 Hs");
                Horarios.Add("14 Hs");
                Horarios.Add("20 Hs");
                Horarios.Add("22 Hs");
                return Horarios;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); return null; }
        }















        /*DataObject o = (DataObject)Clipboard.GetDataObject();
if (o.GetDataPresent(DataFormats.Text))
{
    if (myDataGridView.RowCount > 0)
        myDataGridView.Rows.Clear();

    if (myDataGridView.ColumnCount > 0)
        myDataGridView.Columns.Clear();

    bool columnsAdded = false;
    string[] pastedRows = Regex.Split(o.GetData(DataFormats.Text).ToString().TrimEnd("\r\n".ToCharArray()), "\r\n");
    foreach (string pastedRow in pastedRows)
    {
        string[] pastedRowCells = pastedRow.Split(new char[] { '\t' });

        if (!columnsAdded)
        {
            for (int i = 0; i < pastedRowCells.Length; i++)
                myDataGridView.Columns.Add("col" + i, pastedRowCells[i]);

            columnsAdded = true;
            continue;
        }

        myDataGridView.Rows.Add();
        int myRowIndex = myDataGridView.Rows.Count - 1;

        using (DataGridViewRow myDataGridViewRow = myDataGridView.Rows[myRowIndex])
        {
            for (int i = 0; i < pastedRowCells.Length; i++)
                myDataGridViewRow.Cells[i].Value = pastedRowCells[i];
        }
    }
}*/
    }
}

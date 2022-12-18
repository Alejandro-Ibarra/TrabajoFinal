using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinesEntity;
using BussinesLogic;

namespace TrabajoFinal
{
    public partial class GUI_SeleccionExtras : Form
    {
        public GUI_SeleccionExtras()
        {
            InitializeComponent();
            oBLExtras = new BLExtras();
            listExtrasElegidos = new List<BEExtras>();
            CargarGrillaExtras();
        }

        public List<BEExtras> listaExtrasFinal { get; set; }
        BLExtras oBLExtras;
        List<BEExtras> listExtrasElegidos;

        private void GUI_SeleccionExtras_Load(object sender, EventArgs e)
        {
            GridView_TodosExtras.MultiSelect = false;
            GridView_TodosExtras.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GridView_ExtrasSelec.MultiSelect = false;
            GridView_ExtrasSelec.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void Boton_AgregarExtra_Click(object sender, EventArgs e)
        {
            try
            {
                if (GridView_TodosExtras.Rows.Count > 0 && GridView_TodosExtras.CurrentRow != null)
                {
                    listExtrasElegidos.Add((BEExtras)GridView_TodosExtras.CurrentRow.DataBoundItem);
                    GridView_ExtrasSelec.DataSource = null;
                    GridView_ExtrasSelec.DataSource = listExtrasElegidos;
                    GridView_ExtrasSelec.ClearSelection();
                    OcultarCamposSelec(GridView_ExtrasSelec);
                }
                else
                { MessageBox.Show("Seleccione un elemento de la lista"); }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message);}
        }

        private void Boton_QuitarExtras_Click(object sender, EventArgs e)
        {
            try
            {
                int aux = 0;
                if (GridView_ExtrasSelec.Rows.Count > 0 && GridView_ExtrasSelec.CurrentRow != null)
                {
                    List<BEExtras> ingreAux2 = new List<BEExtras>();
                    foreach (BEExtras ing in listExtrasElegidos)
                    {

                        if (ing.Nombre != ((BEExtras)GridView_ExtrasSelec.CurrentRow.DataBoundItem).Nombre || aux != 0)
                        {
                            ingreAux2.Add(ing);
                        }
                        else { aux++; }
                    }
                    listExtrasElegidos = ingreAux2;
                    GridView_ExtrasSelec.DataSource = null;
                    GridView_ExtrasSelec.DataSource = listExtrasElegidos;
                    GridView_ExtrasSelec.ClearSelection();
                    OcultarCamposSelec(GridView_ExtrasSelec);
                }
                else
                {
                    MessageBox.Show("Seleccione un elemento a retirar de la lista");
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void Boton_Confirmar_Click(object sender, EventArgs e)
        {
            try
            {
                this.listaExtrasFinal = listExtrasElegidos;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void CargarGrillaExtras()
        {
            try
            {
                List<BEExtras> listExtras = oBLExtras.ListarTodo();
                List<BEExtras> listExtrasAux = new List<BEExtras>();

                foreach (BEExtras item in listExtras)
                {
                    if (item.Activo == true)
                    {
                        listExtrasAux.Add(item);
                    }
                }

                GridView_TodosExtras.DataSource = listExtrasAux;
                GridView_TodosExtras.ClearSelection();
                OcultarCamposSelec(GridView_TodosExtras);
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void OcultarCamposSelec(DataGridView dataGrid)
        {
            dataGrid.Columns["CodigoComanda"].Visible = false;
            dataGrid.Columns["CodigoPedido"].Visible = false;
            dataGrid.Columns["CodigoItem"].Visible = false;
            dataGrid.Columns["Codigo"].Visible = false;
            dataGrid.Columns["Descripcion"].Visible = false;
            dataGrid.Columns["Stock"].Visible = false;
            dataGrid.Columns["Tipo"].Visible = false;
            dataGrid.Columns["Proveedor"].Visible = false;
            dataGrid.Columns["Activo"].Visible = false;
        }
    }

}

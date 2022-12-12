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
                if (GridView_TodosExtras.Rows.Count > 0 && GridView_TodosExtras.CurrentRow.DataBoundItem != null)
                {
                    listExtrasElegidos.Add((BEExtras)GridView_TodosExtras.CurrentRow.DataBoundItem);
                    GridView_ExtrasSelec.DataSource = null;
                    GridView_ExtrasSelec.DataSource = listExtrasElegidos;
                    OcultarCamposSelec();
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message);}
        }

        private void Boton_QuitarExtras_Click(object sender, EventArgs e)
        {
            try
            {
                int aux = 0;
                if (GridView_ExtrasSelec.Rows.Count > 0 && GridView_ExtrasSelec.CurrentRow.DataBoundItem != null)
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
                    OcultarCamposSelec();
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
                GridView_TodosExtras.DataSource = oBLExtras.ListarTodo();
                GridView_TodosExtras.Columns["CodigoComanda"].Visible = false;
                GridView_TodosExtras.Columns["CodigoPedido"].Visible = false;
                GridView_TodosExtras.Columns["CodigoItem"].Visible = false;
                GridView_TodosExtras.Columns["Codigo"].Visible = false;
                GridView_TodosExtras.Columns["Descripcion"].Visible = false;
                GridView_TodosExtras.Columns["Stock"].Visible = false;
                GridView_TodosExtras.Columns["Tipo"].Visible = false;
                GridView_TodosExtras.Columns["Proveedor"].Visible = false;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void OcultarCamposSelec()
        {
            GridView_ExtrasSelec.Columns["CodigoComanda"].Visible = false;
            GridView_ExtrasSelec.Columns["CodigoPedido"].Visible = false;
            GridView_ExtrasSelec.Columns["CodigoItem"].Visible = false;
            GridView_ExtrasSelec.Columns["Codigo"].Visible = false;
            GridView_ExtrasSelec.Columns["Descripcion"].Visible = false;
            GridView_ExtrasSelec.Columns["Stock"].Visible = false;
            GridView_ExtrasSelec.Columns["Tipo"].Visible = false;
            GridView_ExtrasSelec.Columns["Proveedor"].Visible = false;
        }
    }

}

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
        


        private void Boton_AgregarExtra_Click(object sender, EventArgs e)
        {
            try
            {
                if (GridView_TodosExtras.Rows.Count > 0)
                {
                    int aux = 0;

                    foreach (BEExtras Extras in listExtrasElegidos)
                    {
                        if (Extras.Codigo == ((BEExtras)GridView_TodosExtras.CurrentRow.DataBoundItem).Codigo)
                        {
                            aux++;
                        }
                    }
                    if (aux == 0)
                    {
                        listExtrasElegidos.Add((BEExtras)GridView_TodosExtras.CurrentRow.DataBoundItem);
                    }
                    else
                    {
                        MessageBox.Show("El ingrediente ya se encuentra en el plato");
                    }

                    GridView_ExtrasSelec.DataSource = null;
                    GridView_ExtrasSelec.DataSource = listExtrasElegidos;
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message);}
        }

        private void Boton_QuitarExtras_Click(object sender, EventArgs e)
        {
            try
            {
                if (GridView_ExtrasSelec.Rows.Count > 0)
                {

                    List<BEExtras> ingreAux2 = new List<BEExtras>();
                    foreach (BEExtras ing in listExtrasElegidos)
                    {
                        if (ing.Nombre != ((BEExtras)GridView_ExtrasSelec.CurrentRow.DataBoundItem).Nombre && GridView_ExtrasSelec.CurrentRow.DataBoundItem != null)
                        {
                            ingreAux2.Add(ing);
                        }
                    }
                    listExtrasElegidos = ingreAux2;
                    GridView_ExtrasSelec.DataSource = null;
                    GridView_ExtrasSelec.DataSource = listExtrasElegidos;
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
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

    }

}

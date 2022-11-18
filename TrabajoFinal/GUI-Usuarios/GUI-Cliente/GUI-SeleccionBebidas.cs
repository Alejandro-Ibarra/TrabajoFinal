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
    public partial class GUI_SeleccionBebidas : Form
    {
        public GUI_SeleccionBebidas()
        {
            InitializeComponent();
            oBLBebida = new BLBebida();
            listaBebidasElegidas = new List<BEBebida>();
            CargarGrillaBebidas();
        }

        public List<BEBebida> listaBebidasFinal { get; set; }
        BLBebida oBLBebida;
        List<BEBebida> listaBebidasElegidas;

        private void Boton_AgregarBebida_Click(object sender, EventArgs e)
        {
            try
            {
                if (GridView_TodosBebidas.Rows.Count > 0)
                {
                    int aux = 0;

                    foreach (BEBebida Extras in listaBebidasElegidas)
                    {
                        if (Extras.Codigo == ((BEBebida)GridView_TodosBebidas.CurrentRow.DataBoundItem).Codigo)
                        {
                            aux++;
                        }
                    }
                    if (aux == 0)
                    {
                        listaBebidasElegidas.Add((BEBebida)GridView_TodosBebidas.CurrentRow.DataBoundItem);
                    }
                    else
                    {
                        MessageBox.Show("El ingrediente ya se encuentra en el plato");
                    }

                    GridView_BebidasSelec.DataSource = null;
                    GridView_BebidasSelec.DataSource = listaBebidasElegidas;
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        
        }

        private void Boton_QuitarBebida_Click(object sender, EventArgs e)
        {
            try
            {
                if (GridView_BebidasSelec.Rows.Count > 0)
                {

                    List<BEBebida> ingreAux2 = new List<BEBebida>();
                    foreach (BEBebida ing in listaBebidasElegidas)
                    {
                        if (ing.Nombre != ((BEBebida)GridView_BebidasSelec.CurrentRow.DataBoundItem).Nombre && GridView_BebidasSelec.CurrentRow.DataBoundItem != null)
                        {
                            ingreAux2.Add(ing);
                        }
                    }
                    listaBebidasElegidas = ingreAux2;
                    GridView_BebidasSelec.DataSource = null;
                    GridView_BebidasSelec.DataSource = listaBebidasElegidas;
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void CargarGrillaBebidas()
        {
            try
            {
                if (GridView_BebidasSelec.Rows.Count > 0)
                {
                    GridView_TodosBebidas.DataSource = oBLBebida.ListarTodo();
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void Boton_Confirmar_Click(object sender, EventArgs e)
        {
            try
            {
                this.listaBebidasFinal = listaBebidasElegidas;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
    }
}

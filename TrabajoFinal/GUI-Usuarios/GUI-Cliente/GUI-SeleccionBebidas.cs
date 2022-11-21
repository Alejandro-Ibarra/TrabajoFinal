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


        private void GUI_SeleccionBebidas_Load(object sender, EventArgs e)
        {
            GridView_TodosBebidas.MultiSelect = false;
            GridView_TodosBebidas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GridView_BebidasSelec.MultiSelect = false;
            GridView_BebidasSelec.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void Boton_AgregarBebida_Click(object sender, EventArgs e)
        {
            try
            {
                if (GridView_TodosBebidas.Rows.Count > 0)
                {

                    listaBebidasElegidas.Add((BEBebida)GridView_TodosBebidas.CurrentRow.DataBoundItem);

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
                int aux = 0;
                if (GridView_BebidasSelec.Rows.Count > 0)
                {
                    List<BEBebida> ingreAux2 = new List<BEBebida>();
                    foreach (BEBebida ing in listaBebidasElegidas)
                    {
                        if (ing.Nombre != ((BEBebida)GridView_BebidasSelec.CurrentRow.DataBoundItem).Nombre || aux != 0)
                        {
                            ingreAux2.Add(ing);

                        }
                        else{aux++;}
                        
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
                
                GridView_TodosBebidas.DataSource = oBLBebida.ListarTodo();
    
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

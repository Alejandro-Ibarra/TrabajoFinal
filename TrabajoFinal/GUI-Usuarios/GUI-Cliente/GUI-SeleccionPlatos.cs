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
    public partial class GUI_SeleccionPlatos : Form
    {
        public GUI_SeleccionPlatos(string tipo)
        {
            InitializeComponent();
            tipoPlato = tipo;
            listaPlatosElegidos = new List<BEPlato>();
            listaPlatos = new List<BEPlato>();
            listaIng = new List<BEIngrediente>();
            oBLPlato = new BLPlato();
            CargarGrillaIngredientes();
        }


        public List<BEPlato> listaPlatosFinal { get; set; }
        string tipoPlato;
        BLPlato oBLPlato;
        List<BEPlato> listaPlatosElegidos;
        List<BEPlato> listaPlatos;
        List<BEIngrediente> listaIng;

        private void GUI_SeleccionPlatos_Load(object sender, EventArgs e)
        {
            GridView_TodosIng.MultiSelect = false;
            GridView_TodosIng.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GridView_IngSelec.MultiSelect = false;
            GridView_IngSelec.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GridView_TodosPlatos.MultiSelect = false;
            GridView_TodosPlatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GridView_PlatoSelec.MultiSelect = false;
            GridView_PlatoSelec.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private List<BEPlato> RecuperarPlatosPorTipo(string tipo)
        {
            try
            {
                List<BEPlato> listaPlaAux = oBLPlato.ListarTodo();
                foreach (BEPlato pla in listaPlaAux)
                {
                    if (pla.Tipo == tipo)
                    {
                        listaPlatos.Add(pla);
                    }
                }
                return listaPlatos;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); return null; }
        }

        private void CargarGrillaIngredientes()
        {
            try
            {
                List<BEPlato> lPlatos = RecuperarPlatosPorTipo(tipoPlato);
                List<BEIngrediente> lIngrediente = new List<BEIngrediente>();
                foreach (BEPlato plato in lPlatos)
                {
                    lIngrediente.Add(plato.IngredientePrincipal);
                }
                var lIngreAux = lIngrediente.GroupBy(x => x.Nombre).Select(x => x.First()).ToList();
                GridView_TodosIng.DataSource = lIngreAux;
                GridView_TodosIng.Columns["Refrigeracion"].Visible = false;
                GridView_TodosIng.Columns["Stock"].Visible = false;
                GridView_TodosIng.Columns["Proveedor"].Visible = false;
                GridView_TodosIng.Columns["Codigo"].Visible = false;

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void Boton_AgregarIng_Click(object sender, EventArgs e)
        {
            try
            {
                if (GridView_TodosIng.Rows.Count > 0 && GridView_TodosIng.CurrentRow.DataBoundItem != null)
                {
                    int aux = 0;

                    foreach (BEIngrediente Ingrediente in listaIng)
                    {
                        if (Ingrediente.Codigo == ((BEIngrediente)GridView_TodosIng.CurrentRow.DataBoundItem).Codigo)
                        {
                            aux++;
                        }
                    }
                    if (aux == 0)
                    {
                        listaIng.Add((BEIngrediente)GridView_TodosIng.CurrentRow.DataBoundItem);
                    }
                    else
                    {
                        MessageBox.Show("El ingrediente ya se encuentra en el plato");
                    }

                    GridView_IngSelec.DataSource = null;
                    GridView_IngSelec.DataSource = listaIng;
                    GridView_IngSelec.Columns["Refrigeracion"].Visible = false;
                    GridView_IngSelec.Columns["Stock"].Visible = false;
                    GridView_IngSelec.Columns["Proveedor"].Visible = false;
                    GridView_IngSelec.Columns["Codigo"].Visible = false;


                }    
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        
        }


        private void Boton_QuitarIng_Click(object sender, EventArgs e)
        {
            try
            {
                if (GridView_IngSelec.Rows.Count > 0 && GridView_IngSelec.CurrentRow.DataBoundItem != null)
                {

                    List<BEIngrediente> ingreAux2 = new List<BEIngrediente>();
                    foreach (BEIngrediente ing in listaIng)
                    {
                        if (ing.Nombre != ((BEIngrediente)GridView_IngSelec.CurrentRow.DataBoundItem).Nombre && GridView_IngSelec.CurrentRow.DataBoundItem != null)
                        {
                            ingreAux2.Add(ing);
                        }
                    }
                    listaIng = ingreAux2;
                    GridView_IngSelec.DataSource = null;
                    GridView_IngSelec.DataSource = listaIng;
                    GridView_IngSelec.Columns["Refrigeracion"].Visible = false;
                    GridView_IngSelec.Columns["Stock"].Visible = false;
                    GridView_IngSelec.Columns["Proveedor"].Visible = false;
                    GridView_IngSelec.Columns["Codigo"].Visible = false;
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void Boton_Sugerir_Click(object sender, EventArgs e)
        {
            try
            {
                List<BEPlato> platoaxu = new List<BEPlato>();
                foreach (BEPlato plato in listaPlatos)
                {
                    foreach (BEIngrediente ingre in listaIng)
                    {
                        if (plato.IngredientePrincipal.Nombre == ingre.Nombre)
                        {
                            platoaxu.Add(plato);
                        }
                    }
                }
                if (platoaxu != null)
                {
                    GridView_TodosPlatos.DataSource = platoaxu;
                    GridView_TodosPlatos.Columns["CodigoComanda"].Visible = false;
                    GridView_TodosPlatos.Columns["CodigoPedido"].Visible = false;
                    GridView_TodosPlatos.Columns["CodigoItem"].Visible = false;
                    GridView_TodosPlatos.Columns["Descripcion"].Visible = false;
                    GridView_TodosPlatos.Columns["Activo"].Visible = false;
                    GridView_TodosPlatos.Columns["IngredientePrincipal"].Visible = false;
                    GridView_TodosPlatos.Columns["Codigo"].Visible = false;



                }
                CargarTextBox();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void Boton_AgregarPlato_Click(object sender, EventArgs e)
        {
            try
            {
                if (GridView_IngSelec.Rows.Count > 0 && GridView_IngSelec.CurrentRow.DataBoundItem != null)
                {
                    if (GridView_TodosPlatos.Rows.Count > 0 && GridView_TodosPlatos.CurrentRow.DataBoundItem != null)
                    {
                        listaPlatosElegidos.Add((BEPlato)GridView_TodosPlatos.CurrentRow.DataBoundItem);

                        GridView_PlatoSelec.DataSource = null;
                        GridView_PlatoSelec.DataSource = listaPlatosElegidos;
                        GridView_PlatoSelec.Columns["CodigoComanda"].Visible = false;
                        GridView_PlatoSelec.Columns["CodigoPedido"].Visible = false;
                        GridView_PlatoSelec.Columns["CodigoItem"].Visible = false;
                        GridView_PlatoSelec.Columns["Descripcion"].Visible = false;
                        GridView_PlatoSelec.Columns["Activo"].Visible = false;
                        GridView_PlatoSelec.Columns["IngredientePrincipal"].Visible = false;
                        GridView_PlatoSelec.Columns["Codigo"].Visible = false;
                        GridView_PlatoSelec.Columns["Clase"].Visible = false;
                        GridView_PlatoSelec.Columns["Tipo"].Visible = false;
                    }
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void Boton_QuitarPlato_Click(object sender, EventArgs e)
        {
            try
            {
                if (GridView_PlatoSelec.Rows.Count > 0 && GridView_PlatoSelec.CurrentRow.DataBoundItem != null)
                {
                    List<BEPlato> platoAux = new List<BEPlato>();
                    foreach (BEPlato plato in listaPlatosElegidos)
                    {
                        if (plato.Nombre != ((BEPlato)GridView_PlatoSelec.CurrentRow.DataBoundItem).Nombre && GridView_PlatoSelec.CurrentRow.DataBoundItem != null)
                        {
                            platoAux.Add(plato);
                        }
                    }
                    listaPlatosElegidos = platoAux;
                    GridView_PlatoSelec.DataSource = null;
                    GridView_PlatoSelec.DataSource = listaPlatosElegidos;
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void Boton_ConfirmarPedido_Click(object sender, EventArgs e)
        {
            try
            {
                this.listaPlatosFinal = listaPlatosElegidos;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void GridView_TodosPlatos_MouseClick(object sender, MouseEventArgs e)
        {
            CargarTextBox();
        }

        private void CargarTextBox()
        {
            BEPlato auxPlato = (BEPlato)GridView_TodosPlatos.CurrentRow.DataBoundItem;
            textBox1.Text = auxPlato.Descripcion;
        }
    }
}

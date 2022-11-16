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

        private List<BEPlato> RecuperarPlatosPorTipo(string tipo)
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

        private void CargarGrillaIngredientes()
        {
            List<BEPlato> lPlatos = RecuperarPlatosPorTipo(tipoPlato);
            List<BEIngrediente> lIngrediente = new List<BEIngrediente>();
            foreach (BEPlato plato in lPlatos)
            {
                lIngrediente.Add(plato.IngredientePrincipal);
            }
            var lIngreAux = lIngrediente.GroupBy(x => x.Nombre).Select(x => x.First()).ToList();
            GridView_TodosIng.DataSource = lIngreAux;

        }

        private void Boton_AgregarIng_Click(object sender, EventArgs e)
        {
            if (GridView_TodosIng.Rows.Count > 0)
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
            }
        }


        private void Boton_QuitarIng_Click(object sender, EventArgs e)
        {
            if (GridView_IngSelec.Rows.Count > 0)
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
            }
        }

        private void Boton_Sugerir_Click(object sender, EventArgs e)
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
            }
        }

        private void Boton_AgregarPlato_Click(object sender, EventArgs e)
        {
            if (GridView_TodosPlatos.Rows.Count > 0)
            {
                listaPlatosElegidos.Add((BEPlato)GridView_TodosPlatos.CurrentRow.DataBoundItem);

                GridView_PlatoSelec.DataSource = null;
                GridView_PlatoSelec.DataSource = listaPlatosElegidos;
            }
        }

        private void Boton_QuitarPlato_Click(object sender, EventArgs e)
        {
            if (GridView_PlatoSelec.Rows.Count > 0)
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

        private void Boton_ConfirmarPedido_Click(object sender, EventArgs e)
        {
            this.listaPlatosFinal = listaPlatosElegidos;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void GUI_SeleccionPlatos_Load(object sender, EventArgs e)
        {

        }
    }
}

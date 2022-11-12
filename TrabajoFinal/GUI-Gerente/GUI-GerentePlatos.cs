using Microsoft.VisualBasic;
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
    public partial class GUI_Gerente_Platos : Form
    {
        public GUI_Gerente_Platos()
        {
            InitializeComponent();
            oBEplato = new BEPlato();
            oBLPlato = new BLPlato();
            oBEIngrediente = new BEIngrediente();
            oBLIngrediente = new BLIngrediente();
            CargarControles();
            ComboEventTipo();
            ComboEventClase();
        }

        BEPlato oBEplato;
        BLPlato oBLPlato;
        BLIngrediente oBLIngrediente;
        BEIngrediente oBEIngrediente;

        private void Boton_Alta_Click(object sender, EventArgs e)
        {
            oBEplato.Descripcion = Interaction.InputBox("Ingrese una descripcion para el plato");
            SeleccionarTipoPlato();
        }
        
        private void ComboEventTipo()
        {
            this.ComboBox_TipoPlato.SelectedIndexChanged +=
            new System.EventHandler(ComboBox_TipoPlato_SelectedIndexChanged);
        }

        private void ComboEventClase()
        {
            this.ComboBox_ClasePlato.SelectedIndexChanged +=
            new System.EventHandler(ComboBox_ClasePlato_SelectedIndexChanged);
        }

        private void SeleccionarTipoPlato()
        {
            MessageBox.Show("Seleccione el tipo de plato");
            ComboBox_TipoPlato.Visible = true;
            ComboBox_TipoPlato.Enabled = true;
        }

        private void ComboBox_TipoPlato_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedTipo = (string)ComboBox_TipoPlato.SelectedItem;
            oBEplato.Tipo = selectedTipo;
            ComboBox_TipoPlato.Enabled = false;
            ComboBox_ClasePlato.Visible = true;
            ComboBox_ClasePlato.Enabled = true;
            MessageBox.Show("Seleccione la clase de plato");
        }

        private void ComboBox_ClasePlato_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedTipo = (string)ComboBox_ClasePlato.SelectedItem;
            oBEplato.Clase= selectedTipo;
            ComboBox_ClasePlato.Enabled = false;

            MessageBox.Show("Seleccione los ingredientes de la lista");

            DataGridView_TodosIngredientes.DataSource = oBLIngrediente.ListarTodo();

        }

        private void DataGridView_SeleccionIngredientes_MouseClick(object sender, MouseEventArgs e)
        {
            QuitarIngrediente();
        }

        private void DataGridView_TodosIngredientes_MouseClick(object sender, MouseEventArgs e)
        {
            AgregarIngrediente();
        }

        private void QuitarIngrediente()
            {
            if (DataGridView_SeleccionIngredientes.Rows.Count > 0)
            {
                List<BEIngrediente> ingreAux = new List<BEIngrediente>();

                if (oBEplato.ListaIngredientes != null)
                {
                    foreach (BEIngrediente item in oBEplato.ListaIngredientes)
                    {
                        ingreAux.Add(item);
                    }
                }
                List<BEIngrediente> ingreAux2 = new List<BEIngrediente>();
                foreach (BEIngrediente ing in ingreAux)
                {
                    if (ing.Nombre != ((BEIngrediente)DataGridView_SeleccionIngredientes.CurrentRow.DataBoundItem).Nombre)
                    {
                        ingreAux2.Add(ing);
                    }
                }
                oBEplato.ListaIngredientes = ingreAux2;
                DataGridView_SeleccionIngredientes.DataSource = null;
                DataGridView_SeleccionIngredientes.DataSource = oBEplato.ListaIngredientes;
            }
        }


        private void AgregarIngrediente()
        {
            if (DataGridView_TodosIngredientes.Rows.Count > 0)
            {
                List<BEIngrediente> ingreAux = new List<BEIngrediente>();
                int aux = 0;
                if (oBEplato.ListaIngredientes != null)
                {
                    foreach (BEIngrediente item in oBEplato.ListaIngredientes)
                    {
                        ingreAux.Add(item);
                    }
                }

                foreach (BEIngrediente Ingrediente in ingreAux)
                {
                    if (Ingrediente.Codigo == ((BEIngrediente)DataGridView_TodosIngredientes.CurrentRow.DataBoundItem).Codigo)
                    {
                        aux++;
                    }
                }
                if (aux == 0)
                {
                    ingreAux.Add((BEIngrediente)DataGridView_TodosIngredientes.CurrentRow.DataBoundItem);
                    oBEplato.ListaIngredientes = ingreAux;
                }
                else
                {
                    MessageBox.Show("El ingrediente ya se encuentra en el plato");
                }
                
                DataGridView_SeleccionIngredientes.DataSource = null;
                DataGridView_SeleccionIngredientes.DataSource = oBEplato.ListaIngredientes;
            }
        }

        private void CargarControles()
        {
            ComboBox_TipoPlato.DataSource = CargarComboTipoPlato();
            ComboBox_ClasePlato.DataSource = CargarComboClasePlato();
        }

        private List<string> CargarComboTipoPlato()
        {
            List<string> TipoPlato = new List<string>();
            TipoPlato.Add("Entrada");
            TipoPlato.Add("Plato Principal");
            TipoPlato.Add("Acompañamiento");
            TipoPlato.Add("Postre");
            return TipoPlato;
        }

        private List<string> CargarComboClasePlato()
        {
            List<string> ClasePlato = new List<string>();
            ClasePlato.Add("Celiaco");
            ClasePlato.Add("Vegetariano");
            ClasePlato.Add("Vegano");
            ClasePlato.Add("Estandar");
            return ClasePlato;
        }


    }
}

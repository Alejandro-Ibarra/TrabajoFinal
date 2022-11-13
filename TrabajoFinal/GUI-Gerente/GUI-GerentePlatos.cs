﻿using Microsoft.VisualBasic;
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
using System.Text.RegularExpressions;

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
            CargarGrillaPlatos();
            //ComboEventTipo();
            //ComboEventClase();
        }

        BEPlato oBEplato;
        BLPlato oBLPlato;
        BLIngrediente oBLIngrediente;
        BEIngrediente oBEIngrediente;

        private void GUI_Gerente_Platos_Load(object sender, EventArgs e)
        {

        }

        #region BotonesPrincipales
        private void Boton_Alta_Click(object sender, EventArgs e)
        {
            ActivarDisponibilidadControles(true);
            oBEplato.Nombre = Interaction.InputBox("Ingrese el nombre del plato");
            oBEplato.Descripcion = Interaction.InputBox("Ingrese una descripcion para el plato");
            Boton_Alta.Enabled = false;
            oBEplato.Codigo = oBLPlato.GenerarCodigo();
            SeleccionarTipoPlato();
        }

        private void Boton_EliminarPlato_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Respuesta;
                Respuesta = MessageBox.Show("¿Quiere continuar con la baja?", "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (Respuesta == DialogResult.Yes)
                {
                    oBLPlato.Baja(oBEplato);
                    LimpiarTextboxYGrilla();
                    CargarGrillaPlatos();
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void Boton_ModificarPlatos_Click(object sender, EventArgs e)
        {
            
            ActivarVisibilidadControles(true);
            ActivarDisponibilidadControles(true);
            SeleccionarPlatoGrilla();
            CargarComboIngredientePrincipal();

        }
        #endregion

        #region BotonesSecundarios
        private void Boton_ContinuarTipoPlato_Click(object sender, EventArgs e)
        {
            oBEplato.Tipo = (string)ComboBox_TipoPlato.SelectedItem;
            ComboBox_TipoPlato.Enabled = false;
            Boton_ContinuarTipoPlato.Enabled = false;
            Label_ClasePlato.Visible = true;
            ComboBox_ClasePlato.Visible = true;
            Boton_ContinuarClasePlato.Visible = true;

            MessageBox.Show("Seleccione la clase de plato");
        }

        private void Boton_ContinuarClasePlato_Click(object sender, EventArgs e)
        {
            oBEplato.Clase = (string)ComboBox_ClasePlato.SelectedItem;
            ComboBox_ClasePlato.Enabled = false;
            Boton_ContinuarClasePlato.Enabled = false;

            MessageBox.Show("Seleccione los ingredientes de la lista");
            DataGridView_TodosIngredientes.Enabled = true;
            DataGridView_SeleccionIngredientes.Visible = true;
            label_GrillaSeleccionados.Visible = true;
            DataGridView_SeleccionIngredientes.Enabled = true;
            Boton_ConfirmarIngredientes.Visible = true;
            DataGridView_TodosIngredientes.DataSource = oBLIngrediente.ListarTodo();
        }

        private void Boton_ConfirmarIngredientes_Click(object sender, EventArgs e)
        {
            DataGridView_TodosIngredientes.Enabled = false;
            DataGridView_SeleccionIngredientes.Enabled = false;
            Boton_ConfirmalIngPrincipal.Visible = true;
            ComboBox_IngredientePrincipal.Visible = true;
            MessageBox.Show("Seleccione el ingrediente principal de la lista y presione el boton \" Confirmar ingrediente principal\"");
            CargarComboIngredientePrincipal();

        }

        private void Boton_ConfirmalIngPrincipal_Click(object sender, EventArgs e)
        {
            AgregarIngredientePrincipal();
            ComboBox_IngredientePrincipal.Enabled = false;
            Boton_ConfirmalIngPrincipal.Enabled = false;
            TextBox_Precio.Visible = true;
            Boton_ConfirmarPrecio.Visible = true;
            MessageBox.Show("Ingrese el precio del plato y presione el boton \" Confirmar precio\"");
        }

        private void Boton_ConfirmarPrecio_Click(object sender, EventArgs e)
        {
            ValidarPrecio();
        }

        private void Button_Guardar_Click(object sender, EventArgs e)
        {
            AsignarAPlato();
            oBLPlato.Guardar(oBEplato);
            ActivarVisibilidadControles(false);
            LimpiarTextboxYGrilla();
            ActivarDisponibilidadControles(false);

            CargarGrillaPlatos();
        }
        #endregion

        #region DatagridClick
        private void DataGridView_SeleccionIngredientes_MouseClick(object sender, MouseEventArgs e)
        {
            QuitarIngrediente();
        }

        private void DataGridView_TodosIngredientes_MouseClick(object sender, MouseEventArgs e)
        {
            AgregarIngrediente();
        }

        private void DataGridView_Platos_MouseClick(object sender, MouseEventArgs e)
        {
            SeleccionarPlatoGrilla();
        }
        #endregion

        #region MetodosPrincipales

        private void SeleccionarPlatoGrilla()
        {
            int codPlato = ((BEPlato)DataGridView_Platos.CurrentRow.DataBoundItem).Codigo;////////////////////////////////////////////////////////////////
            BEPlato oBEPlatoMod = new BEPlato();
            List<BEPlato> listaPlatos = oBLPlato.ListarTodo();
            foreach (BEPlato plato in listaPlatos)
            {
                if (plato.Codigo == codPlato)
                {
                    oBEPlatoMod = plato;
                }
            }
            oBEplato = oBEPlatoMod;
            CargarGrillasModificacion(oBEplato);
            AsignarAControles(oBEplato);

        }

        private void SeleccionarTipoPlato()
        {
            MessageBox.Show("Seleccione el tipo de plato");
            Label_TipoPlato.Visible = true;
            ComboBox_TipoPlato.Visible = true;
            Boton_ContinuarTipoPlato.Visible = true;
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

        private void AgregarIngredientePrincipal()
        {
            foreach (DataGridViewRow row in DataGridView_SeleccionIngredientes.Rows)
            {
                if (((BEIngrediente)row.DataBoundItem).Nombre == ComboBox_IngredientePrincipal.SelectedItem.ToString())
                {
                    oBEplato.IngredientePrincipal = (BEIngrediente)row.DataBoundItem;
                }
            }
        }
        
        private void ConfirmarPlato()
        {
            TextBox_Precio.Enabled = false;
            Boton_ConfirmarPrecio.Enabled = false;
            TextBox_Resumen.Visible = true;
            Boton_Guardar.Visible = true;

            TextBox_Resumen.Text = Resumen(oBEplato);
        }

        private string Resumen(BEPlato oPlato)
        {
            string ingredientes = "";
            foreach (BEIngrediente ing in oPlato.ListaIngredientes)
            {
                ingredientes = ingredientes + "\t\t" + ing.Nombre + Environment.NewLine;
            }

            string resumen = "Nombre del plato: " + oPlato.Nombre + Environment.NewLine + "Descripcion del plato: " + oPlato.Descripcion + Environment.NewLine +
                "Tipo de plato: " + oPlato.Tipo + Environment.NewLine + "Clase de Plato: " + oPlato.Clase + Environment.NewLine + "Precio del plato: " + oPlato.Precio + Environment.NewLine
                + "Ingrediente principal: " + oPlato.IngredientePrincipal.Nombre + Environment.NewLine + "Lista de ingredientes:" + Environment.NewLine + ingredientes;

            return resumen;
        }

        private void AsignarAPlato()
        {
            oBEplato.Tipo = ComboBox_TipoPlato.SelectedItem.ToString();
            oBEplato.Clase = ComboBox_ClasePlato.SelectedItem.ToString();
            AgregarIngredientePrincipal();
            oBEplato.Precio = Convert.ToInt32(TextBox_Precio.Text);

        }


        #endregion

        #region CArgarControles

        private void CargarComboIngredientePrincipal()
        {
            List<string> ingreAux = new List<string>();

            foreach (DataGridViewRow row in DataGridView_SeleccionIngredientes.Rows)
            {
                ingreAux.Add(((BEIngrediente)row.DataBoundItem).Nombre);
            }
            ComboBox_IngredientePrincipal.DataSource = ingreAux;
        }


        private void CargarGrillaPlatos()
        {
            DataGridView_Platos.DataSource = oBLPlato.ListarTodo();
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

        private void CargarGrillasModificacion(BEPlato PlatoMod)
        {
            DataGridView_TodosIngredientes.DataSource = oBLIngrediente.ListarTodo();
        }
        #endregion

        #region AdministracionControles



        private void AsignarAControles(BEPlato oPlato)
        {
            ComboBox_TipoPlato.SelectedItem = oPlato.Tipo;
            ComboBox_ClasePlato.SelectedItem = oPlato.Clase;
            ComboBox_IngredientePrincipal.SelectedItem = oPlato.IngredientePrincipal.Nombre;
            TextBox_Precio.Text = oPlato.Precio.ToString();
            TextBox_Resumen.Text = Resumen(oPlato);
            DataGridView_SeleccionIngredientes.DataSource = oPlato.ListaIngredientes;

        }

        private void ActivarVisibilidadControles(bool valor)
        {
            ComboBox_TipoPlato.Visible = valor;
            Boton_ContinuarTipoPlato.Visible = valor;
            ComboBox_ClasePlato.Visible = valor;
            Boton_ContinuarClasePlato.Visible = valor;
            Boton_ConfirmarIngredientes.Visible = valor;
            Boton_ConfirmalIngPrincipal.Visible = valor;
            ComboBox_IngredientePrincipal.Visible = valor;
            TextBox_Precio.Visible = valor;
            Boton_ConfirmarPrecio.Visible = valor;
            TextBox_Resumen.Visible = valor;
            Boton_Guardar.Visible = valor;
            Label_TipoPlato.Visible = valor;
            Label_ClasePlato.Visible = valor;
            label_GrillaSeleccionados.Visible = valor;
            DataGridView_SeleccionIngredientes.Visible = valor;
        }

        private void ActivarDisponibilidadControles(bool dispo)
        {
            DataGridView_TodosIngredientes.Enabled = dispo;
            DataGridView_SeleccionIngredientes.Enabled = dispo;
            Boton_Alta.Enabled = dispo;
            ComboBox_TipoPlato.Enabled = dispo;
            Boton_ContinuarTipoPlato.Enabled = dispo;
            ComboBox_ClasePlato.Enabled = dispo;
            Boton_ContinuarClasePlato.Enabled = dispo;
            ComboBox_IngredientePrincipal.Enabled = dispo;
            Boton_ConfirmalIngPrincipal.Enabled = dispo;
        }

        private void LimpiarTextboxYGrilla()
        {
            TextBox_Resumen.Clear();
            oBEplato = new BEPlato();
            DataGridView_SeleccionIngredientes.DataSource = oBEplato.ListaIngredientes;
        }

        #endregion

        #region Validaciones
        private void ValidarPrecio()
        {
            string precio = TextBox_Precio.Text;

            if (Regex.IsMatch(precio, @"^[0-9]") && base.Text != null)
            {
                oBEplato.Precio = Convert.ToInt32(precio);
                MessageBox.Show("Verifique los datos ingresados son correctos y precione el boton guardar");
                ConfirmarPlato();
            }
            else
            {
                MessageBox.Show("Formato de precio incorrecto, debe contener numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion


    }
}

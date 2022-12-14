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
            oBLIngrediente = new BLIngrediente();
            CargarControles();
            CargarGrillaPlatos();
            //ComboEventTipo();
            //ComboEventClase();
        }

        BEPlato oBEplato;
        BLPlato oBLPlato;
        BLIngrediente oBLIngrediente;

        private void GUI_Gerente_Platos_Load(object sender, EventArgs e)
        {
            DataGridView_SeleccionIngredientes.MultiSelect = false;
            DataGridView_SeleccionIngredientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridView_TodosIngredientes.MultiSelect = false;
            DataGridView_TodosIngredientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridView_Platos.MultiSelect = false;
            DataGridView_Platos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridView_Platos.ClearSelection();
            DataGridView_SeleccionIngredientes.ClearSelection();
            DataGridView_TodosIngredientes.ClearSelection();
        }

        #region BotonesPrincipales
        private void Boton_Alta_Click(object sender, EventArgs e)
        {
            try
            {
                
                ActivarDisponibilidadControles(true);
                BotonesAbmDisp(false);

                while (oBEplato.Nombre == "" || oBEplato.Descripcion == "" || oBEplato.Nombre == null || oBEplato.Descripcion == null)
                {
                    MessageBox.Show("Ingrese nombre y descripción");
                    oBEplato.Nombre = Interaction.InputBox("Ingrese el nombre del plato");
                    oBEplato.Descripcion = Interaction.InputBox("Ingrese una descripcion para el plato");
                }
                Boton_Cancelar.Visible = true;
                oBEplato.Codigo = oBLPlato.GenerarCodigo();
                SeleccionarTipoPlato();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void Boton_EliminarPlato_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Respuesta;
                Respuesta = MessageBox.Show("¿Quiere continuar con la baja?", "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (Respuesta == DialogResult.Yes)
                {
                    if (oBLPlato.Baja(oBEplato))
                    {
                        LimpiarTextboxYGrilla();
                        CargarGrillaPlatos();
                    }
                    else
                    {
                        MessageBox.Show("No se pueden eliminar platos que esten en pedidos, debe desabilitarlo modificandolo");
                    }
                    
                    
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void Boton_ModificarPlatos_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataGridView_Platos.Rows.Count > 0 && DataGridView_Platos.SelectedRows.Count > 0)
                {
                    
                    ActivarVisibilidadControles(true);
                    ActivarDisponibilidadControles(true);
                    SeleccionarPlatoGrilla();
                    CargarComboIngredientePrincipal();
                    CargarGrillasModificacion();
                    OcultarColumnasGrillas(DataGridView_TodosIngredientes);
                    OcultarColumnasGrillas(DataGridView_SeleccionIngredientes);
                    BotonesAbmDisp(false);
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
        #endregion

        #region BotonesSecundarios
        private void Boton_ContinuarTipoPlato_Click(object sender, EventArgs e)
        {
            try
            {
                oBEplato.Tipo = (string)ComboBox_TipoPlato.SelectedItem;
                ComboBox_TipoPlato.Enabled = false;
                Boton_ContinuarTipoPlato.Enabled = false;
                Label_ClasePlato.Visible = true;
                ComboBox_ClasePlato.Visible = true;
                Boton_ContinuarClasePlato.Visible = true;

                MessageBox.Show("Seleccione la clase de plato");
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void Boton_ContinuarClasePlato_Click(object sender, EventArgs e)
        {
            try
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
                DataGridView_TodosIngredientes.Visible = true;
                label3.Visible = true;


                List<BEIngrediente> todoIng = oBLIngrediente.ListarTodo();
                DataGridView_TodosIngredientes.DataSource = todoIng;
                OcultarColumnasGrillas(DataGridView_TodosIngredientes);
                OcultarColumnasGrillas(DataGridView_SeleccionIngredientes);
                DataGridView_TodosIngredientes.ClearSelection();

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }


        private void Boton_ConfirmarIngredientes_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataGridView_SeleccionIngredientes.Rows.Count > 0)
                {

                    DataGridView_TodosIngredientes.Enabled = false;
                    DataGridView_SeleccionIngredientes.Enabled = false;
                    Boton_ConfirmalIngPrincipal.Visible = true;
                    ComboBox_IngredientePrincipal.Visible = true;
                    MessageBox.Show("Seleccione el ingrediente principal de la lista y presione el boton \"Confirmar ingrediente principal\"");
                    CargarComboIngredientePrincipal();
                }
                else
                {
                    MessageBox.Show("Debe seleccionar al menos un ingrediente de la lista");
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void Boton_ConfirmalIngPrincipal_Click(object sender, EventArgs e)
        {
            try
            {
                AgregarIngredientePrincipal();
                ComboBox_IngredientePrincipal.Enabled = false;
                Boton_ConfirmalIngPrincipal.Enabled = false;
                TextBox_Precio.Visible = true;
                Boton_ConfirmarPrecio.Visible = true;
                MessageBox.Show("Ingrese el precio del plato y presione el boton \"Confirmar precio\"");
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void Boton_ConfirmarPrecio_Click(object sender, EventArgs e)
        {
            ValidarPrecio();
            RadioButton_Activo.Visible = true;
            RadioButton_Inactivo.Visible = true;
            groupBox1.Visible = true;
        }

        private void Button_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                AsignarAPlato();

                oBEplato.Activo = RadioButton_Activo.Checked ? true : false;

                if (oBLPlato.Guardar(oBEplato) == true)
                {
                    ConfiguracionDeControles();
                }
                else
                {
                    oBLPlato.Modificar(oBEplato);
                    ConfiguracionDeControles();
                }

                
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void Boton_Cancelar_Click(object sender, EventArgs e)
        {
            ConfiguracionDeControles();
        }

        #endregion

        #region DatagridClick
        private void DataGridView_SeleccionIngredientes_MouseClick(object sender, MouseEventArgs e)
        {
            if (DataGridView_SeleccionIngredientes.Rows.Count > 0 && DataGridView_SeleccionIngredientes.CurrentRow != null && DataGridView_SeleccionIngredientes.SelectedRows.Count > 0)
            {
                QuitarIngrediente();
            }
        }

        private void DataGridView_TodosIngredientes_MouseClick(object sender, MouseEventArgs e)
        {
            if (DataGridView_TodosIngredientes.Rows.Count > 0 && DataGridView_TodosIngredientes.CurrentRow != null && DataGridView_TodosIngredientes.SelectedRows.Count > 0)
            {
                AgregarIngrediente();
            }
        }

        private void DataGridView_Platos_MouseClick(object sender, MouseEventArgs e)
        {
            if (DataGridView_Platos.Rows.Count > 0 && DataGridView_Platos.CurrentRow != null && DataGridView_Platos.SelectedRows.Count > 0)
            {
                SeleccionarPlatoGrilla();
            }
        }
        #endregion

        #region MetodosPrincipales

        private void SeleccionarPlatoGrilla()
        {
            try
            {
                if (DataGridView_Platos.SelectedRows.Count > 0 && DataGridView_Platos.CurrentRow != null && DataGridView_Platos.SelectedRows.Count > 0)
                {
                    int codPlato = ((BEPlato)DataGridView_Platos.CurrentRow.DataBoundItem).Codigo;
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
                    AsignarAControles(oBEplato);
                    
                }
                else
                {
                    MessageBox.Show("Seleccione un plato a modificar");
                    ConfiguracionDeControles();
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

        }

        private void SeleccionarTipoPlato()
        {
            try
            {
                MessageBox.Show("Seleccione el tipo de plato");
                Label_TipoPlato.Visible = true;
                ComboBox_TipoPlato.Visible = true;
                Boton_ContinuarTipoPlato.Visible = true;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void QuitarIngrediente()
        {
            try
            {
                if (DataGridView_SeleccionIngredientes.Rows.Count > 0 && DataGridView_SeleccionIngredientes.CurrentRow != null && DataGridView_SeleccionIngredientes.SelectedRows.Count > 0)
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
                    OcultarColumnasGrillas(DataGridView_SeleccionIngredientes);
                    OcultarColumnasGrillas(DataGridView_TodosIngredientes);
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void AgregarIngrediente()
        {
            try
            {
                if (DataGridView_TodosIngredientes.Rows.Count > 0 && DataGridView_TodosIngredientes.CurrentRow != null && DataGridView_TodosIngredientes.SelectedRows.Count > 0)
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
                    OcultarColumnasGrillas(DataGridView_SeleccionIngredientes);
                    OcultarColumnasGrillas(DataGridView_TodosIngredientes);
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void AgregarIngredientePrincipal()
        {
            try
            {
                foreach (DataGridViewRow row in DataGridView_SeleccionIngredientes.Rows)
                {
                    if (((BEIngrediente)row.DataBoundItem).Nombre == ComboBox_IngredientePrincipal.SelectedItem.ToString())
                    {
                        oBEplato.IngredientePrincipal = (BEIngrediente)row.DataBoundItem;
                    }
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
        
        private void ConfirmarPlato()
        {
            try
            {
                TextBox_Precio.Enabled = false;
                Boton_ConfirmarPrecio.Enabled = false;
                TextBox_Resumen.Visible = true;
                Boton_Guardar.Visible = true;

                TextBox_Resumen.Text = Resumen(oBEplato);
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private string Resumen(BEPlato oPlato)
        {
            try
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
            catch (Exception ex)
            { MessageBox.Show(ex.Message); return null; }
            
        }

        private void AsignarAPlato()
        {
            try
            {
                oBEplato.Tipo = ComboBox_TipoPlato.SelectedItem.ToString();
                oBEplato.Clase = ComboBox_ClasePlato.SelectedItem.ToString();
                AgregarIngredientePrincipal();
                oBEplato.Precio = Convert.ToInt32(TextBox_Precio.Text);
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
        #endregion

        #region CArgarControles

        private void CargarComboIngredientePrincipal()
        {
            try
            {
                if (DataGridView_SeleccionIngredientes.Rows.Count > 0 && DataGridView_SeleccionIngredientes.CurrentRow != null && DataGridView_SeleccionIngredientes.SelectedRows.Count > 0)
                {
                    List<string> ingreAux = new List<string>();

                    foreach (DataGridViewRow row in DataGridView_SeleccionIngredientes.Rows)
                    {
                        ingreAux.Add(((BEIngrediente)row.DataBoundItem).Nombre);
                    }
                    ComboBox_IngredientePrincipal.DataSource = ingreAux;
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }


        private void CargarGrillaPlatos()
        {
            try
            {
                DataGridView_Platos.DataSource = oBLPlato.ListarTodo();
                OcultarCampos();
                DataGridView_Platos.ClearSelection();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void CargarControles()
        {
            try
            {
                ComboBox_TipoPlato.DataSource = CargarComboTipoPlato();
                ComboBox_ClasePlato.DataSource = CargarComboClasePlato();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private List<string> CargarComboTipoPlato()
        {
            try
            {
                List<string> TipoPlato = new List<string> {"Entrada", "Principal", "Postre"};
                return TipoPlato;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); return null; }
        }

        private List<string> CargarComboClasePlato()
        {
            try
            {
                List<string> ClasePlato = new List<string>{ "Celiaco", "Vegetariano", "Vegano", "Estandar"};
                return ClasePlato;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); return null; }
        }

        private void CargarGrillasModificacion()
        {
            try
            {
                DataGridView_TodosIngredientes.DataSource = oBLIngrediente.ListarTodo();
                DataGridView_TodosIngredientes.ClearSelection();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message);}
        }
        #endregion

        #region AdministracionControles



        private void AsignarAControles(BEPlato oPlato)
        {
            try
            {
                ComboBox_TipoPlato.SelectedItem = oPlato.Tipo;
                ComboBox_ClasePlato.SelectedItem = oPlato.Clase;
                ComboBox_IngredientePrincipal.SelectedItem = oPlato.IngredientePrincipal.Nombre;
                TextBox_Precio.Text = oPlato.Precio.ToString();
                TextBox_Resumen.Text = Resumen(oPlato);
                DataGridView_SeleccionIngredientes.DataSource = oPlato.ListaIngredientes;
                
                if (oPlato.Activo == true) {RadioButton_Activo.Checked = true;}
                else{RadioButton_Inactivo.Checked = true;}

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void ActivarVisibilidadControles(bool valor)
        {
            try
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
                RadioButton_Activo.Visible = valor;
                RadioButton_Inactivo.Visible = valor;
                DataGridView_TodosIngredientes.Visible = valor;
                label3.Visible = valor;
                Boton_Cancelar.Visible = valor;
                groupBox1.Visible = valor;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void ActivarDisponibilidadControles(bool dispo)
        {
            try
            {
                DataGridView_TodosIngredientes.Enabled = dispo;
                DataGridView_SeleccionIngredientes.Enabled = dispo;
                Boton_Alta.Enabled = dispo;
                Boton_ModificarPlatos.Enabled = dispo;
                Boton_EliminarPlato.Enabled = dispo;
                ComboBox_TipoPlato.Enabled = dispo;
                Boton_ContinuarTipoPlato.Enabled = dispo;
                ComboBox_ClasePlato.Enabled = dispo;
                Boton_ContinuarClasePlato.Enabled = dispo;
                ComboBox_IngredientePrincipal.Enabled = dispo;
                Boton_ConfirmalIngPrincipal.Enabled = dispo;
                Boton_ConfirmarPrecio.Enabled = dispo;
                TextBox_Precio.Enabled = dispo;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void LimpiarTextboxYGrilla()
        {
            try
            {
                TextBox_Resumen.Clear();
                oBEplato = new BEPlato();
                DataGridView_SeleccionIngredientes.DataSource = oBEplato.ListaIngredientes;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void ConfiguracionDeControles()
        {
            
            ActivarVisibilidadControles(false);
            LimpiarTextboxYGrilla();
            ActivarDisponibilidadControles(false);
            CargarGrillaPlatos();
            BotonesAbmDisp(true);
        }


        #endregion

        #region Validaciones
        private void ValidarPrecio()
        {
            try
            {
                string precio = TextBox_Precio.Text;

                if (Regex.IsMatch(precio, @"^[0-9]") && base.Text != null)
                {
                    oBEplato.Precio = Convert.ToInt32(precio);
                    MessageBox.Show("Verifique los datos ingresados son correctos y precione el boton \"Confirmar datos del plato\"");
                    ConfirmarPlato();
                }
                else
                {
                    MessageBox.Show("Formato de precio incorrecto, debe contener numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }


        #endregion

        private void OcultarColumnasGrillas(DataGridView dataGrid)
        {
            if (dataGrid.Rows.Count > 0 && dataGrid.CurrentRow != null && dataGrid.SelectedRows.Count > 0)
            {
                dataGrid.Columns["Tipo"].Visible = false;
                dataGrid.Columns["Stock"].Visible = false;
                dataGrid.Columns["Codigo"].Visible = false;
                //dataGrid.Columns["Tipo"].Visible = false;
            }
        }

        private void OcultarCampos()
        {
            DataGridView_Platos.Columns["CodigoComanda"].Visible = false;
            DataGridView_Platos.Columns["CodigoPedido"].Visible = false;
            DataGridView_Platos.Columns["CodigoItem"].Visible = false;
            DataGridView_Platos.Columns["Codigo"].Visible = false;
            DataGridView_Platos.Columns["IngredientePrincipal"].Visible = false;
        }

        private void TextBox_Resumen_TextChanged(object sender, EventArgs e)
        {

        }

        private void BotonesAbmDisp(bool estado)
        {
            Boton_Alta.Enabled = estado;
            Boton_ModificarPlatos.Enabled = estado;
            Boton_EliminarPlato.Enabled = estado;
        }


    }
}

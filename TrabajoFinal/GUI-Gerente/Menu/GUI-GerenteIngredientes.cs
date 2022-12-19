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
    public partial class GUI_Gerente_Ingredientes : Form
    {
        public GUI_Gerente_Ingredientes()
        {
            InitializeComponent();
            oBEIngrediente = new BEIngrediente();
            oBLIngrediente = new BLIngrediente();
        }
        BEIngrediente oBEIngrediente;
        BLIngrediente oBLIngrediente;

        private void GUI_AdminIngredientes_Load(object sender, EventArgs e)
        {
            Grilla_Ingredientes.MultiSelect = false;
            Grilla_Ingredientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CargarCombobox();
            CargarGrilla();
            Grilla_Ingredientes.ClearSelection();
            HabilitarBotonesABM(true);
            HabilitarControlesBebida(false);
        }

        private void Boton_Alta_Click(object sender, EventArgs e)
        {
            try
            {
                HabilitarBotonesABM(false);
                HabilitarControlesBebida(true);
                LimpiarControles();
                Grilla_Ingredientes.Enabled = true;

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void Boton_Baja_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Respuesta;
                Respuesta = MessageBox.Show("¿Quiere continuar con la baja?", "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (Respuesta == DialogResult.Yes)
                {
                    if (oBLIngrediente.Baja(oBEIngrediente))
                    {
                        LimpiarControles();
                        CargarGrilla();
                    }
                    else {MessageBox.Show("No se puede dar de baja un ingrediente que se encuentre en un plato");}
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void Boton_Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Grilla_Ingredientes.Rows.Count > 0 && Grilla_Ingredientes.CurrentRow != null && Grilla_Ingredientes.SelectedRows.Count > 0)
                {
                    HabilitarBotonesABM(false);
                    HabilitarControlesBebida(true);
                    Grilla_Ingredientes.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Seleccione una bebida a modificar");
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void Boton_ConfirmarIngredientes_Click(object sender, EventArgs e)
        {
            if (AsignarIngrediente())
            {
                if (oBLIngrediente.Existe(oBEIngrediente))
                {
                    oBEIngrediente.Codigo = oBLIngrediente.GenerarCodigo();
                    oBLIngrediente.Guardar(oBEIngrediente);
                    CargarGrilla();
                }
                else
                {
                    if (oBLIngrediente.Modificar(oBEIngrediente))
                    {
                        AsignarIngredienteAControles(oBEIngrediente);
                        CargarGrilla();
                    }
                    else { MessageBox.Show("No se puede modificar un ingrediente que se encuentre en un plato"); }
                }
                HabilitarBotonesABM(true);
                HabilitarControlesBebida(false);
                Grilla_Ingredientes.Enabled = true;
            }
            else
            { MessageBox.Show("Ingrese los datos de forma correcta"); }
        }

        private void Boton_Cancelar_Click(object sender, EventArgs e)
        {
            LimpiarControles();
            CargarGrilla();
            HabilitarBotonesABM(true);
            HabilitarControlesBebida(false);
            Grilla_Ingredientes.Enabled = true;
        }

        private bool AsignarIngrediente()
        {
            try
            {
                if (UC_ValNomb.Validar())
                {
                    oBEIngrediente.Nombre = UC_ValNomb.Text;

                    if (UC_ValStock.validar())
                    {
                        oBEIngrediente.Stock = int.Parse(UC_ValStock.Text);
                        oBEIngrediente.Proveedor = ComboBox_Proveedor.SelectedItem.ToString();
                        oBEIngrediente.Tipo = ComboBox_Tipo.SelectedItem.ToString();

                        if (RadioButton_Si.Checked) { oBEIngrediente.Refrigeracion = true; }
                        else { oBEIngrediente.Refrigeracion = false; }

                        return true;
                    }
                    else { return false; }
                }
                else { return false; }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); return false; }
        }


        private void AsignarIngredienteAControles(BEIngrediente oBEIngrediente)
        {
            try
            {
                UC_ValNomb.Text = oBEIngrediente.Nombre;
                UC_ValStock.Text = oBEIngrediente.Stock.ToString();
                ComboBox_Proveedor.SelectedItem = oBEIngrediente.Proveedor;
                ComboBox_Tipo.SelectedItem = oBEIngrediente.Tipo;

                if (oBEIngrediente.Refrigeracion == true){ RadioButton_Si.Checked = true;}
                else
                { RadioButton_No.Checked = true;}

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        void LimpiarControles()
        {
            try
            {
                UC_ValNomb.Text = null;
                ComboBox_Proveedor.SelectedItem = null;
                ComboBox_Tipo.SelectedItem = null;
                UC_ValStock.Text = null;
                RadioButton_Si.Checked = true;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void Grilla_Ingredientes_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (Grilla_Ingredientes.Rows.Count > 0 && Grilla_Ingredientes.CurrentRow != null && Grilla_Ingredientes.SelectedRows.Count > 0)
                {
                    oBEIngrediente = (BEIngrediente)Grilla_Ingredientes.CurrentRow.DataBoundItem;
                AsignarIngredienteAControles(oBEIngrediente);
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void CargarCombobox()
        {
            try
            {
                List<string> ListaProveedor = new List<string> {"Verduleria Amistad", "Frigorifico Corte", "La Serenisima", "Coca Cola", "Pepsi" };
                ComboBox_Proveedor.DataSource = ListaProveedor;

                List<string> ListaTipo = new List<string> { "Principal",  "Secundario" };
                ComboBox_Tipo.DataSource = ListaTipo;

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
        private void CargarGrilla()
        {
            try
            {
                Grilla_Ingredientes.DataSource = null;
                Grilla_Ingredientes.DataSource = oBLIngrediente.ListarTodo();
                Grilla_Ingredientes.ClearSelection();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void HabilitarControlesBebida(bool valor)
        {

            UC_ValNomb.Enabled = valor;
            ComboBox_Proveedor.Enabled = valor;
            ComboBox_Tipo.Enabled = valor;
            UC_ValStock.Enabled = valor;
            RadioButton_Si.Enabled = valor;
            RadioButton_No.Enabled = valor;
            Boton_ConfirmarIngredientes.Enabled = valor;
            Boton_Cancelar.Enabled = valor;

        }

        private void HabilitarBotonesABM(bool valor)
        {
            Boton_Alta.Enabled = valor;
            Boton_Modificar.Enabled = valor;
            Boton_Baja.Enabled = valor;
        }


    }
}

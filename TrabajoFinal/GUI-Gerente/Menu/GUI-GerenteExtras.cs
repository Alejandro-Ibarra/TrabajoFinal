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
    public partial class GUI_Gerente_Extras : Form
    {
        public GUI_Gerente_Extras()
        {
            InitializeComponent();
            oBLExtras = new BLExtras();
            oBEExtras = new BEExtras();
        }

        BLExtras oBLExtras;
        BEExtras oBEExtras;

        private void GUI_AdminExtras_Load(object sender, EventArgs e)
        {
            CargarCombobox();
            CargarGrilla();
            Grilla_Extras.MultiSelect = false;
            Grilla_Extras.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Grilla_Extras.ClearSelection();
            HabilitarBotonesABM(true);
            HabilitarControlesExtras(false);
        }

        private void Boton_Alta_Click(object sender, EventArgs e)
        {
            try
            {
                HabilitarBotonesABM(false);
                HabilitarControlesExtras(true);
                LimpiarControles();
                Grilla_Extras.Enabled = false;

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void Boton_Baja_Click(object sender, EventArgs e)
        {
            try
            {
                if (Grilla_Extras.Rows.Count > 0 && Grilla_Extras.CurrentRow != null && Grilla_Extras.SelectedRows.Count > 0)
                {
                    DialogResult Respuesta;
                    Respuesta = MessageBox.Show("¿Quiere continuar con la baja?", "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (Respuesta == DialogResult.Yes)
                    {
                        if (ValidarEliminacion())
                        {
                            oBLExtras.Baja(oBEExtras);
                            LimpiarControles();
                            CargarGrilla();
                        }
                        else
                        { MessageBox.Show("No se puede eliminar un extra que esté en una comanda, debe desabilitarlo con el boton modificar"); }
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione una bebida a eliminar");
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private bool ValidarEliminacion()
        {
            return oBLExtras.ValidarEliminarExtras(oBEExtras);
        }

        private void Boton_Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Grilla_Extras.Rows.Count > 0 && Grilla_Extras.CurrentRow != null && Grilla_Extras.SelectedRows.Count > 0)
                {
                    HabilitarBotonesABM(false);
                    HabilitarControlesExtras(true);
                    Grilla_Extras.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Seleccione una bebida a modificar");
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void Boton_ConfirmarExtra_Click(object sender, EventArgs e)
        {
            if (AsignarExtras())
            {
                if (oBLExtras.Existe(oBEExtras))
                {
                    oBEExtras.Codigo = oBLExtras.GenerarCodigo();
                    oBLExtras.Guardar(oBEExtras);
                    CargarGrilla();
                }
                else
                {
                    oBLExtras.Modificar(oBEExtras);
                    AsignarExtrasAControles(oBEExtras);
                    CargarGrilla();
                }
            }
            else
            { MessageBox.Show("Ingrese los datos de forma correcta"); }
        }

        private void Boton_Cancelar_Click(object sender, EventArgs e)
        {
            LimpiarControles();
            CargarGrilla();
            HabilitarBotonesABM(true);
            HabilitarControlesExtras(false);
            Grilla_Extras.Enabled = true;
        }

        private bool AsignarExtras()
        {
            try
            {

                if (RadioButton_Activo.Checked){oBEExtras.Activo = true;}
                else{ oBEExtras.Activo = false;}

                if (UC_ValNomb.Validar())
                {
                    oBEExtras.Nombre = UC_ValNomb.Text;

                    if (UC_ValStock.validar())
                    {
                        oBEExtras.Stock = int.Parse(UC_ValStock.Text);
                        oBEExtras.Proveedor = ComboBox_Proveedor.SelectedItem.ToString();
                        oBEExtras.Tipo = ComboBox_Tipo.SelectedItem.ToString();

                        return true;
                    }
                    else { return false; }
                }
                else { return false; }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); return false; }
        }


        private void AsignarExtrasAControles(BEExtras oBEExtras)
        {
            try
            {
                UC_ValNomb.Text = oBEExtras.Nombre;
                UC_ValStock.Text = oBEExtras.Stock.ToString();
                ComboBox_Proveedor.SelectedItem = oBEExtras.Proveedor;
                ComboBox_Tipo.SelectedItem = oBEExtras.Tipo;
                if (oBEExtras.Activo == true){ RadioButton_Activo.Checked = true;}
                else {RadioButton_Inactivo.Checked = true; }
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
                RadioButton_Activo.Checked = true;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }


        private void CargarCombobox()
        {
            try
            {
                List<string> ListaProveedor = new List<string> {"Limpieza clean","Ledesma","Limpieza ramona","Bazar chef",
                    "ChangoMas","Blanqueria nona","Estela limpieza","Distribuidora Pepito","Panderia San Jose","Papelera Papelito"};
                ComboBox_Proveedor.DataSource = ListaProveedor;

                List<string> ListaTipo = new List<string>{"Limpieza","Bazar","Blanqueria","Distribuidora","Panaderia","Papeleria"};
                ComboBox_Tipo.DataSource = ListaTipo;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }


        private void CargarGrilla()
        {
            try
            {
                Grilla_Extras.DataSource = null;
                Grilla_Extras.DataSource = oBLExtras.ListarTodo();
                OcultarCampos();
                Grilla_Extras.ClearSelection();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void Grilla_Ingredientes_Click(object sender, EventArgs e)
        {
            try
            {
                if (Grilla_Extras.Rows.Count > 0 && Grilla_Extras.CurrentRow != null && Grilla_Extras.SelectedRows.Count > 0)
                {
                oBEExtras = (BEExtras)Grilla_Extras.CurrentRow.DataBoundItem;
                AsignarExtrasAControles(oBEExtras);
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void OcultarCampos()
        {
            Grilla_Extras.Columns["CodigoComanda"].Visible = false;
            Grilla_Extras.Columns["CodigoPedido"].Visible = false;
            Grilla_Extras.Columns["CodigoItem"].Visible = false;
            Grilla_Extras.Columns["Codigo"].Visible = false;
            Grilla_Extras.Columns["Descripcion"].Visible = false;
        }

        private void HabilitarControlesExtras(bool valor)
        {

            UC_ValNomb.Enabled = valor;
            ComboBox_Proveedor.Enabled = valor;
            ComboBox_Tipo.Enabled = valor;
            UC_ValStock.Enabled = valor;
            RadioButton_Activo.Enabled = valor;
            RadioButton_Inactivo.Enabled = valor;
            Boton_ConfirmarExtra.Enabled = valor;
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

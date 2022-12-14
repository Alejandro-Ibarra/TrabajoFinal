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
    public partial class GUI_Gerente_Bebidas : Form
    {
        public GUI_Gerente_Bebidas()
        {
            InitializeComponent();
            oBEBebida = new BEBebida();
            oBLBebida = new BLBebida();
        }
        BEBebida oBEBebida;
        BLBebida oBLBebida;

        private void GUI_AdminBebidas_Load(object sender, EventArgs e)
        {
            CargarComboBoxMarca();
            CargarComboBoxEnvase();
            CargarGrilla();
            Grilla_Bebidas.MultiSelect = false;
            Grilla_Bebidas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Grilla_Bebidas.ClearSelection();
        }

        private void Boton_Alta_Click(object sender, EventArgs e)
        {
            try
            {
                HabilitarControlesBebida(true);
                HabilitarBotonesABM(false);
                LimpiarControles();
                Grilla_Bebidas.Enabled = false;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void Boton_Baja_Click(object sender, EventArgs e)
        {
            try
            {
                if (Grilla_Bebidas.Rows.Count > 0 && Grilla_Bebidas.CurrentRow != null && Grilla_Bebidas.SelectedRows.Count > 0)
                {
                    Grilla_Bebidas.Enabled = false;
                    DialogResult Respuesta;
                    Respuesta = MessageBox.Show("¿Quiere continuar con la baja?", "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (Respuesta == DialogResult.Yes)
                    {
                        if (ValidarEliminacion())
                        {
                            oBLBebida.Baja(oBEBebida);
                            LimpiarControles();
                            CargarGrilla();

                            Grilla_Bebidas.Enabled = true;
                        }
                        else
                        {MessageBox.Show("No se puede eliminar una bebida que esta en una comanda");}

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
            return oBLBebida.ValidarEliminarBebida(oBEBebida);
        }

        private void Boton_Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Grilla_Bebidas.Rows.Count > 0 && Grilla_Bebidas.CurrentRow != null && Grilla_Bebidas.SelectedRows.Count > 0)
                {
                    HabilitarControlesBebida(true);
                    HabilitarBotonesABM(false);
                    Grilla_Bebidas.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Seleccione una bebida a modificar");
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void Boton_ConfDatBebidas_Click(object sender, EventArgs e)
        {
            if (AsignarBebida())
            {
                if (oBLBebida.Existe(oBEBebida))
                {
                    oBEBebida.Codigo = oBLBebida.GenerarCodigo();
                    oBLBebida.Guardar(oBEBebida);
                    CargarGrilla();
                    Grilla_Bebidas.Enabled = true;

                }
                else
                {
                    oBLBebida.Modificar(oBEBebida);
                    CargarGrilla();
                    Grilla_Bebidas.Enabled = true;
                    
                }
                HabilitarControlesBebida(false);
                HabilitarBotonesABM(true);
            }
            else
            { MessageBox.Show("Ingrese los datos de forma correcta"); }
        }

        private void Boton_Cancelar_Click(object sender, EventArgs e)
        {
            LimpiarControles();
            CargarGrilla();
            HabilitarControlesBebida(false);
            HabilitarBotonesABM(true);
            Grilla_Bebidas.Enabled = true;
        }

        private bool AsignarBebida()
        {
            try
            {
                if (RadioButton_Activo.Checked){oBEBebida.Activo = true;}
                else { oBEBebida.Activo = false; }

                if (UC_ValNomb.Validar())
                {
                    oBEBebida.Nombre = UC_ValNomb.Text;
                    if (UC_ValPrecio.validar())
                    {
                        oBEBebida.Precio = int.Parse(UC_ValPrecio.Text);
                        if (UC_ValGraduacion.validar())
                        {
                            oBEBebida.GraduacionAlc = int.Parse(UC_ValGraduacion.Text);
                            if (UC_ValStock.validar())
                            {
                                oBEBebida.Stock = int.Parse(UC_ValStock.Text);
                                oBEBebida.Marca = ComboBox_Marca.SelectedItem.ToString();
                                oBEBebida.TipoEnvase = ComboBox_Envases.SelectedItem.ToString();
                                return true;
                            }
                            else { return false; }
                        }
                        else { return false; }
                    }
                    else { return false; }
                }
                else { return false; }

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); return false; }
        }


        private void CargarComboBoxMarca()
        {
            try
            {
                List<string> ListaMarcas = new List<string>{"Coca-Cola","Paso de los toros","Mirinda","7UP","Pepsi","Villavicencio","Aquarius", "Quilmes","Salentein","Luiggi Bosca"};

                ComboBox_Marca.DataSource = ListaMarcas;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void CargarComboBoxEnvase()
        {
            try
            {
                List<string> ListaEnvases = new List<string> {"Vidrio retornable","Vidrio No retornable","Plastico retornable","Plastico No retornable"};

                ComboBox_Envases.DataSource = ListaEnvases;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        void AsignarBebidaAControles(BEBebida oBEBebida)
        {
            try
            {
                UC_ValNomb.Text = oBEBebida.Nombre;
                UC_ValGraduacion.Text = oBEBebida.GraduacionAlc.ToString();
                UC_ValPrecio.Text = oBEBebida.Precio.ToString();
                UC_ValStock.Text = oBEBebida.Stock.ToString();
                ComboBox_Marca.SelectedItem = oBEBebida.Marca;
                ComboBox_Envases.SelectedItem = oBEBebida.TipoEnvase;

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        void CargarGrilla()
        {
            try
            {
                Grilla_Bebidas.DataSource = null;
                Grilla_Bebidas.DataSource = oBLBebida.ListarTodo();
                OcultarCampos();
                Grilla_Bebidas.ClearSelection();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void Grilla_Bebidas_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (Grilla_Bebidas.Rows.Count > 0 && Grilla_Bebidas.CurrentRow != null && Grilla_Bebidas.SelectedRows.Count > 0)
                {
                    oBEBebida = (BEBebida)Grilla_Bebidas.CurrentRow.DataBoundItem;
                    AsignarBebidaAControles(oBEBebida);
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        void LimpiarControles()
        {
            try
            {
                UC_ValNomb.Text = null;
                UC_ValGraduacion.Text = null;
                UC_ValStock.Text = null;
                UC_ValPrecio.Text = null;
                ComboBox_Envases.SelectedItem = null;
                ComboBox_Marca.SelectedItem = null;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
        private void OcultarCampos()
        {
            Grilla_Bebidas.Columns["CodigoComanda"].Visible = false;
            Grilla_Bebidas.Columns["CodigoPedido"].Visible = false;
            Grilla_Bebidas.Columns["CodigoItem"].Visible = false;
            Grilla_Bebidas.Columns["Codigo"].Visible = false;
            Grilla_Bebidas.Columns["Descripcion"].Visible = false;
        }

        private void HabilitarControlesBebida(bool valor)
        {

            UC_ValNomb.Enabled = valor;
            ComboBox_Envases.Enabled = valor;
            ComboBox_Marca.Enabled = valor;
            UC_ValGraduacion.Enabled = valor;
            UC_ValStock.Enabled = valor;
            UC_ValPrecio.Enabled = valor;
            RadioButton_Activo.Enabled = valor;
            RadioButton_Inactivo.Enabled = valor;
            Boton_ConfDatBebidas.Enabled = valor;
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

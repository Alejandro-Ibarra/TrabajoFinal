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
            Grilla_Ingredientes.MultiSelect = false;
            Grilla_Ingredientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Grilla_Ingredientes.ClearSelection();
        }

        private void Boton_Alta_Click(object sender, EventArgs e)
        {
            try
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
                    { MessageBox.Show("El extra ingresado ya existe"); }
                }
                else
                { MessageBox.Show("Ingrese los datos de forma correcta"); }

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
                if (AsignarExtras())
                {
                    oBLExtras.Modificar(oBEExtras);
                    AsignarExtrasAControles(oBEExtras);
                    CargarGrilla();
                }
                else
                { MessageBox.Show("Ingrese los datos de forma correcta"); }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
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
                foreach (TextBox oTextbox in this.Controls.OfType<TextBox>())
                {
                    oTextbox.Text = null;
                }
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
                Grilla_Ingredientes.DataSource = null;
                Grilla_Ingredientes.DataSource = oBLExtras.ListarTodo();
                OcultarCampos();
                Grilla_Ingredientes.ClearSelection();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void Grilla_Ingredientes_Click(object sender, EventArgs e)
        {
            try
            {
                if (Grilla_Ingredientes.Rows.Count > 0 && Grilla_Ingredientes.CurrentRow != null)
                {
                oBEExtras = (BEExtras)Grilla_Ingredientes.CurrentRow.DataBoundItem;
                AsignarExtrasAControles(oBEExtras);
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void OcultarCampos()
        {
            Grilla_Ingredientes.Columns["CodigoComanda"].Visible = false;
            Grilla_Ingredientes.Columns["CodigoPedido"].Visible = false;
            Grilla_Ingredientes.Columns["CodigoItem"].Visible = false;
            Grilla_Ingredientes.Columns["Codigo"].Visible = false;
            Grilla_Ingredientes.Columns["Descripcion"].Visible = false;
        }
    }
}

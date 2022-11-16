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
                    { MessageBox.Show("La bebida ingresada ya existe"); }
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
                    oBLExtras.Baja(oBEExtras);
                    LimpiarControles();
                    CargarGrilla();
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
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
                
                if (UC_ValNomb.validar())
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
            List<string> ListaProveedor = new List<string>();
            ListaProveedor.Add("Limpieza clean");
            ListaProveedor.Add("Ledesma");
            ListaProveedor.Add("Limpieza ramona");
            ListaProveedor.Add("Bazar chef");
            ListaProveedor.Add("Chango");
            ListaProveedor.Add("Blanqueria nona");
            ListaProveedor.Add("Estela limpieza");
            ListaProveedor.Add("Distribuidora Pepito");
            ComboBox_Proveedor.DataSource = ListaProveedor;

            List<string> ListaTipo = new List<string>();
            ListaTipo.Add("Limpieza");
            ListaTipo.Add("Bazar");
            ListaTipo.Add("Blanqueria");
            ListaTipo.Add("Distribuidora");
            ComboBox_Tipo.DataSource = ListaTipo;
        }


        private void CargarGrilla()
        {
            try
            {
                Grilla_Ingredientes.DataSource = null;
                Grilla_Ingredientes.DataSource = oBLExtras.ListarTodo();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void Grilla_Ingredientes_Click(object sender, EventArgs e)
        {
            if (Grilla_Ingredientes.DataSource != null)
            {
                oBEExtras = (BEExtras)Grilla_Ingredientes.CurrentRow.DataBoundItem;
                AsignarExtrasAControles(oBEExtras);
            }
        }
    }
}

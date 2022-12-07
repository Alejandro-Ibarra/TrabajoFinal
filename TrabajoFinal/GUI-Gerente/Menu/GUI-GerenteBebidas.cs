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
        }

        private void Boton_Alta_Click(object sender, EventArgs e)
        {
            try
            {
                if (AsignarBebida())
                {
                    if (oBLBebida.Existe(oBEBebida))
                    {
                        oBEBebida.Codigo = oBLBebida.GenerarCodigo();
                        oBLBebida.Guardar(oBEBebida);
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
                    if (ValidarEliminacion())
                    {
                        oBLBebida.Baja(oBEBebida);
                        LimpiarControles();
                        CargarGrilla();
                    }
                    else
                    {MessageBox.Show("No se puede eliminar una bebida que esta en una comanda");}

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
                if (AsignarBebida())
                {
                    oBLBebida.Modificar(oBEBebida);
                    AsignarBebidaAControles(oBEBebida);
                    CargarGrilla();
                }
                else
                { MessageBox.Show("Ingrese los datos de forma correcta"); }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private bool AsignarBebida()
        {
            try
            {
                if (UC_ValNomb.validar())
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
                List<string> ListaMarcas = new List<string>();
                ListaMarcas.Add("Quilme");
                ListaMarcas.Add("Coca Cola");
                ListaMarcas.Add("Mirinda");
                ListaMarcas.Add("7UP");
                ListaMarcas.Add("Pepsi");

            ComboBox_Marca.DataSource = ListaMarcas;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void CargarComboBoxEnvase()
        {
            try
            {
                List<string> ListaEnvases = new List<string>();
                ListaEnvases.Add("Vidrio retornable");
                ListaEnvases.Add("Vidrio No retornable");
                ListaEnvases.Add("Plastico");
                ListaEnvases.Add("Plastico No retornable");

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
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void Grilla_Bebidas_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (Grilla_Bebidas.Rows.Count > 0)
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
                foreach (TextBox oTextbox in this.Controls.OfType<TextBox>())
                {
                    oTextbox.Text = null;
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

    }
}

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
            CargarCombobox();
            CargarGrilla();
        }

        private void Boton_Alta_Click(object sender, EventArgs e)
        {
            try
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
            ///////////////////////////////////////
            ///Verificar que no este en plato
            //////////////////////////////////////
            try
            {
                DialogResult Respuesta;
                Respuesta = MessageBox.Show("¿Quiere continuar con la baja?", "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (Respuesta == DialogResult.Yes)
                {
                    oBLIngrediente.Baja(oBEIngrediente);
                    LimpiarControles();
                    CargarGrilla();
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void Boton_Modificar_Click(object sender, EventArgs e)
        {
            ///////////////////////////////////////
            ///Verificar que no este en plato
            //////////////////////////////////////
            try
            {
                if (AsignarIngrediente())
                {
                    oBLIngrediente.Modificar(oBEIngrediente);
                    AsignarIngredienteAControles(oBEIngrediente);
                    CargarGrilla();
                }
                else
                { MessageBox.Show("Ingrese los datos de forma correcta"); }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private bool AsignarIngrediente()
        {
            try
            {
                
                

                if (UC_ValNomb.validar())
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
                foreach (TextBox oTextbox in this.Controls.OfType<TextBox>())
                {
                    oTextbox.Text = null;
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void Grilla_Ingredientes_MouseClick(object sender, MouseEventArgs e)
        {
            if (Grilla_Ingredientes.DataSource != null)
            {
                oBEIngrediente = (BEIngrediente)Grilla_Ingredientes.CurrentRow.DataBoundItem;
                AsignarIngredienteAControles(oBEIngrediente);
            }
        }

        private void CargarCombobox()
        {
            List<string> ListaProveedor = new List<string>();
            ListaProveedor.Add("Verduleria Amistad");
            ListaProveedor.Add("Frigorifico Corte");
            ListaProveedor.Add("La Serenisima");
            ListaProveedor.Add("Coca Cola");
            ListaProveedor.Add("Pepsi");
            ComboBox_Proveedor.DataSource = ListaProveedor;

            List<string> ListaTipo = new List<string>();
            ListaTipo.Add("Principal");
            ListaTipo.Add("Secundario");
            ComboBox_Tipo.DataSource = ListaTipo;
        }



        private void CargarGrilla()
        {
            try
            {
                Grilla_Ingredientes.DataSource = null;
                Grilla_Ingredientes.DataSource = oBLIngrediente.ListarTodo();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
    }
}

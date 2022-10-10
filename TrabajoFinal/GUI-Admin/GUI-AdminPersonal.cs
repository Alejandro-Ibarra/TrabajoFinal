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
    public partial class GUI_Administrar_Personal : Form
    {
        public GUI_Administrar_Personal()
        {
            InitializeComponent();
            oBECocinero = new BECocinero();
            oBLCocinero = new BLCocinero();
            oBEMozo = new BEMozo();
            oBLMozo = new BLMozo();
        }

        BECocinero oBECocinero;
        BLCocinero oBLCocinero;
        BEMozo oBEMozo;
        BLMozo oBLMozo;

        private void GUI_Administrar_Personal_Load(object sender, EventArgs e)
        {
            CargarGrillaCocinero();
            CargarGrillaMozo();
        }

        private void Boton_Alta_Click(object sender, EventArgs e)
        {
            try
            {
                if (RadioButton_Cocinero.Checked)
                {
                    if (!oBLCocinero.Existe(int.Parse(UC_ValDNI.Text)))
                    {
                        if (AsignarCocinero())
                        {
                            oBECocinero.Turno = AsignarTurno();
                            oBECocinero.CantPedidos = 0;
                            oBECocinero.Password = ServiceLogic.Encriptar.Encrypt(textBox_Pass.Text.Trim(), null);
                            oBLCocinero.Guardar(oBECocinero);
                            CargarGrillaCocinero();
                        }
                        else
                        { MessageBox.Show("Ingrese los datos de forma correcta"); }
                    }
                    else
                    { MessageBox.Show("Ya existe un cocinero con ese DNI"); }
                }
                else
                {
                    if (AsignarMozo())
                    {
                        oBEMozo.Turno = AsignarTurno();
                        oBEMozo.Ranking = 0;
                        oBEMozo.Password = ServiceLogic.Encriptar.Encrypt(textBox_Pass.Text.Trim(), null);
                        oBLMozo.Guardar(oBEMozo);
                        AsignarMozoAControles(oBEMozo);
                        CargarGrillaMozo();
                    }
                    else
                    { MessageBox.Show("Ingrese los datos de forma correcta"); }
                }

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
                    if (RadioButton_Cocinero.Checked)
                    {
                        oBLCocinero.Baja(oBECocinero);
                        LimpiarControles();
                        CargarGrillaCocinero();
                    }
                    else
                    {
                        oBLMozo.Baja(oBEMozo);
                        LimpiarControles();
                        CargarGrillaMozo();
                    }

                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void Boton_Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (RadioButton_Cocinero.Checked)
                {
                    if (AsignarCocinero())
                    {
                        oBLCocinero.Modificar(oBECocinero);
                        AsignarCocineroAControles(oBECocinero);
                        CargarGrillaCocinero();
                    }
                    else
                    { MessageBox.Show("Ingrese los datos de forma correcta"); }

                }
                else
                {
                    if (AsignarMozo())
                    {
                        oBLMozo.Guardar(oBEMozo);
                        AsignarMozoAControles(oBEMozo);
                        CargarGrillaMozo();
                    }
                    else
                    { MessageBox.Show("Ingrese los datos de forma correcta"); }
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private bool AsignarCocinero()
        {
            try
            {
                if (UC_ValDNI.validar())
                {
                    oBECocinero.DNI = int.Parse(UC_ValDNI.Text);
                    if (UC_ValNomb.validar())
                    {
                        oBECocinero.Nombre = UC_ValNomb.Text;
                        if (UC_ValApe.validar())
                        {
                            oBECocinero.Apellido = UC_ValApe.Text;
                            if (UC_ValCod.validar())
                            {
                                oBECocinero.Codigo = int.Parse(UC_ValCod.Text);
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

        private bool AsignarMozo()
        {
            try
            {
                if (UC_ValDNI.validar() && UC_ValDNI.Text != "")
                {
                    oBEMozo.DNI = int.Parse(UC_ValDNI.Text);
                    if (UC_ValNomb.validar() && UC_ValNomb.Text != "")
                    {
                        oBEMozo.Nombre = UC_ValNomb.Text;
                        if (UC_ValApe.validar() && UC_ValApe.Text != "")
                        {
                            oBEMozo.Apellido = UC_ValApe.Text;
                            if (UC_ValCod.validar() && UC_ValCod.Text != "")
                            {
                                oBEMozo.Codigo = int.Parse(UC_ValCod.Text);
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

        private string AsignarTurno()
        {
            if (RadioButton_Mañana.Checked)
            {
                return "Mañana";
            }
            else if (RadioButton_Tarde.Checked)
            {
                return "Tarde";
            }
            else
            {
                return "Noche";
            }

        }

        void AsignarCocineroAControles(BECocinero oBECocinero)
        {
            try
            {
                UC_ValApe.Text = oBECocinero.Apellido;
                UC_ValCod.Text = oBECocinero.Codigo.ToString();
                UC_ValNomb.Text = oBECocinero.Nombre;
                UC_ValDNI.Text = oBECocinero.DNI.ToString();
                UC_ValCod.Text = oBECocinero.Codigo.ToString();
                RadioButton_Cocinero.Checked = true;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        void AsignarMozoAControles(BEMozo oBEMozo)
        {
            try
            {
                UC_ValApe.Text = oBEMozo.Apellido;
                UC_ValCod.Text = oBEMozo.Codigo.ToString();
                UC_ValNomb.Text = oBEMozo.Nombre;
                UC_ValDNI.Text = oBEMozo.DNI.ToString();
                UC_ValCod.Text = oBEMozo.Codigo.ToString();
                RadioButton_Mozo.Checked = true;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        void CargarGrillaCocinero()
        {
            try
            {
                Grilla_Cocineros.DataSource = null;
                Grilla_Cocineros.DataSource = oBLCocinero.ListarTodo();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

        }

        void CargarGrillaMozo()
        {
            try
            {
                Grilla_Mozos.DataSource = null;
                Grilla_Mozos.DataSource = oBLMozo.ListarTodo();
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

        private void Grilla_Cocineros_MouseClick(object sender, MouseEventArgs e)
        {
            if (Grilla_Cocineros.DataSource != null)
            {
                oBECocinero = (BECocinero)Grilla_Cocineros.CurrentRow.DataBoundItem;
                AsignarCocineroAControles(oBECocinero);
            }
        }

        private void Grilla_Mozos_MouseClick(object sender, MouseEventArgs e)
        {
            if (Grilla_Mozos.DataSource != null)
            {
                oBEMozo = (BEMozo)Grilla_Mozos.CurrentRow.DataBoundItem;
                AsignarMozoAControles(oBEMozo);
            }
        }
    }
}

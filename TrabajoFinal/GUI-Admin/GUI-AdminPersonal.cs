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


        private void Boton_Alta_Click(object sender, EventArgs e)
         {
            try
            {
                if (RadioButton_Cocinero.Checked)
                {
                    if (AsignarCocinero() == true)
                    {
                        oBECocinero.Codigo = 0;
                        oBLCocinero.Guardar(oBECocinero);
                        AsignarCocineroAControles(oBECocinero);
                        CargarGrillaCocinero();
                    }
                    else
                    { MessageBox.Show("Ingrese los datos de forma correcta"); }

                }
                else
                {
                    if (AsignarMozo() == true)
                    {
                        oBEMozo.Codigo = 0;
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
                    if (AsignarCocinero() == true)
                    {
                        oBLCocinero.Guardar(oBECocinero);
                        AsignarCocineroAControles(oBECocinero);
                        CargarGrillaCocinero();
                    }
                    else
                    { MessageBox.Show("Ingrese los datos de forma correcta"); }

                }
                else
                {
                    if (AsignarMozo() == true)
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
                            if (UC_ValCod.Text != "")
                            {
                                oBECocinero.Codigo = int.Parse(UC_ValCod.Text);
                                return true;
                            }
                            else
                            {
                                oBEMozo.Ranking = 0;
                                oBEMozo.Password = ServiceLogic.Encriptar.Encrypt(textBox_Pass.Text.Trim(), null);
                                return true;
                            }
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
                if (UC_ValCod.validar())
                {
                    oBEMozo.Codigo = int.Parse(UC_ValCod.Text);
                    if (UC_ValNomb.validar())
                    {
                        oBEMozo.Nombre = UC_ValNomb.Text;
                        if (UC_ValApe.validar())
                        {
                            oBEMozo.Apellido = UC_ValApe.Text;
                            if (UC_ValDNI.validar())
                            {
                                oBEMozo.DNI = int.Parse(UC_ValDNI.Text);
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

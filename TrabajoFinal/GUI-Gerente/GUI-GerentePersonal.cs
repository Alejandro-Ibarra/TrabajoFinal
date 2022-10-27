﻿using System;
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
using ServiceLogic;

namespace TrabajoFinal
{
    public partial class GUI_Gerente_Personal : Form
    {
        public GUI_Gerente_Personal()
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
                
                    if (!oBLCocinero.Existe(int.Parse(UC_ValDNI.Text)))
                    {
                        if (AsignarCocinero())
                        {
                            oBECocinero.Turno = AsignarTurno();
                            oBECocinero.CantPedidos = 0;
                            oBECocinero.Password = Encriptacion.Encrypt(textBox_Pass.Text.Trim(), null);
                            oBLCocinero.Guardar(oBECocinero);
                            CargarGrillaCocinero();
                        }
                        else
                        { MessageBox.Show("Ingrese los datos de forma correcta"); }
                    }
                    else
                    { MessageBox.Show("Ya existe un cocinero con ese DNI"); }

                if (AsignarMozo())
                {
                    oBEMozo.Turno = AsignarTurno();
                    oBEMozo.Ranking = 0;
                    oBEMozo.Password = Encriptacion.Encrypt(textBox_Pass.Text.Trim(), null);
                    oBLMozo.Guardar(oBEMozo);
                    AsignarMozoAControles(oBEMozo);
                    CargarGrillaMozo();
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
                    
                        oBLCocinero.Baja(oBECocinero);
                        LimpiarControles();
                        CargarGrillaCocinero();
                    
                        oBLMozo.Baja(oBEMozo);
                        LimpiarControles();
                        CargarGrillaMozo();
                  

                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void Boton_Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                
                    if (AsignarCocinero())
                    {
                        oBLCocinero.Modificar(oBECocinero);
                        AsignarCocineroAControles(oBECocinero);
                        CargarGrillaCocinero();
                    }
                    else
                    { MessageBox.Show("Ingrese los datos de forma correcta"); }

              
                    if (AsignarMozo())
                    {
                        oBLMozo.Modificar(oBEMozo);
                        AsignarMozoAControles(oBEMozo);
                        CargarGrillaMozo();
                    }
                    else
                    { MessageBox.Show("Ingrese los datos de forma correcta"); }
                
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
            
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        void CargarGrillaPermisos(BECocinero Cocinero)
        {
            Grilla_RolesAsignados.DataSource = null;
            BECocinero AuxCocinero = oBLCocinero.ListarObjeto(Cocinero.DNI);

            Grilla_RolesAsignados.DataSource = AuxCocinero.Roles;


        }

        void CargarGrillaCocinero()
        {
            try
            {
                Grilla_Usuarios.DataSource = null;
                Grilla_Usuarios.DataSource = oBLCocinero.ListarTodo();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

        }

        void CargarGrillaMozo()
        {
            try
            {
                Grilla_RolesAsignados.DataSource = null;
                Grilla_RolesAsignados.DataSource = oBLMozo.ListarTodo();
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
            if (Grilla_Usuarios.DataSource != null)
            {
                oBECocinero = (BECocinero)Grilla_Usuarios.CurrentRow.DataBoundItem;
                AsignarCocineroAControles(oBECocinero);
                CargarGrillaPermisos(oBECocinero);
            }
        }

        private void Grilla_Mozos_MouseClick(object sender, MouseEventArgs e)
        {
            if (Grilla_RolesAsignados.DataSource != null)
            {
                oBEMozo = (BEMozo)Grilla_RolesAsignados.CurrentRow.DataBoundItem;
                AsignarMozoAControles(oBEMozo);
            }
        }


    }
}

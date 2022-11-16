﻿using Mapper;
using ServiceEntity;
using ServiceLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinesEntity;
using BussinesLogic;

namespace TrabajoFinal
{
    public partial class GUI_Login : Form
    {
        public GUI_Login()
        {
            InitializeComponent();
            oSELogin = new SELogin();
            oSLLogin = new SLLogin();

            oBECocinero = new BECocinero();
            oBLCocinero = new BLCocinero();
            oBEMozo = new BEMozo();
            oBLMozo = new BLMozo();
            oBEPersonal = new BEAdmin();
            oBLPersonal = new BLPersonal();
        }

        SELogin oSELogin;
        SLLogin oSLLogin;
        BECocinero oBECocinero;
        BLCocinero oBLCocinero;
        BEMozo oBEMozo;
        BLMozo oBLMozo;
        BEPersonal oBEPersonal;
        BLPersonal oBLPersonal;

        

        private void Button_Aceptar_Click(object sender, EventArgs e)
        {
            if (TextBox_DNI.validar() == true)
            {
                BEPersonal oper = RecuperarUsuario(Convert.ToInt32(TextBox_DNI.Text));
                List<string> tipo = RecuperarTipo(Convert.ToInt32(TextBox_DNI.Text));
                oSELogin.DNI = Convert.ToInt32(TextBox_DNI.Text);
                oSELogin.Password = Encriptacion.Encrypt(TextBox_Pass.Text, null);
                oSELogin.Personal = oper;

                if (oSLLogin.VerificarUsuario(oSELogin, tipo) != false)
                {
                    GUI_MenuPrincipal oGUI_MenuPrincipal = new GUI_MenuPrincipal(oper);
                    this.Hide();
                    oGUI_MenuPrincipal.Show();
                }
                else {MessageBox.Show("Usuario o contraseña incorrectos");}
            }
        }

        private void Button_Cancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private BEPersonal RecuperarUsuario(int dni)
        {
            if (oBLCocinero.Existe(dni))
            {
                oBEPersonal = oBLCocinero.ListarObjeto(dni);
            }
            else if (oBLMozo.Existe(dni))
            {
                oBEPersonal = oBLMozo.ListarObjeto(dni);
            }
            else
            {
                oBEPersonal = oBLPersonal.ListarObjeto(dni);
            }
            return oBEPersonal;
        }

        private List<string> RecuperarTipo(int dni)
        {
            string tipos;
            string tipo;
            List<string> list = new List<string>();
            if (oBLCocinero.Existe(dni))
            {
                tipos = "Cocineros";
                tipo = "Cocinero";
            }
            else if (oBLMozo.Existe(dni))
            {
                tipos = "Mozos";
                tipo = "Mozo";
            }
            else
            {
                tipos = "Gerente";
                tipo = "Admin";
            }
            list.Add(tipos);
            list.Add(tipo);
            return list;
        }

    }
}
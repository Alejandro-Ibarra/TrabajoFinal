using Mapper;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TrabajoFinal
{
    public partial class GUI_Login : Form
    {
        public GUI_Login()
        {
            InitializeComponent();
            oSELogin = new SELogin();
            oSLLogin = new SLLogin();
        }
        SELogin oSELogin;
        SLLogin oSLLogin;
        private void Button_Aceptar_Click(object sender, EventArgs e)
        {
            if (RadioButton_Admin.Checked || RadioButton_Cocina.Checked || RadioButton_Mozo.Checked)
            {
                if (TextBox_DNI.validar() == true)
                {
                    oSELogin.DNI = Convert.ToInt32(TextBox_DNI.Text);
                    oSELogin.Password = Encriptacion.Encrypt(TextBox_Pass.Text, null);
                    if (RadioButton_Admin.Checked)
                    {
                        if (oSLLogin.VerificarUsuarioAdmin(oSELogin))
                        {
                            GUI_UsrAdmin oGUI_UsrAdmin = new GUI_UsrAdmin();
                            this.Hide();
                            oGUI_UsrAdmin.Show();
                        }
                        else
                        {
                            MessageBox.Show("No existe un admin con los parametros ingresados");
                        }
                    }
                    else if (RadioButton_Cocina.Checked)
                    {
                        if (oSLLogin.VerificarUsuarioCocinero(oSELogin))
                        {
                            GUI_UsrCocina oGUI_UsrCocina = new GUI_UsrCocina(oSELogin.DNI);
                            this.Hide();
                            oGUI_UsrCocina.Show();
                        }
                        else
                        {
                            MessageBox.Show("No existe un cocinero con los parametros ingresados");
                        }
                    }
                    else if (RadioButton_Mozo.Checked)
                    {
                        if (oSLLogin.VerificarUsuarioMozo(oSELogin))
                        {
                            GUI_UsrMozo oGUI_UsrMozo = new GUI_UsrMozo(oSELogin.DNI);
                            this.Hide();
                            oGUI_UsrMozo.Show();

                        }
                        else
                        {
                            MessageBox.Show("No existe un mozo con los parametros ingresados");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Seleccione el tipo de usuario");
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione el tipo de cuenta");
            }

        }

        private void Button_Cancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}

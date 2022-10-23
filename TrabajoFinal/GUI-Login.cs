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
          
            if (TextBox_DNI.validar() == true)
            {
                oSELogin.DNI = Convert.ToInt32(TextBox_DNI.Text);
                oSELogin.Password = Encriptacion.Encrypt(TextBox_Pass.Text, null);

                if (oSLLogin.VerificarUsuario(oSELogin) != false)
                {
                    GUI_MenuPrincipal oGUI_MenuPrincipal = new GUI_MenuPrincipal();
                    oGUI_MenuPrincipal.dniUsr = oSELogin.DNI;
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

    }
}

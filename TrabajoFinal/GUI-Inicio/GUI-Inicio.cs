using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoFinal
{
    public partial class GUI_Inicio : Form
    {
        public GUI_Inicio()
        {
            InitializeComponent();
        }

        private void Button_Cliente_Click(object sender, EventArgs e)
        {
            GUI_Cliente oGUI_Cliente = new GUI_Cliente();
            this.Hide();
            oGUI_Cliente.Show();
        }

        private void Buton_Restaurante_Click(object sender, EventArgs e)
        {
            GUI_Login oGUI_Login = new GUI_Login();
            this.Hide();
            oGUI_Login.Show();
        }

        private void Pruebas_Click(object sender, EventArgs e)
        {
            GUI_RolesPermisos oGUI_Prueba = new GUI_RolesPermisos();
            this.Hide();
            oGUI_Prueba.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GUI_Gerente_Ingredientes oGUI_Prueba = new GUI_Gerente_Ingredientes();
            this.Hide();
            oGUI_Prueba.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GUI_RolesPermisos oGUI_Prueba = new GUI_RolesPermisos();
            this.Hide();
            oGUI_Prueba.Show();
        }
    }
}

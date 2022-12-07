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
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Button_Cliente_Click(object sender, EventArgs e)
        {
            GUI_Cliente oGUI_Cliente = new GUI_Cliente();
            this.Hide();
            oGUI_Cliente.StartPosition = FormStartPosition.CenterScreen;
            oGUI_Cliente.Show();
        }

        private void Buton_Restaurante_Click(object sender, EventArgs e)
        {
            GUI_Login oGUI_Login = new GUI_Login();
            this.Hide();
            oGUI_Login.StartPosition = FormStartPosition.CenterScreen;
            oGUI_Login.Show();
        }
    }
}

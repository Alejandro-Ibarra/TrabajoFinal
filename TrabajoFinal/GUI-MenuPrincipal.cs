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
    public partial class GUI_MenuPrincipal : Form
    {
        public GUI_MenuPrincipal()
        {
            InitializeComponent();
        }

        private void realizarPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void personalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_Administrar_Personal oGUI_Administrar_Personal = new GUI_Administrar_Personal();
            oGUI_Administrar_Personal.MdiParent = this;
            oGUI_Administrar_Personal.Show();
        }
    }
}

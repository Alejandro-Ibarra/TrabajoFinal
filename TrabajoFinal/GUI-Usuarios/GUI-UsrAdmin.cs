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
    public partial class GUI_UsrAdmin : Form
    {
        public GUI_UsrAdmin()
        {
            InitializeComponent();
        }

        private void BebidasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void IngredientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void PlatosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ExtrasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void EventoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MesasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void TurnosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void PersonalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_Administrar_Personal oGUI_Administrar_Personal = new GUI_Administrar_Personal();
            oGUI_Administrar_Personal.MdiParent = this;
            oGUI_Administrar_Personal.Show();
        }
    }
}

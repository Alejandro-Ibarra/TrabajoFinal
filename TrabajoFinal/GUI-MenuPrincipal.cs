using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServiceEntity;
using BussinesEntity;
using BussinesLogic;

namespace TrabajoFinal
{
    public partial class GUI_MenuPrincipal : Form
    {
        public int dniUsr { get; set; }
        
        public GUI_MenuPrincipal()
        {
            InitializeComponent();
            oBECocinero = new BECocinero();
            oBLCocinero = new BLCocinero();
            oBEMozo = new BEMozo();
            oBLMozo = new BLMozo();
            oBEAdmin = new BEAdmin();
            oBLAdmin = new BLAdmin();
        }

        BECocinero oBECocinero;
        BLCocinero oBLCocinero;
        BEMozo oBEMozo;
        BLMozo oBLMozo;
        BEAdmin oBEAdmin;
        BLAdmin oBLAdmin;

        private void RecuperarUsuario(int dni)
        {
            if (oBLCocinero.Existe(dni))
            {
                oBECocinero = oBLCocinero.ListarObjeto(dni);
                
            }
            else if (oBLMozo.Existe(dni))
            {
                oBEMozo = oBLMozo.ListarObjeto(dni);
            }
            else
            {
                oBEAdmin = oBLAdmin.ListarObjeto(dni);
            }

        }

        private void personalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_Administrar_Personal oGUI_Administrar_Personal = new GUI_Administrar_Personal();
            oGUI_Administrar_Personal.MdiParent = this;
            oGUI_Administrar_Personal.Show();
        }
    }
}

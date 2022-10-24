using BussinesEntity;
using BussinesLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoFinal
{
    public partial class GUI_UsrMozo : Form
    {
        public GUI_UsrMozo(BEMozo Mozo)
        {
            InitializeComponent();
            oBEMozo = Mozo;
            oBLMozo = new BLMozo();
            AsignarAControles(oBEMozo);
        }

        BEMozo oBEMozo;
        BLMozo oBLMozo;

        private void AsignarAControles(BEMozo oBEMozo)
        {
            try
            {
                TextBox_Apellido.Text = oBEMozo.Apellido;
                TextBox_Nombre.Text = oBEMozo.Nombre;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
    }
}

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
    public partial class GUI_UsrMozo : GUI_GerenteMesas
    {
        public GUI_UsrMozo()
        {
            InitializeComponent();
            oBEMozo = new BEMozo();
            oBLMozo = new BLMozo();
            AsignarAControles(oBEMozo);
        }

        BEMozo oBEMozo;
        BLMozo oBLMozo;

        private void AsignarAControles(BEMozo oBEMozo)
        {
            try
            {

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
    }
}

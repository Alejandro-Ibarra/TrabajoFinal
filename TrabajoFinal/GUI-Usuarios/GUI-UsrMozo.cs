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
        public GUI_UsrMozo(int DNI)
        {
            InitializeComponent();
            oBEMozo = new BEMozo();
            oBLMozo = new BLMozo();
            CargarDatosDeMozo(DNI);
        }

        BEMozo oBEMozo;
        BLMozo oBLMozo;

        private void CargarDatosDeMozo(int DNI)
        {
            try
            {
                oBEMozo = RecuperarMozoPorDNI(DNI);
                AsignarAControles(oBEMozo);
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }



        private BEMozo RecuperarMozoPorDNI(int oDNI)
        {
            try
            {
                BEMozo oBEUsrAux;
                oBEMozo.DNI = oDNI;
                oBEUsrAux = oBLMozo.ListarObjeto(oBEMozo);
                oBEUsrAux.DNI = oDNI;
                return oBEUsrAux;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
            return null;
        }

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

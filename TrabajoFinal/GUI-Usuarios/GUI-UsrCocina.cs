using BussinesEntity;
using BussinesLogic;
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
    public partial class GUI_UsrCocina : Form
    {
        public GUI_UsrCocina(int DNI)
        {
            InitializeComponent();
            oBECocinero = new BECocinero();
            oBLCocinero = new BLCocinero();
            CargarDatosDeCocinero(DNI);

        }

        BECocinero oBECocinero;
        BLCocinero oBLCocinero;

        private void CargarDatosDeCocinero(int DNI)
        {
            try
            {
                oBECocinero = RecuperarCocineroPorDNI(DNI);
                AsignarAControles(oBECocinero);

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

        }

        private BECocinero RecuperarCocineroPorDNI(int oDNI)
        {
            try
            {
                BECocinero oBEUsrAux;
                oBECocinero.DNI = oDNI;
                oBEUsrAux = oBLCocinero.ListarObjeto(oBECocinero);
                oBEUsrAux.DNI = oDNI;
                return oBEUsrAux;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
            return null;
        }

        void AsignarAControles(BECocinero oBECocinero)
        {
            try
            {
                oBLCocinero.Guardar(oBECocinero); //BORRAR solo era para evitar warning
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

    }
}

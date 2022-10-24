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
        public GUI_UsrCocina(BECocinero Cocinero)
        {
            InitializeComponent();
            oBECocinero = Cocinero;
            oBLCocinero = new BLCocinero();
            AsignarAControles(oBECocinero);

        }

        BECocinero oBECocinero;
        BLCocinero oBLCocinero;


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

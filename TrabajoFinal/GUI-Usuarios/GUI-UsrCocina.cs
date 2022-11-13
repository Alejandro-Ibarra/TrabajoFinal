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
        public GUI_UsrCocina(BEPersonal Personal)
        {
            InitializeComponent();
            oBEPersonal = Personal;
            oBLCocinero = new BLCocinero();
            AsignarAControles(oBEPersonal);

        }

        BEPersonal oBEPersonal;
        BLCocinero oBLCocinero;


        void AsignarAControles(BEPersonal oBEPerso)
        {
            try
            {
                
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

    }
}

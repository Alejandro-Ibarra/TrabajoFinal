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
    public partial class UC_Mesas : UserControl
    {
        public UC_Mesas()
        {
            InitializeComponent();
            this.BackColor = Color.Ivory;

            cont = 0;

            Label oLabel = new Label();
            oLabel.BackColor = Color.Ivory;

        }

        int cont;

        private void UC_Mesas_ControlAdded(object sender, ControlEventArgs e)
        {
            Label oLabel = new Label();
            oLabel.BackColor = Color.Green;

            try
            {
                foreach (Label oLabelAux in this.Controls.OfType<Label>())
                {
                    cont = cont + 1;
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

            oLabel.Text = "Mesa " + cont.ToString();

        }
    }
}

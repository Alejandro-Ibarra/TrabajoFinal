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
    public partial class GUI_Gerente_Mesas : Form
    {
        public GUI_Gerente_Mesas()
        {
            InitializeComponent();
            cont = 0;
        }
        int cont;

        private void Button_CrearMesa_Click(object sender, EventArgs e)
        {
            Button Btn = new Button();

            foreach (Button oBtnAux in this.Controls.OfType<Button>())
            {
                cont = cont + 1;
            }
            Btn.Size = new Size(65, 50);
            Btn.Text = "Mesa " + (cont - 1).ToString();
            Btn.Name = "Mesa " + (cont - 1).ToString();
            Btn.Location = new Point(152, 6);
            cont = 0;

        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinesEntity;
using Abstraction;

namespace TrabajoFinal
{
    public partial class GUI_Cliente : Form
    {
        public GUI_Cliente()
        {
            InitializeComponent();
            ListaPlatosPrincipales = new List<BEPlato>();
        }

        int MontoTotal = 0;
        public List<BEPlato> ListaPlatosPrincipales;

        private void Boton_Entrada_Click(object sender, EventArgs e)
        {
            using (var form = new GUI_SeleccionPlatos("Entrada"))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    List<BEPlato> Platos = form.listaPlatosFinal;    
                    
                    ListaPlatosPrincipales.AddRange(Platos);
                }
            }

            dataGridView1.DataSource = ListaPlatosPrincipales.Select(o => new
            { Nombre = o.Nombre, Precio = o.Precio }).ToList();

            CalcularTotal(ListaPlatosPrincipales);
            textBox1.Text = "$" + MontoTotal.ToString();

        }

        private void Boton_PlatoPrincipal_Click(object sender, EventArgs e)
        {
            using (var form = new GUI_SeleccionPlatos("Principal"))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    List<BEPlato> Platos = form.listaPlatosFinal;

                    ListaPlatosPrincipales.AddRange(Platos);
                }
            }

            dataGridView1.DataSource = ListaPlatosPrincipales.Select(o => new
            { Nombre = o.Nombre, Precio = o.Precio }).ToList();

            CalcularTotal(ListaPlatosPrincipales);
            textBox1.Text = "$" + MontoTotal.ToString();
        }

        private void Boton_Postre_Click(object sender, EventArgs e)
        {
            using (var form = new GUI_SeleccionPlatos("Postre"))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    List<BEPlato> Platos = form.listaPlatosFinal;

                    ListaPlatosPrincipales.AddRange(Platos);
                }
            }

            dataGridView1.DataSource = ListaPlatosPrincipales.Select(o => new
            { Nombre = o.Nombre, Precio = o.Precio }).ToList();

            CalcularTotal(ListaPlatosPrincipales);
            textBox1.Text = "$" + MontoTotal.ToString();
        }

        private void Boton_Extras_Click(object sender, EventArgs e)
        {

        }

        private void Boton_Bebidas_Click(object sender, EventArgs e)
        {

        }

        private void Boton_Pagar_Click(object sender, EventArgs e)
        {

        }

        private void CalcularTotal(List<BEPlato> platos)
        {
            int aux = 0;
            foreach (BEPlato plato in platos)
            {
                aux = plato.Precio + aux;
            }
            MontoTotal = aux;
        }
    }
}

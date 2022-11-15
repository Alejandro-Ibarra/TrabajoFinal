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
            ListaExtras = new List<BEExtras>();
            listNombrePrecio = new List<NombrePrecio>();
            
            
        }

        int MontoTotal = 0;
        public List<BEPlato> ListaPlatosPrincipales;
        public List<BEExtras> ListaExtras;
        List<NombrePrecio> listNombrePrecio;
        
        

        private void Boton_Entrada_Click(object sender, EventArgs e)
        {
            AbrirMenuPlato("Entrada");
        }

        private void Boton_PlatoPrincipal_Click(object sender, EventArgs e)
        {
            AbrirMenuPlato("Principal");
        }

        private void Boton_Postre_Click(object sender, EventArgs e)
        {
            AbrirMenuPlato("Postre");
        }

        private void Boton_Extras_Click(object sender, EventArgs e)
        {
            using (var form = new GUI_SeleccionExtras())
            {
                List<NombrePrecio> listNPAux = new List<NombrePrecio>();
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    List<BEExtras> Extras = form.listaExtrasFinal;
                    foreach (BEExtras item in Extras)
                    {
                        NombrePrecio nombPre = new NombrePrecio();
                        nombPre.nombre = item.Nombre;

                        listNPAux.Add(nombPre);
                    }

                    listNombrePrecio.AddRange(listNPAux);
                }
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listNombrePrecio;
        }

        private void Boton_Bebidas_Click(object sender, EventArgs e)
        {
            using (var form = new GUI_SeleccionBebidas())
            {
                List<NombrePrecio> listNPAux = new List<NombrePrecio>();
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    List<BEBebida> Extras = form.listaBebidasFinal;
                    foreach (BEBebida item in Extras)
                    {
                        NombrePrecio nombPre = new NombrePrecio();
                        nombPre.nombre = item.Nombre;
                        nombPre.precio = item.Precio;
                        listNPAux.Add(nombPre);
                    }

                    listNombrePrecio.AddRange(listNPAux);
                }
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listNombrePrecio;

            CalcularTotal(listNombrePrecio);
            textBox1.Text = "$" + MontoTotal.ToString();
        }

        private void Boton_Pagar_Click(object sender, EventArgs e)
        {

        }

        private void AbrirMenuPlato(string tipo)
        {
            using (var form = new GUI_SeleccionPlatos(tipo))
            {
                List<NombrePrecio> listNPAux = new List<NombrePrecio>();
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    List<BEPlato> Platos = form.listaPlatosFinal;
                    foreach (BEPlato item in Platos)
                    {
                        NombrePrecio nombPre = new NombrePrecio();
                        nombPre.nombre = item.Nombre;
                        nombPre.precio = item.Precio;

                        listNPAux.Add(nombPre);
                    }

                    listNombrePrecio.AddRange(listNPAux);
                }
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listNombrePrecio;

            CalcularTotal(listNombrePrecio);
            textBox1.Text = "$" + MontoTotal.ToString();
        }

        private void CalcularTotal(List<NombrePrecio> NP)
        {
            int aux = 0;
            foreach (NombrePrecio precio in NP)
            {
                aux = precio.precio + aux;
            }
            MontoTotal = aux;
        }
    }

    public class NombrePrecio
    {
        public string nombre { get; set; }
        public int precio { get; set; }

        public NombrePrecio()
        {
        }
    }
}

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
using BussinesLogic;
using Microsoft.VisualBasic;

namespace TrabajoFinal
{
    public partial class GUI_Cliente : Form
    {
        public GUI_Cliente()
        {
            InitializeComponent();

            MontoTotal = 0;
            nroMesa = CalcularNroMesa();
            listNombrePrecio = new List<NombrePrecio>();
            oBLComanda = new BLComanda();
            oBEComanda = new BEComanda();
            cargarTextbox();
            CargarComandaPrincipal();


        }

        int MontoTotal;
        int nroMesa;
        List<NombrePrecio> listNombrePrecio;
        BLComanda oBLComanda;
        BEComanda oBEComanda;



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
                int codPedido = oBLComanda.GenerarCodigoPedido(oBEComanda.Codigo);
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    List<BEExtras> Extras = form.listaExtrasFinal;
                    foreach (BEExtras item in Extras)
                    {
                        NombrePrecio nombPre = new NombrePrecio();
                        nombPre.Nombre = item.Nombre;
                        nombPre.CodigoComanda = codPedido;
                        listNPAux.Add(nombPre);
                    }
                    CargarComandaMozo(Extras, null, 0, codPedido);
                    listNombrePrecio.AddRange(listNPAux);
                }
            }
            Grilla_PedidosCliente.DataSource = null;
            Grilla_PedidosCliente.DataSource = listNombrePrecio;
        }

        private void Boton_Bebidas_Click(object sender, EventArgs e)
        {
            using (var form = new GUI_SeleccionBebidas())
            {
                int montoComanda = 0;
                List<NombrePrecio> listNPAux = new List<NombrePrecio>();
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    List<BEBebida> Bebidas = form.listaBebidasFinal;
                    int codPedido = oBLComanda.GenerarCodigoPedido(oBEComanda.Codigo);
                    foreach (BEBebida item in Bebidas)
                    {
                        NombrePrecio nombPre = new NombrePrecio();
                        nombPre.Nombre = item.Nombre;
                        nombPre.Precio = item.Precio;
                        nombPre.CodigoComanda = codPedido;
                        listNPAux.Add(nombPre);
                        montoComanda = montoComanda + nombPre.Precio;
                    }
                    CargarComandaMozo(null, Bebidas, montoComanda, codPedido);
                    listNombrePrecio.AddRange(listNPAux);
                }
            }
            Grilla_PedidosCliente.DataSource = null;
            Grilla_PedidosCliente.DataSource = listNombrePrecio;

            CalcularTotal(listNombrePrecio);
            textBox1.Text = "$" + MontoTotal.ToString();
        }

        private void Boton_Pagar_Click(object sender, EventArgs e)
        {

        }

        private void Boton_Aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = TextBox_NombreGrilla.Text;
                int codigo = Convert.ToInt32(TextBox_CodigoGrilla.Text);
                oBLComanda.GestionarPlato(nombre, codigo, "Aceptar");

            }
            catch (Exception)
            {throw;}
        }

        private void Boton_Rechazar_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception)
            { throw; }
        }

        private void Boton_Cancelar_Click(object sender, EventArgs e)
        {

        }

        private void Grilla_PedidosCliente_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (Grilla_PedidosCliente.CurrentRow.DataBoundItem != null)
                {
                    NombrePrecio Seleccion = (NombrePrecio)Grilla_PedidosCliente.CurrentRow.DataBoundItem;
                    TextBox_CodigoGrilla.Text = Seleccion.Nombre;
                    TextBox_CodigoGrilla.Text = Seleccion.CodigoComanda.ToString();
                }
                

            }
            catch (Exception)
            {throw;}
        }


        private void AbrirMenuPlato(string tipo)
        {
            using (var form = new GUI_SeleccionPlatos(tipo))
            {
                int montoComanda = 0;
                List<NombrePrecio> listNPAux = new List<NombrePrecio>();
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    List<BEPlato> Platos = form.listaPlatosFinal;
                    int codPedido = oBLComanda.GenerarCodigoPedido(oBEComanda.Codigo);
                    foreach (BEPlato item in Platos)
                    {
                        NombrePrecio nombPre = new NombrePrecio();
                        nombPre.Nombre = item.Nombre;
                        nombPre.Precio = item.Precio;
                        nombPre.CodigoComanda = codPedido;
                        montoComanda = montoComanda + nombPre.Precio;
                        listNPAux.Add(nombPre);
                    }
                    
                    CargarComandaCocinero(Platos, montoComanda, codPedido);
                    listNombrePrecio.AddRange(listNPAux);
                }
            }
            Grilla_PedidosCliente.DataSource = null;
            Grilla_PedidosCliente.DataSource = listNombrePrecio;

            CalcularTotal(listNombrePrecio);
            textBox1.Text = "$" + MontoTotal.ToString();
        }

        private void CalcularTotal(List<NombrePrecio> NP)
        {
            int aux = 0;
            foreach (NombrePrecio precio in NP)
            {
                aux = precio.Precio + aux;
            }
            MontoTotal = aux;
        }

        private void CargarComandaCocinero(List<BEPlato> platos, int montoComanda, int codPedido)
        {
            BEComandaCocina oBEComandaCocina = new BEComandaCocina();
            oBEComandaCocina.Codigo = codPedido;
            oBEComandaCocina.Estado = "Enviado_Cocina";
            oBEComandaCocina.MontoTotal = montoComanda;
            oBEComandaCocina.NroMesa = nroMesa;
            oBEComandaCocina.FechaHora = DateTime.Now;
            oBEComandaCocina.oBEPlato = platos;
            oBEComanda.comandas.Add(oBEComandaCocina);
            oBLComanda.Guardar(oBEComanda);
        }

        private void CargarComandaMozo( List<BEExtras> extras, List<BEBebida> bebidas, int montoComanda, int codPedido)
        {
            BEComandaMozo oBEComandaMozo = new BEComandaMozo();

            oBEComandaMozo.Codigo = codPedido;
            oBEComandaMozo.Estado = "Enviado_Mozo";
            oBEComandaMozo.MontoTotal = montoComanda;
            oBEComandaMozo.NroMesa = nroMesa;
            oBEComandaMozo.FechaHora = DateTime.Now;    
            if (extras != null)
            {
                oBEComandaMozo.extras = extras;
            }
            else
            {
                oBEComandaMozo.bebidas = bebidas;
            }
            oBEComanda.comandas.Add(oBEComandaMozo);
            oBLComanda.Guardar(oBEComanda);
        }

        private int CalcularNroMesa()
        {
            Random rand = new Random();
            int number = rand.Next(0, 30);
            return number;
        }

        private void CargarComandaPrincipal()
        {
            BECliente oBECliente = new BECliente();
            oBECliente.Nombre = TextBox_Nombre.Text;
            oBECliente.EMail = TextBox_Mail.Text;

            oBEComanda.Codigo = oBLComanda.GenerarCodigo();
            oBEComanda.Cliente = oBECliente;

            oBLComanda.Guardar(oBEComanda);

        }
        private void cargarTextbox()
        {
            TextBox_Nombre.Text = Interaction.InputBox("Ingrese su nombre");
            TextBox_Mail.Text = Interaction.InputBox("Ingrese su mail");
        }


    }

    public class NombrePrecio
    {
        public int CodigoComanda { get; set; }
        public string Nombre { get; set; }
        public int Precio { get; set; }
        public string Estado { get; set; }

        public NombrePrecio()
        {
        }
    }
}

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
            nroPedido = 0;
            MontoTotal = 0;
            nroMesa = CalcularNroMesa();
            listNombrePrecio = new List<ItemsSeleccionados>();
            oBLComanda = new BLComanda();
            oBEComanda = new BEComanda();
            item = new ItemsSeleccionados();
            cargarTextbox();
            CargarComandaPrincipal();


        }

        int MontoTotal;
        int nroMesa;
        int nroPedido;
        ItemsSeleccionados item;
        List<ItemsSeleccionados> listNombrePrecio;
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
                
                int codItem = 1;
                List<ItemsSeleccionados> listNPAux = new List<ItemsSeleccionados>();
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    List<BEExtras> Extras = form.listaExtrasFinal;
                    nroPedido = nroPedido + 1;
                    foreach (BEExtras ext in Extras)
                    {
                        ItemsSeleccionados nombPre = new ItemsSeleccionados();
                        nombPre.Nombre = ext.Nombre;
                        nombPre.CodigoComanda = oBEComanda.Codigo;
                        nombPre.codigoPedido = nroPedido;
                        nombPre.CodigoItem = codItem;
                        ext.CodigoItem = codItem;
                        ext.CodigoPedido = nroPedido;
                        ext.CodigoComanda = oBEComanda.Codigo;
                        codItem += 1;

                        listNPAux.Add(nombPre);
                    }
                    CargarComandaMozo(Extras, null, 0, nroPedido);
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
                int montoComanda = 1;
                int codItem = 1;
                List<ItemsSeleccionados> listNPAux = new List<ItemsSeleccionados>();
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    List<BEBebida> Bebidas = form.listaBebidasFinal;
                    nroPedido = nroPedido + 1;
                    foreach (BEBebida item in Bebidas)
                    {
                        ItemsSeleccionados nombPre = new ItemsSeleccionados();
                        nombPre.Nombre = item.Nombre;
                        nombPre.Precio = item.Precio;
                        nombPre.CodigoComanda = oBEComanda.Codigo;
                        nombPre.codigoPedido = nroPedido;
                        nombPre.CodigoItem = codItem;
                        item.CodigoItem = codItem;
                        item.CodigoPedido = nroPedido;
                        item.CodigoComanda = oBEComanda.Codigo;
                        codItem += 1;

                        listNPAux.Add(nombPre);
                        montoComanda = montoComanda + nombPre.Precio;
                    }
                    CargarComandaMozo(null, Bebidas, montoComanda, nroPedido);
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
                item.Estado = "Aceptado";
                oBLComanda.GestionarPlato(item);

            }
            catch (Exception)
            {throw;}
        }

        private void Boton_Rechazar_Click(object sender, EventArgs e)
        {
            try
            {
                item.Estado = "Rechazado";
                oBLComanda.GestionarPlato(item);
            }
            catch (Exception)
            { throw; }
        }

        private void Boton_Cancelar_Click(object sender, EventArgs e)
        {
            item.Estado = "Cancelado";
            oBLComanda.GestionarPlato(item);
        }

        private void Grilla_PedidosCliente_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (Grilla_PedidosCliente.CurrentRow.DataBoundItem != null)
                {
                    item = (ItemsSeleccionados)Grilla_PedidosCliente.CurrentRow.DataBoundItem;
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
                int codItem = 1;
                List<ItemsSeleccionados> listNPAux = new List<ItemsSeleccionados>();
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    List<BEPlato> Platos = form.listaPlatosFinal;
                    nroPedido = nroPedido + 1;
                    foreach (BEPlato item in Platos)
                    {
                        ItemsSeleccionados nombPre = new ItemsSeleccionados();
                        nombPre.Nombre = item.Nombre;
                        nombPre.Precio = item.Precio;
                        nombPre.CodigoComanda = oBEComanda.Codigo;
                        nombPre.codigoPedido = nroPedido;
                        nombPre.CodigoItem = codItem;
                        item.CodigoItem = codItem;
                        item.CodigoPedido = nroPedido;
                        item.CodigoComanda = oBEComanda.Codigo;
                        montoComanda = montoComanda + nombPre.Precio;
                        
                        codItem += 1;

                        listNPAux.Add(nombPre);
                    }
                    
                    CargarComandaCocinero(Platos, montoComanda, nroPedido);
                    listNombrePrecio.AddRange(listNPAux);
                }
            }
            Grilla_PedidosCliente.DataSource = null;
            Grilla_PedidosCliente.DataSource = listNombrePrecio;

            CalcularTotal(listNombrePrecio);
            textBox1.Text = "$" + MontoTotal.ToString();
        }

        private void CalcularTotal(List<ItemsSeleccionados> NP)
        {
            int aux = 0;
            foreach (ItemsSeleccionados precio in NP)
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
            oBEComandaCocina.Plato = platos;
            oBEComanda.Comandas.Add(oBEComandaCocina);
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
            oBEComanda.Comandas.Add(oBEComandaMozo);
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
    /*
    public class ItemsSeleccionados
    {
        public int CodigoComanda { get; set; }
        public int codigoPedido { get; set; }
        public int CodigoItem { get; set; }
        public string Nombre { get; set; }
        public int Precio { get; set; }
        public string Estado { get; set; }

        public ItemsSeleccionados()
        {
        }
    }*/
}

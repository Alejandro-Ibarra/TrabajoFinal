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
            listNombrePrecio = new List<BEItemsSeleccionados>();
            oBLComanda = new BLComanda();
            oBEComanda = new BEComanda();
            item = new BEItemsSeleccionados();
            cargarTextbox();
            CargarComandaPrincipal();


        }

        int MontoTotal;
        int nroMesa;
        int nroPedido;
        BEItemsSeleccionados item;
        List<BEItemsSeleccionados> listNombrePrecio;
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
            try
            {
                using (var form = new GUI_SeleccionExtras())
                {
                    int codItem = 1;
                    List<BEItemsSeleccionados> listNPAux = new List<BEItemsSeleccionados>();
                    var result = form.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        List<BEExtras> Extras = form.listaExtrasFinal;
                        nroPedido = nroPedido + 1;
                        foreach (BEExtras ext in Extras)
                        {
                            BEItemsSeleccionados nombPre = new BEItemsSeleccionados();
                            nombPre.Nombre = ext.Nombre;
                            nombPre.CodigoComanda = oBEComanda.Codigo;
                            nombPre.CodigoPedido = nroPedido;
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
            catch (Exception ex)
            { MessageBox.Show(ex.Message);}
        }

        private void Boton_Bebidas_Click(object sender, EventArgs e)
        {
            try
            {
                using (var form = new GUI_SeleccionBebidas())
                {
                    int montoComanda = 1;
                    int codItem = 1;
                    List<BEItemsSeleccionados> listNPAux = new List<BEItemsSeleccionados>();
                    var result = form.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        List<BEBebida> Bebidas = form.listaBebidasFinal;
                        nroPedido = nroPedido + 1;
                        foreach (BEBebida item in Bebidas)
                        {
                            BEItemsSeleccionados nombPre = new BEItemsSeleccionados();
                            nombPre.Nombre = item.Nombre;
                            nombPre.Precio = item.Precio;
                            nombPre.CodigoComanda = oBEComanda.Codigo;
                            nombPre.CodigoPedido = nroPedido;
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
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
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
            try
            {
                item.Estado = "Cancelado";
                oBLComanda.GestionarPlato(item);
            }
            catch (Exception)
            { throw; }
        }

        private void Grilla_PedidosCliente_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (Grilla_PedidosCliente.CurrentRow.DataBoundItem != null)
                {
                    item = (BEItemsSeleccionados)Grilla_PedidosCliente.CurrentRow.DataBoundItem;
                }
            }
            catch (Exception)
            {throw;}
        }


        private void AbrirMenuPlato(string tipo)
        {
            try
            {
                using (var form = new GUI_SeleccionPlatos(tipo))
                {
                    int montoComanda = 0;
                    int codItem = 1;
                    List<BEItemsSeleccionados> listNPAux = new List<BEItemsSeleccionados>();
                    var result = form.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        List<BEPlato> Platos = form.listaPlatosFinal;
                        nroPedido = nroPedido + 1;
                        foreach (BEPlato item in Platos)
                        {
                            BEItemsSeleccionados nombPre = new BEItemsSeleccionados();
                            nombPre.Nombre = item.Nombre;
                            nombPre.Precio = item.Precio;
                            nombPre.CodigoComanda = oBEComanda.Codigo;
                            nombPre.CodigoPedido = nroPedido;
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
            catch (Exception)
            { throw; }
        }

        private void CalcularTotal(List<BEItemsSeleccionados> NP)
        {
            try
            {
                int aux = 0;
                foreach (BEItemsSeleccionados precio in NP)
                {
                    aux = precio.Precio + aux;
                }
                MontoTotal = aux;
            }
            catch (Exception)
            { throw; }
        }

        private void CargarComandaCocinero(List<BEPlato> platos, int montoComanda, int codPedido)
        {
            try
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
            catch (Exception)
            { throw; }
        }

        private void CargarComandaMozo( List<BEExtras> extras, List<BEBebida> bebidas, int montoComanda, int codPedido)
        {
            try
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
            catch (Exception)
            { throw; }
        }

        private int CalcularNroMesa()
        {
            try
            {
                Random rand = new Random();
                int number = rand.Next(0, 18);
                return number;
            }
            catch (Exception)
            { throw; }
        }

        private void CargarComandaPrincipal()
        {
            try
            {
                BECliente oBECliente = new BECliente();
                oBECliente.Nombre = TextBox_Nombre.Text;
                oBECliente.EMail = TextBox_Mail.Text;

                oBEComanda.Codigo = oBLComanda.GenerarCodigo();
                oBEComanda.Cliente = oBECliente;

                oBLComanda.Guardar(oBEComanda);
            }
            catch (Exception)
            { throw; }
        }
        private void cargarTextbox()
        {
            try
            {
                TextBox_Nombre.Text = Interaction.InputBox("Ingrese su nombre");
                TextBox_Mail.Text = Interaction.InputBox("Ingrese su mail");
            }
            catch (Exception)
            { throw; }
        }
    }
}

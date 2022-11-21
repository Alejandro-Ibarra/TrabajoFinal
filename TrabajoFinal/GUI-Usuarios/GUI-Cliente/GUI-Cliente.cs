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
            listaItemsSeleccionados = new List<BEItemsSeleccionados>();
            oBLComanda = new BLComanda();
            oBEComanda = new BEComanda();
            oBLPlato = new BLPlato();
            oBLBebida = new BLBebida();
            oBLExtras = new BLExtras();
            item = new BEItemsSeleccionados();
            cargarTextbox();
            CargarComandaPrincipal();


        }

        int MontoTotal;
        int nroMesa;
        int nroPedido;
        BEItemsSeleccionados item;
        List<BEItemsSeleccionados> listaItemsSeleccionados;
        BLComanda oBLComanda;
        BEComanda oBEComanda;
        BLPlato oBLPlato;
        BLBebida oBLBebida;
        BLExtras oBLExtras;

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
                            nombPre.Estado = "Enviado_Mozo";
                            ext.CodigoItem = codItem;
                            ext.CodigoPedido = nroPedido;
                            ext.CodigoComanda = oBEComanda.Codigo;
                            codItem += 1;

                            listNPAux.Add(nombPre);
                        }
                        CargarComandaMozo(Extras, null, 0, nroPedido);
                        listaItemsSeleccionados.AddRange(listNPAux);
                    }
                }
                CargarGrilla();
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
                            nombPre.Estado = "Enviado_Mozo";
                            item.CodigoItem = codItem;
                            item.CodigoPedido = nroPedido;
                            item.CodigoComanda = oBEComanda.Codigo;
                            codItem += 1;

                            listNPAux.Add(nombPre);
                            montoComanda = montoComanda + nombPre.Precio;
                        }
                        CargarComandaMozo(null, Bebidas, montoComanda, nroPedido);
                        listaItemsSeleccionados.AddRange(listNPAux);
                    }
                }
                CargarGrilla();

                CalcularTotal(listaItemsSeleccionados);
                textBox1.Text = "$" + MontoTotal.ToString();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
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
                            nombPre.Estado = "Enviado_Cocina";
                            item.CodigoItem = codItem;
                            item.CodigoPedido = nroPedido;
                            item.CodigoComanda = oBEComanda.Codigo;
                            montoComanda = montoComanda + nombPre.Precio;

                            codItem += 1;

                            listNPAux.Add(nombPre);
                        }

                        CargarComandaCocinero(Platos, montoComanda, nroPedido);
                        listaItemsSeleccionados.AddRange(listNPAux);
                    }
                }
                CargarGrilla();

                CalcularTotal(listaItemsSeleccionados);
                textBox1.Text = "$" + MontoTotal.ToString();
            }
            catch (Exception)
            { throw; }
        }

        private void Boton_Pagar_Click(object sender, EventArgs e)
        {
            int aux = 0;

            List<string> listaEstados = new List<string>();
            foreach (DataGridViewRow row in Grilla_PedidosCliente.Rows)
            {
                
                listaEstados.Add(row.Cells[1].Value.ToString());
            }

            foreach (string est in listaEstados)
            {
                if (est == "Enviado_Cocina" || est == "Enviado_Mozo" || est == "Rechazado_Mozo" || est == "En_Preparacion_Mozo" || est == "En_Preparacion_Cocinero" || est == "Entregado" || est == "En_Entrega_Mozo" || est == "En_Entrega_Cocinero")
                {
                    aux = aux + 1;
                }
            }
            if (aux > 0)
            {
                MessageBox.Show("No se puede realizar la operación, todavia hay pedidos en curso");
            }
            else
            {
                DialogResult Respuesta;
                Respuesta = MessageBox.Show("¿Quiere continuar con el pago?", "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (Respuesta == DialogResult.Yes)
                {

                    oBEComanda.Estado = "Pagado";
                    oBLComanda.Modificar(oBEComanda);

                    MessageBox.Show("Se ha realizado el pago. Esperamos que haya disfrutado la velada");
                    Application.Exit();
                }
            }
        }

        private void Boton_Aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                item.Estado = "Aceptado";
                oBLComanda.GestionarPlato(item);
                ActualizarListaitems(item);
                CargarGrilla();
            }
            catch (Exception)
            {throw;}
        }

        private void Boton_Rechazar_Click(object sender, EventArgs e)
        {
            try
            {
                List<BEItemsSeleccionados> listNPAux = new List<BEItemsSeleccionados>();
                if (item.Estado == "Entregado")
                {
                    item.Estado = "Rechazado";
                    string tipoItem = RecuperarTipoItem(item.Nombre);

                    nroPedido = nroPedido + 1;

                    BEItemsSeleccionados nombPre = new BEItemsSeleccionados();
                    nombPre.Nombre = item.Nombre;
                    nombPre.CodigoComanda = oBEComanda.Codigo;
                    nombPre.CodigoPedido = nroPedido;
                    nombPre.CodigoItem = 1;
                    nombPre.Estado = "Enviado_Mozo";

                    if (tipoItem == "Plato")
                    {
                        List<BEPlato> lplat = new List<BEPlato>();
                        BEPlato oBEPlato = new BEPlato();
                        oBEPlato.Nombre = nombPre.Nombre;
                        oBEPlato.CodigoComanda = nombPre.CodigoComanda;
                        oBEPlato.CodigoItem = nombPre.CodigoItem;
                        oBEPlato.CodigoPedido = nombPre.CodigoPedido;

                        lplat.Add(oBEPlato);
                        CargarComandaCocinero(lplat, 0, nroPedido);
                        

                    }
                    else if (tipoItem == "Bebida")
                    {
                        List<BEBebida> listBebida = new List<BEBebida>();
                        BEBebida oBEBebida = new BEBebida();
                        oBEBebida.Nombre = nombPre.Nombre;
                        oBEBebida.CodigoComanda = nombPre.CodigoComanda;
                        oBEBebida.CodigoItem = nombPre.CodigoItem;
                        oBEBebida.CodigoPedido = nombPre.CodigoPedido;

                        listBebida.Add(oBEBebida);
                        CargarComandaMozo(null, listBebida, 0, nroPedido);
                    }
                    else
                    {
                        List<BEExtras> listExt = new List<BEExtras>();
                        BEExtras oBEExt = new BEExtras();
                        oBEExt.Nombre = nombPre.Nombre;
                        oBEExt.CodigoComanda = nombPre.CodigoComanda;
                        oBEExt.CodigoItem = nombPre.CodigoItem;
                        oBEExt.CodigoPedido = nombPre.CodigoPedido;

                        listExt.Add(oBEExt);

                        CargarComandaMozo(listExt, null, 0, nroPedido);
                    }

                    listNPAux.Add(nombPre);
                    listaItemsSeleccionados.AddRange(listNPAux);

                    oBLComanda.GestionarPlato(item);
                    ActualizarListaitems(item);
                    CargarGrilla();
                }
                else
                {MessageBox.Show("Solo se pueden rechazar platos entregados"); }
                
            }
            catch (Exception)
            { throw; }
        }

        private void RecuperarUsuario()
        {
            string nombre = TextBox_Nombre.Text;
            string mail = TextBox_Mail.Text;

            List<BEComanda> listComandas = oBLComanda.ListarTodo();

            foreach (BEComanda coma in listComandas)
            {
                if (coma.Cliente.Nombre == nombre && coma.Cliente.EMail == mail && coma.Estado != "Pagado")
                {
                    oBEComanda = coma;
                    oBEComanda = oBLComanda.ListarObjeto(oBEComanda.Codigo);
                }
            }

        }

        private void RecuperarPLatos()
        {

        }

        private void RecuperarBebidas()
        {

        }

        private void RecuperarExtras()
        {

        }

        private string RecuperarTipoItem(string nombre)
        {
            string aux;
            List<BEPlato> platos = oBLPlato.ListarTodo();
            foreach (BEPlato plat in platos)
            {
                if (plat.Nombre == nombre)
                {
                    aux = "Plato";
                    return aux;
                }
            }
            List<BEBebida> bebidas = oBLBebida.ListarTodo();
            foreach (BEBebida Beb in bebidas)
            {
                if (Beb.Nombre == nombre)
                {
                    aux = "Bebida";
                    return aux;
                }
            }
            List<BEExtras> extras = oBLExtras.ListarTodo();
            foreach (BEExtras ext in extras)
            {
                if (ext.Nombre == nombre)
                {
                    aux = "Extra";
                    return aux;
                }
            }
            return null;
        }


        private void ActualizarListaitems(BEItemsSeleccionados itemSelec)
        {
            foreach (BEItemsSeleccionados item in listaItemsSeleccionados)
            {
                if (item.CodigoComanda == itemSelec.CodigoComanda && item.CodigoPedido == itemSelec.CodigoPedido && item.CodigoItem == itemSelec.CodigoItem )
                {
                    item.Estado = itemSelec.Estado;
                }
            }
        }

        private void Boton_Cancelar_Click(object sender, EventArgs e)
        {
            try
            {
                item.Estado = "Cancelado";
                oBLComanda.GestionarPlato(item);
                CargarGrilla();
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

        private void CargarGrilla()
        {
            Grilla_PedidosCliente.DataSource = null;
            Grilla_PedidosCliente.DataSource = listaItemsSeleccionados;
        }

        private void cargarTextbox()
        {
            try
            {
                TextBox_Nombre.Text = Interaction.InputBox("Ingrese su nombre");
                TextBox_Mail.Text = Interaction.InputBox("Ingrese su mail");
                RecuperarUsuario();
            }
            catch (Exception)
            { throw; }
        }

    }
}

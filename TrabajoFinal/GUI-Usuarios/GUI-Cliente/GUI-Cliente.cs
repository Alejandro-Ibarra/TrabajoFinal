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
using System.Text.RegularExpressions;

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
            CargarTextbox();
            RecONuev();


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

        private void GUI_Cliente_Load(object sender, EventArgs e)
        {
            Grilla_PedidosCliente.MultiSelect = false;
            Grilla_PedidosCliente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

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
                    form.StartPosition = FormStartPosition.CenterScreen;
                    var result = form.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        List<BEExtras> Extras = form.listaExtrasFinal;
                        nroPedido++;
                        foreach (BEExtras ext in Extras)
                        {
                            BEItemsSeleccionados nombPre = new BEItemsSeleccionados
                            {
                                Nombre = ext.Nombre,
                                CodigoComanda = oBEComanda.Codigo,
                                CodigoPedido = nroPedido,
                                CodigoItem = codItem,
                                Estado = "Enviado_Mozo"

                            };
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
                    form.StartPosition = FormStartPosition.CenterScreen;
                    var result = form.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        List<BEBebida> Bebidas = form.listaBebidasFinal;
                        nroPedido++;
                        foreach (BEBebida item in Bebidas)
                        {
                            BEItemsSeleccionados nombPre = new BEItemsSeleccionados
                            {
                                Nombre = item.Nombre,
                                Precio = item.Precio,
                                CodigoComanda = oBEComanda.Codigo,
                                CodigoPedido = nroPedido,
                                CodigoItem = codItem,
                                Estado = "Enviado_Mozo"
                            };
                            item.CodigoItem = codItem;
                            item.CodigoPedido = nroPedido;
                            item.CodigoComanda = oBEComanda.Codigo;
                            codItem += 1;

                            listNPAux.Add(nombPre);
                            montoComanda += nombPre.Precio;
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
                    form.StartPosition = FormStartPosition.CenterScreen;
                    var result = form.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        List<BEPlato> Platos = form.listaPlatosFinal;
                        nroPedido++;
                        foreach (BEPlato item in Platos)
                        {
                            BEItemsSeleccionados nombPre = new BEItemsSeleccionados
                            {
                                Nombre = item.Nombre,
                                Precio = item.Precio,
                                CodigoComanda = oBEComanda.Codigo,
                                CodigoPedido = nroPedido,
                                CodigoItem = codItem,
                                Estado = "Enviado_Cocina",
                                
                            };
                            item.CodigoItem = codItem;
                            item.CodigoPedido = nroPedido;
                            item.CodigoComanda = oBEComanda.Codigo;
                            montoComanda += nombPre.Precio;

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
                    aux++;
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

                    nroPedido++;

                    BEItemsSeleccionados nombPre = new BEItemsSeleccionados
                    {
                        Nombre = item.Nombre,
                        CodigoComanda = oBEComanda.Codigo,
                        CodigoPedido = nroPedido,
                        CodigoItem = 1,
                        Estado = "Enviado_Mozo"
                    };

                    if (tipoItem == "Plato")
                    {
                        List<BEPlato> lplat = new List<BEPlato>();
                        BEPlato oBEPlato = new BEPlato
                        {
                            Nombre = nombPre.Nombre,
                            CodigoComanda = nombPre.CodigoComanda,
                            CodigoItem = nombPre.CodigoItem,
                            CodigoPedido = nombPre.CodigoPedido
                        };

                        lplat.Add(oBEPlato);
                        CargarComandaCocinero(lplat, 0, nroPedido);
                        

                    }
                    else if (tipoItem == "Bebida")
                    {
                        List<BEBebida> listBebida = new List<BEBebida>();
                        BEBebida oBEBebida = new BEBebida
                        {
                            Nombre = nombPre.Nombre,
                            CodigoComanda = nombPre.CodigoComanda,
                            CodigoItem = nombPre.CodigoItem,
                            CodigoPedido = nombPre.CodigoPedido
                        };

                        listBebida.Add(oBEBebida);
                        CargarComandaMozo(null, listBebida, 0, nroPedido);
                    }
                    else
                    {
                        List<BEExtras> listExt = new List<BEExtras>();
                        BEExtras oBEExt = new BEExtras
                        {
                            Nombre = nombPre.Nombre,
                            CodigoComanda = nombPre.CodigoComanda,
                            CodigoItem = nombPre.CodigoItem,
                            CodigoPedido = nombPre.CodigoPedido
                        };

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

        private bool RecuperarUsuario()
        {
            string nombre = TextBox_Nombre.Text;
            string mail = TextBox_Mail.Text;
            bool aux = false;
            List<BEComanda> listComandas = oBLComanda.ListarTodo();

            foreach (BEComanda coma in listComandas)
            {
                if (coma.Cliente.Nombre == nombre && coma.Cliente.EMail == mail && coma.Estado != "Pagado")
                {
                    oBEComanda = coma;
                    oBEComanda = oBLComanda.ListarObjeto(oBEComanda.Codigo);
                    aux = true;
                }
            }
            CargarItems(oBEComanda.Comandas);
            return aux;
        }

        private void CargarItems(List<BEComanda> comandas)
        {
            List<BEItemsSeleccionados> lsele = new List<BEItemsSeleccionados>();
            foreach (BEComanda com in comandas)
            {
                nroPedido++;
                foreach (BEComanda com2 in com.Comandas)
                {
                    BEItemsSeleccionados itm = new BEItemsSeleccionados
                    {
                        CodigoComanda = com2.CodigoComanda,
                        CodigoPedido = com2.CodigoPedido,
                        CodigoItem = com2.CodigoItem,
                        Nombre = com2.Nombre,
                        Estado = com2.Estado,
                        Precio = com2.MontoTotal
                    };
                    lsele.Add(itm);
                    
                }
            }
            CalcularTotal(lsele);
            textBox1.Text = "$" + MontoTotal.ToString();
            listaItemsSeleccionados.AddRange(lsele);

            Grilla_PedidosCliente.DataSource = lsele;
            OcultarCampos();
        }

        private void RecONuev()
        {
            if (RecuperarUsuario()){}
            else{CargarComandaPrincipal();}
            
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
                if (item.Estado == "Enviado_Mozo" || item.Estado == "Enviado_Cocinero")
                {
                    item.Estado = "Cancelado";
                    oBLComanda.GestionarPlato(item);
                    CargarGrilla();
                }
                else
                {MessageBox.Show("Solo se pueden cancelar pedidos que aún no se encuentren en preparación"); }
                
            }
            catch (Exception)
            { throw; }
        }

        private void Grilla_PedidosCliente_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (Grilla_PedidosCliente.Rows.Count > 0 && Grilla_PedidosCliente.CurrentRow != null)
                {
                    item = (BEItemsSeleccionados)Grilla_PedidosCliente.CurrentRow.DataBoundItem;
                }
                if (item.Estado == "Entregado")
                {
                    Boton_Aceptar.Enabled = true;
                    Boton_Rechazar.Enabled = true;
                }
                else
                {
                    Boton_Aceptar.Enabled = false;
                    Boton_Rechazar.Enabled = false;
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
                BEComandaCocina oBEComandaCocina = new BEComandaCocina
                {
                    Codigo = codPedido,
                    Estado = "Enviado_Cocina",
                    MontoTotal = montoComanda,
                    NroMesa = nroMesa,
                    FechaHora = DateTime.Now,
                    Plato = platos
                };
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
                BEComandaMozo oBEComandaMozo = new BEComandaMozo
                {
                    Codigo = codPedido,
                    Estado = "Enviado_Mozo",
                    MontoTotal = montoComanda,
                    NroMesa = nroMesa,
                    FechaHora = DateTime.Now
                };
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
                BECliente oBECliente = new BECliente
                {
                    Nombre = TextBox_Nombre.Text,
                    EMail = TextBox_Mail.Text
                };

                oBEComanda.Codigo = oBLComanda.GenerarCodigo();
                oBEComanda.Cliente = oBECliente;
                oBEComanda.NroMesa = nroMesa;

                oBLComanda.Guardar(oBEComanda);
            }
            catch (Exception)
            { throw; }
        }

        private void CargarGrilla()
        {
            Grilla_PedidosCliente.DataSource = null;
            Grilla_PedidosCliente.DataSource = listaItemsSeleccionados;
            Grilla_PedidosCliente.ClearSelection();
            OcultarCampos();
        }

        private void CargarTextbox()
        {
            try
            {
                bool match = false;

                do
                {
                    TextBox_Nombre.Text = Interaction.InputBox("Ingrese su nombre");
                } while (TextBox_Nombre.Text == "");

                
                do
                {
                    TextBox_Mail.Text = Interaction.InputBox("Ingrese su mail");

                    match = Regex.IsMatch(TextBox_Mail.Text, @"^[a-z0-9][-a-z0-9._]+@([-a-z0-9]+.)+[a-z]{2,5}$") && TextBox_Mail.Text != null;
                } while (match == false || TextBox_Mail.Text == "");
                
            }
            catch (Exception)
            { throw; }
        }

        private void Boton_CerrarSesion_Click(object sender, EventArgs e)
        {
            GUI_Inicio oGUI_Inicio = new GUI_Inicio();
            this.Close();
            oGUI_Inicio.Show();
        }

        private void OcultarCampos()
        {
            Grilla_PedidosCliente.Columns["CodigoComanda"].Visible = false;
            Grilla_PedidosCliente.Columns["CodigoPedido"].Visible = false;
            Grilla_PedidosCliente.Columns["CodigoItem"].Visible = false;
            Grilla_PedidosCliente.Columns["Codigo"].Visible = false;
            Grilla_PedidosCliente.Columns["Descripcion"].Visible = false;
        }
    }
}

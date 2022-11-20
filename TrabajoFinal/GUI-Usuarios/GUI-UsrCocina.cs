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

            oBLItem = new BLItemsSeleccionados();
            oItem = new List<BEItemsSeleccionados>();
            oBEItem = new BEItemsSeleccionados();
            CargarGrillaPedidos();

            if (Personal is BECocinero) { rol = "Cocinero"; }
            else { rol = "Mozo"; }

            VisibilidadBotones(rol);
        }

        string rol;
        BEPersonal oBEPersonal;
        BLCocinero oBLCocinero;
        List<BEItemsSeleccionados> oItem;
        BLItemsSeleccionados oBLItem;
        BEItemsSeleccionados oBEItem;

        private void Boton_VerificacionPlato_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Respuesta;
                Respuesta = MessageBox.Show("¿El plato es el correcto y se encuentra en las condiciones indicadas?", "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (Respuesta == DialogResult.Yes)
                {
                    oBEItem.Estado = "Enviado_" + rol;
                    oBLItem.Modificar(oBEItem);
                    CargarGrillaPedidos();
                }
                else
                {
                    oBEItem.Estado = "Rechazado_Mozo";
                    oBLItem.Modificar(oBEItem);
                    CargarGrillaPedidos();
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message);}
        }

        private void Boton_EnPreparacion_Click(object sender, EventArgs e)
        {
            try
            {
                oBEItem.Estado = "En_Preparacion_" + rol;
                oBLItem.Modificar(oBEItem);
                CargarGrillaPedidos();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message);}
        }

        private void Boton_EnEntrega_Click(object sender, EventArgs e)
        {
            try
            {
                oBEItem.Estado = "En_Entrega_" + rol;
                oBLItem.Modificar(oBEItem);
                CargarGrillaPedidos();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void Boton_Entregado_Click(object sender, EventArgs e)
        {
            try
            {
                if (oBEPersonal is BECocinero)
                { oBEItem.Estado = "Enviado_Mozo"; }
                else 
                { oBEItem.Estado = "Entregado"; }

                oBEItem.Estado = "Entregado";
                oBLItem.Modificar(oBEItem);
                CargarGrillaPedidos();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void Boton_Retirado_Click(object sender, EventArgs e)
        {
            try
            {
                oBEItem.Estado = "Retirado";
                oBLItem.Modificar(oBEItem);
                CargarGrillaPedidos();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void GridView_Pedidos_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (GridView_Pedidos.DataSource != null)
                {
                    oBEItem = (BEItemsSeleccionados)GridView_Pedidos.CurrentRow.DataBoundItem;

                    if (oBEItem.Estado == "Verificar_" + rol)
                    {

                        Boton_VerificacionPlato.Enabled = true;
                        Boton_EnPreparacion.Enabled = false;
                        Boton_EnEntrega.Enabled = false;
                        Boton_Entregado.Enabled = false;
                        Boton_Retirado.Enabled = false;

                    }

                    if (oBEItem.Estado == "Enviado_" + rol)
                    {
                        Boton_VerificacionPlato.Enabled = false;
                        Boton_EnPreparacion.Enabled = true;
                        Boton_EnEntrega.Enabled = false;
                        Boton_Entregado.Enabled = false;
                        Boton_Retirado.Enabled = false;
                    }

                    if (oBEItem.Estado == "En_Preparacion_" + rol)
                    {
                        Boton_VerificacionPlato.Enabled = false;
                        Boton_EnPreparacion.Enabled = false;
                        Boton_EnEntrega.Enabled = true;
                        Boton_Entregado.Enabled = false;
                        Boton_Retirado.Enabled = false;
                    }

                    if (oBEItem.Estado == "En_Entrega_" + rol)
                    {
                        Boton_VerificacionPlato.Enabled = false;
                        Boton_EnPreparacion.Enabled = false;
                        Boton_EnEntrega.Enabled = false;
                        Boton_Entregado.Enabled = true;
                        Boton_Retirado.Enabled = false;
                    }
                    if (oBEItem.Estado == "Rechazado")
                    {
                        Boton_VerificacionPlato.Enabled = false;
                        Boton_EnPreparacion.Enabled = false;
                        Boton_EnEntrega.Enabled = false;
                        Boton_Entregado.Enabled = false;
                        Boton_Retirado.Enabled = true;
                    }
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void VisibilidadBotones(string rol)
        {
            try
            {
                if (rol == "Cocinero")
                {
                    Boton_Retirado.Visible = false;
                    Boton_VerificacionPlato.Visible = false;
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void CargarGrillaPedidos()
        {
            try
            {
                GridView_Pedidos.DataSource = FiltrarItems();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private List<BEItemsSeleccionados> FiltrarItems()
        {
            try
            {
                List<BEItemsSeleccionados> listaTodos = oBLItem.ListarTodo();
                List<BEItemsSeleccionados> listaFiltrada = new List<BEItemsSeleccionados>();
                foreach (BEItemsSeleccionados item in listaTodos)
                {

                    if (oBEPersonal is BEMozo)
                    {
                        if (item.Estado == "Enviado_Mozo" || item.Estado == "En_Preparacion_Mozo" || item.Estado == "Listo_Entrega_Mozo" || item.Estado == "En_Entrega_Mozo" || item.Estado == "Rechazado" || item.Estado == "Verificar_Mozo") 
                        {
                            listaFiltrada.Add(item);
                        }
                    }
                    else if (oBEPersonal is BECocinero)
                    {
                        if (item.Estado == "Enviado_Cocinero" || item.Estado == "En_Preparacion_Cocinero" || item.Estado == "Listo_Entrega_Cocinero" || item.Estado == "En_Entrega_Cocinero" || item.Estado == "Rechazado_Mozo")
                        {
                            listaFiltrada.Add(item);
                        }
                    }
                
                }
                return listaFiltrada;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); return null; }

        }

    }
}

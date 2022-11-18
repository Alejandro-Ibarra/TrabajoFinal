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
using BussinesLogic;
using ServiceLogic;

namespace TrabajoFinal
{
    public partial class GUI_UsrMozo : Form
    {
        public GUI_UsrMozo()
        {
            InitializeComponent();
            
            oBLItemMozo = new BLItemsSeleccionados();
            oItemMozo = new List<BEItemsSeleccionados>();
            oBEItemMozo = new BEItemsSeleccionados();
            CargarGrillaPedidos();
        }

        List<BEItemsSeleccionados> oItemMozo;
        BLItemsSeleccionados oBLItemMozo;
        BEItemsSeleccionados oBEItemMozo;

        private void Boton_EnEntrega_Click(object sender, EventArgs e)
        {
            try
            {
                oBEItemMozo.Estado = "En_Entrega";
                oBLItemMozo.Modificar(oBEItemMozo);
                CargarGrillaPedidos();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void Boton_Entregado_Click(object sender, EventArgs e)
        {
            try
            {
                oBEItemMozo.Estado = "Entregado";
                oBLItemMozo.Modificar(oBEItemMozo);
                CargarGrillaPedidos();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void Boton_Retirado_Click(object sender, EventArgs e)
        {
            try
            {
                oBEItemMozo.Estado = "Retirado";
                oBLItemMozo.Modificar(oBEItemMozo);
                CargarGrillaPedidos();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void GridView_Pedidos_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                oBEItemMozo = (BEItemsSeleccionados)GridView_Pedidos.CurrentRow.DataBoundItem;

                if (oBEItemMozo.Estado == "Enviado_Mozo" || oBEItemMozo.Estado == "Listo_Entrega")
                {
                    Boton_EnEntrega.Enabled = true;
                    Boton_Entregado.Enabled = false;
                    Boton_Retirado.Enabled = false;
                }
                if (oBEItemMozo.Estado == "En_Entrega")
                {
                    Boton_EnEntrega.Enabled = false;
                    Boton_Entregado.Enabled = true;
                    Boton_Retirado.Enabled = false;

                }
                if (oBEItemMozo.Estado == "Rechazado")
                {
                    Boton_EnEntrega.Enabled = false;
                    Boton_Entregado.Enabled = false;
                    Boton_Retirado.Enabled = true;
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
                List<BEItemsSeleccionados> listaTodos = oBLItemMozo.ListarTodo();
                List<BEItemsSeleccionados> listaFiltrada = new List<BEItemsSeleccionados>();
                foreach (BEItemsSeleccionados item in listaTodos)
                {
                    if (item.Estado == "Enviado_Mozo" || item.Estado == "Listo_Entrega" || item.Estado == "En_Entrega" ||item.Estado == "Rechazado")
                    {
                        listaFiltrada.Add(item);
                    }
                }
                return listaFiltrada;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); return null; }
        }
    }
}

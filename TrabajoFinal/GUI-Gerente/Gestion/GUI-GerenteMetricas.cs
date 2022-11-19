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
using Abstraction;



namespace TrabajoFinal
{
    public partial class GUI_Gerente_Metricas : Form
    {
        public GUI_Gerente_Metricas()
        {
            InitializeComponent();
            oBLPlato = new BLPlato();
            oBLItemsSeleccionados = new BLItemsSeleccionados();
            oBEPlato = new BEPlato();
            oListaItemsCod = new List<BEItemsSeleccionados>();
            oListaPlatos = new List<BEPlato>();
            CargarGraficoPlatos();
        }

        BLPlato oBLPlato;
        BEPlato oBEPlato;
        BLItemsSeleccionados oBLItemsSeleccionados;
        List<BEItemsSeleccionados> oListaItemsCod;
        List<BEPlato> oListaPlatos;

        private List<BEPlato> RecuperarPlatos()
        {
            List<BEPlato> platos = new List<BEPlato>();

            oListaItemsCod = oBLItemsSeleccionados.RecuperarPlatosMasVendidos();
            oListaPlatos = oBLPlato.ListarTodo();

            foreach (BEItemsSeleccionados item in oListaItemsCod)
            {
                foreach (BEPlato plat in oListaPlatos)
                {
                    if (plat.Codigo == item.Codigo)
                    {
                        platos.Add(plat);
                    }
                }
            }
            return platos;
        }

        /*private List<BEPlato> RecuperarBebidas()
        {
            List<BEBebida> platos = new List<BEBebida>();

            oListaItemsCod = oBLItemsSeleccionados.RecuperarPlatosMasVendidos();
            oListaPlatos = oBLPlato.ListarTodo();

            foreach (BEItemsSeleccionados item in oListaItemsCod)
            {
                foreach (BEBebida plat in oListaPlatos)
                {
                    if (plat.Codigo == item.Codigo)
                    {
                        platos.Add(plat);
                    }
                }
            }
            return platos;
        }*/

        private void CargarGraficoPlatos()
        {
            List<BEPlato> platos = RecuperarPlatos();
            List<string> NombresPlatos = new List<string>();
            List<int> cantidad = new List<int>();
            var platosPorID = platos
                .GroupBy(u => u.Codigo)
                .Select(grp => grp.ToList())
                .ToList();

            foreach (var grupos in platosPorID)
            {
                int aux = 0;
                string aux2 = "";
                foreach (var item in grupos)
                {
                    aux = aux + 1;
                    aux2 = item.Nombre;
                }
                cantidad.Add(aux);
                NombresPlatos.Add(aux2);
            }
           
            Chart_Platos.Series["Series1"].Points.DataBindXY(NombresPlatos, cantidad);
            Chart_Platos.Titles.Add("Estadisticas platos");

            Chart_Platos.ChartAreas["ChartArea1"].Area3DStyle.Enable3D = true;
            Chart_Platos.Legends[0].Enabled = true;
        }

    }
}

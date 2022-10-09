using Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesEntity
{
    public class BEPedidoCliente : BEEntity
    {
        public DateTime FechaHora { get; set; }
        public bool PedidoCustom { get; set; }
        public string Aclaraciones { get; set; }
        public int Descuento { get; set; }
        public int MontoTotal { get; set; }
        public List<BEPlato> ListaPlatos { get; set; }
        public List<BEBebida> ListaBebidas { get; set; }
        public List<BEExtras> ListaExtras { get; set; }
    }
}

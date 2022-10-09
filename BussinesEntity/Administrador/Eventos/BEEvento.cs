using Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesEntity
{
    public class BEEvento : BEEntity
    {
        public int CantPersonas { get; set; }
        public DateTime FechaHora { get; set; }
        public List<BECliente> ListaClientes { get; set; }
    }
}

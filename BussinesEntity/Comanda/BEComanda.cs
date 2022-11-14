using Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesEntity
{
    public class BEComanda : BEEntity
    {
        public int NroMesa { get; set; }
        public DateTime FechaHora { get; set; }
        public int MontoTotal { get; set; }
    }
}

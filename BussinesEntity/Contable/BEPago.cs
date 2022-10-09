using Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesEntity
{
    public class BEPago : BEEntity
    {
        public bool Estado { get; set; }
        public int Monto { get; set; }

    }
}

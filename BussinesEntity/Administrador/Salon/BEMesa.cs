using Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesEntity
{
    public class BEMesa : BEEntity
    {
        public int Capacidad { get; set; }
        public int Ocupacion { get; set; }
    }
}

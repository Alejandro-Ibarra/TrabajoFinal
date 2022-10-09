using Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesEntity
{
    public class BECliente : BEEntity
    {
        public string Nombre { get ; set ; }
        public string EMail { get; set; }
    }
}

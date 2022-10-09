using Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesEntity
{
    public class BETurno : BEEntity
    {
        public string Nombre { get; set; }
        public TimeSpan Horario { get; set; }
        public string Dias { get; set; }
    }
}

using Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesEntity
{
    public class BEBebida : BEItem
    {
        public string TipoEnvase { get; set; }
        public string Marca { get; set; }
        public int GraduacionAlc { get; set; }
        public int Stock { get; set; }
        public int Precio { get; set; }
    }
}

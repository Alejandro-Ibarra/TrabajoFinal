using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesEntity
{
    public class BEItem : BEEntity
    {
        public string Nombre { get; set; }
        public int CodigoComanda { get; set; }
        public int CodigoPedido { get; set; }
        public int CodigoItem { get; set; }

    }
}

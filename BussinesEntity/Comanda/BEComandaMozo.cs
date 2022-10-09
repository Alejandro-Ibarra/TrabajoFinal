using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesEntity
{
    public class BEComandaMozo : BEComanda
    {
        public List<BEBebida> ListaBebidas { get; set; }
        public List<BEExtras> ListaExtras { get; set; }
    }
}

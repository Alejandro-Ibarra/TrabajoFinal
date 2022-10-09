using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesEntity
{
    public class BEComandaCocina : BEComanda
    {
        public List<BEPlato> ListaPlatos { get; set; }
    }
}

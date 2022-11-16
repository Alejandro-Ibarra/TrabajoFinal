using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesEntity
{
    public class BEComandaMozo : BEComanda
    {

        public List<BEExtras> extras = new List<BEExtras>();
        public List<BEBebida> bebidas = new List<BEBebida>();


    }
}

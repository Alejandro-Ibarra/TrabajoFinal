using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesEntity
{
    public class BEItemsSeleccionados : BEItem
    {
        public int Precio { get; set; }
        public string Estado { get; set; }
        public int Mesa { get; set; }

        public BEItemsSeleccionados()
        {
        }
    }
}

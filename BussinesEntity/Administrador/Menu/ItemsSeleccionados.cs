using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesEntity
{
    public class ItemsSeleccionados
    {
        public int CodigoComanda { get; set; }
        public int codigoPedido { get; set; }
        public int CodigoItem { get; set; }
        public string Nombre { get; set; }
        public int Precio { get; set; }
        public string Estado { get; set; }

        public ItemsSeleccionados()
        {
        }
    }
}

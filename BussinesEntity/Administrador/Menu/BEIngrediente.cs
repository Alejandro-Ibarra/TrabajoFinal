using Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesEntity
{
    public class BEIngrediente : BEEntity
    {
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public bool Refrigeracion { get; set; }
        public int Stock { get; set; }
        public string Proveedor { get; set; }
    }
}

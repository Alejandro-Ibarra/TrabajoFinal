using Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesEntity
{
    public class BEPlato : BEItem
    {

        public string Tipo { get; set; }
        public string Clase { get; set; }
        public int Precio { get; set; }
        public bool Activo { get; set; }
        public BEIngrediente IngredientePrincipal { get; set; }
        public List<BEIngrediente> ListaIngredientes { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesEntity
{
    public class BEComandaMozo : BEComanda
    {

        private List<BEComanda> _comandas;

        public BEComandaMozo(DateTime fechaHora, int nroMesa, int montoTotal, string estado) : base(fechaHora, nroMesa, montoTotal, estado)
        {
            _comandas = new List<BEComanda>();
        }



        public List<BEBebida> ListaBebidas { get; set; }
        public List<BEExtras> ListaExtras { get; set; }
    }
}

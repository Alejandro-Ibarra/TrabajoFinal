using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesEntity
{
    public class BEComandaCocina : BEComanda
    {

        private List<BEComanda> _comandas;
        private BEPlato _Plato;

        public BEComandaCocina(DateTime fechaHora, int nroMesa, int montoTotal, string estado, BEPlato plato) : base(fechaHora, nroMesa, montoTotal, estado)
        {
            _Plato = new BEPlato();
            _comandas = new List<BEComanda>();
        }

        public List<BEPlato> ListaPlatos { get; set; }
    }
}

using Abstraction;
using BussinesEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLogic
{
    public class BLComandaCocina : BLComanda
    {
        private List<BLComanda> _comandas;

        public BLComandaCocina( int nroMesa, DateTime fechaHora, int montoTotal, string estado, BEPlato platos) : base(nroMesa, fechaHora, montoTotal, estado)
        {
            _comandas = new List<BLComanda>();
        }

        public override void AgregarComanda(BLComanda comanda)
        {
            _comandas.Add(comanda);
        }

        public override IList<BLComanda> ObtenerComandas()
        {
            return _comandas.ToArray();
        }

        public override void CambiarEstado(string estado)
        {
            throw new NotImplementedException();
        }

    }
}

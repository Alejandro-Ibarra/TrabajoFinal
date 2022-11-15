using Abstraction;
using BussinesEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLogic
{
    public class BLComandaMozo : BLComanda
    {
        private List<BLComanda> _comandas;

        public BLComandaMozo( int nroMesa, DateTime fechaHora, int montoTotal, string estado, List<BEExtras> extras , List<BEBebida> bebidas) : base(nroMesa, fechaHora, montoTotal, estado)
        {
            _comandas = new List<BLComanda>();
        }

        public override void AgregarComanda(BLComanda comanda)
        {
            _comandas.Add(comanda);
        }

        public override void CambiarEstado(string estado)
        {
            throw new NotImplementedException();
        }

        public override IList<BLComanda> ObtenerComandas()
        {
            return _comandas.ToArray();
        }
    }
}

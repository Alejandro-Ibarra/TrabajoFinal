using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinesEntity;

namespace BussinesLogic
{
    public abstract class BLComanda
    {

        int _NroMesa;
        DateTime _FechaHora;
        int _MontoTotal;
        string _Estado;

        public BLComanda( int nroMesa, DateTime fechaHora, int montoTotal, string estado)
        {
            _NroMesa = nroMesa;
            _FechaHora = fechaHora;
            _MontoTotal = montoTotal;
            _Estado = estado;
        }

        public int NroMesa { get { return _NroMesa; } }
        public DateTime FechaHora { get { return _FechaHora; } }
        public int MontoTotal { get { return _MontoTotal; } }
        public string Estado { get { return _Estado; } }

        public abstract void AgregarComanda(BLComanda comanda);
        public abstract IList<BLComanda> ObtenerComandas();
        public abstract void CambiarEstado(string estado);

    }
}

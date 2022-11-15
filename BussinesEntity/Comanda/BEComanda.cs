﻿using Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesEntity
{
    public abstract class BEComanda
    {
        int _NroMesa;
        DateTime _FechaHora;
        int _MontoTotal;
        string _Estado;

        public BEComanda(DateTime fechaHora, int nroMesa,  int montoTotal, string estado)
        {
            _NroMesa = nroMesa;
            _FechaHora = fechaHora;
            _MontoTotal = montoTotal;
            _Estado = estado;
        }

        public int NroMesa { get { return _NroMesa; } }
        public DateTime FechaHora { get { return _FechaHora; } }
        public int MontoTotal { get { return _MontoTotal; } }
        public string  Estado { get { return _Estado; } }
    }
}

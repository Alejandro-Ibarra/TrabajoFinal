﻿using Abstraction;
using BussinesEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLogic
{
    public class BLEvento : IGestorABM<BEEvento>, IGestorConsulta<int>
    {
        public bool Existe(int obj)
        {
            throw new NotImplementedException();
        }

        public bool Modificar(BEEvento Objeto)
        {
            throw new NotImplementedException();
        }

        bool IGestorABM<BEEvento>.Baja(BEEvento oBEEvento)
        {
            throw new NotImplementedException();
        }

        bool IGestorABM<BEEvento>.Guardar(BEEvento oBEEvento)
        {
            throw new NotImplementedException();
        }

        BEEvento IGestorABM<BEEvento>.ListarObjeto(int oBEEvento)
        {
            throw new NotImplementedException();
        }

        List<BEEvento> IGestorABM<BEEvento>.ListarTodo()
        {
            throw new NotImplementedException();
        }
    }
}

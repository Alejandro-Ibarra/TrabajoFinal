﻿using Abstraction;
using BussinesEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLogic
{
    public class BLIngrediente : IGestorABM<BEIngrediente>, IGestorConsulta<string>
    {
        public bool Baja(BEIngrediente oBEIngredientes)
        {
            throw new NotImplementedException();
        }

        public bool Existe(string obj)
        {
            throw new NotImplementedException();
        }

        public bool Guardar(BEIngrediente oBEIngredientes)
        {
            throw new NotImplementedException();
        }

        public BEIngrediente ListarObjeto(BEIngrediente oBEIngredientes)
        {
            throw new NotImplementedException();
        }

        public List<BEIngrediente> ListarTodo()
        {
            throw new NotImplementedException();
        }
    }
}
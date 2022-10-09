using Abstraction;
using BussinesEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLogic
{
    public class BLExtras : IGestorABM<BEExtras>, IGestorConsulta<string>
    {
        public bool Baja(BEExtras Objeto)
        {
            throw new NotImplementedException();
        }

        public bool Existe(string obj)
        {
            throw new NotImplementedException();
        }

        public bool Guardar(BEExtras Objeto)
        {
            throw new NotImplementedException();
        }

        public BEExtras ListarObjeto(BEExtras Objeto)
        {
            throw new NotImplementedException();
        }

        public List<BEExtras> ListarTodo()
        {
            throw new NotImplementedException();
        }
    }
}

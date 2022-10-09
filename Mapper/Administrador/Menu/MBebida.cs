using Abstraction;
using BussinesEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapper.Administrador.Menu
{
    internal class MBebida : IGestorABM<BEBebida>, IGestorConsulta<string>
    {
        public bool Baja(BEBebida Objeto)
        {
            throw new NotImplementedException();
        }

        public bool Existe(string obj)
        {
            throw new NotImplementedException();
        }

        public bool Guardar(BEBebida Objeto)
        {
            throw new NotImplementedException();
        }

        public BEBebida ListarObjeto(BEBebida Objeto)
        {
            throw new NotImplementedException();
        }

        public List<BEBebida> ListarTodo()
        {
            throw new NotImplementedException();
        }
    }
}

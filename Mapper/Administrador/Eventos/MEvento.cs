using Abstraction;
using BussinesEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapper.Administrador.Eventos
{
    internal class MEvento : IGestorABM<BEEvento>, IGestorConsulta<int>
    {
        public bool Baja(BEEvento Objeto)
        {
            throw new NotImplementedException();
        }

        public bool Existe(int obj)
        {
            throw new NotImplementedException();
        }

        public bool Guardar(BEEvento Objeto)
        {
            throw new NotImplementedException();
        }

        public BEEvento ListarObjeto(BEEvento Objeto)
        {
            throw new NotImplementedException();
        }

        public List<BEEvento> ListarTodo()
        {
            throw new NotImplementedException();
        }

        public bool Modificar(BEEvento Objeto)
        {
            throw new NotImplementedException();
        }
    }
}

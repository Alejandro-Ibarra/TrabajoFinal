using Abstraction;
using BussinesEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapper
{
    public class MMozo : IGestorABM<BEMozo>, IGestorConsulta<int>
    {
        public bool Baja(BEMozo Objeto)
        {
            throw new NotImplementedException();
        }

        public bool Existe(int obj)
        {
            throw new NotImplementedException();
        }

        public bool Guardar(BEMozo Objeto)
        {
            throw new NotImplementedException();
        }
        public BEMozo ListarObjeto(BEMozo Objeto)
        {
            throw new NotImplementedException();
        }
        public List<BEMozo> ListarTodo()
        {
            throw new NotImplementedException();
        }

        public bool Modificar(BEMozo Objeto)
        {
            throw new NotImplementedException();
        }
    }
}

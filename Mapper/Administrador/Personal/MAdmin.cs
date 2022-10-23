using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstraction;
using BussinesEntity;
using System.Xml.Linq;

namespace Mapper
{
    public class MAdmin : IGestorABM<BEAdmin>, IGestorConsulta<int>
    {
        public bool Baja(BEAdmin Objeto)
        {
            throw new NotImplementedException();
        }

        public bool Existe(int obj)
        {
            throw new NotImplementedException();
        }

        public bool Guardar(BEAdmin Objeto)
        {
            throw new NotImplementedException();
        }

        public BEAdmin ListarObjeto(BEAdmin Objeto)
        {
            throw new NotImplementedException();
        }

        public List<BEAdmin> ListarTodo()
        {
            throw new NotImplementedException();
        }

        public bool Modificar(BEAdmin Objeto)
        {
            throw new NotImplementedException();
        }
    }
}

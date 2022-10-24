using Abstraction;
using BussinesEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapper
{
    internal class MPlato : IGestorABM<BEPlato>, IGestorConsulta<string>
    {
        public bool Baja(BEPlato Objeto)
        {
            throw new NotImplementedException();
        }

        public bool Existe(string obj)
        {
            throw new NotImplementedException();
        }

        public bool Guardar(BEPlato Objeto)
        {
            throw new NotImplementedException();
        }
        public BEPlato ListarObjeto(int Objeto)
        {
            throw new NotImplementedException();
        }
        public List<BEPlato> ListarTodo()
        {
            throw new NotImplementedException();
        }

        public bool Modificar(BEPlato Objeto)
        {
            throw new NotImplementedException();
        }
    }
}

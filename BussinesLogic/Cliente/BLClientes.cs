using Abstraction;
using BussinesEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLogic
{
    public class BLClientes : IGestorABM<BECliente>, IGestorConsulta<int>
    {
        public bool Baja(BECliente Objeto)
        {
            throw new NotImplementedException();
        }

        public bool Existe(int obj)
        {
            throw new NotImplementedException();
        }

        public bool Guardar(BECliente Objeto)
        {
            throw new NotImplementedException();
        }

        public BECliente ListarObjeto(int Dni)
        {
            throw new NotImplementedException();
        }

        public List<BECliente> ListarTodo()
        {
            throw new NotImplementedException();
        }

        public bool Modificar(BECliente Objeto)
        {
            throw new NotImplementedException();
        }
    }
}

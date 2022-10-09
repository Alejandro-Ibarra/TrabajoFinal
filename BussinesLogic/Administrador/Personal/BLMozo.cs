using Abstraction;
using BussinesEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLogic
{
    public class BLMozo : IGestorABM<BEMozo>, IGestorConsulta<int>
    {
        public bool Baja(BEMozo oBEMozo)
        {
            throw new NotImplementedException();
        }

        public bool Existe(int obj)
        {
            throw new NotImplementedException();
        }

        public bool Guardar(BEMozo oBEMozo)
        {
            throw new NotImplementedException();
        }

        public BEMozo ListarObjeto(BEMozo oBEMozo)
        {
            throw new NotImplementedException();
        }

        public List<BEMozo> ListarTodo()
        {
            throw new NotImplementedException();
        }
    }
}

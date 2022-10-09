using Abstraction;
using BussinesEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLogic
{
    public class BLPlato : IGestorABM<BEPlato>, IGestorConsulta<string>
    {
        public bool Baja(BEPlato oBEPlato)
        {
            throw new NotImplementedException();
        }

        public bool Existe(string obj)
        {
            throw new NotImplementedException();
        }

        public bool Guardar(BEPlato oBEPlato)
        {
            throw new NotImplementedException();
        }

        public BEPlato ListarObjeto(BEPlato oBEPlato)
        {
            throw new NotImplementedException();
        }

        public List<BEPlato> ListarTodo()
        {
            throw new NotImplementedException();
        }
    }
}

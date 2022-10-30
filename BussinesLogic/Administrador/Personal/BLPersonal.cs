using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstraction;
using BussinesEntity;
using Mapper;

namespace BussinesLogic
{
    public class BLPersonal : IGestorABM<BEAdmin>, IGestorConsulta<int>
    {
        public BLPersonal()
        {
            oMadmin = new MPersonal();
        }

        MPersonal oMadmin;

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

        public List<BEAdmin> ListarTodo()
        {
            throw new NotImplementedException();
        }

        public bool Modificar(BEAdmin Objeto)
        {
            throw new NotImplementedException();
        }

        public BEAdmin ListarObjeto(int dni)
        {
            return oMadmin.ListarObjeto(dni);
        }

        public List<BERoles> ListarRoles(int dni)
        {
            return oMadmin.ListarRoles(dni);
        }
    }
}

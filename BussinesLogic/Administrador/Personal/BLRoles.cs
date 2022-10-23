using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mapper;
using BussinesEntity;
using Abstraction;

namespace BussinesLogic
{
    public class BLRoles : IGestorABM<BERoles>
    {
        public BLRoles()
        {
            oMroles = new MRoles();
        }

        MRoles oMroles;

        public bool Guardar(BERoles Objeto)
        {
            return oMroles.Guardar(Objeto);
        }

        public bool Baja(BERoles Objeto)
        {
            return oMroles.Baja(Objeto);   
        }

        public bool Modificar(BERoles Objeto)
        {
            return oMroles.Modificar(Objeto);
        }

        public List<BERoles> ListarTodo()
        {
            return oMroles.ListarTodo();
        }

        public BERoles ListarObjeto(BERoles Objeto)
        {
            return oMroles.ListarObjeto(Objeto);
        }
    }
}

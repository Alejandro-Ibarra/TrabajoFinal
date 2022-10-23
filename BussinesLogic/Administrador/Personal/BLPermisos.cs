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
    public class BLPermisos : IGestorABM<BEPermisos>
    {

        public BLPermisos()
        {
            oMpermisos = new MPermisos();
        }

        MPermisos oMpermisos;

        public bool Guardar(BEPermisos Objeto)
        {
            return oMpermisos.Guardar(Objeto);
        }

        public bool Baja(BEPermisos Objeto)
        {
            return oMpermisos.Baja(Objeto);
        }

        public bool Modificar(BEPermisos Objeto)
        {
            return oMpermisos.Modificar(Objeto);
        }

        public List<BEPermisos> ListarTodo()
        {
            return oMpermisos.ListarTodo();
        }

        public BEPermisos ListarObjeto(BEPermisos Objeto)
        {
            return oMpermisos.ListarObjeto(Objeto);
        }
    }
    
}

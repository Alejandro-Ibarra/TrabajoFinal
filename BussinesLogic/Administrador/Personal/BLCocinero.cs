using Abstraction;
using BussinesEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mapper;

namespace BussinesLogic
{
    public class BLCocinero : IGestorABM<BECocinero>, IGestorConsulta<int>
    {
        public BLCocinero()
        {
            oMCocinero = new MCocinero();
        }

        MCocinero oMCocinero;

        public bool Baja(BECocinero Objeto)
        {
            return oMCocinero.Baja(Objeto);
        }

        public bool Existe(int obj)
        {
            return oMCocinero.Existe(obj);
        }

        public bool Guardar(BECocinero Objeto)
        {
            return oMCocinero.Guardar(Objeto);
        }

        public BECocinero ListarObjeto(BECocinero Objeto)
        {
            throw new NotImplementedException();
        }

        public List<BECocinero> ListarTodo()
        {
            return oMCocinero.ListarTodo();
        }

        public bool Modificar(BECocinero Objeto)
        {
            return oMCocinero.Modificar(Objeto);
        }
    }
}

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
    public class BLExtras : IGestorABM<BEExtras>, IGestorConsulta<BEExtras>
    {

        public BLExtras()
        {
            oMExtras = new MExtras();
        }

        MExtras oMExtras;

        public bool Baja(BEExtras oBExtras)
        {
            return oMExtras.Baja(oBExtras);
        }

        public bool Existe(BEExtras oBExtras)
        {
            return oMExtras.Existe(oBExtras);
        }

        public bool Guardar(BEExtras oBExtras)
        {
            return oMExtras.Guardar(oBExtras);
        }

        public BEExtras ListarObjeto(BEExtras oBExtras)
        {
            throw new NotImplementedException();
        }

        public List<BEExtras> ListarTodo()
        {
            return oMExtras.ListarTodo();
        }

        public bool Modificar(BEExtras oBExtras)
        {
            return oMExtras.Modificar(oBExtras);
        }
    }
}

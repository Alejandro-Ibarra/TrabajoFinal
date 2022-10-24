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
    public class BLMozo : IGestorABM<BEMozo>, IGestorConsulta<int>
    {
        public BLMozo()
        {
            oMMozo = new MMozo();
        }

        MMozo oMMozo;

        public bool Baja(BEMozo oBEMozo)
        {
            return oMMozo.Baja(oBEMozo);
        }

        public bool Existe(int oBEMozo)
        {
            return oMMozo.Existe(oBEMozo);
        }

        public bool Guardar(BEMozo oBEMozo)
        {
            return oMMozo.Guardar(oBEMozo);
        }

        public BEMozo ListarObjeto(int dni)
        {
            return oMMozo.ListarObjeto(dni);
        }

        public List<BEMozo> ListarTodo()
        {
            return oMMozo.ListarTodo();
        }

        public bool Modificar(BEMozo oBEMozo)
        {
            return oMMozo.Modificar(oBEMozo);
        }
    }
}

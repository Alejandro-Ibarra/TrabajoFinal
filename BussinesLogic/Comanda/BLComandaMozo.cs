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
    public class BLComandaMozo : IGestorABM<BEComandaMozo>, IGestorConsulta<int>
    {

        public BLComandaMozo()
        {
            oMComandaMozo = new MComandaMozo();
        }

        MComandaMozo oMComandaMozo;

        public bool Baja(BEComandaMozo Objeto)
        {
            return oMComandaMozo.Baja(Objeto);
        }

        public bool Existe(int obj)
        {
            return oMComandaMozo.Existe(obj);
        }

        public bool Guardar(BEComandaMozo Objeto)
        {
            return oMComandaMozo.Guardar(Objeto);
        }

        public BEComandaMozo ListarObjeto(int Dni)
        {
            return oMComandaMozo.ListarObjeto(Dni);
        }

        public List<BEComandaMozo> ListarTodo()
        {
            return oMComandaMozo.ListarTodo();
        }

        public bool Modificar(BEComandaMozo Objeto)
        {
            return oMComandaMozo.Modificar(Objeto);
        }

        public int GenerarCodigo()
        {
            return oMComandaMozo.GenerarCodigo();
        }
    }
}

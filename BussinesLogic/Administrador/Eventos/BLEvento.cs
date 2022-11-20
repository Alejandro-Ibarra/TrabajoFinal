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
    public class BLEvento : IGestorABM<BEEvento>, IGestorConsulta<int>
    {

        public BLEvento()
        {
            oMEvento = new MEvento();
        }
        MEvento oMEvento;

        public bool Existe(int obj)
        {
            return oMEvento.Existe(obj);
        }

        public bool Modificar(BEEvento Objeto)
        {
            return oMEvento.Modificar(Objeto);
        }

        public bool Baja(BEEvento oBEEvento)
        {
            return oMEvento.Baja(oBEEvento);
        }

        public bool Guardar(BEEvento oBEEvento)
        {
            return oMEvento.Guardar(oBEEvento);
        }

        public int GenerarCodigo()
        {
            return oMEvento.GenerarCodigo();
        }

        public BEEvento ListarObjeto(int oBEEvento)
        {
            return oMEvento.ListarObjeto(oBEEvento);
        }

        public List<BEEvento> ListarTodo()
        {
            return oMEvento.ListarTodo();    
        }
    }
}

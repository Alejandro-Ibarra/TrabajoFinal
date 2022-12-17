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
    public class BLPlato : IGestorABM<BEPlato>, IGestorConsulta<BEPlato>
    {
        public BLPlato()
        {
            oMPlato = new MPlato();
        }

        MPlato oMPlato;

        public bool Baja(BEPlato oBEPlato)
        {
            return oMPlato.Baja(oBEPlato);
        }

        public bool Existe(BEPlato oBEPlato)
        {
            return oMPlato.Existe(oBEPlato);
        }

        public bool Guardar(BEPlato oBEPlato)
        {
            return oMPlato.Guardar(oBEPlato);
        }

        public BEPlato ListarObjeto(int oBEPlato)
        {
            throw new NotImplementedException();
        }

        public List<BEPlato> ListarTodo()
        {
            return oMPlato.ListarTodo();
        }

        public bool Modificar(BEPlato Objeto)
        {
            return oMPlato.Modificar(Objeto);
        }

        public int GenerarCodigo()
        {
            return oMPlato.GenerarCodigo();
        }
    }
}

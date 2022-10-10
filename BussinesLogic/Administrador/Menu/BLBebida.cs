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
    public class BLBebida : IGestorABM<BEBebida>, IGestorConsulta<BEBebida>
    {

        public BLBebida()
        {
            oMBebida = new MBebida();
        }

        MBebida oMBebida;

        public bool Baja(BEBebida oBEBebida)
        {
            return oMBebida.Baja(oBEBebida);
        }

        public bool Existe(BEBebida oBEBebida)
        {
            return oMBebida.Existe(oBEBebida);
        }

        public bool Guardar(BEBebida oBEBebida)
        {
            return oMBebida.Guardar(oBEBebida);
        }

        public BEBebida ListarObjeto(BEBebida oBEBebida)
        {
            throw new NotImplementedException();
        }

        public List<BEBebida> ListarTodo()
        {
            return oMBebida.ListarTodo();
        }

        public bool Modificar(BEBebida oBEBebida)
        {
            return oMBebida.Modificar(oBEBebida);
        }
    }
}

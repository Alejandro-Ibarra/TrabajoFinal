using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinesEntity;
using Abstraction;
using Mapper;

namespace BussinesLogic
{
    public class BLItemsSeleccionados : IGestorABM<BEItemsSeleccionados>, IGestorConsulta<BEItemsSeleccionados>
    {
        public BLItemsSeleccionados()
        {
            oMItemSelec = new MItemsSeleccionados();
        }

        MItemsSeleccionados oMItemSelec;

        public bool Baja(BEItemsSeleccionados Objeto)
        {
            throw new NotImplementedException();
        }

        public bool Existe(BEItemsSeleccionados obj)
        {
            throw new NotImplementedException();
        }

        public bool Guardar(BEItemsSeleccionados Objeto)
        {
            throw new NotImplementedException();
        }

        public BEItemsSeleccionados ListarObjeto(int Dni)
        {
            throw new NotImplementedException();
        }

        public List<BEItemsSeleccionados> ListarTodo()
        {
            return oMItemSelec.ListarTodo();
        }

        public bool Modificar(BEItemsSeleccionados Objeto)
        {
            return oMItemSelec.Modificar(Objeto);
        }

        public List<BEItemsSeleccionados> RecuperarPlatosMasVendidos()
        {

            return oMItemSelec.RecuperarPlatosMasVendidos();
        }

    }
}

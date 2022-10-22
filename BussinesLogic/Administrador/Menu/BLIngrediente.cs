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
    public class BLIngrediente : IGestorABM<BEIngrediente>, IGestorConsulta<BEIngrediente>
    {
        public BLIngrediente()
        {
            oMIngredientes = new MIngredientes();
        }

        MIngredientes oMIngredientes;

        public bool Baja(BEIngrediente oBEIngredientes)
        {
            return oMIngredientes.Baja(oBEIngredientes);
        }

        public bool Existe(BEIngrediente oBEIngredientes)
        {
            return oMIngredientes.Existe(oBEIngredientes);
        }

        public bool Guardar(BEIngrediente oBEIngredientes)
        {
            return oMIngredientes.Guardar(oBEIngredientes);
        }

        public BEIngrediente ListarObjeto(BEIngrediente oBEIngredientes)
        {
            throw new NotImplementedException();
        }

        public List<BEIngrediente> ListarTodo()
        {
            return oMIngredientes.ListarTodo();
        }

        public bool Modificar(BEIngrediente oBEIngredientes)
        {
            return oMIngredientes.Modificar(oBEIngredientes);
        }
    }
}

using Abstraction;
using BussinesEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapper.Administrador.Menu
{
    public class MIngredientes : IGestorABM<BEIngrediente>, IGestorConsulta<string>
    {
        public bool Baja(BEIngrediente Objeto)
        {
            throw new NotImplementedException();
        }

        public bool Existe(string obj)
        {
            throw new NotImplementedException();
        }

        public bool Guardar(BEIngrediente Objeto)
        {
            throw new NotImplementedException();
        }
        public BEIngrediente ListarObjeto(BEIngrediente Objeto)
        {
            throw new NotImplementedException();
        }
        public List<BEIngrediente> ListarTodo()
        {
            throw new NotImplementedException();
        }

        public bool Modificar(BEIngrediente Objeto)
        {
            throw new NotImplementedException();
        }
    }
}

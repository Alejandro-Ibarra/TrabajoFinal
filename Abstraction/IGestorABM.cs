using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public interface IGestorABM<T> where T : IEntityCod
    {
        bool Guardar(T Objeto);

        bool Baja(T Objeto);

        bool Modificar(T Objeto);

        List<T> ListarTodo();

        T ListarObjeto(T Objeto);
    }
}

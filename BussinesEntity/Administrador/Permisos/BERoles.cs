using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesEntity
{
    public class BERoles : BEPermisos
    {
        public List<BEPermisos> Permisos { get; set; }

        public BERoles(List<BEPermisos> permisos)
        {
            Permisos = permisos;
        }

        public BERoles()
        {
            
        }

        public BERoles(int codigo, string descripcion)
        {
            Codigo = codigo;
            Descripcion = descripcion;
        }

        public BERoles(int codigo, string descripcion, List<BEPermisos> permisos)
        {
            Codigo = codigo;
            Descripcion = descripcion;
            Permisos = permisos;
        }
    }
}

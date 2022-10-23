using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesEntity
{
    public class BERoles : BEPermisos
    {
        private List<BEPermisos> permisos = new List<BEPermisos>();

        public List<BEPermisos> Permisos
        {
            get { return permisos; }
        }
    }
}

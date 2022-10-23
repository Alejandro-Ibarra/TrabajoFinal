using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesEntity
{
    public abstract class BEPersonal : BEEntity
    {
        public int DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Turno { get; set; }
        public string Password { get; set; }
        public string Rol { get; set; }
        private List<BEPermisos> permisos { get; set; }
    }
}

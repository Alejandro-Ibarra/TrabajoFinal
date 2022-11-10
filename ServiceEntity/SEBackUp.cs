using BussinesEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ServiceEntity
{
    public class SEBackUp : BEEntity
    {

        public string Ruta { get; set; }
        public string NombreUsuario { get; set; }
        public string Tipo { get; set; }
        public string FechaHora { get; set; }
        public string NombreArchivo { get; set; }

    }
}

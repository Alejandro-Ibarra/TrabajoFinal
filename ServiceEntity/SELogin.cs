using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinesEntity;

namespace ServiceEntity
{
    public class SELogin
    {
        public int DNI { get; set; }
        public string Password { get; set; }
        public BEPersonal Personal { get; set; }
    }
}

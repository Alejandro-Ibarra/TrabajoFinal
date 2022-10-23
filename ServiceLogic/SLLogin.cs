using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mapper;
using ServiceEntity;
using Abstraction;

namespace ServiceLogic
{
    public class SLLogin 
    {
        public SLLogin ()
        {
            oMLogin = new MLogin();
        }
        MLogin oMLogin;

        public bool VerificarUsuario(SELogin oSELogin)
        {
            return oMLogin.VerificarUsuario(oSELogin);
        }
    }
}

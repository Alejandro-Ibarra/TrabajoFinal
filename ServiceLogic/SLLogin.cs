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
    public class SLLogin : IGestorConsulta<SELogin>
    {
        public SLLogin ()
        {
            oMLogin = new MLogin();
        }
        MLogin oMLogin;


        public bool Existe(SELogin oSELogin)
        {
            return oMLogin.Existe(oSELogin);
        }

        public bool VerificarUsuarioAdmin(SELogin oSELogin)
        {
            throw new NotImplementedException();
        }

        public bool VerificarUsuarioCocinero(SELogin oSELogin)
        {
            throw new NotImplementedException();
        }

        public bool VerificarUsuarioMozo(SELogin oSELogin)
        {
            throw new NotImplementedException();
        }
    }
}

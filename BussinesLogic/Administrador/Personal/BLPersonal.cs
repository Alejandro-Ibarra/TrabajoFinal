using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstraction;
using BussinesEntity;
using Mapper;

namespace BussinesLogic
{
    public class BLPersonal : IGestorABM<BEPersonal>, IGestorConsulta<int>
    {
        public BLPersonal()
        {
            oMpersonal = new MPersonal();
        }

        MPersonal oMpersonal;

        public bool Baja(BEPersonal Objeto)
        {
            return oMpersonal.Baja(Objeto);
        }

        public bool Existe(int obj)
        {
            return oMpersonal.Existe(obj);
        }

        public bool Guardar(BEPersonal Objeto)
        {
            return oMpersonal.Guardar(Objeto);
        }

        public List<BEPersonal> ListarTodo()
        {
            return oMpersonal.ListarTodo();
        }

        public bool Modificar(BEPersonal Objeto)
        {
            throw new NotImplementedException();
        }

        public BEPersonal ListarObjeto(int dni)
        {
            return oMpersonal.ListarObjeto(dni);
        }

        public List<BERoles> ListarRoles(int dni)
        {
            return oMpersonal.ListarRoles(dni);
        }

        public bool GuardarRol(BEPersonal oBEPersonal)
        {
            return oMpersonal.GuardarRol(oBEPersonal);
        }

        public bool BorrarRol(BEPersonal oBEPersonal)
        {
            return oMpersonal.BorrarRol(oBEPersonal);
        }

        public string RecuperarPass(int pass)
        {
            return oMpersonal.RecuperarPass(pass);
        }

        public string RecuperarPuesto(int dni)
        {
            return oMpersonal.RecuperarPuesto(dni);
        }
    }
}

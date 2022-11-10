using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mapper;
using Abstraction;
using ServiceEntity;

namespace ServiceLogic
{
    public class SLBackUp : IGestorABM<SEBackUp>
    {
        public SLBackUp()
        {
            oMBackup = new MBackUp();
        }
        MBackUp oMBackup;

        public bool Guardar(SEBackUp oBackup)
        {
            return oMBackup.Guardar(oBackup);
        }

        public bool Baja(SEBackUp oBackup)
        {
            throw new NotImplementedException();
        }

        public bool Modificar(SEBackUp oBackup)
        {
            throw new NotImplementedException();
        }

        public List<SEBackUp> ListarTodo()
        {
            return oMBackup.ListarTodo();
        }

        public SEBackUp ListarObjeto(int Codigo)
        {
            return oMBackup.ListarObjeto(Codigo);
        }

        public int GenerarCodigo()
        {
            return oMBackup.GenerarCodigo();
        }

        public bool HacerRestore(SEBackUp bK, SEBackUp bK2)
        {
            return oMBackup.HacerRestore(bK, bK2);
        }
    }
}

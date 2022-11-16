using Abstraction;
using BussinesEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mapper;
namespace BussinesLogic
{
    public class BLComandaCocina : IGestorABM<BEComandaCocina>, IGestorConsulta<int>
    {
        public BLComandaCocina()
        {
            oMComandaCocina = new MComandaCocina();
        }

        MComandaCocina oMComandaCocina;

        public bool Baja(BEComandaCocina Objeto)
        {
            return oMComandaCocina.Baja(Objeto);
        }

        public bool Existe(int obj)
        {
            return oMComandaCocina.Existe(obj);
        }

        public bool Guardar(BEComandaCocina Objeto)
        {
            return oMComandaCocina.Guardar(Objeto);
        }

        public BEComandaCocina ListarObjeto(int Dni)
        {
            return oMComandaCocina.ListarObjeto(Dni);
        }

        public List<BEComandaCocina> ListarTodo()
        {
            return oMComandaCocina.ListarTodo();
        }

        public bool Modificar(BEComandaCocina Objeto)
        {
            return oMComandaCocina.Modificar(Objeto);
        }
        public int GenerarCodigo()
        {
            return oMComandaCocina.GenerarCodigo();
        }
    }
}

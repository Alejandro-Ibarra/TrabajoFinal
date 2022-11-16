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
    public class BLComanda : IGestorABM<BEComanda>, IGestorConsulta<int>
    {

        public BLComanda()
        {
            oMComanda = new MComanda();
        }
        MComanda oMComanda;

        public bool Baja(BEComanda Objeto)
        {
            return oMComanda.Baja(Objeto);
        }

        public bool Existe(int obj)
        {
            return oMComanda.Existe(obj);
        }

        public bool Guardar(BEComanda Objeto)
        {
            return oMComanda.Guardar(Objeto);
        }

        public BEComanda ListarObjeto(int Dni)
        {
            return oMComanda.ListarObjeto(Dni);
        }

        public List<BEComanda> ListarTodo()
        {
            return oMComanda.ListarTodo();
        }

        public bool Modificar(BEComanda Objeto)
        {
            return oMComanda.Modificar(Objeto);
        }
        public int GenerarCodigo()
        {
            return oMComanda.GenerarCodigo();
        }
        public int GenerarCodigoPedido(int codigo)
        {
            return oMComanda.GenerarCodigoPedido(codigo);
        }

        public bool GestionarPlato(string nombre, int codigo, string estadoPlato)
        {
            return oMComanda.GestionarPlato(nombre, codigo, estadoPlato);
        }
    }
}

using Abstraction;
using BussinesEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Mapper
{
    public class MComandaMozo : IGestorABM<BEComandaMozo>, IGestorConsulta<int>
    {
        public MComandaMozo()
        {
            oMComandaMozo = new MComandaMozo();
        }

        MComandaMozo oMComandaMozo;

        public bool Baja(BEComandaMozo Objeto)
        {
            return oMComandaMozo.Baja(Objeto);
        }

        public bool Existe(int obj)
        {
            return oMComandaMozo.Existe(obj);
        }

        public bool Guardar(BEComandaMozo Objeto)
        {
            return oMComandaMozo.Guardar(Objeto);  
        }

        public BEComandaMozo ListarObjeto(int Dni)
        {
            return oMComandaMozo.ListarObjeto(Dni);
        }

        public List<BEComandaMozo> ListarTodo()
        {
            return oMComandaMozo.ListarTodo();
        }

        public bool Modificar(BEComandaMozo Objeto)
        {
            return oMComandaMozo.Modificar(Objeto);
        }

        public int GenerarCodigo()
        {
            XDocument xmlDocument = XDocument.Load("Restaurante.xml");

            var consulta = (from Ingrediente in xmlDocument.Descendants("Ingrediente")
                            select new BEIngrediente
                            {
                                Codigo = Convert.ToInt32(Ingrediente.Attribute("Codigo").Value.Trim())
                            }).ToList<BEIngrediente>();
            int aux = 0;
            foreach (BEIngrediente Ingrediente in consulta)
            {
                if (aux < Ingrediente.Codigo)
                {
                    aux = Ingrediente.Codigo;
                }
            }
            return aux + 1;
        }
    }
}

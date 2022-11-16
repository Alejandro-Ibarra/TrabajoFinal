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
    public class MComandaCocina : IGestorABM<BEComandaCocina>, IGestorConsulta<int>
    {
        public bool Baja(BEComandaCocina Objeto)
        {
            throw new NotImplementedException();
        }

        public bool Existe(int obj)
        {
            throw new NotImplementedException();
        }

        public bool Guardar(BEComandaCocina Objeto)
        {
            throw new NotImplementedException();
        }

        public BEComandaCocina ListarObjeto(int Dni)
        {
            throw new NotImplementedException();
        }

        public List<BEComandaCocina> ListarTodo()
        {
            throw new NotImplementedException();
        }

        public bool Modificar(BEComandaCocina Objeto)
        {
            throw new NotImplementedException();
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

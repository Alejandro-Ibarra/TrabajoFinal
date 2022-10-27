using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstraction;
using BussinesEntity;
using System.Xml.Linq;

namespace Mapper
{
    public class MRoles : IGestorABM<BERoles>
    {
        public bool Baja(BERoles Objeto)
        {
            throw new NotImplementedException();
        }

        public bool Guardar(BERoles Objeto)
        {
            throw new NotImplementedException();
        }

        public BERoles ListarObjeto(int Cod)
        {
            throw new NotImplementedException();
        }

        public List<BERoles> ListarTodo()
        {
            try
            {
                var consulta =
                from rol in XElement.Load("Restaurante.xml").Elements("Roles").Elements("Rol")
                select new BERoles
                {
                    Codigo = Convert.ToInt32(Convert.ToString(rol.Attribute("ID").Value).Trim()),
                    Descripcion = Convert.ToString(rol.Element("Descripcion").Value).Trim(),
                    Permisos = (from permisos in rol.Elements("Permisos").Elements("Permiso")
                                select new BEPermisos
                                        {
                                         Codigo = Convert.ToInt32(permisos.Attribute("ID").Value.Trim()),
                                         //Descripcion = (from desc in XElement.Load("Restaurante.xml").Elements("Permisos").Elements("Permiso")
                                         //              where Convert.ToInt32(permisos.Attribute("ID").Value.Trim()) == Convert.ToInt32(desc.Attribute("ID").Value.Trim())
                                         //              select Convert.ToString(desc.Elements("Descripcion").FirstOrDefault().Value.Trim())
                                         //              ).ToString()


                                        }).ToList<BEPermisos>()
                };
                List<BERoles> Lista = consulta.ToList<BERoles>();
                return Lista;
            }
            catch (System.Xml.XmlException ex)
            { throw ex; }
            catch (Exception ex)
            { throw ex; }
        }

        public bool Modificar(BERoles Objeto)
        {
            throw new NotImplementedException();
        }
    }
}

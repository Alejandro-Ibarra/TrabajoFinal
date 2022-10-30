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
    public class MPersonal : IGestorABM<BEAdmin>, IGestorConsulta<int>
    {
        public bool Baja(BEAdmin Objeto)
        {
            throw new NotImplementedException();
        }

        public bool Existe(int obj)
        {
            throw new NotImplementedException();
        }

        public bool Guardar(BEAdmin Objeto)
        {
            throw new NotImplementedException();
        }

        public BEAdmin ListarObjeto(int dni)
        {
            try
            {
                XDocument xmlDocument = XDocument.Load("Restaurante.xml");

                var consulta =
                    from Admin in xmlDocument.Descendants("Admin")
                    where Admin.Element("Dni").Value == dni.ToString()
                    select new BEAdmin
                    {
                        Codigo = Convert.ToInt32(Convert.ToString(Admin.Attribute("Codigo").Value).Trim()),
                        Nombre = Convert.ToString(Admin.Element("Nombre").Value).Trim(),
                        Apellido = Convert.ToString(Admin.Element("Apellido").Value).Trim(),
                        Password = Convert.ToString(Admin.Element("Password").Value).Trim(),
                        Turno = Convert.ToString(Admin.Element("Turno").Value).Trim(),
                        DNI = Convert.ToInt32(Convert.ToString(Admin.Element("Dni").Value).Trim()),
                        Roles = (from rol in Admin.Elements("Roles").Elements("Rol")
                                 select new BERoles
                                 {
                                    Codigo = Convert.ToInt32(Convert.ToString(rol.Attribute("ID").Value.Trim())),
                                    Permisos = (from permisos in xmlDocument.Descendants("Rol")
                                                where permisos.Attribute("ID").Value.ToString() == Convert.ToString(rol.Attribute("ID").Value.Trim())
                                                select new BEPermisos
                                                {
                                                    Codigo = Convert.ToInt32(Convert.ToString(permisos.Attribute("ID").Value.Trim())),
                                                    Descripcion = Convert.ToString(permisos.Element("Descripcion").Value).Trim(),
                                                }).ToList()
                                 }).ToList()
                    };
                BEAdmin oBEAdmin = (BEAdmin)consulta;
                return oBEAdmin;

            }
            catch (System.Xml.XmlException ex)
            { throw ex; }
            catch (Exception ex)
            { throw ex; }
        }

        public List<BERoles> ListarRoles(int dni)
        {
            try
            {
                XDocument xmlDocument = XDocument.Load("Restaurante.xml");

                var consulta =
                    from Personal in xmlDocument.Descendants("Usuarios")
                    where Personal.Attribute("Codigo").Value.ToString() == dni.ToString()
                    select new BERoles
                    {
                        Codigo = Convert.ToInt32(Convert.ToString(Personal.Attribute("Codigo").Value).Trim()),
                        Descripcion =  (from rol in xmlDocument.Descendants("Rol")
                                        where rol.Attribute("ID").Value.ToString() == Convert.ToString(Personal.Attribute("Codigo").Value).Trim()
                                        select rol.Element("Descripcion").Value).ToString()
                                        
                                
                    };
                List <BERoles> listrol = consulta.ToList();
                
                return listrol;

            }
            catch (System.Xml.XmlException ex)
            { throw ex; }
            catch (Exception ex)
            { throw ex; }
        }

        public List<BEAdmin> ListarTodo()
        {
            throw new NotImplementedException();
        }

        public bool Modificar(BEAdmin Objeto)
        {
            throw new NotImplementedException();
        }
    }
}

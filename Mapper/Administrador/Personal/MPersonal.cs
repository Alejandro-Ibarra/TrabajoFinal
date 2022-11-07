using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstraction;
using BussinesEntity;
using System.Xml.Linq;
using System.Data.Linq.SqlClient;

namespace Mapper
{
    public class MPersonal : IGestorABM<BEPersonal>, IGestorConsulta<int>
    {
        public bool Baja(BEPersonal oBEPersonal)
        {
            try
            {
                XDocument xmlDocument = XDocument.Load("Restaurante.xml");

                var consulta = xmlDocument.Descendants()
                    .Where(x => (string)x.Attribute("Codigo") == Convert.ToString(oBEPersonal.DNI))
                    .FirstOrDefault();

                consulta.Remove();
                xmlDocument.Save("Restaurante.xml");
                return true;
            }
            catch (System.Xml.XmlException ex)
            { throw ex; }
            catch (Exception ex)
            { throw ex; }
        }

        public bool Existe(int obj)
        {
            throw new NotImplementedException();
        }

        public bool Guardar(BEPersonal Objeto)
        {
            throw new NotImplementedException();
        }

        public BEPersonal ListarObjeto(int dni)
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

        public string RecuperarPass(int pass)
        {
            try
            {
                XDocument xmlDocument = XDocument.Load("Restaurante.xml");
                

                var consulta = xmlDocument.Descendants()
                    .Where(x => (string)x.Attribute("Codigo") == Convert.ToString(pass))
                    .FirstOrDefault();

               string password =  consulta.Element("Password").Value.ToString();

                return password;

            }
            catch (System.Xml.XmlException ex)
            { throw ex; }
            catch (Exception ex)
            { throw ex; }
        }

        public bool BorrarRol(BEPersonal oBEPersonal)
        {
            try
            {
                XDocument xmlDocument = XDocument.Load("Restaurante.xml");

                var consulta = xmlDocument.Descendants()
                    .Where(x => (string)x.Attribute("Codigo") == Convert.ToString(oBEPersonal.DNI))
                    .FirstOrDefault();

                var rol = consulta.Descendants().Where(x => (string)x.Attribute("ID") == Convert.ToString(oBEPersonal.Roles.FirstOrDefault().Codigo))
                            .FirstOrDefault();

                rol.Remove();
                xmlDocument.Save("Restaurante.xml");
                return true;
            }
            catch (System.Xml.XmlException ex)
            { throw ex; }
            catch (Exception ex)
            { throw ex; }
        }

        public bool GuardarRol(BEPersonal oBEPersonal)
        {
            try
            {
                XDocument xmlDocument = XDocument.Load("Restaurante.xml");

                var consulta = xmlDocument.Descendants()
                    .Where(x => (string)x.Attribute("Codigo") == Convert.ToString(oBEPersonal.DNI))
                    .FirstOrDefault();

                consulta.Element("RolesAsignados").Add(new XElement("RolAsignado",
                                                                new XAttribute("ID", oBEPersonal.Roles.Last().Codigo.ToString())));

                xmlDocument.Save("Restaurante.xml");
                return true;
            }
            catch (System.Xml.XmlException ex)
            { throw ex; }
            catch (Exception ex)
            { throw ex; }
        }

        public string RecuperarPuesto(int dni)
        {
            try
            {
                XDocument xmlDocument = XDocument.Load("Restaurante.xml");

                var consulta = xmlDocument.Descendants()
                    .Where(x => (string)x.Attribute("Codigo") == dni.ToString())
                    .FirstOrDefault();


                if (consulta.Name == "Mozo")
                {
                    return "Mozo";
                }
                else
                {
                    return "Cocinero";
                }



            }
            catch (System.Xml.XmlException ex)
            { throw ex; }
            catch (Exception ex)
            { throw ex; }
        }



        public List<BERoles> ListarRoles(int dni)
        {
            throw new NotImplementedException();
        }

        public List<BEPersonal> ListarTodo()
        {
            throw new NotImplementedException();
        }

        public bool Modificar(BEPersonal Objeto)
        {
            throw new NotImplementedException();
        }
    }
}

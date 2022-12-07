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

        public bool Existe(int dni)
        {
            try
            {
                XDocument xmlDocument = XDocument.Load("Restaurante.xml");


                var consulta = from gerente in xmlDocument.Descendants("Admin")
                               where gerente.Attribute("Codigo").Value == dni.ToString()
                               select gerente;

                if (consulta.Any())
                { return true; }
                else
                { return false; }

            }
            catch (System.Xml.XmlException ex)
            { throw ex; }
            catch (Exception ex)
            { throw ex; }
        }

        public bool Guardar(BEPersonal oBEPersonal)
        {
            try
            {
                if (Existe(oBEPersonal.DNI) == false)
                {
                    XDocument xmlDocument = XDocument.Load("Restaurante.xml");
                    xmlDocument.Element("Restaurante").Element("Usuarios").Element("Gerente").Add(new XElement("Admin",
                                                                                        new XAttribute("Codigo", oBEPersonal.DNI.ToString().Trim()),
                                                                                        new XElement("Nombre", oBEPersonal.Nombre.Trim()),
                                                                                        new XElement("Apellido", oBEPersonal.Apellido.Trim()),
                                                                                        new XElement("RolesAsignados"),
                                                                                        new XElement("Password", oBEPersonal.Password.ToString().Trim()),
                                                                                        new XElement("Turno", oBEPersonal.Turno.Trim())));


                    xmlDocument.Save("Restaurante.xml");
                    return true;
                }
                else
                { return false; }
            }
            catch (System.Xml.XmlException ex)
            { throw ex; }
            catch (Exception ex)
            { throw ex; }
        }

        public BEPersonal ListarObjeto(int dni)
        {
            try
            {
                XDocument xmlDocument = XDocument.Load("Restaurante.xml");

                var consultaRoles =
                    from rol in XElement.Load("Restaurante.xml").Elements("Roles").Elements("Rol")
                    select new BERoles
                    {
                        Codigo = Convert.ToInt32(Convert.ToString(rol.Attribute("ID").Value).Trim()),
                        Descripcion = Convert.ToString(rol.Element("Descripcion").Value).Trim(),
                        Permisos = (from permisos in rol.Elements("Permisos").Elements("PermisoAsignado")
                                    select new BEPermisos
                                    {
                                        Codigo = Convert.ToInt32(permisos.Attribute("ID").Value.Trim()),
                                        Descripcion = (from desc in XElement.Load("Restaurante.xml").Elements("Permisos").Elements("Permiso")
                                                       where (string)desc.Attribute("ID") == (string)permisos.Attribute("ID")
                                                       select desc
                                                            ).FirstOrDefault().Element("Descripcion").Value.ToString()
                                    }).ToList<BEPermisos>()
                    };

                var consulta =
                    (from Admin in XElement.Load("Restaurante.xml").Elements("Usuarios").Elements("Gerente").Elements("Admin")
                    where Admin.Attribute("Codigo").Value == dni.ToString()
                    select new BEAdmin
                    {
                        Codigo = Convert.ToInt32(Convert.ToString(Admin.Attribute("Codigo").Value).Trim()),
                        Nombre = Convert.ToString(Admin.Element("Nombre").Value).Trim(),
                        Apellido = Convert.ToString(Admin.Element("Apellido").Value).Trim(),
                        Password = Convert.ToString(Admin.Element("Password").Value).Trim(),
                        Roles = (from rol in Admin.Elements("RolesAsignados").Elements("RolAsignado")
                                 select new BERoles
                                 {
                                    Codigo = Convert.ToInt32(Convert.ToString(rol.Attribute("ID").Value.Trim())),
                                     Descripcion = (from rDesc in XElement.Load("Restaurante.xml").Elements("Roles").Elements("Rol")
                                                    where (string)rDesc.Attribute("ID") == (string)rol.Attribute("ID")
                                                    select rDesc
                                                    ).FirstOrDefault().Element("Descripcion").Value.ToString(),
                                 }).ToList<BERoles>()
                    }).ToList<BEAdmin>();

                BEAdmin oBEAdmin = consulta.FirstOrDefault();
                List<BERoles> listaRoles = consultaRoles.ToList<BERoles>();
                List<BERoles> listRolAux = new List<BERoles>();
                if (oBEAdmin != null)
                {
                    foreach (BERoles rol in listaRoles)
                    {
                        foreach (BERoles rolAd in oBEAdmin.Roles)
                        {
                            if (rol.Codigo == rolAd.Codigo)
                            {
                                listRolAux.Add(rol);
                            }
                        }
                    }
                    oBEAdmin.Roles = listRolAux;
                    return oBEAdmin;
                }else { return null; }

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
            try
            {
                var consulta =
                from Gerente in XElement.Load("Restaurante.xml").Elements("Usuarios").Elements("Gerente").Elements("Admin")
                select new BEPersonal
                {
                    DNI = Convert.ToInt32(Convert.ToString(Gerente.Attribute("Codigo").Value).Trim()),
                    Nombre = Convert.ToString(Gerente.Element("Nombre").Value).Trim(),
                    Apellido = Convert.ToString(Gerente.Element("Apellido").Value).Trim(),
                    Password = Convert.ToString(Gerente.Element("Password").Value).Trim(),
                    Turno = Convert.ToString(Gerente.Element("Turno").Value).Trim(),

                };
                List<BEPersonal> ListaGerentes = consulta.ToList<BEPersonal>();
                return ListaGerentes;
            }
            catch (System.Xml.XmlException ex)
            { throw ex; }
            catch (Exception ex)
            { throw ex; }
        }

        public bool Modificar(BEPersonal Objeto)
        {
            throw new NotImplementedException();
        }
    }
}

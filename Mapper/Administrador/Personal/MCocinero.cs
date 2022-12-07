using Abstraction;
using BussinesEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;


namespace Mapper
{
    public class MCocinero : IGestorABM<BECocinero>, IGestorConsulta<int>
    {
        public bool Baja(BECocinero oBECocinero)
        {
            try
            {
                string Cod = oBECocinero.DNI.ToString();
                XDocument xmlDocument = XDocument.Load("Restaurante.xml");

                var consulta = from Cocinero in xmlDocument.Descendants("Cocinero")
                               where Cocinero.Attribute("Codigo").Value == Cod
                               select Cocinero;

                consulta.Remove();
                xmlDocument.Save("Restaurante.xml");
                return true;
            }
            catch (System.Xml.XmlException ex)
            { throw ex; }
            catch (Exception ex)
            { throw ex; }
        }

        public bool Modificar(BECocinero oBECocinero)
        {
            try
            {
                string dni = oBECocinero.DNI.ToString();
                XDocument xmlDocument = XDocument.Load("Restaurante.xml");

                var consulta = from cocinero in xmlDocument.Descendants("Cocineros")
                               where Convert.ToString(cocinero.Element("Cocinero").Attribute("Codigo").Value) == dni.ToString()
                               select cocinero;

                foreach (XElement EModifcar in consulta)
                {
                    EModifcar.Element("Nombre").Value = oBECocinero.Nombre.Trim();
                    EModifcar.Element("Apellido").Value = oBECocinero.Apellido.Trim();
                    EModifcar.Element("Password").Value = oBECocinero.Password.ToString().Trim();
                    EModifcar.Element("Turno").Value = oBECocinero.Turno.Trim();

                }
                xmlDocument.Save("Restaurante.xml");
                return true;
            }
            catch (System.Xml.XmlException ex)
            { throw ex; }
            catch (Exception ex)
            { throw ex; }
        }

        public bool Guardar(BECocinero oBECocinero)
        {
            try
            {
                if (Existe(oBECocinero.DNI) == false)
                {
                    XDocument xmlDocument = XDocument.Load("Restaurante.xml");
                    xmlDocument.Element("Restaurante").Element("Usuarios").Element("Cocineros").Add(new XElement("Cocinero",
                                                                                        new XAttribute("Codigo", oBECocinero.DNI.ToString().Trim()),
                                                                                        new XElement("Nombre", oBECocinero.Nombre.Trim()),
                                                                                        new XElement("Apellido", oBECocinero.Apellido.Trim()),
                                                                                        new XElement("RolesAsignados"),
                                                                                        new XElement("Password", oBECocinero.Password.ToString().Trim()),
                                                                                        new XElement("Turno", oBECocinero.Turno.Trim()),
                                                                                        new XElement("Cantidad_Pedidos", oBECocinero.CantPedidos.ToString().Trim())));


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
        public BECocinero ListarObjeto(int dni)
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
                
                var consultaCocinero =
                    (from Cocinero in XElement.Load("Restaurante.xml").Elements("Usuarios").Elements("Cocineros").Elements("Cocinero")
                     where Cocinero.Attribute("Codigo").Value.ToString() == dni.ToString()
                     select new BECocinero
                     {
                         Codigo = Convert.ToInt32(Convert.ToString(Cocinero.Attribute("Codigo").Value).Trim()),
                         Nombre = Convert.ToString(Cocinero.Element("Nombre").Value).Trim(),
                         Apellido = Convert.ToString(Cocinero.Element("Apellido").Value).Trim(),
                         Password = Convert.ToString(Cocinero.Element("Password").Value).Trim(),
                         Turno = Convert.ToString(Cocinero.Element("Turno").Value).Trim(),
                         CantPedidos = Convert.ToInt32(Convert.ToString(Cocinero.Element("Cantidad_Pedidos").Value).Trim()),
                         Roles = (from rol in Cocinero.Elements("RolesAsignados").Elements("RolAsignado")
                                  select new BERoles
                                  {
                                      Codigo = Convert.ToInt32(Convert.ToString(rol.Attribute("ID").Value.Trim())),
                                      Descripcion = (from rDesc in XElement.Load("Restaurante.xml").Elements("Roles").Elements("Rol")
                                                     where (string)rDesc.Attribute("ID") == (string)rol.Attribute("ID")
                                                     select rDesc
                                                     ).FirstOrDefault().Element("Descripcion").Value.ToString(),

                                  }).ToList<BERoles>()
                     }).ToList<BECocinero>();
                BECocinero oBECocinero = consultaCocinero.FirstOrDefault();
                List<BERoles> listaRoles = consultaRoles.ToList<BERoles>();
                List<BERoles> listRolAux = new List<BERoles>();
                if (oBECocinero != null)
                {
                    foreach (BERoles rol in listaRoles)
                    {
                        foreach (BERoles rolcocinero in oBECocinero.Roles)
                        {
                            if (rol.Codigo == rolcocinero.Codigo)
                            {
                                listRolAux.Add(rol);
                            }
                        }
                    }
                    oBECocinero.Roles = listRolAux;
                    return oBECocinero;
                }
                else
                {
                    return null;
                }
            }
            catch (XmlException ex)
            { throw ex; }
            catch (Exception ex)
            { throw ex; }
        }


        public List<BECocinero> ListarTodo()
        {
            try
            {
                var consulta =
                from Cocinero in XElement.Load("Restaurante.xml").Elements("Usuarios").Elements("Cocineros").Elements("Cocinero")
                select new BECocinero
                {
                    DNI = Convert.ToInt32(Convert.ToString(Cocinero.Attribute("Codigo").Value).Trim()),
                    Nombre = Convert.ToString(Cocinero.Element("Nombre").Value).Trim(),
                    Apellido = Convert.ToString(Cocinero.Element("Apellido").Value).Trim(),
                    Password = Convert.ToString(Cocinero.Element("Password").Value).Trim(),
                    Turno = Convert.ToString(Cocinero.Element("Turno").Value).Trim(),
                    CantPedidos = Convert.ToInt32(Convert.ToString(Cocinero.Element("Cantidad_Pedidos").Value).Trim()),
                    
                };
                List<BECocinero> ListaCocineros = consulta.ToList<BECocinero>();
                return ListaCocineros;
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


                var consulta = from Cocinero in xmlDocument.Descendants("Cocinero")
                               where Cocinero.Attribute("Codigo").Value == dni.ToString()
                               select Cocinero;

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


    }
}

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
    public class MRoles : IGestorABM<BERoles>, IGestorConsulta<int>
    {
        public bool Baja(BERoles oBERole)
        {
            try
            {
                string Cod = oBERole.Codigo.ToString();
                XDocument xmlDocument = XDocument.Load("Restaurante.xml");

                var consulta = from Rol in xmlDocument.Descendants("Rol")
                               where Rol.Attribute("Codigo").Value == Cod
                               select Rol;

                consulta.Remove();
                xmlDocument.Save("Restaurante.xml");
                return true;
            }
            catch (System.Xml.XmlException ex)
            { throw ex; }
            catch (Exception ex)
            { throw ex; }
        }


        public bool Guardar(BERoles oBERoles)
        {
            try
            {
                if (Existe(oBERoles.Codigo) == false)
                {
                    XDocument xmlDocument = XDocument.Load("Restaurante.xml");
                    xmlDocument.Element("Restaurante").Element("Roles").Add(new XElement("Rol",
                                                                                        new XAttribute("ID", oBERoles.Codigo.ToString().Trim()),
                                                                                        new XElement("Descripcion", oBERoles.Descripcion.Trim()),
                                                                                        new XElement("Permisos")));
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
                List<BERoles> Lista = consulta.ToList<BERoles>();
                return Lista;
            }
            catch (System.Xml.XmlException ex)
            { throw ex; }
            catch (Exception ex)
            { throw ex; }
        }

        public bool Modificar(BERoles oBERole)
        {
            try
            {
                string ID = oBERole.Codigo.ToString();
                int aux = 0;
                int aux2 = 0;
                int aux3 = 0;
                XDocument xmlDocument = XDocument.Load("Restaurante.xml");

                var consulta = from rol in xmlDocument.Descendants("Rol")
                               where rol.Attribute("ID").Value == ID
                               select rol;


                foreach (XElement EModifcar in consulta)
                {
                    EModifcar.Element("Descripcion").Value = oBERole.Descripcion.ToString().Trim();
                    if (EModifcar.Elements("Permisos").Elements("PermisoAsignado").Count() < oBERole.Permisos.Count())
                    {
                        EModifcar.Element("Permisos").Add(new XElement("PermisoAsignado",
                                                                        new XAttribute("ID", oBERole.Permisos.Last().Codigo.ToString())));
                    }
                    else
                    {
                        List<BEPermisos> listperm = EModifcar.Elements("Permisos").Elements("PermisoAsignado").Select(perm => new BEPermisos
                        {
                            Codigo = Convert.ToInt32(perm.Attribute("ID").Value)

                        }).ToList();

                        for (int i = 0; i < oBERole.Permisos.Count; i++)
                        {
                            if (listperm[aux].Codigo != oBERole.Permisos[i].Codigo)
                            {
                                aux2 = aux;
                                break;
                            }
                            aux++;
                        }
                        foreach (var item in EModifcar.Elements("Permisos").Elements("PermisoAsignado").ToList())
                        {
                            if (aux3 == aux2)
                            {
                                item.Remove();
                            }
                            aux3++;
                        }

                    }
                }


                xmlDocument.Save("Restaurante.xml");
                return true;
            }
            catch (System.Xml.XmlException ex)
            { throw ex; }
            catch (Exception ex)
            { throw ex; }
        }
        
        public bool Existe(int ID)
        {
            try
            {
                XDocument xmlDocument = XDocument.Load("Restaurante.xml");


                var consulta = from Rol in xmlDocument.Descendants("Rol")
                               where Rol.Attribute("ID").Value == ID.ToString()
                               select Rol;

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


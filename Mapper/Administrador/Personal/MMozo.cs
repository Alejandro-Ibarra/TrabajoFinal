using Abstraction;
using BussinesEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Mapper
{
    public class MMozo : IGestorABM<BEMozo>, IGestorConsulta<int>
    {
        public bool Guardar(BEMozo oBEMozo)
        {
            try
            {
                if (Existe(oBEMozo.DNI) == false)
                {
                    string restaurante = Application.StartupPath + @"\Restaurante.xml";
                    XDocument xmlDocument = XDocument.Load(restaurante);

                    xmlDocument.Element("Restaurante").Element("Usuarios").Element("Mozos").Add(new XElement("Mozo",
                                                                                        new XAttribute("Codigo", oBEMozo.DNI.ToString().Trim()),
                                                                                        new XElement("Nombre", oBEMozo.Nombre.Trim()),
                                                                                        new XElement("Apellido", oBEMozo.Apellido.Trim()),
                                                                                        new XElement("RolesAsignados"),
                                                                                        new XElement("Password", oBEMozo.Password.ToString().Trim()),
                                                                                        new XElement("Turno", oBEMozo.Turno.Trim()),
                                                                                        new XElement("Ranking", oBEMozo.Ranking.ToString().Trim())));


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


        public bool Modificar(BEMozo oBEMozo)
        {
            try
            {
                string dni = oBEMozo.DNI.ToString();
                string restaurante = Application.StartupPath + @"\Restaurante.xml";
                XDocument xmlDocument = XDocument.Load(restaurante);


                var consulta = from mozo in xmlDocument.Descendants("Mozo")
                               where Convert.ToString(mozo.Attribute("Codigo").Value) == dni.ToString()
                               select mozo;

                foreach (XElement EModifcar in consulta)
                {
                    EModifcar.Element("Nombre").Value = oBEMozo.Nombre.Trim();
                    EModifcar.Element("Apellido").Value = oBEMozo.Apellido.Trim();
                    EModifcar.Element("Turno").Value = oBEMozo.Turno.Trim();

                }
                xmlDocument.Save("Restaurante.xml");
                return true;
            }
            catch (System.Xml.XmlException ex)
            { throw ex; }
            catch (Exception ex)
            { throw ex; }
        }

        public bool Baja(BEMozo oBEMozo)
        {
            try
            {
                string Cod = oBEMozo.DNI.ToString();
                string restaurante = Application.StartupPath + @"\Restaurante.xml";
                XDocument xmlDocument = XDocument.Load(restaurante);


                var consulta = from Mozo in xmlDocument.Descendants("Mozo")
                               where Mozo.Attribute("Codigo").Value == Cod
                               select Mozo;

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
                string restaurante = Application.StartupPath + @"\Restaurante.xml";
                XDocument xmlDocument = XDocument.Load(restaurante);



                var consulta = from Mozo in xmlDocument.Descendants("Mozo")
                               where Mozo.Attribute("Codigo").Value == dni.ToString()
                               select Mozo;

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


        public BEMozo ListarObjeto(int dni)
        {
            try
            {
                string restaurante = Application.StartupPath + @"\Restaurante.xml";
                XDocument xmlDocument = XDocument.Load(restaurante);


                var consultaRoles =
                from rol in xmlDocument.Descendants("Rol")
                select new BERoles
                {
                    Codigo = Convert.ToInt32(Convert.ToString(rol.Attribute("ID").Value).Trim()),
                    Descripcion = Convert.ToString(rol.Element("Descripcion").Value).Trim(),
                    Permisos = (from permisos in rol.Elements("Permisos").Elements("PermisoAsignado")
                                select new BEPermisos
                                {
                                    Codigo = Convert.ToInt32(permisos.Attribute("ID").Value.Trim()),
                                    Descripcion = (from desc in xmlDocument.Descendants("Permiso")
                                                   where (string)desc.Attribute("ID") == (string)permisos.Attribute("ID")
                                                   select desc
                                                        ).FirstOrDefault().Element("Descripcion").Value.ToString()
                                }).ToList<BEPermisos>()
                };
                
                var consultaMozo = 
                    (from Mozo in xmlDocument.Descendants("Mozo")
                    where Mozo.Attribute("Codigo").Value.ToString() == dni.ToString()
                    select new BEMozo
                    {
                        Codigo = Convert.ToInt32(Convert.ToString(Mozo.Attribute("Codigo").Value).Trim()),
                        Nombre = Convert.ToString(Mozo.Element("Nombre").Value).Trim(),
                        Apellido = Convert.ToString(Mozo.Element("Apellido").Value).Trim(),
                        Password = Convert.ToString(Mozo.Element("Password").Value).Trim(),
                        Turno = Convert.ToString(Mozo.Element("Turno").Value).Trim(),
                        Ranking = Convert.ToInt32(Convert.ToString(Mozo.Element("Ranking").Value).Trim()),
                        Roles = (from rol in Mozo.Elements("RolesAsignados").Elements("RolAsignado")
                                 select new BERoles    
                                 {
                                     Codigo = Convert.ToInt32(Convert.ToString(rol.Attribute("ID").Value.Trim())),
                                     Descripcion = (from rDesc in xmlDocument.Descendants("Rol")
                                                    where (string)rDesc.Attribute("ID") == (string)rol.Attribute("ID")
                                                    select rDesc
                                                    ).FirstOrDefault().Element("Descripcion").Value.ToString(),

                                 }).ToList<BERoles>()
                    }).ToList<BEMozo>();
                BEMozo oBEMozo = consultaMozo.FirstOrDefault();
                List<BERoles> listaRoles = consultaRoles.ToList<BERoles>();
                List<BERoles> listRolAux = new List<BERoles>();
                if (oBEMozo != null)
                {
                    foreach (BERoles rol in listaRoles)
                    {
                        foreach (BERoles rolMozo in oBEMozo.Roles)
                        {
                            if (rol.Codigo == rolMozo.Codigo)
                            {
                                listRolAux.Add(rol);
                            }
                        }
                    }
                    oBEMozo.Roles = listRolAux;
                    return oBEMozo;
                }
                else
                {
                    return null;
                }
                
            }
            catch (System.Xml.XmlException ex)
            { throw ex; }
            catch (Exception ex)
            { throw ex; }
        }

        private void retornarpermisos(int num)
        {

        }

        public List<BEMozo> ListarTodo()
        {
            try
            {
                string restaurante = Application.StartupPath + @"\Restaurante.xml";
                XDocument xmlDocument = XDocument.Load(restaurante);

                var consulta =
                from Mozo in xmlDocument.Descendants("Mozo")
                select new BEMozo
                {
                    DNI = Convert.ToInt32(Convert.ToString(Mozo.Attribute("Codigo").Value).Trim()),
                    Nombre = Convert.ToString(Mozo.Element("Nombre").Value).Trim(),
                    Apellido = Convert.ToString(Mozo.Element("Apellido").Value).Trim(),
                    Password = Convert.ToString(Mozo.Element("Password").Value).Trim(),
                    Turno = Convert.ToString(Mozo.Element("Turno").Value).Trim(),
                    Ranking = Convert.ToInt32(Convert.ToString(Mozo.Element("Ranking").Value).Trim()),
                };
                List<BEMozo> ListaMozos = consulta.ToList<BEMozo>();
                return ListaMozos;
            }
            catch (System.Xml.XmlException ex)
            { throw ex; }
            catch (Exception ex)
            { throw ex; }
        }

    }
}

﻿using Abstraction;
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
                string Cod = oBECocinero.Codigo.ToString();
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

                var consulta = from cocinero in xmlDocument.Descendants("Cocinero")
                               where cocinero.Element("Dni").Value == dni
                               select cocinero;

                foreach (XElement EModifcar in consulta)
                {
                    EModifcar.Element("Nombre").Value = oBECocinero.Nombre.Trim();
                    EModifcar.Element("Apellido").Value = oBECocinero.Apellido.Trim();
                    EModifcar.Element("Dni").Value = oBECocinero.DNI.ToString().Trim();
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
                    xmlDocument.Element("Restaurante").Element("Empleados").Add(new XElement("Cocineros",
                                                                                    new XElement("Cocinero",
                                                                                        new XAttribute("Codigo", oBECocinero.Codigo.ToString().Trim()),
                                                                                        new XElement("Rol", "Cocinero"),
                                                                                        new XElement("Nombre", oBECocinero.Nombre.Trim()),
                                                                                        new XElement("Apellido", oBECocinero.Apellido.Trim()),
                                                                                        new XElement("Password", oBECocinero.Password.ToString().Trim()),
                                                                                        new XElement("Turno", oBECocinero.Turno.Trim()),
                                                                                        new XElement("Cantidad_Pedidos", oBECocinero.CantPedidos.ToString().Trim()),
                                                                                        new XElement("Dni", oBECocinero.DNI.ToString().Trim()))));


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

                List<BERoles> listaRoles = new List<BERoles>();
                var consulta = 
                    from Cocinero in xmlDocument.Descendants("Cocinero")
                    where Cocinero.Element("Dni").Value == dni.ToString()
                    select new BECocinero
                    {
                        Codigo = Convert.ToInt32(Convert.ToString(Cocinero.Attribute("Codigo").Value).Trim()),
                        Nombre = Convert.ToString(Cocinero.Element("Nombre").Value).Trim(),
                        Apellido = Convert.ToString(Cocinero.Element("Apellido").Value).Trim(),
                        Password = Convert.ToString(Cocinero.Element("Password").Value).Trim(),
                        Turno = Convert.ToString(Cocinero.Element("Turno").Value).Trim(),
                        CantPedidos = Convert.ToInt32(Convert.ToString(Cocinero.Element("Cantidad_Pedidos").Value).Trim()),
                        DNI = Convert.ToInt32(Convert.ToString(Cocinero.Element("Dni").Value).Trim()),
                        Roles = (
                                from rol in Cocinero.Elements("Roles").Elements("Rol")
                                 select new BERoles
                                 {
                                 Codigo = Convert.ToInt32(Convert.ToString(rol.Attribute("ID").Value.Trim())),
                                 Permisos = (from permisos in XElement.Load("Restaurante.xml").Elements("Roles").Elements("Rol")
                                             where permisos.Attribute("ID").Value.ToString() == Convert.ToString(rol.Attribute("ID").Value.Trim())
                                             select new BEPermisos
                                             {
                                                 Codigo = Convert.ToInt32(Convert.ToString(permisos.Element("Permisos").Element("Permiso").Attribute("ID").Value.Trim())),
                                                 Descripcion = (from pDesc in XElement.Load("Restaurante.xml").Elements("Permisos").Elements("Permiso")
                                                                where (string)pDesc.Attribute("ID") == Convert.ToString(permisos.Element("Permisos").Element("Permiso").Attribute("ID").Value.Trim())
                                                                select pDesc
                                                           
                                                                )



                                             }).ToList<BEPermisos>()
                                 }).ToList<BERoles>()
                    };
                
                string pepe = "lala";
 

                BECocinero oBECocinero = (BECocinero)consulta;
                return oBECocinero; 

            }
            catch (System.Xml.XmlException ex)
            { throw ex; }
            catch (Exception ex)
            { throw ex; }
        }


        public List<BECocinero> ListarTodo()
        {
            try
            {
                var consulta =
                from Cocinero in XElement.Load("Restaurante.xml").Elements("Empleados").Elements("Cocineros").Elements("Cocinero")
                select new BECocinero
                {
                    Codigo = Convert.ToInt32(Convert.ToString(Cocinero.Attribute("Codigo").Value).Trim()),
                    Nombre = Convert.ToString(Cocinero.Element("Nombre").Value).Trim(),
                    Apellido = Convert.ToString(Cocinero.Element("Apellido").Value).Trim(),
                    Password = Convert.ToString(Cocinero.Element("Password").Value).Trim(),
                    Turno = Convert.ToString(Cocinero.Element("Turno").Value).Trim(),
                    CantPedidos = Convert.ToInt32(Convert.ToString(Cocinero.Element("Cantidad_Pedidos").Value).Trim()),
                    DNI = Convert.ToInt32(Convert.ToString(Cocinero.Element("Dni").Value).Trim()),
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
                               where Cocinero.Element("Dni").Value == dni.ToString()
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

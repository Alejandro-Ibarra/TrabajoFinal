﻿using Abstraction;
using BussinesEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace Mapper
{
    public class MCocinero : IGestorABM<BECocinero>, IGestorConsulta<int>
    {
        public bool Baja(BECocinero Objeto)
        {
            throw new NotImplementedException();
        }
        public bool Guardar(BECocinero oBECocinero)
        {
            try
            {
                ///////////////////////////////////////////////////////////////////////
                ////Ver porquye no crea o toma el archivo XML
                ///////////////////////////////////////////////////////////////////////
                if (Existe(oBECocinero.DNI) == false)
                {
                XDocument xmlDocument = XDocument.Load("Restaurante.xml");
                    xmlDocument.Element("Cocineros").Add(new XElement("Cocinero",
                                                            new XAttribute("Codigo", oBECocinero.Codigo.ToString().Trim()),
                                                            new XElement("Nombre", oBECocinero.Nombre.Trim()),
                                                            new XElement("Apellido", oBECocinero.Apellido.Trim()),
                                                            new XElement("Password", oBECocinero.Password.Trim()),
                                                            new XElement("Turno", oBECocinero.Turno.Trim()),
                                                            new XElement("Cantidad_Pedidos", oBECocinero.CantPedidos.ToString().Trim()),
                                                            new XElement("Dni", oBECocinero.DNI.ToString().Trim())));


                    xmlDocument.Save("Restaurante.XML");
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
        public BECocinero ListarObjeto(BECocinero Objeto)
        {
            throw new NotImplementedException();
        }
        public List<BECocinero> ListarTodo()
        {
            try
            {
                var consulta =
                from Cocinero in XElement.Load("Restaurante.XML").Elements("Cocinero")
                select new BECocinero
                {
                    Codigo = Convert.ToInt32(Convert.ToString(Cocinero.Attribute("Id").Value).Trim()),
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
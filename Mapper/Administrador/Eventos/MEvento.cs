using Abstraction;
using BussinesEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace Mapper
{
    public class MEvento : IGestorABM<BEEvento>, IGestorConsulta<int>
    {

        public bool Baja(BEEvento oBEEvento)
        {
            try
            {
                string Cod = oBEEvento.Codigo.ToString();
                XDocument xmlDocument = XDocument.Load("Restaurante.xml");

                var consulta = from Evento in xmlDocument.Descendants("Evento")
                               where Evento.Attribute("ID").Value == Cod
                               select Evento;

                consulta.Remove();
                xmlDocument.Save("Restaurante.xml");
                return true;
            }
            catch (System.Xml.XmlException ex)
            { throw ex; }
            catch (Exception ex)
            { throw ex; }
        }

        public int GenerarCodigo()
        {
            XDocument xmlDocument = XDocument.Load("Restaurante.xml");

            var consulta = (from Comanda in xmlDocument.Descendants("Evento")
                            select new BEComanda
                            {
                                Codigo = Convert.ToInt32(Comanda.Attribute("ID").Value.Trim())
                            }).ToList<BEComanda>();
            int aux = 0;
            foreach (BEComanda comanda in consulta)
            {
                if (aux < comanda.Codigo)
                {
                    aux = comanda.Codigo;
                }
            }
            return aux + 1;
        }

        public bool Existe(int ID)
        {
            try
            {
                XDocument xmlDocument = XDocument.Load("Restaurante.xml");


                var consulta = from evento in xmlDocument.Descendants("Evento")
                               where evento.Attribute("ID").Value.ToString() == ID.ToString()
                               select evento;

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

        public bool Guardar(BEEvento oBEEvento)
        {
            try
            {
                if (Existe(oBEEvento.Codigo) == false)
                {
                    XElement clientes = new XElement("Clientes");
                    foreach (BECliente cli in oBEEvento.ListaClientes)
                    {
                        clientes.Add(new XElement("ClienteEvento",
                                                        new XAttribute("ID", cli.Codigo.ToString().Trim()),
                                                        new XElement("Nombre", cli.Nombre.Trim()),
                                                        new XElement("Mail", cli.EMail.Trim())));

                    }


                    XDocument xmlDocument = XDocument.Load("Restaurante.xml");
                    xmlDocument.Element("Restaurante").Element("Eventos").Add(new XElement("Evento",
                                                                                new XAttribute("ID", oBEEvento.Codigo.ToString().Trim()),
                                                                                new XElement("CantidadPersonas", oBEEvento.CantPersonas.ToString().Trim()),
                                                                                new XElement("Fecha", oBEEvento.Fecha.ToString().Trim()),
                                                                                new XElement("Hora", oBEEvento.Hora.Trim()),
                                                                                clientes));
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

        public BEEvento ListarObjeto(int Objeto)
        {
            throw new NotImplementedException();
        }

        public List<BEEvento> ListarTodo()
        {
            try
            {
                var consulta =
                from Evento in XElement.Load("Restaurante.xml").Elements("Eventos").Elements("Evento")
                select new BEEvento
                {
                    Codigo = Convert.ToInt32(Convert.ToString(Evento.Attribute("ID").Value)),
                    CantPersonas = Convert.ToInt32(Evento.Element("CantidadPersonas").Value),
                    Fecha = Convert.ToString(Evento.Element("Fecha").Value),
                    Hora = Convert.ToString(Evento.Element("Hora").Value).Trim(),
                    ListaClientes = (from clientes in Evento.Elements("Clientes").Elements("ClienteEvento")
                                     select new BECliente
                                     {
                                         Codigo = Convert.ToInt32(Convert.ToString(clientes.Attribute("ID").Value)),
                                         EMail = Convert.ToString(clientes.Element("Mail").Value).Trim(),
                                         Nombre = Convert.ToString(clientes.Element("Nombre").Value).Trim()

                                     }).ToList<BECliente>()
                };
                List<BEEvento> Lista = consulta.ToList<BEEvento>();
                Lista = consulta.ToList<BEEvento>();
                return Lista;
            }
            catch (System.Xml.XmlException ex)
            { throw ex; }
            catch (Exception ex)
            { throw ex; }
        }

        public bool Modificar(BEEvento oBEEventos)
        {
            Baja(oBEEventos);
            Guardar(oBEEventos);
            return true;
            
        }
    }
}

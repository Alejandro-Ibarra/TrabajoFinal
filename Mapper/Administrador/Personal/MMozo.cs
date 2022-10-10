using Abstraction;
using BussinesEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                    XDocument xmlDocument = XDocument.Load("Restaurante.xml");
                    xmlDocument.Element("Restaurante").Add(new XElement("Mozos",
                                                            new XElement("Mozo",
                                                                new XAttribute("Codigo", oBEMozo.Codigo.ToString().Trim()),
                                                                new XElement("Nombre", oBEMozo.Nombre.Trim()),
                                                                new XElement("Apellido", oBEMozo.Apellido.Trim()),
                                                                new XElement("Password", oBEMozo.Password.ToString().Trim()),
                                                                new XElement("Turno", oBEMozo.Turno.Trim()),
                                                                new XElement("Ranking", oBEMozo.Ranking.ToString().Trim()),
                                                                new XElement("Dni", oBEMozo.DNI.ToString().Trim()))));


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
                XDocument xmlDocument = XDocument.Load("Restaurante.xml");

                var consulta = from mozo in xmlDocument.Descendants("Mozo")
                               where mozo.Element("Dni").Value == dni
                               select mozo;

                foreach (XElement EModifcar in consulta)
                {
                    EModifcar.Element("Nombre").Value = oBEMozo.Nombre.Trim();
                    EModifcar.Element("Apellido").Value = oBEMozo.Apellido.Trim();
                    EModifcar.Element("Dni").Value = oBEMozo.DNI.ToString().Trim();
                    EModifcar.Element("Password").Value = oBEMozo.Password.ToString().Trim();
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
                string Cod = oBEMozo.Codigo.ToString();
                XDocument xmlDocument = XDocument.Load("Restaurante.xml");

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
                XDocument xmlDocument = XDocument.Load("Restaurante.xml");


                var consulta = from Mozo in xmlDocument.Descendants("Mozo")
                               where Mozo.Element("Dni").Value == dni.ToString()
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


        public BEMozo ListarObjeto(BEMozo Objeto)
        {
            throw new NotImplementedException();
        }
        public List<BEMozo> ListarTodo()
        {
            try
            {
                var consulta =
                from Mozo in XElement.Load("Restaurante.xml").Elements("Mozos").Elements("Mozo")
                select new BEMozo
                {
                    Codigo = Convert.ToInt32(Convert.ToString(Mozo.Attribute("Codigo").Value).Trim()),
                    Nombre = Convert.ToString(Mozo.Element("Nombre").Value).Trim(),
                    Apellido = Convert.ToString(Mozo.Element("Apellido").Value).Trim(),
                    Password = Convert.ToString(Mozo.Element("Password").Value).Trim(),
                    Turno = Convert.ToString(Mozo.Element("Turno").Value).Trim(),
                    Ranking = Convert.ToInt32(Convert.ToString(Mozo.Element("Ranking").Value).Trim()),
                    DNI = Convert.ToInt32(Convert.ToString(Mozo.Element("Dni").Value).Trim()),
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

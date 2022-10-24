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
    public class MBebida : IGestorABM<BEBebida>, IGestorConsulta<BEBebida>
    {
        public bool Baja(BEBebida oBEBebida)
        {
            try
            {
                string Cod = oBEBebida.Codigo.ToString();
                XDocument xmlDocument = XDocument.Load("Restaurante.xml");

                var consulta = from Bebida in xmlDocument.Descendants("Bebida")
                               where Bebida.Attribute("Codigo").Value == Cod
                               select Bebida;

                consulta.Remove();
                xmlDocument.Save("Restaurante.xml");
                return true;
            }
            catch (System.Xml.XmlException ex)
            { throw ex; }
            catch (Exception ex)
            { throw ex; }
        }

        public bool Existe(BEBebida oBEBebida)
        {
            try
            {
                List<BEBebida> listaBebidas = ListarTodo();
                foreach (BEBebida bebida in listaBebidas)
                {
                    if (bebida == oBEBebida)
                    {
                        return false;
                    }
                }
                return true;
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool Guardar(BEBebida oBEBebida)
        {
            try
            {
                
                XDocument xmlDocument = XDocument.Load("Restaurante.xml");
                xmlDocument.Element("Restaurante").Element("Bebidas").Add(new XElement("Bebida",
                                                                            new XAttribute("Codigo", oBEBebida.Codigo.ToString().Trim()),
                                                                            new XElement("Nombre", oBEBebida.Nombre.Trim()),
                                                                            new XElement("Envase", oBEBebida.TipoEnvase.Trim()),
                                                                            new XElement("Marca", oBEBebida.Marca.Trim()),
                                                                            new XElement("Graduacion_Alcoholica", oBEBebida.GraduacionAlc.ToString().Trim()),
                                                                            new XElement("Stock", oBEBebida.Stock.ToString().Trim()),
                                                                            new XElement("Precio", oBEBebida.Precio.ToString().Trim())));

                xmlDocument.Save("Restaurante.xml");
                return true;
                

            }
            catch (System.Xml.XmlException ex)
            { throw ex; }
            catch (Exception ex)
            { throw ex; }
        }

        public BEBebida ListarObjeto(int Objeto)
        {
            throw new NotImplementedException();
        }

        public List<BEBebida> ListarTodo()
        {
            try
            {
                var consulta =
                from Bebida in XElement.Load("Restaurante.xml").Elements("Bebidas").Elements("Bebida")
                select new BEBebida
                {
                    Codigo = Convert.ToInt32(Convert.ToString(Bebida.Attribute("Codigo").Value).Trim()),
                    Nombre = Convert.ToString(Bebida.Element("Nombre").Value).Trim(),
                    TipoEnvase = Convert.ToString(Bebida.Element("Envase").Value).Trim(),
                    Marca = Convert.ToString(Bebida.Element("Marca").Value).Trim(),
                    GraduacionAlc = Convert.ToInt32(Convert.ToString(Bebida.Element("Graduacion_Alcoholica").Value).Trim()),
                    Stock = Convert.ToInt32(Convert.ToString(Bebida.Element("Stock").Value).Trim()),
                    Precio = Convert.ToInt32(Convert.ToString(Bebida.Element("Precio").Value).Trim()),
                };
                List<BEBebida> ListaBebidas = consulta.ToList<BEBebida>();
                return ListaBebidas;
            }
            catch (System.Xml.XmlException ex)
            { throw ex; }
            catch (Exception ex)
            { throw ex; }
        }

        public bool Modificar(BEBebida oBEBebida)
        {
            try
            {
                string Codigo = oBEBebida.Codigo.ToString();
                XDocument xmlDocument = XDocument.Load("Restaurante.xml");

                var consulta = from Bebida in xmlDocument.Descendants("Bebida")
                               where Bebida.Attribute("Codigo").Value == Codigo
                               select Bebida;

                foreach (XElement EModifcar in consulta)
                {
                    EModifcar.Element("Nombre").Value = oBEBebida.Nombre.Trim();
                    EModifcar.Element("Envase").Value = oBEBebida.TipoEnvase.Trim();
                    EModifcar.Element("Marca").Value = oBEBebida.Marca.ToString().Trim();
                    EModifcar.Element("Graduacion_Alcoholica").Value = oBEBebida.GraduacionAlc.ToString().Trim();
                    EModifcar.Element("Stock").Value = oBEBebida.Stock.ToString().Trim();
                    EModifcar.Element("Precio").Value = oBEBebida.Precio.ToString().Trim();
                }
                xmlDocument.Save("Restaurante.xml");
                return true;
            }
            catch (System.Xml.XmlException ex)
            { throw ex; }
            catch (Exception ex)
            { throw ex; }
        }
    }
}

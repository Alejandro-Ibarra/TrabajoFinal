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
    public class MExtras : IGestorABM<BEExtras>, IGestorConsulta<BEExtras>
    {
        public bool Baja(BEExtras oBEExtras)
        {
            try
            {
                string Cod = oBEExtras.Codigo.ToString();
                XDocument xmlDocument = XDocument.Load("Restaurante.xml");

                var consulta = from Extras in xmlDocument.Descendants("Extra")
                               where Extras.Attribute("Codigo").Value == Cod
                               select Extras;

                consulta.Remove();
                xmlDocument.Save("Restaurante.xml");
                return true;
            }
            catch (System.Xml.XmlException ex)
            { throw ex; }
            catch (Exception ex)
            { throw ex; }
        }

        public bool Existe(BEExtras oBEExtras)
        {
            try
            {
                List<BEExtras> listaExtras = ListarTodo();
                foreach (BEExtras Extra in listaExtras)
                {
                    if (Extra == oBEExtras)
                    {
                        return false;
                    }
                }
                return true;
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool Guardar(BEExtras oBEExtras)
        {
            try
            {

                XDocument xmlDocument = XDocument.Load("Restaurante.xml");
                xmlDocument.Element("Restaurante").Element("Extras").Add(new XElement("Extra",
                                                                                new XAttribute("Codigo", oBEExtras.Codigo.ToString().Trim()),
                                                                                new XElement("Nombre", oBEExtras.Nombre.Trim()),
                                                                                new XElement("Tipo", oBEExtras.Tipo.Trim()),
                                                                                new XElement("Stock", oBEExtras.Stock.ToString().Trim()),
                                                                                new XElement("Proveedor", oBEExtras.Proveedor.ToString().Trim())));

                xmlDocument.Save("Restaurante.xml");
                return true;


            }
            catch (System.Xml.XmlException ex)
            { throw ex; }
            catch (Exception ex)
            { throw ex; }
        }
        public BEExtras ListarObjeto(BEExtras oBEExtras)
        {
            throw new NotImplementedException();
        }
        public List<BEExtras> ListarTodo()
        {
            try
            {
                var consulta =
                from Extras in XElement.Load("Restaurante.xml").Elements("Extras").Elements("Extra")
                select new BEExtras
                {
                    Codigo = Convert.ToInt32(Convert.ToString(Extras.Attribute("Codigo").Value).Trim()),
                    Nombre = Convert.ToString(Extras.Element("Nombre").Value).Trim(),
                    Tipo = Convert.ToString(Extras.Element("Tipo").Value).Trim(),
                    Stock = Convert.ToInt32(Convert.ToString(Extras.Element("Stock").Value).Trim()),
                    Proveedor = Convert.ToString(Extras.Element("Proveedor").Value).Trim(),

                };
                List<BEExtras> ListaExtras = consulta.ToList<BEExtras>();
                return ListaExtras;
            }
            catch (System.Xml.XmlException ex)
            { throw ex; }
            catch (Exception ex)
            { throw ex; }
        }

        public bool Modificar(BEExtras oBEExtras)
        {
            try
            {
                string Codigo = oBEExtras.Codigo.ToString();
                XDocument xmlDocument = XDocument.Load("Restaurante.xml");

                var consulta = from Extra in xmlDocument.Descendants("Extra")
                               where Extra.Attribute("Codigo").Value == Codigo
                               select Extra;

                foreach (XElement EModifcar in consulta)
                {
                    EModifcar.Element("Nombre").Value = oBEExtras.Nombre.ToString().Trim();
                    EModifcar.Element("Tipo").Value = oBEExtras.Tipo.ToString().Trim();
                    EModifcar.Element("Stock").Value = oBEExtras.Stock.ToString().Trim();
                    EModifcar.Element("Proveedor").Value = oBEExtras.Proveedor.ToString().Trim();
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

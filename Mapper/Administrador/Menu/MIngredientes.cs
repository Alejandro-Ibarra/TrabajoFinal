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
    public class MIngredientes : IGestorABM<BEIngrediente>, IGestorConsulta<BEIngrediente>
    {
        public bool Baja(BEIngrediente oBEIngrediente)
        {
            try
            {
                string Cod = oBEIngrediente.Codigo.ToString();
                string restaurante = Application.StartupPath + @"\Restaurante.xml";
                XDocument xmlDocument = XDocument.Load(restaurante);


                var consplatos = from inge in xmlDocument.Descendants("IngredientePlato")
                                 where inge.Attribute("ID").Value == Cod
                                 select inge;

                if (!consplatos.Any())
                {
                    var consulta = from Ingrediente in xmlDocument.Descendants("Ingrediente")
                                   where Ingrediente.Attribute("Codigo").Value == Cod
                                   select Ingrediente;

                    consulta.Remove();
                    xmlDocument.Save("Restaurante.xml");
                    return true;
                }
                else
                {return false;}



                
                
            }
            catch (System.Xml.XmlException ex)
            { throw ex; }
            catch (Exception ex)
            { throw ex; }
        }

        public bool Existe(BEIngrediente oBEingrediente)
        {
            try
            {
                List<BEIngrediente> listaIngredientes = ListarTodo();
                foreach (BEIngrediente ingrediente in listaIngredientes)
                {
                    if (oBEingrediente.Nombre == ingrediente.Nombre && oBEingrediente.Proveedor == ingrediente.Proveedor && oBEingrediente.Refrigeracion ==ingrediente.Refrigeracion && oBEingrediente.Tipo == ingrediente.Tipo)
                    {
                        return false;
                    }
                }
                return true;
            }
            catch (Exception ex)
            { throw ex; }
        }

        public int GenerarCodigo()
        {
            try
            {
                string restaurante = Application.StartupPath + @"\Restaurante.xml";
                XDocument xmlDocument = XDocument.Load(restaurante);


                var consulta = (from Ingrediente in xmlDocument.Descendants("Ingrediente")
                                select new BEIngrediente
                                {
                                    Codigo = Convert.ToInt32(Ingrediente.Attribute("Codigo").Value.Trim())
                                }).ToList<BEIngrediente>();
                int aux = 0;
                foreach (BEIngrediente Ingrediente in consulta)
                {
                    if (aux < Ingrediente.Codigo)
                    {
                        aux = Ingrediente.Codigo;
                    }
                }
                return aux + 1;
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool Guardar(BEIngrediente oBEingrediente)
        {
            try
            {

                string restaurante = Application.StartupPath + @"\Restaurante.xml";
                XDocument xmlDocument = XDocument.Load(restaurante);

                xmlDocument.Element("Restaurante").Element("Ingredientes").Add(new XElement("Ingrediente",
                                                                                    new XAttribute("Codigo", oBEingrediente.Codigo.ToString().Trim()),
                                                                                    new XElement("Nombre", oBEingrediente.Nombre.Trim()),
                                                                                    new XElement("Tipo", oBEingrediente.Tipo.Trim()),
                                                                                    new XElement("Refrigeracion", oBEingrediente.Refrigeracion.ToString().Trim()),
                                                                                    new XElement("Stock", oBEingrediente.Stock.ToString().Trim()),
                                                                                    new XElement("Proveedor", oBEingrediente.Proveedor.ToString().Trim())));

                xmlDocument.Save("Restaurante.xml");
                return true;


            }
            catch (System.Xml.XmlException ex)
            { throw ex; }
            catch (Exception ex)
            { throw ex; }
        }

        public BEIngrediente ListarObjeto(int Objeto)
        {
            throw new NotImplementedException();
        }

        public List<BEIngrediente> ListarTodo()
        {
            try
            {
                string restaurante = Application.StartupPath + @"\Restaurante.xml";
                XDocument xmlDocument = XDocument.Load(restaurante);

                var consulta =
                from Ingrediente in xmlDocument.Descendants("Ingrediente")
                select new BEIngrediente
                {
                    Codigo = Convert.ToInt32(Convert.ToString(Ingrediente.Attribute("Codigo").Value).Trim()),
                    Nombre = Convert.ToString(Ingrediente.Element("Nombre").Value).Trim(),
                    Tipo = Convert.ToString(Ingrediente.Element("Tipo").Value).Trim(),
                    Refrigeracion = Convert.ToBoolean(Ingrediente.Element("Refrigeracion").Value),
                    Stock = Convert.ToInt32(Convert.ToString(Ingrediente.Element("Stock").Value).Trim()),
                    Proveedor = Convert.ToString(Ingrediente.Element("Proveedor").Value).Trim(),

                };
                List<BEIngrediente> ListaIngredientes = consulta.ToList<BEIngrediente>();
                return ListaIngredientes;
            }
            catch (System.Xml.XmlException ex)
            { throw ex; }
            catch (Exception ex)
            { throw ex; }
        }

        public bool Modificar(BEIngrediente oBEingrediente)
        {

            try
            {
                string Codigo = oBEingrediente.Codigo.ToString();
                string restaurante = Application.StartupPath + @"\Restaurante.xml";
                XDocument xmlDocument = XDocument.Load(restaurante);


                var consplatos = from inge in xmlDocument.Descendants("IngredientePlato")
                                 where inge.Attribute("ID").Value == Codigo
                                 select inge;

                if (!consplatos.Any())
                {
                    var consulta = from Ingrediente in xmlDocument.Descendants("Ingrediente")
                               where Ingrediente.Attribute("Codigo").Value == Codigo
                               select Ingrediente;

                    foreach (XElement EModifcar in consulta)
                    {
                        EModifcar.Element("Nombre").Value = oBEingrediente.Nombre.ToString().Trim();
                        EModifcar.Element("Tipo").Value = oBEingrediente.Tipo.ToString().Trim();
                        EModifcar.Element("Refrigeracion").Value = oBEingrediente.Refrigeracion.ToString().Trim();
                        EModifcar.Element("Stock").Value = oBEingrediente.Stock.ToString().Trim();
                        EModifcar.Element("Proveedor").Value = oBEingrediente.Proveedor.ToString().Trim();
                    }
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
    }
}

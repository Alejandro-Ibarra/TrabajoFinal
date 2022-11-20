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
    public class MPlato : IGestorABM<BEPlato>, IGestorConsulta<int>
    {
        
        public bool Baja(BEPlato oBEPlato)
        {
            try
            {
                string Cod = oBEPlato.Codigo.ToString();
                XDocument xmlDocument = XDocument.Load("Restaurante.xml");

                var consulta = from Ingrediente in xmlDocument.Descendants("Plato")
                               where Ingrediente.Attribute("ID").Value == Cod
                               select Ingrediente;

                consulta.Remove();
                xmlDocument.Save("Restaurante.xml");
                return true;
            }
            catch (System.Xml.XmlException ex)
            { throw ex; }
            catch (Exception ex)
            { throw ex; }
        }
        
        public MPlato()
        {
            oMIngredientes =  new MIngredientes();
        }

        MIngredientes oMIngredientes;


        public bool Guardar(BEPlato oBEPlato)
        {
            try
            {
                if (Existe(oBEPlato.Codigo) == false)
                {
                    XElement ingredientes = new XElement("IngredientesPlato");
                    foreach (BEIngrediente ing in oBEPlato.ListaIngredientes)
                    {
                        ingredientes.Add(new XElement("IngredientePlato",
                                                        new XAttribute("ID", ing.Codigo.ToString().Trim()),
                                                        new XElement("Nombre", ing.Nombre.Trim()),
                                                        new XElement("Tipo", ing.Tipo.Trim()),
                                                        new XElement("Refrigeracion", ing.Refrigeracion.ToString().Trim()),
                                                        new XElement("Stock", ing.Stock.ToString().Trim()),
                                                        new XElement("Proveedor", Convert.ToString(ing.Proveedor).Trim())));

                    }


                    XDocument xmlDocument = XDocument.Load("Restaurante.xml");
                    xmlDocument.Element("Restaurante").Element("Platos").Add(new XElement("Plato",
                                                                                new XAttribute("ID", oBEPlato.Codigo.ToString().Trim()),
                                                                                new XElement("Nombre", oBEPlato.Nombre.Trim()),
                                                                                new XElement("TipoPlato", oBEPlato.Tipo.Trim()),
                                                                                new XElement("Clase", oBEPlato.Clase.Trim()),
                                                                                new XElement("Descripcion", oBEPlato.Descripcion.Trim()),
                                                                                new XElement("Precio", Convert.ToString(oBEPlato.Precio).Trim()),
                                                                                new XElement("IngredientePrincipal",
                                                                                            new XAttribute("ID", oBEPlato.IngredientePrincipal.Codigo.ToString().Trim()),
                                                                                            new XElement("Nombre", oBEPlato.IngredientePrincipal.Nombre.Trim()),
                                                                                            new XElement("Tipo", oBEPlato.IngredientePrincipal.Tipo.Trim()),
                                                                                            new XElement("Refrigeracion", oBEPlato.IngredientePrincipal.Refrigeracion.ToString().Trim()),
                                                                                            new XElement("Stock", oBEPlato.IngredientePrincipal.Stock.ToString().Trim()),
                                                                                            new XElement("Proveedor", Convert.ToString(oBEPlato.IngredientePrincipal.Proveedor).Trim())),
                                                                               ingredientes));
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

        public BEPlato ListarObjeto(int Objeto)
        {
            throw new NotImplementedException();
        }

        public List<BEPlato> ListarTodo()
        {
            try
            {
                var consulta =
                from Plato in XElement.Load("Restaurante.xml").Elements("Platos").Elements("Plato")
                select new BEPlato
                {
                    Codigo = Convert.ToInt32(Convert.ToString(Plato.Attribute("ID").Value)),
                    Nombre = Convert.ToString(Plato.Element("Nombre").Value).Trim(),
                    Tipo = Convert.ToString(Plato.Element("TipoPlato").Value).Trim(),
                    Clase = Convert.ToString(Plato.Element("Clase").Value).Trim(),
                    Descripcion = Convert.ToString(Plato.Element("Descripcion").Value).Trim(),
                    Precio = Convert.ToInt32(Plato.Element("Precio").Value),
                    //Activo = Convert.ToBoolean(Plato.Element("Activo").Value),
                    IngredientePrincipal = new BEIngrediente
                    {
                        Codigo = Convert.ToInt32(Plato.Element("IngredientePrincipal").Attribute("ID").Value),
                        Nombre = Convert.ToString(Plato.Element("IngredientePrincipal").Element("Nombre").Value),
                        Tipo = Convert.ToString(Plato.Element("IngredientePrincipal").Element("Tipo").Value),
                        Refrigeracion = Convert.ToBoolean(Plato.Element("IngredientePrincipal").Element("Refrigeracion").Value),
                        Stock = Convert.ToInt32(Plato.Element("IngredientePrincipal").Attribute("Stock")),
                        Proveedor = Convert.ToString(Plato.Element("IngredientePrincipal").Element("Proveedor").Value),
                    },
                    ListaIngredientes = (from ingredientes in Plato.Elements("IngredientesPlato").Elements("IngredientePlato")
                                            select new BEIngrediente
                                            {
                                                Codigo = Convert.ToInt32(Convert.ToString(ingredientes.Attribute("ID").Value))
                                            }).ToList<BEIngrediente>()
                };
                List<BEPlato> Lista = consulta.ToList<BEPlato>();
                List<BEIngrediente> listIngredientes = oMIngredientes.ListarTodo();
                
                foreach (BEPlato plato in Lista)
                {
                    List<BEIngrediente> Listaingfinal = new List<BEIngrediente>();
                    foreach (BEIngrediente ing in plato.ListaIngredientes)
                    {
                        foreach (BEIngrediente ingaux in listIngredientes)
                        {
                            if (ing.Codigo == ingaux.Codigo)
                            {
                                Listaingfinal.Add(ingaux);
                            }
                        }
                    }
                    plato.ListaIngredientes = Listaingfinal;
                }
                return Lista;
            }
            catch (System.Xml.XmlException ex)
            { throw ex; }
            catch (Exception ex)
            { throw ex; }
        }

        public bool Modificar(BEPlato Objeto)
        {
            throw new NotImplementedException();
        }

        public bool Existe(int ID)
        {
            try
            {
                XDocument xmlDocument = XDocument.Load("Restaurante.xml");


                var consulta = from Plato in xmlDocument.Descendants("Plato")
                               where Plato.Attribute("ID").Value.ToString() == ID.ToString()
                               select Plato;

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

        public int GenerarCodigo()
        {
            XDocument xmlDocument = XDocument.Load("Restaurante.xml");

            var consulta = (from plato in xmlDocument.Descendants("Plato")
                            select new BEPlato
                            {
                                Codigo = Convert.ToInt32(plato.Attribute("ID").Value.Trim())
                            }).ToList<BEPlato>();
            int aux = 0;
            foreach (BEPlato Plato in consulta)
            {
                if (aux < Plato.Codigo)
                {
                    aux = Plato.Codigo;
                }
            }
            return aux + 1;
        }
    }
}

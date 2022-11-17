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
    public class MComanda : IGestorABM<BEComanda>, IGestorConsulta<int>
    {
        public bool Baja(BEComanda Objeto)
        {
            throw new NotImplementedException();
        }



        public bool Guardar(BEComanda oBEcomanda)
        {
            try
            {
                XDocument xmlDocument = XDocument.Load("Restaurante.xml");
                if (Existe(oBEcomanda.Codigo) == false && oBEcomanda.Comandas.Count == 0)
                {
                    
                    xmlDocument.Element("Restaurante").Element("Comandas").Add(new XElement("Comanda",
                                                                                        new XAttribute("ID", oBEcomanda.Codigo.ToString().Trim()),
                                                                                        new XElement("Mesa", oBEcomanda.NroMesa.ToString()),
                                                                                        new XElement("EstadoPrincipal", "En curso"),
                                                                                        new XElement("Cliente",
                                                                                                    new XElement("Nombre", oBEcomanda.Cliente.Nombre),
                                                                                                    new XElement("Mail", oBEcomanda.Cliente.EMail))));
                    xmlDocument.Save("Restaurante.xml");
                    return true;
                }
                else if (Existe(oBEcomanda.Codigo) == true)
                {
                    BEComanda comAux = new BEComanda();
                    var consulta = from Comanda in xmlDocument.Descendants("Comanda")
                                   where Comanda.Attribute("ID").Value == oBEcomanda.Codigo.ToString()
                                   select Comanda;

                    foreach (XElement comViejas in consulta)
                    {
                        int aux = comViejas.Elements("PedidosRealizadosCocina").Count();
                        int lala = oBEcomanda.Comandas.Count -1;
                        if (oBEcomanda.Comandas[lala] is BEComandaCocina)
                        {
                            BEComandaCocina oBEComCocAux = (BEComandaCocina)oBEcomanda.Comandas[lala];
                            XElement platos = new XElement("PlatosDeComanda");

                            foreach (BEPlato plato in oBEComCocAux.Plato )
                            {
                                platos.Add(new XElement("PlatoComandaCocina",
                                               new XAttribute("Codigo", plato.Codigo),
                                               new XElement("Estado", "Enviado_Cocina"),
                                               new XElement("CodigoComanda", plato.CodigoComanda.ToString()),
                                               new XElement("CodigoPedido", plato.CodigoPedido.ToString()),
                                               new XElement("CodigoItem", plato.CodigoItem.ToString())
                                               ));
                            }

                            comViejas.Add(new XElement("PedidosRealizadosCocina",
                                        new XAttribute("ID", oBEComCocAux.Codigo.ToString()),
                                        new XElement("Tipo", "Cocina"),
                                        new XElement("Estado", oBEComCocAux.Estado.ToString()),
                                        new XElement("FechaHoraPedido", oBEComCocAux.FechaHora.ToString()),
                                        new XElement("MontoTotal", oBEComCocAux.MontoTotal),
                                        platos
                                        ));
                        }
                        else
                        {
                            XElement bebidas = new XElement("BebidasDeComanda");
                            XElement extras = new XElement("ExtrasDeComanda");
                            BEComandaMozo oBEComMozAux = (BEComandaMozo)oBEcomanda.Comandas.Last();

                            foreach (BEBebida bebida in oBEComMozAux.bebidas)
                            {
                                bebidas.Add(new XElement("BebidasComandaMozo",
                                                new XAttribute("ID", bebida.Codigo),
                                                new XElement("Estado", "Enviado_Mozo"),
                                                new XElement("CodigoComanda", bebida.CodigoComanda.ToString()),
                                                new XElement("CodigoPedido", bebida.CodigoPedido.ToString()),
                                                new XElement("CodigoItem", bebida.CodigoItem.ToString())));
                            }

                            foreach (BEExtras extra in oBEComMozAux.extras)
                            {
                                extras.Add(new XElement("ExtrasComandaMozo",
                                                new XAttribute("ID", extra.Codigo),
                                                new XElement("CodigoComanda", extra.CodigoComanda.ToString()),
                                                new XElement("CodigoPedido", extra.CodigoPedido.ToString()),
                                                new XElement("CodigoItem", extra.CodigoItem.ToString()),
                                                new XElement("Estado", "Enviado_Mozo")));
                            }
                            if (!bebidas.IsEmpty)
                            {
                                comViejas.Add(new XElement("PedidosRealizadosBebidas",
                                        new XAttribute("ID", (aux + 1).ToString()),
                                        new XElement("Tipo", "Mozo"),
                                        new XElement("Estado", oBEComMozAux.Estado.ToString()),
                                        new XElement("FechaHoraPedido", oBEComMozAux.FechaHora.ToString()),
                                        new XElement("MontoTotal", oBEComMozAux.MontoTotal),
                                        bebidas
                                        ));
                            }
                            else
                            {
                                comViejas.Add(new XElement("PedidosRealizadosExtras",
                                        new XAttribute("ID", (aux + 1).ToString()),
                                        new XElement("Tipo", "Mozo"),
                                        new XElement("Estado", oBEComMozAux.Estado.ToString()),
                                        new XElement("FechaHoraPedido", oBEComMozAux.FechaHora.ToString()),
                                        new XElement("MontoTotal", oBEComMozAux.MontoTotal),
                                        extras
                                        ));
                            }
                            
                        }
                        
                        xmlDocument.Save("Restaurante.xml");
                    }
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

        public bool GestionarPlato(ItemsSeleccionados item)
        {
            try
            {
                XDocument xmlDocument = XDocument.Load("Restaurante.xml");
                var consultaPlato = from plato in xmlDocument.Descendants("PlatoComandaCocina")
                                     where plato.Element("CodigoComanda").Value == item.CodigoComanda.ToString() && plato.Element("CodigoPedido").Value == item.codigoPedido.ToString() && plato.Element("CodigoItem").Value == item.CodigoItem.ToString()
                                    select plato;

                var consultaBebida = from bebida in xmlDocument.Descendants("BebidasComandaMozo")
                               where bebida.Element("CodigoComanda").Value == item.CodigoComanda.ToString() && bebida.Element("CodigoPedido").Value == item.codigoPedido.ToString() && bebida.Element("CodigoItem").Value == item.CodigoItem.ToString()
                               select bebida;

                var consultaExtra = from extras in xmlDocument.Descendants("ExtrasComandaMozo")
                                     where extras.Element("CodigoComanda").Value == item.CodigoComanda.ToString() && extras.Element("CodigoPedido").Value == item.codigoPedido.ToString() && extras.Element("CodigoItem").Value == item.CodigoItem.ToString()
                                     select extras;

                if (consultaPlato.Any())
                {
                    foreach (XElement EModifcar in consultaPlato)
                    {
                        EModifcar.Element("Estado").Value = item.Estado.Trim();
                    }
                }
                else if (consultaBebida.Any())
                {
                    foreach (XElement EModifcar in consultaBebida)
                    {
                        EModifcar.Element("Estado").Value = item.Estado.Trim();
                    }
                }
                else if(consultaExtra.Any())
                {
                    foreach (XElement EModifcar in consultaExtra)
                    {
                        EModifcar.Element("Estado").Value = item.Estado.Trim();
                    }
                }
                xmlDocument.Save("Restaurante.xml");
                return true;
            }
            catch (Exception)
            {throw;}

        }



        private void SetEstadoPlato()
        {

        }

        public BEComanda ListarObjeto(int Dni)
        {
            throw new NotImplementedException();
        }

        public List<BEComanda> ListarTodo()
        {
            try
            {
                var consulta =
                from comanda in XElement.Load("Restaurante.xml").Elements("Comandas").Elements("Comanda")
                select new BEComanda
                {
                    Codigo = Convert.ToInt32(Convert.ToString(comanda.Attribute("ID").Value).Trim()),
                    NroMesa = Convert.ToInt32(comanda.Element("Mesa").Value),
                    Cliente = new BECliente
                    {
                        Nombre = comanda.Element("Cliente").Element("Nombre").Value.ToString(),
                        EMail = comanda.Element("Cliente").Element("Mail").Value.ToString()
                    },
                
                    
                
                };
                List<BEComanda> Lista = consulta.ToList<BEComanda>();

                foreach (BEComanda comanda in Lista)
                {
                    var pedidos = from com in XElement.Load("Restaurante.xml").Elements("Comandas").Elements("Comanda")
                                  where com.Attribute("ID").Value.ToString() == comanda.Codigo.ToString() && com.Element("PedidosRealizadosCocina").Value.Any()
                                  select new BEComandaCocina
                                  {
                                      Codigo = Convert.ToInt32(com.Attribute("PedidosRealizadosCocina").Value),
                                       /*from platos in XElement.Load("Restaurante.xml").Elements("Platos").Elements("Plato")
                                              where platos.Attribute("ID").Value == com.Elements("PedidosRealizadosCocina").Elements("PlatosDeComanda").Elements("PlatoComandaCocina").Attributes("ID")
                                              select new BEPlato
                                              {
                                                  
                                              }*/

                                  };


                }
                return Lista;
            }
            catch (System.Xml.XmlException ex)
            { throw ex; }
            catch (Exception ex)
            { throw ex; }
        }

        public bool Modificar(BEComanda oBEComanda)
        {
            return true;
        }

        public int GenerarCodigo()
        {
            XDocument xmlDocument = XDocument.Load("Restaurante.xml");

            var consulta = (from Comanda in xmlDocument.Descendants("Comanda")
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
        /*public int GenerarCodigoPedido(int codigo)
        {
            XDocument xmlDocument = XDocument.Load("Restaurante.xml");

            var consulta = from Pedidos in xmlDocument.Descendants("Comanda")
                            where Pedidos.Attribute("ID").Value == codigo.ToString()
                            select Pedidos;
            int aux = 0;
            foreach (XElement pedido in consulta.Elements("PedidosRealizados"))
            {
                if (Convert.ToInt32(pedido.Attribute("ID").Value) > aux)
                {
                    aux = Convert.ToInt32(pedido.Attribute("ID").Value);
                }
            }

            return aux + 1;
        }*/

        public bool Existe(int ID)
        {
            try
            {
                XDocument xmlDocument = XDocument.Load("Restaurante.xml");


                var consulta = from comanda in xmlDocument.Descendants("Comanda")
                               where comanda.Attribute("ID").Value == ID.ToString()
                               select comanda;

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

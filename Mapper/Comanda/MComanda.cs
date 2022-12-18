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
                
                string restaurante = Application.StartupPath + @"\Restaurante.xml";
                XDocument xmlDocument = XDocument.Load(restaurante);


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
                        int aux2 = comViejas.Elements("PedidosRealizadosBebidas").Count();
                        int aux3 = comViejas.Elements("PedidosRealizadosExtras").Count();
                        int auxtot = aux + aux2 + aux3;
                        int aux4 = oBEcomanda.Comandas.Count -1;
                        if (oBEcomanda.Comandas[aux4] is BEComandaCocina)
                        {
                            BEComandaCocina oBEComCocAux = (BEComandaCocina)oBEcomanda.Comandas[aux4];
                            XElement platos = new XElement("PlatosDeComanda");

                            foreach (BEPlato plato in oBEComCocAux.Plato )
                            {
                                platos.Add(new XElement("PlatoComandaCocina",
                                               new XAttribute("Codigo", plato.Codigo),
                                               new XElement("Estado", "Enviado_Cocinero"),
                                               new XElement("CodigoComanda", plato.CodigoComanda.ToString()),
                                               new XElement("CodigoPedido", plato.CodigoPedido.ToString()),
                                               new XElement("CodigoItem", plato.CodigoItem.ToString())
                                               ));
                            }

                            comViejas.Add(new XElement("PedidosRealizadosCocina",
                                        new XAttribute("ID", oBEComCocAux.Codigo.ToString()),
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
                                        new XAttribute("ID", (auxtot + 1).ToString()),
                                        new XElement("Estado", oBEComMozAux.Estado.ToString()),
                                        new XElement("FechaHoraPedido", oBEComMozAux.FechaHora.ToString()),
                                        new XElement("MontoTotal", oBEComMozAux.MontoTotal),
                                        bebidas
                                        ));
                            }
                            else
                            {
                                comViejas.Add(new XElement("PedidosRealizadosExtras",
                                        new XAttribute("ID", (auxtot + 1).ToString()),
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

        public bool GestionarPlato(BEItemsSeleccionados item)
        {
            try
            {
                string restaurante = Application.StartupPath + @"\Restaurante.xml";
                XDocument xmlDocument = XDocument.Load(restaurante);

                var consultaPlato = from plato in xmlDocument.Descendants("PlatoComandaCocina")
                                     where plato.Element("CodigoComanda").Value == item.CodigoComanda.ToString() && plato.Element("CodigoPedido").Value == item.CodigoPedido.ToString() && plato.Element("CodigoItem").Value == item.CodigoItem.ToString()
                                    select plato;

                var consultaBebida = from bebida in xmlDocument.Descendants("BebidasComandaMozo")
                               where bebida.Element("CodigoComanda").Value == item.CodigoComanda.ToString() && bebida.Element("CodigoPedido").Value == item.CodigoPedido.ToString() && bebida.Element("CodigoItem").Value == item.CodigoItem.ToString()
                               select bebida;

                var consultaExtra = from extras in xmlDocument.Descendants("ExtrasComandaMozo")
                                     where extras.Element("CodigoComanda").Value == item.CodigoComanda.ToString() && extras.Element("CodigoPedido").Value == item.CodigoPedido.ToString() && extras.Element("CodigoItem").Value == item.CodigoItem.ToString()
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


        public BEComanda ListarObjeto(int Codigo)
        {

            try
            {
                
                string restaurante = Application.StartupPath + @"\Restaurante.xml";
                XDocument xmlDocument = XDocument.Load(restaurante);



                var pedidosCocina = (from com in xmlDocument.Descendants("PedidosRealizadosCocina")
                                    where com.Element("PlatosDeComanda").Element("PlatoComandaCocina").Element("CodigoComanda").Value.ToString() == Codigo.ToString()
                                    select new BEComanda
                                    {
                                        Codigo = Convert.ToInt32(Convert.ToString(com.Attribute("ID").Value).Trim()),
                                        Estado = Convert.ToString(com.Element("Estado").Value),
                                        FechaHora = Convert.ToDateTime(com.Element("FechaHoraPedido").Value),
                                        MontoTotal = Convert.ToInt32(com.Element("MontoTotal").Value),
                                        Comandas = (from plat in com.Elements("PlatosDeComanda").Elements("PlatoComandaCocina")
                                                    select new BEComanda
                                                    {
                                                        Codigo = Convert.ToInt32(Convert.ToString(plat.Attribute("Codigo").Value).Trim()),
                                                        Estado = Convert.ToString(plat.Element("Estado").Value),
                                                        CodigoComanda = Convert.ToInt32(plat.Element("CodigoComanda").Value),
                                                        CodigoPedido = Convert.ToInt32(plat.Element("CodigoPedido").Value),
                                                        CodigoItem = Convert.ToInt32(plat.Element("CodigoItem").Value),

                                                    }).ToList<BEComanda>(),
                                    
                                    }).ToList<BEComanda>();

                var pedidosBebida = (from com in xmlDocument.Descendants("PedidosRealizadosBebidas")
                                    where com.Element("BebidasDeComanda").Element("BebidasComandaMozo").Element("CodigoComanda").Value.ToString() == Codigo.ToString()
                                    select new BEComanda
                                    {
                                        Codigo = Convert.ToInt32(Convert.ToString(com.Attribute("ID").Value).Trim()),
                                        Estado = Convert.ToString(com.Element("Estado").Value),
                                        FechaHora = Convert.ToDateTime(com.Element("FechaHoraPedido").Value),
                                        MontoTotal = Convert.ToInt32(com.Element("MontoTotal").Value),
                                        Comandas = (from plat in com.Elements("BebidasDeComanda").Elements("BebidasComandaMozo")
                                                    select new BEComanda
                                                    {
                                                        Codigo = Convert.ToInt32(Convert.ToString(plat.Attribute("ID").Value).Trim()),
                                                        Estado = Convert.ToString(plat.Element("Estado").Value),
                                                        CodigoComanda = Convert.ToInt32(plat.Element("CodigoComanda").Value),
                                                        CodigoPedido = Convert.ToInt32(plat.Element("CodigoPedido").Value),
                                                        CodigoItem = Convert.ToInt32(plat.Element("CodigoItem").Value),

                                                    }).ToList<BEComanda>(),


                                    }).ToList<BEComanda>();

                var pedidosExtras = (from com in xmlDocument.Descendants("PedidosRealizadosExtras")
                                    where com.Element("ExtrasDeComanda").Element("ExtrasComandaMozo").Element("CodigoComanda").Value.ToString() == Codigo.ToString()
                                     select new BEComanda
                                     {
                                         Codigo = Convert.ToInt32(Convert.ToString(com.Attribute("ID").Value).Trim()),
                                         Estado = Convert.ToString(com.Element("Estado").Value),
                                         FechaHora = Convert.ToDateTime(com.Element("FechaHoraPedido").Value),
                                         MontoTotal = Convert.ToInt32(com.Element("MontoTotal").Value),
                                         Comandas = (from plat in com.Elements("ExtrasDeComanda").Elements("ExtrasComandaMozo")
                                                     select new BEComanda
                                                     {
                                                         Codigo = Convert.ToInt32(Convert.ToString(plat.Attribute("ID").Value).Trim()),
                                                         Estado = Convert.ToString(plat.Element("Estado").Value),
                                                         CodigoComanda = Convert.ToInt32(plat.Element("CodigoComanda").Value),
                                                         CodigoPedido = Convert.ToInt32(plat.Element("CodigoPedido").Value),
                                                         CodigoItem = Convert.ToInt32(plat.Element("CodigoItem").Value),

                                                     }).ToList<BEComanda>(),


                                     }).ToList<BEComanda>();

                var pedidos = pedidosCocina.Concat(pedidosBebida);
                pedidos.Concat(pedidosExtras);


                List<BEPlato> lplato = new List<BEPlato>();
                MPlato mplato = new MPlato();
                lplato = mplato.ListarTodo();
                


                BEComanda comandafinal = new BEComanda();
                List<BEComanda> comandafin = new List<BEComanda>();

                foreach (BEComanda com1 in pedidos)
                {
                    BEComanda comandaaux = new BEComanda();
                    List<BEComanda> listAux = new List<BEComanda>();
                    foreach (BEComanda com2 in com1.Comandas)
                    {
                        foreach (BEPlato plat in lplato)
                        {
                            if (com2.Codigo == plat.Codigo)
                            {
                                com2.MontoTotal = com1.MontoTotal;
                                com2.Nombre = plat.Nombre;
                                listAux.Add((BEComanda)com2);
                            }
                        }
                    }
                    comandaaux.Comandas = listAux;
                    comandafin.Add(comandaaux);
                }

                var consulta =
                            from comanda in xmlDocument.Descendants("Comanda")
                            where comanda.Attribute("ID").Value == Codigo.ToString()
                            select new BEComanda
                            {
                                Codigo = Convert.ToInt32(Convert.ToString(comanda.Attribute("ID").Value).Trim()),
                                NroMesa = Convert.ToInt32(comanda.Element("Mesa").Value),
                                Estado = Convert.ToString(comanda.Element("EstadoPrincipal").Value),
                                Cliente = new BECliente
                                {
                                    Nombre = comanda.Element("Cliente").Element("Nombre").Value.ToString(),
                                    EMail = comanda.Element("Cliente").Element("Mail").Value.ToString()
                                },
                                Comandas = comandafin

                            };
                         
                BEComanda coman = consulta.FirstOrDefault(); 

                return coman;
            }
            catch (System.Xml.XmlException ex)
            { throw ex; }
            catch (Exception ex)
            { throw ex; }

        }

        public List<BEComanda> ListarTodo()
        {
            try
            {
                
                string restaurante = Application.StartupPath + @"\Restaurante.xml";
                XDocument xmlDocument = XDocument.Load(restaurante);


                var consulta =
                            from comanda in xmlDocument.Descendants("Comanda")
                            select new BEComanda
                            {
                                Codigo = Convert.ToInt32(Convert.ToString(comanda.Attribute("ID").Value).Trim()),
                                NroMesa = Convert.ToInt32(comanda.Element("Mesa").Value),
                                Estado = Convert.ToString(comanda.Element("EstadoPrincipal").Value),
                                Cliente = new BECliente
                                {
                                    Nombre = comanda.Element("Cliente").Element("Nombre").Value.ToString(),
                                    EMail = comanda.Element("Cliente").Element("Mail").Value.ToString()
                                },
                            };
                List<BEComanda> Lista = consulta.ToList<BEComanda>();

                return Lista;
            }
            catch (System.Xml.XmlException ex)
            { throw ex; }
            catch (Exception ex)
            { throw ex; }
        }

        public bool Modificar(BEComanda oBEComanda)
        {
            try
            {
                string Codigo = oBEComanda.Codigo.ToString();

                
                string restaurante = Application.StartupPath + @"\Restaurante.xml";
                XDocument xmlDocument = XDocument.Load(restaurante);


                var consulta = from comanda in xmlDocument.Descendants("Comanda")
                               where comanda.Attribute("ID").Value == Codigo
                               select comanda;

                foreach (XElement EModifcar in consulta)
                {
                    EModifcar.Element("EstadoPrincipal").Value = oBEComanda.Estado.ToString().Trim();

                }
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
            try
            {
                
                string restaurante = Application.StartupPath + @"\Restaurante.xml";
                XDocument xmlDocument = XDocument.Load(restaurante);


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
            catch (System.Xml.XmlException ex)
            { throw ex; }
            catch (Exception ex)
            { throw ex; }
        }

        public bool Existe(int ID)
        {
            try
            {
                
                string restaurante = Application.StartupPath + @"\Restaurante.xml";
                XDocument xmlDocument = XDocument.Load(restaurante);


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

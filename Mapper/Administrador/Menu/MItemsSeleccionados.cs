using Abstraction;
using BussinesEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Mapper
{
    public class MItemsSeleccionados : IGestorABM<BEItemsSeleccionados>, IGestorConsulta<BEItemsSeleccionados>
    {
        public bool Baja(BEItemsSeleccionados Objeto)
        {
            throw new NotImplementedException();
        }

        public bool Existe(BEItemsSeleccionados obj)
        {
            throw new NotImplementedException();
        }

        public bool Guardar(BEItemsSeleccionados Objeto)
        {
            throw new NotImplementedException();
        }

        public BEItemsSeleccionados ListarObjeto(int Dni)
        {
            throw new NotImplementedException();
        }

        public List<BEItemsSeleccionados> ListarTodo()
        {
            try
            {
                string restaurante = Application.StartupPath + @"\Restaurante.xml";
                XDocument xmlDocument = XDocument.Load(restaurante);


                var consultaBebida =
                from PBebidas in xmlDocument.Descendants("BebidasComandaMozo")
                select new BEItemsSeleccionados
                {
                    Codigo = Convert.ToInt32(Convert.ToString(PBebidas.Attribute("ID").Value).Trim()),
                    Nombre = (from Bebida in xmlDocument.Descendants("Bebida")
                              where Convert.ToInt32(Convert.ToString(Bebida.Attribute("Codigo").Value).Trim()) == Convert.ToInt32(Convert.ToString(PBebidas.Attribute("ID").Value).Trim())
                                 select new BEBebida
                                 {

                                     Nombre = Convert.ToString(Bebida.Element("Nombre").Value).Trim(),
 
                                 }).FirstOrDefault().Nombre,
                    Estado = Convert.ToString(PBebidas.Element("Estado").Value).Trim(),
                    CodigoItem = Convert.ToInt32(PBebidas.Element("CodigoItem").Value),
                    CodigoPedido = Convert.ToInt32(PBebidas.Element("CodigoPedido").Value),
                    CodigoComanda = Convert.ToInt32(PBebidas.Element("CodigoComanda").Value),
                };

                var consultaPlatos =
                from PBPlatos in xmlDocument.Descendants("PlatoComandaCocina")
                select new BEItemsSeleccionados
                {
                    Codigo = Convert.ToInt32(Convert.ToString(PBPlatos.Attribute("Codigo").Value).Trim()),
                    Nombre = (from plato in xmlDocument.Descendants("Plato")
                              where Convert.ToInt32(Convert.ToString(plato.Attribute("ID").Value).Trim()) == Convert.ToInt32(Convert.ToString(PBPlatos.Attribute("Codigo").Value).Trim())
                              select new BEPlato
                              {

                                  Nombre = Convert.ToString(plato.Element("Nombre").Value).Trim(),

                              }).FirstOrDefault().Nombre,
                    Estado = Convert.ToString(PBPlatos.Element("Estado").Value).Trim(),
                    CodigoItem = Convert.ToInt32(PBPlatos.Element("CodigoItem").Value),
                    CodigoPedido = Convert.ToInt32(PBPlatos.Element("CodigoPedido").Value),
                    CodigoComanda = Convert.ToInt32(PBPlatos.Element("CodigoComanda").Value),
                };

                var consultaExtras =
                from PBExtras in xmlDocument.Descendants("ExtrasComandaMozo")
                select new BEItemsSeleccionados
                {
                    Codigo = Convert.ToInt32(Convert.ToString(PBExtras.Attribute("ID").Value).Trim()),
                    Nombre = (from extras in xmlDocument.Descendants("Extra")
                              where Convert.ToInt32(Convert.ToString(extras.Attribute("Codigo").Value).Trim()) == Convert.ToInt32(Convert.ToString(PBExtras.Attribute("ID").Value).Trim())
                              select new BEPlato
                              {

                                  Nombre = Convert.ToString(extras.Element("Nombre").Value).Trim(),

                              }).FirstOrDefault().Nombre,
                    Estado = Convert.ToString(PBExtras.Element("Estado").Value).Trim(),
                    CodigoItem = Convert.ToInt32(PBExtras.Element("CodigoItem").Value),
                    CodigoPedido = Convert.ToInt32(PBExtras.Element("CodigoPedido").Value),
                    CodigoComanda = Convert.ToInt32(PBExtras.Element("CodigoComanda").Value),
                    
                    
                };


                List<BEItemsSeleccionados> ListaItems= new List<BEItemsSeleccionados>();
                ListaItems.AddRange(consultaBebida.ToList());
                ListaItems.AddRange(consultaPlatos.ToList());
                ListaItems.AddRange(consultaExtras.ToList());

                foreach (BEItemsSeleccionados item in ListaItems)
                {

                    var auxNum = from Comanda in xmlDocument.Descendants("Comanda")
                                 where item.CodigoComanda == Convert.ToInt32(Comanda.Attribute("ID").Value.ToString())
                                 select Comanda.Element("Mesa").Value.ToString();

                    item.Mesa = Convert.ToInt32(auxNum.FirstOrDefault());

                }

                return ListaItems;
            }
            catch (System.Xml.XmlException ex)
            { throw ex; }
            catch (Exception ex)
            { throw ex; }



        }

        public List<BEItemsSeleccionados> RecuperarPlatosMasVendidos()
        {
            try
            {
                string restaurante = Application.StartupPath + @"\Restaurante.xml";
                XDocument xmlDocument = XDocument.Load(restaurante);


                var consulta =
                from platos in xmlDocument.Descendants("PlatoComandaCocina")
                select new BEItemsSeleccionados
                {
                    Codigo = Convert.ToInt32(platos.Attribute("Codigo").Value)
                };


                List<BEItemsSeleccionados> ListaItems = consulta.ToList<BEItemsSeleccionados>();

                return ListaItems;
            }
            catch (System.Xml.XmlException ex)
            { throw ex; }
            catch (Exception ex)
            { throw ex; }
        }


        public List<BEItemsSeleccionados> RecuperarBebidasMasVendidas()
        {
            try
            {
                string restaurante = Application.StartupPath + @"\Restaurante.xml";
                XDocument xmlDocument = XDocument.Load(restaurante);


                var consulta =
                from bebidas in xmlDocument.Descendants("BebidasComandaMozo")
                select new BEItemsSeleccionados
                {
                    Codigo = Convert.ToInt32(bebidas.Attribute("ID").Value)
                };

                List<BEItemsSeleccionados> ListaItems = consulta.ToList<BEItemsSeleccionados>();
                return ListaItems;
            }
            catch (System.Xml.XmlException ex)
            { throw ex; }
            catch (Exception ex)
            { throw ex; }
        }

        public bool Modificar(BEItemsSeleccionados oBEItem)
        {
            try
            {
                string CodigoItem = oBEItem.CodigoItem.ToString();
                string CodigoPedido = oBEItem.CodigoPedido.ToString();
                string CodigoComanda = oBEItem.CodigoComanda.ToString();

                string restaurante = Application.StartupPath + @"\Restaurante.xml";
                XDocument xmlDocument = XDocument.Load(restaurante);


                var comanda = from com in xmlDocument.Descendants("Comanda")
                              where com.Attribute("ID").Value.ToString() == oBEItem.CodigoComanda.ToString()
                              select com;



                 var pedidococina = from ped in comanda.Descendants("PedidosRealizadosCocina")
                             where ped.Attribute("ID").Value == CodigoPedido //|| ped.Element("PedidosRealizadosBebidas").Attribute("ID").Value == CodigoPedido || ped.Element("PedidosRealizadosExtras").Attribute("ID").Value == CodigoPedido
                             select ped;

                if (pedidococina.Any())
                {
                    var item = from it in pedidococina.Descendants("PlatoComandaCocina")
                               where it.Element("CodigoItem").Value == CodigoItem
                               select it;

                    foreach (XElement EModifcar in item)
                    {
                        EModifcar.Element("Estado").Value = oBEItem.Estado.ToString().Trim();
                    }
                }
               
                var pedidobebida = from ped in comanda.Descendants("PedidosRealizadosBebidas")
                             where ped.Attribute("ID").Value == CodigoPedido //|| ped.Element("PedidosRealizadosBebidas").Attribute("ID").Value == CodigoPedido || ped.Element("PedidosRealizadosExtras").Attribute("ID").Value == CodigoPedido
                             select ped;

                if (pedidobebida.Any())
                {
                    var item = from it in pedidobebida.Descendants("BebidasComandaMozo")
                               where it.Element("CodigoItem").Value == CodigoItem
                               select it;

                    foreach (XElement EModifcar in item)
                    {
                        EModifcar.Element("Estado").Value = oBEItem.Estado.ToString().Trim();
                    }
                }

                var pedidoextra = from ped in comanda.Descendants("PedidosRealizadosExtras")
                                   where ped.Attribute("ID").Value == CodigoPedido //|| ped.Element("PedidosRealizadosBebidas").Attribute("ID").Value == CodigoPedido || ped.Element("PedidosRealizadosExtras").Attribute("ID").Value == CodigoPedido
                                   select ped;

                if (pedidoextra.Any())
                {
                    var item = from it in pedidoextra.Descendants("ExtrasComandaMozo")
                               where it.Element("CodigoItem").Value == CodigoItem
                               select it;

                    foreach (XElement EModifcar in item)
                    {
                        EModifcar.Element("Estado").Value = oBEItem.Estado.ToString().Trim();
                    }
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

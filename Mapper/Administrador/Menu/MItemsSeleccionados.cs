using Abstraction;
using BussinesEntity;
using System;
using System.Collections.Generic;
using System.Linq;
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
                XDocument xmlDocument = XDocument.Load("Restaurante.xml");
                string papapa = "kaka";


                var consultaBebida =
                from PBebidas in xmlDocument.Descendants("BebidasComandaMozo")
                select new BEItemsSeleccionados
                {
                    Codigo = Convert.ToInt32(Convert.ToString(PBebidas.Attribute("ID").Value).Trim()),
                    Nombre = (from Bebida in XElement.Load("Restaurante.xml").Elements("Bebidas").Elements("Bebida")
                              where Convert.ToInt32(Convert.ToString(Bebida.Attribute("Codigo").Value).Trim()) == Convert.ToInt32(Convert.ToString(PBebidas.Attribute("ID").Value).Trim())
                                 select new BEBebida
                                 {

                                     Nombre = Convert.ToString(Bebida.Element("Nombre").Value).Trim(),
 
                                 }).FirstOrDefault().Nombre,
                    Estado = Convert.ToString(PBebidas.Element("Estado").Value).Trim(),
                    CodigoItem = Convert.ToInt32(PBebidas.Element("CodigoItem").Value),
                    CodigoPedido = Convert.ToInt32(PBebidas.Element("CodigoPedido").Value),
                    CodigoComanda = Convert.ToInt32(PBebidas.Element("CodigoComanda").Value)
                };

                var consultaPlatos =
                from PBPlatos in xmlDocument.Descendants("PlatoComandaCocina")
                select new BEItemsSeleccionados
                {
                    Codigo = Convert.ToInt32(Convert.ToString(PBPlatos.Attribute("Codigo").Value).Trim()),
                    Nombre = (from plato in XElement.Load("Restaurante.xml").Elements("Platos").Elements("Plato")
                              where Convert.ToInt32(Convert.ToString(plato.Attribute("ID").Value).Trim()) == Convert.ToInt32(Convert.ToString(PBPlatos.Attribute("Codigo").Value).Trim())
                              select new BEPlato
                              {

                                  Nombre = Convert.ToString(plato.Element("Nombre").Value).Trim(),

                              }).FirstOrDefault().Nombre,
                    Estado = Convert.ToString(PBPlatos.Element("Estado").Value).Trim(),
                    CodigoItem = Convert.ToInt32(PBPlatos.Element("CodigoItem").Value),
                    CodigoPedido = Convert.ToInt32(PBPlatos.Element("CodigoPedido").Value),
                    CodigoComanda = Convert.ToInt32(PBPlatos.Element("CodigoComanda").Value)
                };


                var consultaExtras =
                from PBExtras in xmlDocument.Descendants("ExtrasComandaMozo")
                select new BEItemsSeleccionados
                {
                    Codigo = Convert.ToInt32(Convert.ToString(PBExtras.Attribute("ID").Value).Trim()),
                    Nombre = (from extras in XElement.Load("Restaurante.xml").Elements("Extras").Elements("Extra")
                              where Convert.ToInt32(Convert.ToString(extras.Attribute("Codigo").Value).Trim()) == Convert.ToInt32(Convert.ToString(PBExtras.Attribute("ID").Value).Trim())
                              select new BEPlato
                              {

                                  Nombre = Convert.ToString(extras.Element("Nombre").Value).Trim(),

                              }).FirstOrDefault().Nombre,
                    Estado = Convert.ToString(PBExtras.Element("Estado").Value).Trim(),
                    CodigoItem = Convert.ToInt32(PBExtras.Element("CodigoItem").Value),
                    CodigoPedido = Convert.ToInt32(PBExtras.Element("CodigoPedido").Value),
                    CodigoComanda = Convert.ToInt32(PBExtras.Element("CodigoComanda").Value)
                };


                List<BEItemsSeleccionados> ListaItems= new List<BEItemsSeleccionados>();
                ListaItems.AddRange(consultaBebida.ToList());
                ListaItems.AddRange(consultaPlatos.ToList());
                ListaItems.AddRange(consultaExtras.ToList());

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

                XDocument xmlDocument = XDocument.Load("Restaurante.xml");

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

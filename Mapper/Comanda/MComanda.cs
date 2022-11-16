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
                if (Existe(oBEcomanda.Codigo) == false && oBEcomanda.comandas.Count == 0)
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
                        int aux = comViejas.Elements("PedidosRealizados").Count();
                        if (oBEcomanda.comandas[aux] is BEComandaCocina)
                        {
                            BEComandaCocina oBEComCocAux = (BEComandaCocina)oBEcomanda.comandas[aux];
                            XElement platos = new XElement("PlatosDeComanda");

                            foreach (BEPlato plato in oBEComCocAux.oBEPlato )
                            {
                                platos.Add(new XElement("PlatoComandaCocina",
                                               new XAttribute("Codigo", plato.Codigo),
                                               new XElement("Estado", "Enviado_Cocina")
                                               ));
                            }

                            comViejas.Add(new XElement("PedidosRealizados",
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
                            BEComandaMozo oBEComMozAux = (BEComandaMozo)oBEcomanda.comandas[aux];

                            foreach (BEBebida bebida in oBEComMozAux.bebidas)
                            {
                                bebidas.Add(new XElement("BebidasComandaMozo",
                                                new XAttribute("ID", bebida.Codigo),
                                                new XElement("Estado", "Enviado_Mozo")));
                            }

                            foreach (BEExtras extra in oBEComMozAux.extras)
                            {
                                extras.Add(new XElement("ExtrasComandaMozo",
                                                new XAttribute("ID", extra.Codigo),
                                                new XElement("Estado", "Enviado_Mozo")));
                            }
                            if (!bebidas.IsEmpty)
                            {
                                comViejas.Add(new XElement("PedidosRealizados",
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
                                comViejas.Add(new XElement("PedidosRealizados",
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

        public bool GestionarPlato(string nombre, int codigo, string estadoPlato)
        {
            try
            {
                XDocument xmlDocument = XDocument.Load("Restaurante.xml");
                var consulta = from Comanda in xmlDocument.Descendants("PedidosRealizados")
                               where Comanda.Attribute("ID").Value == codigo.ToString()
                               select Comanda;

                if (estadoPlato == "Aceptado")
                {

                }
                else if (estadoPlato == "Rechazado")
                {

                }
                else
                {

                }
                return false;
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
            throw new NotImplementedException();
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
        public int GenerarCodigoPedido(int codigo)
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
        }

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

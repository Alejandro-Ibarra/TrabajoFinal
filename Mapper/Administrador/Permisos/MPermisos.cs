using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstraction;
using BussinesEntity;
using System.Xml.Linq;
using System.Windows.Forms;

namespace Mapper
{
    public class MPermisos : IGestorABM<BEPermisos>
    {
        public bool Baja(BEPermisos Objeto)
        {
            throw new NotImplementedException();
        }

        public bool Guardar(BEPermisos Objeto)
        {
            throw new NotImplementedException();
        }

        public BEPermisos ListarObjeto(int cod)
        {
            throw new NotImplementedException();
        }

        public List<BEPermisos> ListarTodo()
        {
            try
            {
                string restaurante = Application.StartupPath + @"\Restaurante.xml";
                XDocument xmlDocument = XDocument.Load(restaurante);

                var consulta =
                from Permisos in xmlDocument.Descendants("Permiso")
                select new BEPermisos
                {
                    Codigo = Convert.ToInt32(Convert.ToString(Permisos.Attribute("ID").Value).Trim()),
                    Descripcion = Convert.ToString(Permisos.Element("Descripcion").Value).Trim(),
                    
                };
                List<BEPermisos> Lista = consulta.ToList<BEPermisos>();
                return Lista;
            }
            catch (System.Xml.XmlException ex)
            { throw ex; }
            catch (Exception ex)
            { throw ex; }
        }

        public bool Modificar(BEPermisos Objeto)
        {
            throw new NotImplementedException();
        }
    }
}

using ServiceEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstraction;
using System.Xml.Linq;

namespace Mapper
{
    public class MLogin 
    {
        public bool VerificarUsuario(SELogin oSELogin)
        {
            try
            {
                XDocument xmlDocument = XDocument.Load("Restaurante.xml");

                var consulta = from Usuario in xmlDocument.Descendants("Usuarios")
                               where Usuario.Element("Dni").Value == oSELogin.DNI.ToString() && Usuario.Element("Password").Value == oSELogin.Password
                               select Usuario;

                if (consulta.Any()) {return true;}
                else { return false; }
            }
            catch (System.Xml.XmlException ex)
            { throw ex; }
            catch (Exception ex)
            { throw ex; }
        }
    }
}

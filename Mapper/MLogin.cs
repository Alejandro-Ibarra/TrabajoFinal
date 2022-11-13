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
        public bool VerificarUsuario(SELogin oSELogin, List<string> tipo)
        {
            try
            {
                XDocument xmlDocument = XDocument.Load("Restaurante.xml");
                string cod = oSELogin.DNI.ToString();

                var consulta = from Usuario in xmlDocument.Descendants(tipo[1])
                               where Usuario.Attribute("Codigo").Value ==  cod && Usuario.Element("Password").Value == oSELogin.Password
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

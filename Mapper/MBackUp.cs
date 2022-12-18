using ServiceEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstraction;
using System.IO;
using System.Data;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Mapper
{
    public class MBackUp : IGestorABM<SEBackUp>
    {
        public bool Baja(SEBackUp Objeto)
        {
            throw new NotImplementedException();
        }

        public bool Guardar(SEBackUp oSEBackup)
        {

            try
            {
                string archbackup = Application.StartupPath + @"\BackUps.xml";
                XDocument xmlDocument = XDocument.Load(archbackup);

                xmlDocument.Element("Backups").Add(new XElement("Backup",
                                                    new XAttribute("Codigo", oSEBackup.Codigo.ToString().Trim()),
                                                    new XElement("NombreArchivo", oSEBackup.NombreArchivo.Trim()),
                                                    new XElement("Tipo", oSEBackup.Tipo.Trim()),
                                                    new XElement("Ruta", oSEBackup.Ruta.Trim()),
                                                    new XElement("NombreUsuario", oSEBackup.NombreUsuario.Trim()),
                                                    new XElement("FechaHora", oSEBackup.FechaHora.Trim())));

                xmlDocument.Save(Application.StartupPath + @"\BackUps.xml");
                if (oSEBackup.Tipo == "BackUp")
                {
                    string restaurante = Application.StartupPath + @"\Restaurante.xml";
                    string backup = oSEBackup.Ruta;
                    File.Copy(restaurante, backup, true);
                    MessageBox.Show("BackUp creado con exito");
                }
                return true;
        
            }
            catch (System.Xml.XmlException ex)
            { throw ex; }
            catch (Exception ex)
            { throw ex; }
        }

        public bool HacerRestore(SEBackUp backupRecuperar, SEBackUp restore)
        {
            try
            {
                string Rutarestaurante = Application.StartupPath + @"\Restaurante.xml";
                restore.Ruta = "";
                Guardar(restore);

                File.Copy(backupRecuperar.Ruta, Rutarestaurante, true);
                MessageBox.Show("BackUp restaurado con exito");
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
                string restaurante = Application.StartupPath + @"\BackUps.xml";
                XDocument xmlDocument = XDocument.Load(restaurante);


                var consulta = (from BK in xmlDocument.Descendants("Backup")
                               select new SEBackUp 
                               { 
                                   Codigo = Convert.ToInt32(BK.Attribute("Codigo").Value.Trim())
                               }).ToList<SEBackUp>();
                int aux = 0;
                foreach (SEBackUp backup in consulta)
                {
                    if (aux < backup.Codigo)
                    {
                        aux = backup.Codigo;
                    }
                }
                return aux+1;
            }
            catch (System.Xml.XmlException ex)
            { throw ex; }
            catch (Exception ex)
            { throw ex; }
        }

        public SEBackUp ListarObjeto(int Dni)
        {
            throw new NotImplementedException();
        }

        public List<SEBackUp> ListarTodo()
        {
            try
            {
                string restaurante = Application.StartupPath + @"\BackUps.xml";
                XDocument xmlDocument = XDocument.Load(restaurante);


                var consulta =
                from Backups in xmlDocument.Elements("Backups").Elements("Backup")
                select new SEBackUp
                {
                    Codigo = Convert.ToInt32(Convert.ToString(Backups.Attribute("Codigo").Value).Trim()),
                    Ruta = Convert.ToString(Backups.Element("Ruta").Value).Trim(),
                    Tipo = Convert.ToString(Backups.Element("Tipo").Value).Trim(),
                    NombreArchivo = Convert.ToString(Backups.Element("NombreArchivo").Value).Trim(),
                    NombreUsuario = Convert.ToString(Backups.Element("NombreUsuario").Value).Trim(),
                    FechaHora = Convert.ToString(Backups.Element("FechaHora").Value).Trim(),
                };
                List<SEBackUp> Lista = consulta.ToList<SEBackUp>();
                return Lista;
            }
            catch (System.Xml.XmlException ex)
            { throw ex; }
            catch (Exception ex)
            { throw ex; }
        }

        public bool Modificar(SEBackUp Objeto)
        {
            throw new NotImplementedException();
        }
    }
}

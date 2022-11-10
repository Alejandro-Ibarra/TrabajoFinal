using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServiceLogic;
using ServiceEntity;
using BussinesEntity;
using BussinesLogic;

namespace TrabajoFinal
{
    public partial class GUI_BackUp : Form
    {
        public GUI_BackUp(int codigo)
        {
            InitializeComponent();
            oSLBackup = new SLBackUp();
            oSEBackup = new SEBackUp();
            oBEPersonal = new BEPersonal();
            oBLPersonal = new BLPersonal();
            codigoAdmin = codigo;
        }
        SLBackUp oSLBackup;
        SEBackUp oSEBackup;
        BEPersonal oBEPersonal;
        BLPersonal oBLPersonal;
        int codigoAdmin;

        private void GUI_BackUp_Load(object sender, EventArgs e)
        {
            CargarDatagrid();
            RecuperarUsuario();
        }

        private void Boton_BackUp_Click(object sender, EventArgs e)
        {
                        
            oSLBackup.Guardar(AsignarAObjetoBackup("BackUp"));
            CargarDatagrid();
        }

        private void Boton_Restore_Click(object sender, EventArgs e)
        {
            SEBackUp BK = (SEBackUp)DataGridView_BackUps.CurrentRow.DataBoundItem;
            SEBackUp restore = AsignarAObjetoBackup("restore");



            oSLBackup.HacerRestore(BK, restore);
            CargarDatagrid();

        }

        private void CargarDatagrid()
        {
            DataGridView_BackUps.DataSource = oSLBackup.ListarTodo();
        }

        private BEPersonal RecuperarUsuario()
        {
            oBEPersonal = oBLPersonal.ListarObjeto(codigoAdmin);
            return oBEPersonal;
        }

        private void AsignarAControles(SEBackUp BK)
        {
            TextBox_Cod.Text = BK.Codigo.ToString();
            TextBox_Tipo.Text = BK.Tipo;
            TextBox_Usuario.Text = BK.NombreUsuario;
            TextBox_NombArchivo.Text = BK.NombreArchivo;
            TextBox_FechHora.Text = BK.FechaHora;
            TextBox_Ruta.Text = BK.Ruta;
        }

        private SEBackUp AsignarAObjetoBackup(string tipo)
        {
            try
            {
                string fechaHora = DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss");
                SEBackUp BK = new SEBackUp();

                BK.Codigo = Convert.ToInt32(oSLBackup.GenerarCodigo());
                BK.Tipo = tipo;
                BK.FechaHora = fechaHora;
                BK.NombreArchivo = (Convert.ToString(BK.Codigo)) + "-Restaurante-BK-" + BK.FechaHora + ".xml";
                BK.NombreUsuario = RecuperarUsuario().Nombre;
                BK.Ruta = Application.StartupPath + @"\Backups\" + BK.NombreArchivo; 
                return BK;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); return null; }
        }

        private void DataGridView_BackUps_MouseClick(object sender, MouseEventArgs e)
        {
            SEBackUp BK = (SEBackUp)DataGridView_BackUps.CurrentRow.DataBoundItem;
            AsignarAControles(BK);
        }

    }
}

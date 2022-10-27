using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinesEntity;
using BussinesLogic;

namespace TrabajoFinal
{
    public partial class GUI_Admin : Form
    {
        public GUI_Admin()
        {
            InitializeComponent();
            oBERoles = new BERoles();
            oBLRoles = new BLRoles();
            oBLPermisos = new BLPermisos();
            oBEPermisos = new BEPermisos();
            CargarGrillaRoles();
        }

        BLRoles oBLRoles;
        BERoles oBERoles;
        BLPermisos oBLPermisos;
        BEPermisos oBEPermisos;

        private void GUI_Admin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void CargarGrillaRoles()
        {
            try
            {
                Grilla_Roles.DataSource = null;
                Grilla_Roles.DataSource = oBLRoles.ListarTodo();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void CargarGrillaPermisos(BERoles roles)
        {
            try
            {
                List<BERoles> listRoles = oBLRoles.ListarTodo();
                List<BEPermisos> listPermisos = new List<BEPermisos>();
                List<BEPermisos> listPermisosNo = new List<BEPermisos>();
                foreach (BERoles Rol in listRoles)
                {
                    if (roles.Codigo == Rol.Codigo)
                    {
                        foreach (BEPermisos Perm in Rol.Permisos)
                        {
                            listPermisos.Add(Perm);
                        }
                    }
                }
                listPermisosNo = PermNoAsig(listPermisos);
                Grilla_PermisosAsignados.DataSource = null;
                Grilla_PermisosAsignados.DataSource = listPermisos;
                Grilla_PermisosNoAsignados.DataSource = null;
                Grilla_PermisosNoAsignados.DataSource = listPermisosNo;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private List<BEPermisos> PermNoAsig(List<BEPermisos> listPer)
        {
            List<BEPermisos> listaAux = oBLPermisos.ListarTodo();
            List<BEPermisos> listaAux2 = oBLPermisos.ListarTodo();

            for (int i = 0; i < listPer.Count; i++)
            {
                for (int j = 0; j < listaAux.Count; j++)
                {
                    if (listPer[i].Codigo == listaAux[j].Codigo)
                    {
                        listaAux.RemoveAt(j);
                    }
                }
            }
            return listaAux;
        }


        private void Grilla_Roles_MouseClick(object sender, MouseEventArgs e)
        {

            try
            {
                oBERoles = (BERoles)Grilla_Roles.CurrentRow.DataBoundItem;
                CargarGrillaPermisos(oBERoles);

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }


    }
}

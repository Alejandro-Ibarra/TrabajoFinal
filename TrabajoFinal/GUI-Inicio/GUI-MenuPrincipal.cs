using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServiceEntity;
using BussinesEntity;
using BussinesLogic;

namespace TrabajoFinal
{
    public partial class GUI_MenuPrincipal : Form
    {
        //public int dniUsr { get; set; }

        public GUI_MenuPrincipal(BEPersonal bEPersonal)
        {
            InitializeComponent();
            oBePersonal = bEPersonal;
            AsignarControles(bEPersonal);
        }

        BEPersonal oBePersonal;

        private List<BEPermisos> RecuperarTodosPermisos(BEPersonal obEPersonal)
        {
            try
            {
                List<BEPermisos> todosPer = new List<BEPermisos>(); 
            foreach (BERoles rol in obEPersonal.Roles)
            {
                foreach (BEPermisos item in rol.Permisos)
                {
                    todosPer.Add(item);
                }
            }
            return todosPer;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); return null; }
        }

        private void AsignarControles(BEPersonal obEPersonal)
        {
            try
            {
                List<BEPermisos> perperso = RecuperarTodosPermisos(obEPersonal);
                foreach ( BEPermisos item in perperso)
                {
                    foreach (ToolStripMenuItem tool in menuStrip1.Items)
                    {
                        if (tool.Name == item.Descripcion)
                        {
                            tool.Visible = true;
                        }
                    }
                    foreach (ToolStripMenuItem tool in ToolStrip_Admin.DropDownItems)
                    {
                        if (tool.Name == item.Descripcion)
                        {
                            ToolStrip_Admin.Visible = true;
                            tool.Visible = true;
                        }
                    }
                    foreach (ToolStripMenuItem tool in ToolStrip_Menu.DropDownItems)
                    {
                        if (tool.Name == item.Descripcion)
                        {
                            ToolStrip_Menu.Visible = true;
                            tool.Visible = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message);}
        }

        private void ToolStrip_Cocinero_Click(object sender, EventArgs e)
        {
            GUI_UsrCocina oGUI_Cocina = new GUI_UsrCocina(oBePersonal);
            oGUI_Cocina.Show();
        }

        private void ToolStrip_Mozo_Click(object sender, EventArgs e)
        {
            GUI_UsrCocina oGUI_Cocina = new GUI_UsrCocina(oBePersonal);
            oGUI_Cocina.Show();

            //GUI_UsrMozo oGUI_Mozo = new GUI_UsrMozo();
            //oGUI_Mozo.Show();
        }

        private void ToolStrip_Personal_Click(object sender, EventArgs e)
        {
            GUI_Gerente_Personal oGUI_Personal = new GUI_Gerente_Personal();
            oGUI_Personal.Show();
        }

        private void ToolStrip_Ingredientes_Click(object sender, EventArgs e)
        {
            GUI_Gerente_Ingredientes oGUI_Ingredientes = new GUI_Gerente_Ingredientes();
            oGUI_Ingredientes.Show();
        }

        private void ToolStrip_Bebidas_Click(object sender, EventArgs e)
        {
            GUI_Gerente_Bebidas oGUI_Bebidas = new GUI_Gerente_Bebidas();
            oGUI_Bebidas.Show();
        }

        private void ToolStrip_Platos_Click(object sender, EventArgs e)
        {
            GUI_Gerente_Platos oGUI_Platos = new GUI_Gerente_Platos();
            oGUI_Platos.Show();
        }

        private void ToolStrip_Evento_Click(object sender, EventArgs e)
        {
            GUI_Gerente_Eventos oGUI_Eventos = new GUI_Gerente_Eventos();
            oGUI_Eventos.Show();
        }

        private void ToolStrip_Extras_Click(object sender, EventArgs e)
        {
            GUI_Gerente_Extras oGUI_Extras = new GUI_Gerente_Extras();
            oGUI_Extras.Show();
        }

        private void ToolStrip_Mesas_Click(object sender, EventArgs e)
        {
            GUI_GerenteMesas oGUI_Mesas = new GUI_GerenteMesas();
            oGUI_Mesas.Show();
        }

        private void ToolStrip_BackUp_Click(object sender, EventArgs e)
        {
            GUI_BackUp oGUI_BackUp = new GUI_BackUp(oBePersonal.Codigo);
            oGUI_BackUp.Show();
        }

        private void ToolStrip_Roles_Click(object sender, EventArgs e)
        {
            GUI_RolesPermisos oGUI_RolesPermisos = new GUI_RolesPermisos();
            oGUI_RolesPermisos.Show();
        }

        private void ToolStrip_Metricas_Click(object sender, EventArgs e)
        {
            GUI_Gerente_Metricas oGUI_RolesPermisos = new GUI_Gerente_Metricas();
            oGUI_RolesPermisos.Show();
        }

        private void ToolStrip_CerrarSesion_Click(object sender, EventArgs e)
        {
            GUI_Login oGUI_LogIn = new GUI_Login();
            this.Close();
            oGUI_LogIn.Show();
        }
    }
}

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


            oGUI_Empleados = new GUI_UsrEmpleado(oBePersonal);
            FormsConfig(oGUI_Empleados);
            this.Panel.Controls.Add(oGUI_Empleados);

            oGUI_Personal = new GUI_Gerente_Personal();
            FormsConfig(oGUI_Personal);
            this.Panel.Controls.Add(oGUI_Personal);

            oGUI_Ingredientes = new GUI_Gerente_Ingredientes();
            FormsConfig(oGUI_Ingredientes);
            this.Panel.Controls.Add(oGUI_Ingredientes);

            oGUI_Bebidas = new GUI_Gerente_Bebidas();
            FormsConfig(oGUI_Bebidas);
            this.Panel.Controls.Add(oGUI_Bebidas);

            oGUI_Platos = new GUI_Gerente_Platos();
            FormsConfig(oGUI_Platos);
            this.Panel.Controls.Add(oGUI_Platos);

            oGUI_Eventos = new GUI_Gerente_Eventos();
            FormsConfig(oGUI_Eventos);
            this.Panel.Controls.Add(oGUI_Eventos);

            oGUI_Extras = new GUI_Gerente_Extras();
            FormsConfig(oGUI_Extras);
            this.Panel.Controls.Add(oGUI_Extras);

            oGUI_Mesas = new GUI_GerenteMesas();
            FormsConfig(oGUI_Mesas);
            this.Panel.Controls.Add(oGUI_Mesas);

            oGUI_BackUp = new GUI_BackUp(oBePersonal.Codigo);
            FormsConfig(oGUI_BackUp);
            this.Panel.Controls.Add(oGUI_BackUp);

            oGUI_RolesPermisos = new GUI_RolesPermisos();
            FormsConfig(oGUI_RolesPermisos);
            this.Panel.Controls.Add(oGUI_RolesPermisos);

            oGUI_Metricas = new GUI_Gerente_Metricas();
            FormsConfig(oGUI_Metricas);
            this.Panel.Controls.Add(oGUI_Metricas);

        }


        GUI_UsrEmpleado oGUI_Empleados;

        GUI_Gerente_Personal oGUI_Personal;
        GUI_Gerente_Ingredientes oGUI_Ingredientes;
        GUI_Gerente_Bebidas oGUI_Bebidas;
        GUI_Gerente_Platos oGUI_Platos;
        GUI_Gerente_Eventos oGUI_Eventos;
        GUI_Gerente_Extras oGUI_Extras;
        GUI_GerenteMesas oGUI_Mesas;
        GUI_BackUp oGUI_BackUp;
        GUI_RolesPermisos oGUI_RolesPermisos;
        GUI_Gerente_Metricas oGUI_Metricas;

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
            oGUI_Empleados.Show();
            oGUI_Empleados.BringToFront();
        }

        private void ToolStrip_Mozo_Click(object sender, EventArgs e)
        {
            oGUI_Empleados.Show();
            oGUI_Empleados.BringToFront();
        }

        private void ToolStrip_Personal_Click(object sender, EventArgs e)
        {
            oGUI_Personal.Show();

            oGUI_Personal.BringToFront();
        }

        private void ToolStrip_Ingredientes_Click(object sender, EventArgs e)
        {
            oGUI_Ingredientes.Show();
            oGUI_Ingredientes.BringToFront();
        }

        private void ToolStrip_Bebidas_Click(object sender, EventArgs e)
        {
            oGUI_Bebidas.Show();
            oGUI_Bebidas.BringToFront();
        }

        private void ToolStrip_Platos_Click(object sender, EventArgs e)
        {
            oGUI_Platos.Show();
            oGUI_Platos.BringToFront();
        }

        private void ToolStrip_Evento_Click(object sender, EventArgs e)
        {
            oGUI_Eventos.Show();
            oGUI_Eventos.BringToFront();
        }

        private void ToolStrip_Extras_Click(object sender, EventArgs e)
        {
            oGUI_Extras.Show();
            oGUI_Extras.BringToFront();
        }

        private void ToolStrip_Mesas_Click(object sender, EventArgs e)
        {
            oGUI_Mesas.Show();
            oGUI_Mesas.BringToFront();
        }

        private void ToolStrip_BackUp_Click(object sender, EventArgs e)
        {
            oGUI_BackUp.Show();
            oGUI_BackUp.BringToFront();
        }

        private void ToolStrip_Roles_Click(object sender, EventArgs e)
        {
            oGUI_RolesPermisos.Show();
            oGUI_RolesPermisos.BringToFront();
        }

        private void ToolStrip_Metricas_Click(object sender, EventArgs e)
        {
            oGUI_Metricas.Show();
            oGUI_Metricas.BringToFront();
            //CerrarForms();
            //this.Panel.Controls.Add(oGUI_Metricas);
            //oGUI_Metricas.Show();
        }

        private void ToolStrip_CerrarSesion_Click(object sender, EventArgs e)
        {
            GUI_Inicio oGUI_Inicio = new GUI_Inicio();
            this.Close();
            oGUI_Inicio.Show();
        }

        private void FormsConfig(Form form)
        {
            form.TopLevel = false;
            form.AutoScroll = true;
            form.FormBorderStyle = FormBorderStyle.None;
           
        }



        private void CerrarForms()
        {
            foreach (Form control in this.Panel.Controls)
            {
                control.Hide();
            }
        }
    }
}

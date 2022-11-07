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
using ServiceLogic;

namespace TrabajoFinal
{
    public partial class GUI_Gerente_Personal : Form
    {
        public GUI_Gerente_Personal()
        {
            InitializeComponent();
            oBECocinero = new BECocinero();
            oBLCocinero = new BLCocinero();
            oBEMozo = new BEMozo();
            oBLMozo = new BLMozo();
            oBERoles = new BERoles();
            oBLRoles = new BLRoles();
            oBEPersonal = new BEPersonal();
            oBLPersonal = new BLPersonal();

        }

        BERoles oBERoles;
        BLRoles oBLRoles;
        BECocinero oBECocinero;
        BLCocinero oBLCocinero;
        BEMozo oBEMozo;
        BLMozo oBLMozo;
        BEPersonal oBEPersonal;
        BLPersonal oBLPersonal;

        private void GUI_Administrar_Personal_Load(object sender, EventArgs e)
        {
            CargarGrillaUsuarios();
            
        }

        private void Boton_Alta_Click(object sender, EventArgs e)
        {
            try
            {
                if (RadioButton_Cocinero.Checked)
                {
                    if (!oBLCocinero.Existe(int.Parse(UC_ValDNI.Text)))
                    {
                        if (AsignarCocinero())
                        {
                            oBECocinero.Turno = AsignarTurno();
                            oBECocinero.CantPedidos = 0;
                            oBECocinero.Password = Encriptacion.Encrypt(textBox_Pass.Text.Trim(), null);
                            oBLCocinero.Guardar(oBECocinero);
                            AsignarAControles(oBECocinero);
                        }
                        else
                        { MessageBox.Show("Ingrese los datos de forma correcta"); }
                    }
                    else
                    { MessageBox.Show("Ya existe un cocinero con ese DNI"); }

                }
                else
                {
                    if (!oBLMozo.Existe(int.Parse(UC_ValDNI.Text)))
                    {
                        if (AsignarMozo())
                        {
                            oBEMozo.Turno = AsignarTurno();
                            oBEMozo.Ranking = 0;
                            oBEMozo.Password = Encriptacion.Encrypt(textBox_Pass.Text.Trim(), null);
                            oBLMozo.Guardar(oBEMozo);
                            AsignarAControles(oBEMozo);
                        }
                    }
                }
                CargarGrillaUsuarios();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void Boton_Baja_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Respuesta;
                Respuesta = MessageBox.Show("¿Quiere continuar con la baja?", "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (Respuesta == DialogResult.Yes)
                {
                        AsignarCocinero();
                        oBLPersonal.Baja(oBECocinero);
                        LimpiarControles();

                    CargarGrillaUsuarios();
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void Boton_Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (RadioButton_Cocinero.Checked)
                {
                    if (AsignarCocinero())
                    {
                        oBECocinero.Turno = AsignarTurno();
                        oBLCocinero.Modificar(oBECocinero);
                        AsignarAControles(oBECocinero);
                    }
                    else
                    { MessageBox.Show("Ingrese los datos de forma correcta"); }
                }
                else
                {
                    if (AsignarMozo())
                    {
                        oBEMozo.Turno = AsignarTurno();
                        oBLMozo.Modificar(oBEMozo);
                        AsignarAControles(oBEMozo);
                    }
                    else
                    { MessageBox.Show("Ingrese los datos de forma correcta"); }
                }
                CargarGrillaUsuarios();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private bool AsignarCocinero()
        {
            try
            {
                if (UC_ValDNI.validar())
                {
                    oBECocinero.DNI = int.Parse(UC_ValDNI.Text);
                    if (UC_ValNomb.validar())
                    {
                        oBECocinero.Nombre = UC_ValNomb.Text;
                        if (UC_ValApe.validar())
                        {
                            oBECocinero.Apellido = UC_ValApe.Text;
                            return true;
                        }
                        else { return false; }
                    }
                    else { return false; }
                }
                else { return false; }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); return false; }
        }

        private bool AsignarMozo()
        {
            try
            {
                if (UC_ValDNI.validar() && UC_ValDNI.Text != "")
                {
                    oBEMozo.DNI = int.Parse(UC_ValDNI.Text);
                    if (UC_ValNomb.validar() && UC_ValNomb.Text != "")
                    {
                        oBEMozo.Nombre = UC_ValNomb.Text;
                        if (UC_ValApe.validar() && UC_ValApe.Text != "")
                        {
                            oBEMozo.Apellido = UC_ValApe.Text;
                            return true;
                        }
                        else { return false; }
                    }
                    else { return false; }
                }
                else { return false; }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); return false; }
        }

        private string AsignarTurno()
        {
            if (RadioButton_Mañana.Checked)
            {return "Mañana";}
            else if (RadioButton_Tarde.Checked)
            {return "Tarde";}
            else
            {return "Noche";}

        }

        void AsignarAControles(BEPersonal oBEpersonal)
        {
            try
            {
                UC_ValApe.Text = oBEpersonal.Apellido;
                UC_ValNomb.Text = oBEpersonal.Nombre;
                UC_ValDNI.Text = oBEpersonal.DNI.ToString();

                if (oBEpersonal.Turno == "Mañana") { RadioButton_Mañana.Checked = true;}
                else if (oBEpersonal.Turno == "Tarde") { RadioButton_Tarde.Checked = true;}
                else { RadioButton_Noche.Checked = true;}

                if (oBEPersonal is BECocinero) { RadioButton_Cocinero.Checked = true; }
                else { RadioButton_Mozo.Checked = true; }

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        void LimpiarControles()
        {
            try
            {
                foreach (TextBox oTextbox in this.Controls.OfType<TextBox>())
                {
                    oTextbox.Text = null;
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        void CargarGrillaUsuarios()
        {
            List<BEPersonal> listPersonal = new List<BEPersonal>();
            List<BECocinero> listCocineros = oBLCocinero.ListarTodo();
            List<BEMozo> listMozo = oBLMozo.ListarTodo();

            foreach (BECocinero coci in listCocineros)
            {
                listPersonal.Add((BEPersonal)coci);
            }
            foreach (BEMozo mozo in listMozo)
            {
                listPersonal.Add((BEMozo)mozo);
            }
            Grilla_Usuarios.DataSource = listPersonal;
        }

        private void Grilla_Usuarios_MouseClick(object sender, MouseEventArgs e)
        {
            BEPersonal Personal = (BEPersonal)Grilla_Usuarios.CurrentRow.DataBoundItem;
            AsignarAControles(Personal);
            RecuperarPuesto(Personal.DNI);
            LlenarGrillasRoles(Personal);
            LlenarTreeWiev(Personal.Roles);
            textBox_Pass.UseSystemPasswordChar = true;
        }

        private void RecuperarPuesto(int dni)
        {
            string puesto = oBLPersonal.RecuperarPuesto(dni);
            if (puesto == "Mozo")
            {
                RadioButton_Mozo.Checked = true;
            }
            else
            {
                RadioButton_Cocinero.Checked = true;
            }
        }

        private void LlenarGrillasRoles(BEPersonal Personal)
        {
            BECocinero Cook = oBLCocinero.ListarObjeto(Personal.DNI);
            BEMozo mozo = oBLMozo.ListarObjeto(Personal.DNI);


            if (!(Cook is null))
            {
                Grilla_RolesAsignados.DataSource = Cook.Roles;
                SeleccionarRolesNoAsignados(Cook.Roles);
            }
            else
            {
                Grilla_RolesAsignados.DataSource = mozo.Roles;
                SeleccionarRolesNoAsignados(mozo.Roles);
            }
        }



        private void SeleccionarRolesNoAsignados(List<BERoles> Cook)
        {
            List<BERoles> listRoles = oBLRoles.ListarTodo();
            foreach (BERoles rol in Cook)
            {
                for (int i = listRoles.Count -1 ; i >= 0 ; i--)
                {
                    if (rol.Codigo == listRoles[i].Codigo)
                    {
                        listRoles.RemoveAt(i);
                    }
                }
            }
            Grilla_RolesNoAsignados.DataSource = listRoles;
        }

        private void Boton_Agregar_Click(object sender, EventArgs e)
        {
            AgregarRol();
        }

        private void Boton_Quitar_Click(object sender, EventArgs e)
        {
            QuitarRol();
        }

        private void LlenarTreeWiev(List<BERoles> listRoles)
        {
            listRoles.OrderBy(r => r.Codigo).ToList();
            var nodoSuperior = new TreeNode("Select all");
            treeView1.Nodes.Add(nodoSuperior);
            string currentGroup = listRoles.First().Codigo.ToString();
            var treeNodes = new List<TreeNode>();
            var childNodes = new List<TreeNode>();
            foreach (BERoles obj in listRoles)
            {
                if (currentGroup == obj.Codigo.ToString())
                    childNodes.Add(new TreeNode(obj.Descripcion));
                else
                {
                    if (childNodes.Count > 0)
                    {
                        treeNodes.Add(new TreeNode(currentGroup, childNodes.ToArray()));
                        childNodes = new List<TreeNode>();
                    }
                    childNodes.Add(new TreeNode(obj.Descripcion));
                    currentGroup = obj.Codigo.ToString();
                }
            }
            if (childNodes.Count > 0)
            {
                treeNodes.Add(new TreeNode(currentGroup, childNodes.ToArray()));
            }
            treeView1.Nodes[0].Nodes.AddRange(treeNodes.ToArray());
        }

        private void AgregarRol()
        {
 
            oBERoles = (BERoles)Grilla_RolesNoAsignados.CurrentRow.DataBoundItem;
            oBEPersonal = (BEPersonal)Grilla_Usuarios.CurrentRow.DataBoundItem;
            List<BERoles> rolesAsignados = new List<BERoles>();
            rolesAsignados.Add(oBERoles);
            oBEPersonal.Roles = rolesAsignados;
            oBLPersonal.GuardarRol(oBEPersonal);
            LlenarGrillasRoles(oBEPersonal);
        }

        private void QuitarRol()
        {
            oBERoles = (BERoles)Grilla_RolesAsignados.CurrentRow.DataBoundItem;
            oBEPersonal = (BEPersonal)Grilla_Usuarios.CurrentRow.DataBoundItem;
            List<BERoles> rolesAsignados = new List<BERoles>();
            rolesAsignados.Add(oBERoles);
            oBEPersonal.Roles = rolesAsignados;
            oBLPersonal.BorrarRol(oBEPersonal);
            LlenarGrillasRoles(oBEPersonal);
        }

        private void Boton_MostrarPsw_Click(object sender, EventArgs e)
        {
            oBEPersonal = (BEPersonal)Grilla_Usuarios.CurrentRow.DataBoundItem;
            string passEnc = oBLPersonal.RecuperarPass(oBEPersonal.DNI);
            textBox_Pass.UseSystemPasswordChar = false;
            textBox_Pass.Text = Encriptacion.Decrypt(passEnc, null);
        }
    }
}

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
                 if (!oBLCocinero.Existe(int.Parse(UC_ValDNI.Text)))
                    {
                        if (AsignarCocinero())
                        {
                            oBECocinero.Turno = AsignarTurno();
                            oBECocinero.CantPedidos = 0;
                            oBECocinero.Password = Encriptacion.Encrypt(textBox_Pass.Text.Trim(), null);
                            oBLCocinero.Guardar(oBECocinero);
                        }
                        else
                        { MessageBox.Show("Ingrese los datos de forma correcta"); }
                    }
                    else
                    { MessageBox.Show("Ya existe un cocinero con ese DNI"); }

                if (AsignarMozo())
                {
                    oBEMozo.Turno = AsignarTurno();
                    oBEMozo.Ranking = 0;
                    oBEMozo.Password = Encriptacion.Encrypt(textBox_Pass.Text.Trim(), null);
                    oBLMozo.Guardar(oBEMozo);
                    AsignarAControles(oBEMozo);
                }
                

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
                    
                        oBLCocinero.Baja(oBECocinero);
                        LimpiarControles();
                                           
                        oBLMozo.Baja(oBEMozo);
                        LimpiarControles();
                  

                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void Boton_Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                
                    if (AsignarCocinero())
                    {
                        oBLCocinero.Modificar(oBECocinero);
                        AsignarAControles(oBECocinero);
                    }
                    else
                    { MessageBox.Show("Ingrese los datos de forma correcta"); }

                
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
                            if (UC_ValCod.validar())
                            {
                                oBECocinero.Codigo = int.Parse(UC_ValCod.Text);
                                return true;
                            }
                            else { return false; }
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
                            if (UC_ValCod.validar() && UC_ValCod.Text != "")
                            {
                                oBEMozo.Codigo = int.Parse(UC_ValCod.Text);
                                return true;
                            }
                            else { return false; }
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
            {
                return "Mañana";
            }
            else if (RadioButton_Tarde.Checked)
            {
                return "Tarde";
            }
            else
            {
                return "Noche";
            }

        }

        void AsignarAControles(BEPersonal oBEpersonal)
        {
            try
            {
                UC_ValApe.Text = oBEpersonal.Apellido;
                UC_ValCod.Text = oBEpersonal.Codigo.ToString();
                UC_ValNomb.Text = oBEpersonal.Nombre;
                UC_ValDNI.Text = oBEpersonal.DNI.ToString();
                UC_ValCod.Text = oBEpersonal.Codigo.ToString();
            
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        void CargarGrillaPermisos(BECocinero Cocinero)
        {
            Grilla_RolesAsignados.DataSource = null;
            BECocinero AuxCocinero = oBLCocinero.ListarObjeto(Cocinero.DNI);

            Grilla_RolesAsignados.DataSource = AuxCocinero.Roles.ToList();
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
            Grilla_RolesAsignados.DataSource = oBLPersonal.ListarRoles(Personal.DNI);
            CargarRolesNoAsignados(Personal);
            CargarRolesAsignados(Personal);


            //List<BERoles> listRoles = oBLRoles.ListarTodo();
            //List<BERoles> listRolesAsignados = oBLPersonal.ListarRoles(Personal.DNI);
            //List<BERoles> listRolesNoAsignados= new List<BERoles>();



            /*
            foreach (BERoles Rol in listRoles)
            {
                if (roles.Codigo == Rol.Codigo)
                {

                }
            }
            listPermisosNo = RolesNoAsig(listPermisos);
            Grilla_PermisosAsignados.DataSource = null;
            Grilla_PermisosAsignados.DataSource = listPermisos;
            Grilla_PermisosNoAsignados.DataSource = null;
            Grilla_PermisosNoAsignados.DataSource = listPermisosNo;
            
        }


        private List<BEPermisos> RolesNoAsig(List<BEPermisos> listPer)
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
            return listaAux;*/
        }



        private void CargarRolesAsignados(BEPersonal Personal)
        {
            throw new NotImplementedException();
        }

        private void CargarRolesNoAsignados(BEPersonal Personal)
        {
            throw new NotImplementedException();
        }

        private void Grilla_RolesNoAsignados_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void Grilla_RolesAsignados_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}

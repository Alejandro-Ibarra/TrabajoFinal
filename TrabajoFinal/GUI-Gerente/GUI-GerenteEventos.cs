using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Abstraction;
using BussinesEntity;
using BussinesLogic;

namespace TrabajoFinal
{
    public partial class GUI_Gerente_Eventos : Form
    {
        public GUI_Gerente_Eventos()
        {
            InitializeComponent();
            CargarComboBox();
            listaEventos = new List<BEEvento>();
            oBLEvento = new BLEvento();
            oBEEvento = new BEEvento();
            listaClientes = new List<BECliente>();
            oBECliente = new BECliente();
            CargarGrillaClientes();
            CargarGrillaEventos();
        }

        BECliente oBECliente;
        BEEvento oBEEvento;
        BLEvento oBLEvento;
        List<BEEvento> listaEventos;
        List<BECliente> listaClientes;

        private void GUI_Gerente_Eventos_Load(object sender, EventArgs e)
        {
            Grilla_Eventos.MultiSelect = false;
            Grilla_Eventos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Grilla_DeClientes.MultiSelect = false;
            Grilla_DeClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void Boton_VerificarDisp_Click(object sender, EventArgs e)
        {
            try
            {
                if (VerificarDisponibilidad())
                {
                    MessageBox.Show("No se puede tomar reserva ese dia y hora");
                }
                else
                {
                    MessageBox.Show("Se puede tomar reserva ese dia y hora");
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void Boton_ConfirmarEvento_Click(object sender, EventArgs e)
        {
            try
            {
                CargarDatosEvento();

                if (ConfirmarCantUsuarios())
                {
                    if (VerificarDisponibilidad())
                    {
                        MessageBox.Show("No se puede tomar reserva ese dia y hora");
                    }
                    else
                    {
                        oBLEvento.Guardar(oBEEvento);
                        LimpiarControles();
                        CargarGrillaEventos();
                    }
                }
                else { MessageBox.Show("Verifique la cantidad de usuarios"); }
                }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void Boton_AgregarInvitados_Click(object sender, EventArgs e)
        {
            try
            {
                if (uC_ValCod1.Text != null)
                {
                    if (Grilla_DeClientes.RowCount < Convert.ToInt32(uC_ValCod1.Text) )
                    {
                        if (uC_ValidarMail1.validar() && uC_ValNombApe1.Text != null && uC_ValidarMail1.Text != null)
                        {
                            CargarClientes();
                            CargarGrillaClientes();
                        }else{ MessageBox.Show("Verifique la informacion ingresada en el nombre o mail"); }
                    }else{ MessageBox.Show("No puede agregar mas clientes que los indicados"); }
                }else { MessageBox.Show("Ingrese la cantidad de invitados"); }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void Boton_ModificarInvitados_Click(object sender, EventArgs e)
        {
            try
            {
                if (uC_ValNombApe1.Text != null && uC_ValidarMail1.Text != null)
                {
                    foreach (BECliente Cli in listaClientes)
                    {
                        if (Cli.Codigo == oBECliente.Codigo)
                        {
                            Cli.Nombre = uC_ValNombApe1.Text;
                            Cli.EMail = uC_ValidarMail1.Text;
                        }

                    }
                    CargarGrillaClientes();
                    
                    //LimpiarControles();
                }
                else
                {MessageBox.Show("Ingrese la cantidad de invitados");}
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void Boton_EliminarEvento_Click(object sender, EventArgs e)
        {
            try
            {
                if (DateTime.Parse(oBEEvento.Fecha) > DateTime.Now)
                {
                    DialogResult Respuesta;
                    Respuesta = MessageBox.Show("¿Quiere continuar con la baja?", "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (Respuesta == DialogResult.Yes)
                    {
                        oBLEvento.Baja(oBEEvento);
                        LimpiarControles();
                        CargarGrillaEventos();
                        CargarGrillaClientes();
                    }
                }
                else
                {MessageBox.Show("No se pueden eliminar eventos pasados");}
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void Boton_ModificarEvento_Click(object sender, EventArgs e)
        {
            try
            {
                if (ConfirmarCantUsuarios())
                {
                    oBEEvento.ListaClientes = listaClientes;
                    oBLEvento.Modificar(oBEEvento);
                    LimpiarControles();
                    CargarGrillaEventos();

                }
                else { MessageBox.Show("Verifique la cantidad de usuarios"); }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void Grilla_Eventos_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (Grilla_Eventos.Rows.Count > 0 && Grilla_Eventos.CurrentRow.DataBoundItem != null)
                {
                    oBEEvento = (BEEvento)Grilla_Eventos.CurrentRow.DataBoundItem;
                    AsignarEventoAControles(oBEEvento);
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void Grilla_DeClientes_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (Grilla_DeClientes.Rows.Count > 0 && Grilla_DeClientes.CurrentRow.DataBoundItem != null)
                {
                    oBECliente = (BECliente)Grilla_DeClientes.CurrentRow.DataBoundItem;
                    AsignarClienteAControles(oBECliente);
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private bool ConfirmarCantUsuarios()
        {

            int aux = 0;
            foreach (BECliente item in oBEEvento.ListaClientes)
            {
                aux = aux + 1;
            }
            if (uC_ValCod1.Text !=  aux.ToString())
            {
                DialogResult Respuesta;
                Respuesta = MessageBox.Show("No coincide la cantidad de invitados agregados con la cantidad indicada ¿Desea continuar?", "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (Respuesta == DialogResult.Yes)
                {
                    return true;
                }
                return false;
            }
            else{ return true;}
        }


        private bool VerificarDisponibilidad()
        {
            try
            {
                if (Calendario.SelectionRange.Start > DateTime.Today)
                {
                    listaEventos = oBLEvento.ListarTodo();
                    int cantPer = 0;
                    foreach (BEEvento evento in listaEventos)
                    {
                        if (evento.Fecha == Calendario.SelectionRange.Start.ToShortDateString() && evento.Hora == ComboBox_Horarios.Text.ToString())
                        {
                            cantPer = cantPer + evento.CantPersonas;

                        }
                    }
                    cantPer = cantPer + Convert.ToInt32(uC_ValCod1.Text);
                    if (cantPer > 50)
                    {
                        return true;
                    }
                    return false;
                }
                else
                {
                    MessageBox.Show("No se pueden elegir fechas anteriores");
                    return true;
                }

                
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); return false; }
        }

        private void CargarDatosEvento()
        {
            try
            {
                if (uC_ValCod1.validar() && Convert.ToInt32(uC_ValCod1.Text) > 0 && Convert.ToInt32(uC_ValCod1.Text) < 50)
                {
                    oBEEvento.Codigo = oBLEvento.GenerarCodigo();
                    oBEEvento.CantPersonas = Convert.ToInt32(uC_ValCod1.Text);
                    oBEEvento.Fecha = Calendario.SelectionRange.Start.ToShortDateString();
                    oBEEvento.Hora = ComboBox_Horarios.Text.ToString();
                    oBEEvento.ListaClientes = listaClientes;
                   
                }
                else{ MessageBox.Show("Verifique que los datos ingresados sean correctos"); }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message);}
        }

        private void CargarClientes()
        {
            try
            {
                int aux = 0;
                foreach (BECliente Cli in listaClientes)
                {
                    aux = aux + 1;
                }

                BECliente cliente = new BECliente();
                cliente.Codigo = aux;
                cliente.Nombre = uC_ValNombApe1.Text;
                cliente.EMail = uC_ValidarMail1.Text;

                listaClientes.Add(cliente);
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }



        private void CargarGrillaClientes()
        {
            try
            {
                List<BECliente> listAux = new List<BECliente>();
                foreach (BECliente item in listaClientes)
                {
                    listAux.Add(item);
                }
                Grilla_DeClientes.DataSource = listAux;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

        }

        private void CargarGrillaEventos()
        {
            try
            {
                Grilla_Eventos.DataSource = oBLEvento.ListarTodo();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void CargarComboBox()
        {
            try
            {
                ComboBox_Horarios.DataSource = CargarComboHorario();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private List<string> CargarComboHorario()
        {
            try
            {
                List<string> Horarios = new List<string>();
                Horarios.Add("12 Hs");
                Horarios.Add("14 Hs");
                Horarios.Add("20 Hs");
                Horarios.Add("22 Hs");
                return Horarios;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); return null; }
        }


        private void AsignarClienteAControles(BECliente oBEcli)
        {
            uC_ValCod2.Text = oBEcli.Codigo.ToString();
            uC_ValNombApe1.Text = oBEcli.Nombre;
            uC_ValidarMail1.Text = oBEcli.EMail;
        }

        private void AsignarEventoAControles(BEEvento oBEEven)
        {
            try
            {
                List<BEEvento> listeve = oBLEvento.ListarTodo();
                
                foreach (BEEvento eve in listeve)
                {
                    if (oBEEven.Codigo == eve.Codigo)
                    {
                        oBEEvento = eve;
                    }
                }

                uC_ValCod1.Text = oBEEven.CantPersonas.ToString();
                Calendario.SetDate(Convert.ToDateTime(oBEEvento.Fecha));
                ComboBox_Horarios.SelectedItem = oBEEven.Hora;
                listaClientes = oBEEven.ListaClientes;

                List<BECliente> listAux = new List<BECliente>();
                foreach (BECliente item in listaClientes)
                {
                    listAux.Add(item);
                }
                Grilla_DeClientes.DataSource = listAux;


            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void LimpiarControles()
        {
            listaClientes.Clear();
            uC_ValCod1.Clear();
            uC_ValCod2.Clear();
            uC_ValidarMail1.Clear();
            uC_ValNombApe1.Clear();
            Grilla_DeClientes.DataSource = null;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoFinal
{
    public class UC_ValidarMail : TextBox
    {
        public Boolean validar()
        {
           
            if (Regex.IsMatch(base.Text, @"^[a-z0-9][-a-z0-9._]+@([-a-z0-9]+.)+[a-z]{2,5}$") && base.Text != null)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Formato de E-Mail incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
        }
    }
}

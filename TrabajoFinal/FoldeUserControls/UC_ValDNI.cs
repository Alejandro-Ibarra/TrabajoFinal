using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoFinal
{
    internal class UC_ValDNI : TextBox
    {
        public Boolean validar()
        {
            if (Regex.IsMatch(base.Text, @"^[0-9]{8}$") && base.Text != null)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Formato de DNI incorrecto, debe contener 8 numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}

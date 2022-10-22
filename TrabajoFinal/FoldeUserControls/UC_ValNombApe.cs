using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoFinal
{
    internal class UC_ValNombApe : TextBox
    {
        public Boolean validar()
        {
            if (Regex.IsMatch(base.Text, @"^[a-zA-Z]+$") && base.Text != null)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Formato Incorrecto, deben ser solo caracteres alfabeticos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}

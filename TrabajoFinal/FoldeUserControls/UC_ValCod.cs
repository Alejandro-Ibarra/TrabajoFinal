using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoFinal
{
    public class UC_ValCod : TextBox
    {
        public Boolean validar()
        {
            if (Regex.IsMatch(base.Text, @"^[0-9]") && base.Text != null)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Formato de codigo incorrecto, debe contener numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }

}

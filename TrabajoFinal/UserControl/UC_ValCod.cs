using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoFinal.UserControl
{
    public class UC_ValCod : TextBox
    {
        public Boolean validar()
        {
            if (Regex.IsMatch(base.Text, @"^[0-9]{8}$"))
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

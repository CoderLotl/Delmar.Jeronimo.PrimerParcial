using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public static class Extras
    {
        public static void ControlColorChange(Control control, int option)
        {
            if (!String.IsNullOrEmpty(control.Text))
            {
                if ((option == 1 && !int.TryParse(control.Text, out _)) || (option == 2 && !control.Text.All(char.IsLetter))
                    || (option == 3 && control.Text.Length >= 8) || (option == 4 && ((NumericUpDown)control).Value == 0))
                {
                    control.BackColor = System.Drawing.Color.PaleVioletRed;
                }
                else
                {
                    control.BackColor = System.Drawing.Color.LightGreen;
                }
            }
            else
            {
                control.BackColor = SystemColors.Window;
            }
        }
    }
}

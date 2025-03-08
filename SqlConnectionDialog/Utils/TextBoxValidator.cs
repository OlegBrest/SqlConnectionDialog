using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using TextBox = System.Windows.Controls.TextBox;

namespace SqlConnectionDialog.Utils
{
    static internal class TextBoxValidator
    {
        public static bool IntegerNumberValidationTextBox(object sender, TextCompositionEventArgs e, int maxValue = int.MaxValue)
        {
            int result = 0;
            string txt = ((TextBox)sender).Text;
            return !(int.TryParse(txt + e.Text, out result) && result <= maxValue);
        }
        public static bool DoubleNumberValidationTextBox(object sender, TextCompositionEventArgs e, double maxValue = double.MaxValue)
        {
            string txt = ((TextBox)sender).Text;
            double result = 0;
            string val = (txt + e.Text + "0");
            return !(double.TryParse(val, out result) && result <= maxValue);
        }
    }
}

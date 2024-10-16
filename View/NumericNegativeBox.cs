using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View
{
    internal class NumericNegativeBox : NumericBox
    {
        public override void ValidateInput(object sender, KeyPressEventArgs e)
        {
            char symbol = e.KeyChar;
            if ((symbol == '.' || symbol == ',')
                && Text.IndexOf(',') != -1)
            {
                e.Handled = true;
                return;
            }

            if (!char.IsDigit(symbol) && symbol != (char)Keys.Back
                && symbol != ',' && symbol != '.' && symbol != '-')
            {
                e.Handled = true;
            }

            if (symbol == '.')
            {
                e.KeyChar = ',';
            }
        }
    }
}

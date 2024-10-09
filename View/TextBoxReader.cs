using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View
{
    /// <summary>
    /// Класс для чтения данных с текстовых полей.
    /// </summary>
    internal class TextBoxReader
    {
        /// <summary>
        /// Метод запрета ввода некорректных символов.
        /// </summary>
        /// <param name="e"></param>
        public static void CheckInput(KeyPressEventArgs e)
        {
            const int backSpace = 8;
            char number = e.KeyChar;
            if ((e.KeyChar < '0' || e.KeyChar > '9')
                && number != backSpace
                && number != ',')
            {
                e.Handled = true;
            }
        }
    }
}

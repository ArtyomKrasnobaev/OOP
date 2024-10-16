namespace View
{
    /// <summary>
    /// Класс для ввода чисел.
    /// </summary>
    public class NumericBox : TextBox
    {
        /// <summary>
        /// Конструктор класса NumericBox.
        /// </summary>
        public NumericBox()
        {
            KeyPress += new KeyPressEventHandler(ValidateInput);
        }

        /// <summary>
        /// Корректировка ввода данных.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Объект, содержащий данные о событии.</param>
        public virtual void ValidateInput(object sender, KeyPressEventArgs e)
        {
            char symbol = e.KeyChar;
            if ((symbol == '.' || symbol == ',')
                && Text.IndexOf(',') != -1)
            {
                e.Handled = true;
                return;
            }

            if (!char.IsDigit(symbol) && symbol != (char)Keys.Back
                && symbol != ',' && symbol != '.')
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

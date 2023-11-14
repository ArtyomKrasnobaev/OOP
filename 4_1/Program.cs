namespace _4_1
{
    /// <summary>
    /// Program.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Функция преобразования элементов строки
        /// к противоположному регистру.
        /// </summary>
        /// <param name="text">Строка.</param>
        /// <returns>Строка в противоположном регистре.</returns>
        private static string ChangeCase(string text)
        {
            // Пустая строка
            string newWord = "";

            // Итерируемся по элементам строки
            foreach (char letter in text)
            {
                // Если буква заглавная - преобразуем к нижнему регистру
                if (Char.IsUpper(letter))
                {
                    newWord += Char.ToLower(letter);
                }

                // В остальных случаях преобразуем к верхнему регистру
                else
                {
                    newWord += Char.ToUpper(letter);
                }
            }

            // Возвращаем измененную строку
            return newWord;
        }

        /// <summary>
        /// Main.
        /// </summary>
        static void Main()
        {
            // Ввод строки с консоли
            string text = Console.ReadLine();

            // Вывод измененной строки в консоль
            Console.WriteLine(ChangeCase(text));
        }
    }
}
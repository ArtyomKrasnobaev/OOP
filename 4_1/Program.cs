namespace _4_1
{
    /// <summary>
    /// Program.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Функция преобразования строки к верхнему регистру.
        /// </summary>
        /// <param name="text">Строка.</param>
        /// <returns>Строка в верхнем регистре.</returns>
        private static string ToUpperLetters(string text)
        {
            string newWord = "";

            // Функция использует встроенный метод .ToUpper
            foreach (char letter in text)
            {
                if (Char.IsUpper(letter))
                {
                    newWord += Char.ToLower(letter);
                }
                else
                {
                    newWord += Char.ToUpper(letter);
                }
            }

            return newWord;
        }

        /// <summary>
        /// Main.
        /// </summary>
        static void Main()
        {
            string text = Console.ReadLine();
            Console.WriteLine(ToUpperLetters(text));
        }
    }
}
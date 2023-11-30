namespace _4_3
{
    /// <summary>
    /// Program.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Рекурсивная функция для вычисления суммы ряда n/i при i = [2, n].
        /// </summary>
        /// <param name="n">Аргумент функции.</param>
        /// <param name="i">Начальное значение счетчика.</param>
        /// <returns>Сумма ряда n/i при i = [2, n].</returns>
        private static int RecursionSum(int n, int i)
        {
            // При n = 1 возвращаем 1
            if (n == 1)
            {
                return 1;
            }

            // Возвращаем сумму ряда при n >= i с помощью рекурсии
            if (n >= i)
            {
                return n / i + RecursionSum(n, i + 1);
            }

            // В остальных случаях возвращаем 0
            else return 0;
        }

        /// <summary>
        /// Main.
        /// </summary>
        /// <param name="args">.</param>
        static void Main(string[] args)
        {
            // Ввод аргумента функции с кансоли
            Console.Write("Введите n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            // Вывод результата выполнения функции RecursionSum в консоль
            Console.Write($"Сумма ряда от 2 до {n}: {RecursionSum(n, 2)} \n");
        }
    }
}
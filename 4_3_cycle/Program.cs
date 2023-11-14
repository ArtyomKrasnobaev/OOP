namespace _4_3_cycle
{
    public class Program
    {
        private static int SeriesSum(int n)
        {
            // Начальное значение суммы ряда
            int sum = 0;

            // При n = 1 возвращаем 1
            if (n == 1)
            {
                return 1;
            }

            // Возвращаем сумму ряда при i от 2 до n
            for (int i = 2; i <= n; i++)
            {
                sum += (n / i);
            }
            return sum;
        }

        static void Main(string[] args)
        {
            // Ввод числа n с консоли
            Console.Write("Введите n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            // Вывод результата выполнения функции
            // SeriesSum(int n) в консоль
            Console.Write($"Сумма ряда от 2 до {n}: {SeriesSum(n)} \n");
        }
    }
}
namespace _4_2
{
    /// <summary>
    /// Program.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Функция генерации случайного одномерного массива.
        /// </summary>
        /// <returns>Случайный одномерный массив.</returns>
        private static int[] CreateArray()
        {
            Console.WriteLine("Исходный массив");

            // Создаем одномерный массив
            int[] array = new int[10];

            // Объявляем рандомайзер
            Random rand = new Random();

            // Заполняем массив рандомными значениями и выводим в консоль
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(-10, 10);
            }

            // Возвращаем массив
            return array;
        }

        /// <summary>
        /// Метод нахождения индекса максимального элемента массива.
        /// </summary>
        /// <param name="array">Одномерный массив.</param>
        /// <returns>Индекс максимального элемента массива.</returns>
        private static int GetIndexOfMax(int[] array)
        {
            // Находим максимальный элемент массива с помощью метода .Max()
            int maxNumber = array.Max();

            // Находим индекс максимального элемента массива
            // с помощью метода .IndexOf()
            int maxNumberIndex = Array.IndexOf(array, maxNumber);

            // Возвращаем индекс максимального элемента массива
            return maxNumberIndex;
        }

        /// <summary>
        /// Функция сортировки одномерного массива методом простого выбора:
        /// до максимального числа - по возрастанию, после - по убыванию.
        /// </summary>
        /// <param name="array">Одномерный массив.</param>
        /// <returns>Отсортированный одномерный массив.</returns>
        private static int[] SelectionSort(int[] array, int maxNumberIndex)
        {
            Console.WriteLine("Отсортированный массив");

            // Объявляем переменные для реализации сортировки
            int i, j, min, max, temp;

            // Сортируем по возрастанию до максимального значения
            for (i = 0; i < maxNumberIndex - 1; i++)
            {
                // Начальное значение минимального индекса
                min = i;

                // Находим индекс минимального элемента
                for (j = i + 1; j < maxNumberIndex; j++)
                {
                    if (array[j] < array[min])
                    {
                        min = j;
                    }
                }

                // Меняем местами текущий и минимальный элементы
                temp = array[i];
                array[i] = array[min];
                array[min] = temp;
            }

            // Сортируем по убыванию от максимального значения до конца
            for (i = maxNumberIndex + 1; i < array.Length - 1; i++)
            {
                // Начальное значение максимального индекса
                max = i;

                // Находим индекс максимального элемента
                for (j = i + 1; j < array.Length; j++)
                {
                    if (array[j] > array[max])
                    {
                        max = j;
                    }
                }

                // Меняем местами текущий и максимальный элементы
                temp = array[i];
                array[i] = array[max];
                array[max] = temp;
            }

            // Возвращаем отсортированный массив
            return array;
        }

        /// <summary>
        /// Метод распечатки массива в консоль.
        /// </summary>
        /// <param name="array">Одномерный массив.</param>
        private static void ShowArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} \t");
            }

            Console.WriteLine("\n");
        }

        /// <summary>
        /// Main.
        /// </summary>
        /// <param name="args">.</param>
        static void Main(string[] args)
        {
            // Генерируем рандомный массив и выводим в консоль
            int[] array = CreateArray();
            ShowArray(array);

            // Находим индекс максимального элемента массива
            int maxNumberIndex = GetIndexOfMax(array);

            // Сортируем массив и выводим отсортированный массив в консоль
            int[] sortedArray = SelectionSort(array, maxNumberIndex);
            ShowArray(sortedArray);
        }
    }
}
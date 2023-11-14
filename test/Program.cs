int[] array = { 3, 2, 8, 1, 5 };

// Начальное значение максимального значения массива
int maxNumber = array[0];

// Начальное значение индекса максимального значения
int maxNumberIndex = 0;

// Поиск индекса максимального значения в массиве
for (int i = 1; i < array.Length; i++)
{
    if (array[i] > maxNumber)
    {
        maxNumber = array[i];
        maxNumberIndex = i;
    }
}

// Сортировка методом простого выбора
for (int i = 0; i < maxNumberIndex; i++)
{
    int min = i;
    for (int j = i + 1; j < maxNumberIndex; j++)
    {
        if (array[j] < array[i])
        {
            min = j;
        }
    }
    int temp = array[i];
    array[i] = array[min];
    array[min] = temp;
}

for (int i = maxNumberIndex + 1; i < array.Length; i++)
{
    int max = i;
    for (int j = i + 1; j < array.Length; j++)
    {
        if (array[j] > array[i])
        {
            max = j;
        }
    }
    int temp = array[i];
    array[i] = array[max];
    array[max] = temp;
}

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]} \t");
}
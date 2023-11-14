int i, j, min, temp;
for (i = 0; i < array.Length - 1; i++)
{
    min = i; //устанавливаем начальное значение минимального индекса

    //находим минимальный индекс элемента
    for (j = i + 1; j < array.Length; j++)
    {
        if (array[j] < array[min])
        {
            min = j;
        }
    }

    //меняем значения местами
    temp = array[i];
    array[i] = array[min];
    array[min] = temp;
}
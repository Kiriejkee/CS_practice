// Задача 36: Задайте одномерный массив, заполненный случайными числами.
//  Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] resultArray = new int[size];

    for (int i = 0; i < size; i++)
    {
        resultArray[i] = new Random().Next(minValue, maxValue + 1);
    }
    return resultArray;
}

int Sum(int[] array)
{
    int sum = 0;
    int len = array.Length;
    for (int i = 0; i < len; i++)
    {
        if (i % 2 != 0)
        {
            sum = sum +array[i];
        }
    }
    return sum;
}

int[] array = GetArray(4, 1, 100);
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях массиве {String.Join(";", array)} равняется {Sum(array)} ");
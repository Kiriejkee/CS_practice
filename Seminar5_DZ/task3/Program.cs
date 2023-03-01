// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

// Используйте NextDouble().

double[] GetDoubleArray(int size)
{
    double[] resultArray = new double[size];

    for (int i = 0; i < size; i++)
    {
        resultArray[i] = new Random().NextDouble() * 100;
    }
    return resultArray;
}

double MinMaxDiff(double[] array)
{
    int len = array.Length;
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < len; i++)
    {
        if (array[i] >= max)
        {
            max = array[i];
        }
        else if (array[i] < min)
        {
            min = array[i];
        }
    }
    double diff = max - min;
    return diff;
}

double[] array = GetDoubleArray(4);
Console.WriteLine($"Разность максимального и минимального значения массива [ {String.Join(" ; ",array)} ] \n примерно равна {Math.Round(MinMaxDiff(array), 2)}");
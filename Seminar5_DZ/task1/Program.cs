// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//  Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] resultArray = new int[size];

    for (int i = 0; i < size; i++)
    {
        resultArray[i] = new Random().Next(minValue, maxValue + 1);
    }
    return resultArray;
}

int Counter(int[] array)
{
    int count = 0;
    int len = array.Length;
    for (int i = 0; i < len; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

int[] array = GetArray(4, 100,1000);
Console.WriteLine($"В массиве {String.Join(";",array)} присутствует {Counter(array)} четных чисел");
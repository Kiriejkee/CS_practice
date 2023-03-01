// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21 

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] resultArray = new int[size];

    for (int i = 0; i < size; i++)
    {
        resultArray[i] = new Random().Next(minValue, maxValue + 1);
    }
    return resultArray;
}

int len = 6;
int[] array = GetArray(len, 0, 10);
int mid = len / 2;
int[] multiplyPairs = new int[mid];

for (int i = 0; i < mid; i++)
{
    multiplyPairs[i] = array[i] * array[len - 1 - i];
}

Console.WriteLine($"Массив : [{String.Join(";", array)}]");

Console.WriteLine($"Попарное перемножение : [{String.Join(";", multiplyPairs)}]");
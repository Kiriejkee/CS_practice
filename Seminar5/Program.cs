// Демонстрация решения
// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29,
// сумма отрицательных равна -20.

// Создание массива
// 3 параметра: 1 - размер массива, 2,3 нижняя и верхняя границы рандома


// int[] GetArray(int size, int minValue, int maxValue)
// {
//     int[] resultArray = new int[size];

//     for (int i = 0; i < size; i++)
//     {
//         resultArray[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return resultArray;
// }

// int[] array = GetArray(4, -9, 9);

// Console.WriteLine($"[{String.Join(";", array)}]");

// int size = array.Length;

// int posSum = 0;
// int negSum = 0;
// for (int i = 0; i < size; i++)
// {
//     if (array[i] > 0)
//     {
//         posSum += array[i];
//     }
//     else
//     {
//         negSum += array[i];
//     }
// }

// Console.WriteLine($"Сумма положительных значений массива равна: {posSum}, сумма отрицательных значений массива равна: {negSum}");


// Задача 32: Напишите программу замена элементов массива:
//  положительные элементы замените на соответствующие отрицательные,
//  и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]


// int[] InverseArray (int[] inputArray)
// {
//     for(int i =0; i < inputArray.Length; i++)
//     {
//         inputArray[i] *= (-1);
//     }
//     return inputArray;
// }

// Console.WriteLine($"[{String.Join(";", InverseArray(array))}]");



// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да


// int[] GetArray(int size, int minValue, int maxValue)
// {
//     int[] resultArray = new int[size];

//     for (int i = 0; i < size; i++)
//     {
//         resultArray[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return resultArray;
// }

// int[] array = GetArray(5, 0, 10);
// int num = Convert.ToInt32(Console.ReadLine());
// int count = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] == num)
//     {
//         count++;
//     }
// }
// if (count > 0)
// {
//     Console.WriteLine($"В массиве [{String.Join(";", array)}] присутвтует {num} {count} раз");
// }
// else
// {
//     Console.WriteLine($"В массиве [{String.Join(";", array)}] отсутствует {num}");
// }


// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

// int[] GetArray(int size, int minValue, int maxValue)
// {
//     int[] resultArray = new int[size];

//     for (int i = 0; i < size; i++)
//     {
//         resultArray[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return resultArray;
// }

// int[] array = GetArray(10, 0, 250);

// int len = array.Length;

// int count = 0;

// for (int i = 0; i < len; i++)
// {
//     if (array[i] >= 10 && array[i] <= 99)
//     {
//         count++;
//     }
// }

// Console.WriteLine($"В массиве [{String.Join(";", array)}] на отрезок [10,99] приходится {count} элементов");

// int[] GetArray(int size, int minValue, int maxValue)
// {
//     int[] resultArray = new int[size];

//     for (int i = 0; i < size; i++)
//     {
//         resultArray[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return resultArray;
// }

// int ArrayCheck(int[] array, int min, int max)
// {
//     int len = array.Length;

//     int count = 0;

//     for (int i = 0; i < len; i++)
//     {
//         if (array[i] >= min && array[i] <= max)
//         {
//             count++;
//         }
//     }
//     return count;
// }

// int[] array = GetArray(10, 0, 250);


// Console.WriteLine($"В массиве [{String.Join(";", array)}] на отрезок [10,99] приходится {ArrayCheck(array, 10, 99)} элементов");

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
        multiplyPairs[i] = array[i] * array[len - i];
}

Console.WriteLine($"Массив : [{String.Join(";", array)}]");

Console.WriteLine($"Попарное перемножение : [{String.Join(";", multiplyPairs)}]");






// // Задача 39: Напишите программу, которая перевернёт одномерный массив 
// // (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// // [1 2 3 4 5] -> [5 4 3 2 1]
// // [6 7 3 6] -> [6 3 7 6]

// // FillArray: размер, мин, макс

// int[] array = FillArray(10, 0, 10);

// Console.WriteLine($"Исходный массив: [{String.Join(";", array)}]");

// Заполнение массива
// int[] FillArray(int size, int min, int max)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(min, max + 1);
//     }
//     return array;
// }

// // Переворачивание массива через запись в новый массив
// // int[] CopyArray(int[] array)
// // {
// //     int len = array.Length;
// //     int j = len- 1;
// //     int[] invArr = new int[len];
// //     for (int i = 0; i < len; i++, j--)
// //     {
// //         invArr[i] = array[j];
// //     }
// //     return invArr;
// // }
// // Console.WriteLine($"Перевернутый массив: [{String.Join(";", CopyArray(array))}]");

// // Переворачивание массива с помощью дополнительной переменной, функция void
// void ReverseArray(int[] array)
// {
//     int len = array.Length;
//     int temp;
//     int j = len - 1;
//     for (int i = 0; i < len / 2; i++, j--)
//     {
//         temp = array[i];
//         array[i] = array[j];
//         array[j] = temp;
//     }
//     return;
// }

// ReverseArray(array);// Заменяет входящие данные 
// Console.WriteLine($"Перевернутый массив: [{String.Join(";", array)}]");



// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет,
//  может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: 
// каждая сторона треугольника меньше суммы двух других сторон.

// int A = new Random().Next(0, 101);
// Console.WriteLine(A);
// int B = new Random().Next(0, 101);
// Console.WriteLine(B);
// int C = new Random().Next(0, 101);
// Console.WriteLine(C);

// void IsTriangle(int A, int B, int C)
// {
//     if ((A + B > C) && (A + C > B) && (C + B > A)) Console.WriteLine("Является треугольником");
//     else Console.WriteLine("Не является треугольником");
// }

// IsTriangle(A,B,C);

// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи.
// Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

// Console.Clear();

// Console.WriteLine("Введите число N");
// int N = Convert.ToInt32(Console.ReadLine());


// int[] FindFibonacci(int N)
// {
//     int[] arrFibonacci = new int[N];
//     arrFibonacci[0] = 0;
//     if (N>1)
//     {


//         arrFibonacci[1] = 1;
//         for (int i = 2; i < N; i++)
//         {
//             arrFibonacci[i] = arrFibonacci[i-1]+arrFibonacci[i-2];
//         }
//         return arrFibonacci;  
//     }
//     else if (N == 2)
//     {
//         arrFibonacci[1] = 1;
//         return arrFibonacci; 
//     }
//     else 
//     {
//         return arrFibonacci;      
//     }
// }

// Console.WriteLine($"Числа фибоначчи до  {N} числа: [{String.Join(";", FindFibonacci(N))}]");


// Задача 42: Напишите программу,
//  которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10


Console.Clear();

double num = Convert.ToDouble(Console.ReadLine());

int[] BinaryNum(double num)
{
    double len1 = Math.Log(num, 2);
    int len2 = Convert.ToInt32(len1);
    double isLen = len1 - len2;
    int N = Convert.ToInt32(num);
    if (isLen > 0)
    {
        int realLen = len2;
        int[] binary = new int[realLen];
        for (int i = 0; i < realLen; i++)
        {
            if (N % 2 == 0)
            {
                N /= 2;
                binary[realLen - 1 - i] = 0;
            }
            else
            {
                N /= 2;
                binary[realLen - 1 - i] = 1;
            }
        }
        return binary;
    }
    else
    {
        int realLen = len2 + 1;
        int[] binary = new int[realLen];
        for (int i = 0; i < realLen; i++)
        {
            if (N % 2 == 0)
            {
                N /= 2;
                binary[realLen - 1 - i] = 0;
            }
            else
            {
                N /= 2;
                binary[realLen - 1 - i] = 1;
            }
        }
        return binary; 
    }


}


int[] bin = BinaryNum(num); 

Console.WriteLine($"Число в двоичной форме [{String.Join(";", bin)}]");

// мда треш, я заебался
// над попробовать через поиск длины массива делением на 10 и через вывод стрингиЫ
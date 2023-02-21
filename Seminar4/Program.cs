// Метод - блок кода (подпрограмма), который часто вызывается как функция

// void: нет оператора return (например печать массива), "процедура" в других языках

// тип_возвращаемого_зн-я имя (параметры), "функция" наименование в стиле PascalCase

// int Calculate(int a, int b, char sign)// a, b, sign - знак операции
// {
//     int result = 0;
//     if (sign == '*') // char - используются одинарные кавычки '', для string двойные ""
//     {
//         result = a * b;
//     }
//     else if (sign == '+')
//     {
//         result = a + b;
//     }
//     else if (sign == '-')
//     {
//         result = a - b;
//     }
//     else
//     {
//         Console.WriteLine("такого знака нет");
//     }
//     return result;
// }

// Console.WriteLine(Calculate(3, 5, '*')); // Вызов метода
// Console.WriteLine(Calculate(3, 5, '-'));
// Console.WriteLine(Calculate(3, 5, '+'));
// Console.WriteLine(Calculate(3, 5, '_'));


// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

// V.1 no method

// Console.WriteLine("Input A: ");
// int limit = Convert.ToInt32(Console.ReadLine()); // num limit
// int sum = 0;
// for (int i = 0; i <= limit; i++)
// {
//     sum += i;
// }

// Console.WriteLine($"Sum of all numbers from 1 till {limit} is {sum}");

// V.2 Hardcode

// Console.WriteLine("Input A: ");
// int limit = Convert.ToInt32(Console.ReadLine());

// // PascalCase - for method
// int GetSum(int A) // A = limit
// {
//     int sum = 0;
//     for (int i = 0; i <= A; i++)
//     {
//         sum += i;
//     }
//     return sum;
// }

// Console.WriteLine($"Sum of all numbers from 1 till {limit} is {GetSum(limit)}");



// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5
// должны быть только цифры, не используем строчки

// Console.WriteLine("Input number: ");
// var num = Console.ReadLine();
// int numInt = 0;
// int count = 0;
// bool isNum = int.TryParse(num, out numInt);
// if (isNum == true)
// {
//     if (numInt > 0)
//     {
//         while (numInt > 0)
//         {
//             numInt /= 10;
//             count++;
//         }
//     }
//     else if (numInt < 0)
//     {
//         while (numInt < 0)
//         {
//             numInt /= 10;
//             count++;
//         }
//     }
//     else
//     {
//         Console.WriteLine("Число равно 0");
//     }
//     Console.WriteLine(count);
// }



// метод
// Console.WriteLine("Input A: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int GetCountNumber(int number)
// {
//     int count = 0;
//     if (number > 0)
//     {
//         while (number > 0)
//         {
//             number /= 10;
//             count++;
//         }
//     }
//     else if (number < 0)
//     {
//         while (number < 0)
//         {
//             number /= 10;
//             count++;
//         }
//     }
//     else
//     {
//         Console.WriteLine("Число равно 0");
//     }
//     return count;
// }

// Console.WriteLine(GetCountNumber(num));


int[] GetBinaryArray(int size)
{
    int[] array = new int[size]; //
    // Массив состоит из size нулей
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(2);
        //array[0] = 0, array[1] = 1.....
    }
    return array;
}

int[] resultArray = GetBinaryArray(8);

//Console.WriteLine(resultArray);// показывает тип массива

// вывод значений массива

// V1
// for (int i = 0; i < resultArray.Length; i++)
// {
//     Console.Write(resultArray[i] + "\t");
// }

//V2
Console.WriteLine($"Array: [ {String.Join(", ", resultArray)}]");
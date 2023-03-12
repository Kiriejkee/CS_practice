// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int num = 5;

string PrintNum(int num)
{
    if(num == 1) return "1";
    return(num + PrintNum(num-1));
}

Console.WriteLine(PrintNum(num));
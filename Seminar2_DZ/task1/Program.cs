// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if ((number % 1000 == number) && (number / 100 > 0) )
{
   int result = ((number % 100) - (number % 10))/10;
   
   Console.Write($"Вторая цифра числа {number} равна {result}");
}
else {Console.Write("Введено неверное число, введите трехзначное");}
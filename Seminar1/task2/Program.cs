using System;

Console.Write("Ввдите первое число: ");

int firstValue = Convert.ToInt32(Console.ReadLine()); //camelCase => firstValue, secondValue, firstNumberOfArray

Console.Write("Ввдите второе число: ");

int secondValue = Convert.ToInt32(Console.ReadLine());

if (firstValue == Math.Pow(secondValue, 2)) // Math.Pow (число, степень)
{
    Console.WriteLine("Число " + firstValue + " является квадратом числа " + secondValue);
}

else
{
    Console.WriteLine("Число " + firstValue + " не является квадратом числа " + secondValue);
}
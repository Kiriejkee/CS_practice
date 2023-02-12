// Задача 2
Console.Write("Введите первое число: ");

int firstNum = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");

int secondNum = Convert.ToInt32(Console.ReadLine());

if (firstNum > secondNum)
{
    Console.WriteLine("Число " + firstNum + " больше числа " + secondNum);
    Console.WriteLine("Число " + secondNum + " меньше числа " + firstNum);
}
else
{
    Console.WriteLine("Число " + secondNum + " больше числа " + firstNum);
    Console.WriteLine("Число " + firstNum + " меньше числа " + secondNum);
}
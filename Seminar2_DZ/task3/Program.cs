// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

if (dayNumber <= 5 && dayNumber > 0)
{
    Console.WriteLine("нет");
}
else if (dayNumber < 8 && dayNumber > 5)
{
    Console.WriteLine("да");
}
// else
// {
//     Console.WriteLine("");
// }
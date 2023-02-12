Console.Write("Введите число для проверки на чётность: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0)
{
    Console.WriteLine("Число " + num + " чётное!");
}
else
{
    Console.WriteLine("Число " + num + " НЕчётное!");
}
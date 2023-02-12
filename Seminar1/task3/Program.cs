Console.Write("Введите число N:");

int N = Convert.ToInt32(Console.ReadLine());

int negativeN = N * (-1);

if (N < 0)
{
    while(negativeN <= N)
    {
        Console.WriteLine(negativeN);
        negativeN++;
    }
}
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
if (N>0)
{
    for (int i = 1; i <= N; i++)
    {
        Console.Write(Math.Pow(i,3) + "\t");    
    }
}
else
{
    for (int i = 1; i >= N; i--)
    {
        Console.Write(Math.Pow(i,3) + "\t");    
    }
}

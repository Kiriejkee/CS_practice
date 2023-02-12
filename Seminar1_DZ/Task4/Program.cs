Console.Write("Введите число: ");

int N = Convert.ToInt32(Console.ReadLine());

int one = 1; 
if (N > 1)
{
   while (one <= N)
{
    Console.WriteLine(one);
    one += 2;
} 
}
else
{
    if (N % 2 == 0)
    {
        while (N <= one)
        {   Console.WriteLine(N);
            N += 2;        
        }  
    }
    else
    {
        N++;
        while (N <= one)
        {   Console.WriteLine(N);
            N += 2;        
        }  
    }
    
}

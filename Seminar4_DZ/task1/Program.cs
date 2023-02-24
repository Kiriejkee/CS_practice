int mafsPower(int num, int degree)
{
    int degreeIncrement = 1;
    int result = num;
    if(degree > 0)
    {
        while (degreeIncrement < degree)
        {
            result = result * num;
            degreeIncrement++;
        }
        return result;
    }
    else
    {
      return 0;  
    }
    
}


Console.WriteLine("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Результатом возведения числа {A} в степень {B} будет: {mafsPower(A,B)}");
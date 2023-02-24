// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12


int NumSum(string num)
{
    int numSum = 0;
    if (num[0] != '-')
    {
        for (int numSumIncrement = 0; numSumIncrement < num.Length; numSumIncrement++)
        {
            numSum = numSum + (num[numSumIncrement] - '0');
        }
    }
    else
    {
        for (int numSumIncrement = 1; numSumIncrement < num.Length; numSumIncrement++)
        {
            numSum = numSum + (num[numSumIncrement] - '0');
        }    
    }
    return numSum;
}

Console.WriteLine("Введите число A: ");
string A = Console.ReadLine();

Console.WriteLine($"Сумма цифр числа {A} равна {NumSum(A)}");



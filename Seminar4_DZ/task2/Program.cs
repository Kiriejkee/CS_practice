// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12


int NumSum(string num)
{
    int numSum = 0;
    if (num[0] != '-')
    {
        int numSumIncrement = 0;
        while (numSumIncrement < num.Length)
        {
            numSum = numSum + (num[numSumIncrement] - '0');
            numSumIncrement++;
        }
    }
    else
    {
        int numSumIncrement = 1;
        while (numSumIncrement < num.Length)
        {
            numSum = numSum + (num[numSumIncrement] - '0');
            numSumIncrement++;
        }    
    }
    return numSum;
}

Console.WriteLine("Введите число A: ");
string A = Console.ReadLine();

Console.WriteLine($"Сумма цифр числа {A} равна {NumSum(A)}");



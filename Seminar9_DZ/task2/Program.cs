// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int M = 8;

int N = 4;

int SumBetween(int M, int N)
{
    int i = 1;
    if (M == N) return M;
    if (M >= N) i = -1;
    return (M + SumBetween(M + i, N));
}

Console.WriteLine(SumBetween(M, N));
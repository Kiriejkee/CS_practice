// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


int Ack(int m, int n)
{
    int ack = 0;
    if (m == 0) ack = n + 1;
    if (m > 0 && n == 0) ack = Ack(m - 1, 1);
    if (m > 0 && n > 0) ack = Ack(m - 1, Ack(m, n - 1));
    return ack;
}

Console.WriteLine(Ack(3, 4));
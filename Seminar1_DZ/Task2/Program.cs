// Console.WriteLine("Введите первое число: ");
// int firstNum = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите второе число: ");
// int secondNum = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите третье число: ");
// int thirdNum = Convert.ToInt32(Console.ReadLine());

int[] maxOf = new int[3];

Console.WriteLine("Введите первое число: ");
maxOf[0] = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
maxOf[1] = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число: ");
maxOf[2] = Convert.ToInt32(Console.ReadLine());

int ind = 0;
int max = maxOf[0];

while (ind <= 2)
{
    if (max < maxOf[ind])
    {
        max = maxOf[ind];
    }
    ind ++;
}

Console.WriteLine("Максимальное число: " + max);
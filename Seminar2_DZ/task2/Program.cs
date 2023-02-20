// Задача 13: Напишите программу, которая выводит третью цифру заданного семизначного числа или сообщает, что третьей цифры нет.

// 78 -> третьей цифры нет

// 3267900 -> 6

// ДОП: цифра третья может быть как с левой стороны, так и с правой



Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 100 == num)
{
    Console.WriteLine("Третьего числа нет");
}
else
{
    int len = 0;
    while (num % Math.Pow(10, len) < num)
    {
        len++;
    }
    //Console.WriteLine(len); 

    double resultLeft = (num % Math.Pow(10, len - 2)) / Math.Pow(10, len - 3); // Нахождение цифры 1234567 -> 234567 -> 34567 -> 3
    resultLeft = resultLeft - (resultLeft % 1); // убираем все что после ","
    
    double resultRight = (num % Math.Pow(10, 3)) / Math.Pow(10, 2); // можно таким образом int number = 123456; Console.WriteLine(number / 100 % 10); 
    resultRight = resultRight - (resultRight % 1);
    Console.WriteLine($" Третья слева цифра {resultLeft}, а третья справа цифра {resultRight}");
}




// int number = 123456; Console.WriteLine(number / 100 % 10); 






//Задача на поиск наибольшей цифры в случайном числе из диапазона

//int number = new Random().Next(10,100);

// int number = new Random().Next(11); // Первый параметр = 0. [0, 11)

int number = new Random().Next(10, 100);

int firstValue = number / 10; //первая цифра нашего числа

int secondValue = number % 10; // Вторая цифра: 78 % 10 = 8 остаток (78 - 7*10 = 8)

int max = firstValue;

if (secondValue > max)
{
    max = secondValue;
}

Console.WriteLine("Наибольшая цифра в числе " + number + " равна " + max);

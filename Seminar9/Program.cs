// Унарные операторы - один операнд
// int a = 5;
// a++;
// a--;

//Бинарные операторы - два операнда
// int a=5+2;
// int b = 5*2;

//Постфикс - "после" (Имеет нименьший приоритет)
//a++;

//Префиксный оператор - "перед" ++а (имеет наибольший приоритет)

// int a = 1;

// int prefixIncrement = ++a*a;
// Console.WriteLine(prefixIncrement);

// int b = 1;
// int postfixIncrement = b++ * b;
// Console.WriteLine(postfixIncrement);

//Тернарный оператор
// условие - 1й операнд ? значение для истины - 2й операнд: значение для лжи - 3й операнд;

// int dreamSalary = int.MaxValue;

// int realSalary = 50000;

// var result = realSalary < dreamSalary ? "Пока что ЗП не такая большая" : "Наша зарплата: 2147483647"; // Функция предикат

// Console.WriteLine(result);

//Стек: LIFO - last in first out


// int Factorial(int value)
// {
//     // Базовый случай - случай выхода из рекурсии
//     if (value==1) return 1;
//     // Рекурсивный случай - задание рекурсии (вызов функции внутри функции)
//     return value * Factorial(value-1);
// }
// Console.WriteLine(Factorial(4));

// Console.WriteLine("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());

// /// <summary>
// /// Печатает все натуральные числа в промежутке от 1 до N
// /// </summary>
// /// <param name="start">1 = start</param>
// /// <param name="end">N = end</param>
// /// <returns></returns>
// string PrintNumbers(int start, int end)
// {
//     // Base
//     if (start == end) return start.ToString();

//     return (start + ", " + PrintNumbers(start + 1, end));
// }

// Console.WriteLine(PrintNumbers(1, N));


// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int SumNumbers(int num)
// {
//     if(num==0) return 0;
//     //Рекурсивный случай
//     return (num%10 + SumNumbers(num/10));
// }

// Console.WriteLine(SumNumbers(number));


Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите степень: ");
int degree = Convert.ToInt32(Console.ReadLine());

int GetPower(int num, int power)
{
    if(power==1) return 1;
    if(power==1) return num;
    return (num * GetPower(num, power - 1));
}

Console.WriteLine(GetPower(number,degree));
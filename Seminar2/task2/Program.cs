// Задача на вывод случайного трехзначного числа и удаление второй цифры этого числа

//456 -> 46
//123 -> 13
//412 -> 42

int number = new Random().Next(100,1000); // [100,999]

// int firstValue = number / 100;
// int thirdValue = number % 100 % 10;

int result = (number/100)*10 + number%10;

Console.WriteLine("При удалении второй цифры числа "+ number + " получается " + result);
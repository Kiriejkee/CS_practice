// Задача на вывод случайного трехзначного числа и удаление второй цифры этого числа

//456 -> 46
//123 -> 13
//412 -> 42

// int number = new Random().Next(100,1000); // [100,999]

// int result = (number/100)*10 + number%10;

// Console.WriteLine("При удалении второй цифры числа "+ number + " получается " + result);

string message = Console.ReadLine(); // "456"

Console.WriteLine(message[0] + "" + message[2]);
//ДЗ2-2 через строку
// string testNum = Console.ReadLine();

// Console.WriteLine(testnumber[0]);

// Console.WriteLine(testnumber[1]);

// Console.WriteLine(testnumber[2]);




//var test = 551; // auto data type




//Вводится строчка. Необходимо проверить являются ли все введенные символы числами
// метод TryParce
// "1234" - подходит, в строчке число
// "12а3" - не подходит

// var stringNumber = Console.ReadLine();
// int number; // Если строчка состоит из чисел, то сюда попадает наше число
// bool isNumber = int.TryParse(stringNumber, out number); // True - строчка состоит из чисел, false - присутствуют буквы/спецсимволы
// if (isNumber)
// {
//     Console.WriteLine("Перевод произошел успешно, в строчке находились только цифры" + isNumber);
// }
// else
// {
//     Console.WriteLine("Перевод не успешен");
// }
// Console.WriteLine(isNumber);
// Console.WriteLine(number);

// TryParce - преобразование строчки в формат числа.
// Если в строчке присутствуют только цифры, то проверка на строчку проходит успешно
// Если в строчке присутствуют НЕ только цифры, то TryParce выводит bool false и выводит в переменную 0



//Напишите программу, которая принимает на вход координаты точки (Х и У),
// причем Х и У не равны 0 и выдает номер четверти плоскости, в которой находится эта точка

// Console.WriteLine("Введите координату по оси Х: ");
// int dotA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату по оси Y: ");
// int dotB = Convert.ToInt32(Console.ReadLine());

// if (dotA>0 && dotB>0)
// {
//    Console.Write("Точка находится в I четверти"); 
// }
// else if (dotA>0 && dotB<0)
// {
//     Console.WriteLine("Точка находится в IV четверти");
// }
// else if (dotA<0 && dotB<0)
// {
//     Console.WriteLine("Точка находится в III четверти");
// }
// else if (dotA<0 && dotB>0)
// {
//     Console.WriteLine("Точка находится во II четверти");
// }
// else
// {
//     Console.WriteLine("Попадание на ось!");
// }



//Программа, которая принимает на вход номер четверти и выдает диапазон допустимых значений для этой четверти

// Console.WriteLine("Введите номер четверти: ");
// int quarter = Convert.ToInt32(Console.ReadLine());

// if (quarter == 1)
// {
//     Console.WriteLine("x > 0 и y > 0");
// }
// и т.д.



// Написать программу, которая принимает на вход координаты двух точек и выдает расстояние между ними
// А(х1;y1)
// B(x2;y2)

// Console.WriteLine("Введите координату Х первой точки");
// int x1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координату Y первой точки");
// int y1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координату Х второй точки");
// int x2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координату Y второй точки");
// int y2 = Convert.ToInt32(Console.ReadLine());

// var len = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

// Console.WriteLine("Расстояние между первой и второй точками равно: " + Math.Round(len, 2)); // Math.Round(число, кол-во знаков)
// Округление до "кол-во" знаков. Если не указать "кол-во знаков" - округляет до целых
// f+число - строгое кол-во символов после запятой



// программа принимает на вход число (N) и выдает таблицу квадратов чисел от 1 до N

// Console.Write("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());

// int i = 1; // Точка начала по условию
// while (i <= N)
// {
//     Console.Write(Math.Pow(i,2) + "\t"); // \t - табуляция, \n - перенос 
//     i++;
// }
// OR
// Console.Write("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());

// for (int i = 1; i <= N; i++)
// {
//     Console.Write(Math.Pow(i,2) + "\t");
// }

// Четные числа от 0 до N с помощью цикла for

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i <= N; i+=2)
{
    Console.Write(i + "\t");
}
// Принимает на вход два числа и выводит, является ли 1 число кратным 2
//Если число 1 не кратно числу 1, то программа выводит остаток от деления.


Console.Write ("Введите первое число: ");
int firstNum = Convert.ToInt32(Console.ReadLine());

Console.Write ("Введите второе число: ");
int secNum = Convert.ToInt32(Console.ReadLine());

if(secNum == 0)
{
    return;
}

if (firstNum % secNum == 0)
{
    Console.WriteLine("Число кратно!");
}
else
{
   
    // Console.WriteLine( "Остаток от деления равен: " + firstNum % secNum);
    Console.WriteLine($"Не кратно, остаток от деления {firstNum} на {secNum} равен: {firstNum % secNum}");
    // $(" текст {переменные/выражение})
}
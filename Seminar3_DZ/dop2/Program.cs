// Назовем число интересным, если в нем разность максимальной и минимальной цифры равняется средней по РАСПОЛОЖЕНИЮ цифре.
// Напишите программу, которая определяет интересное число или нет.
// Если число интересное, следует вывести – «Число интересное» иначе «Число неинтересное».
// -> 954 - число интересное, средняя цифра - 5, разница: 9 - 4 = 5.
// Средняя цифра - цифра(962-6, 23456 - средняя 4)// 


Console.Write("Введите число: ");
string num = Console.ReadLine();
int len = num.Length;
Console.WriteLine("Длина " + len);
int i = 0;
int max = num[i] - '0';// нашел такой метод конвертации в инт, но пока не удалось разобраться как же он все-таки работает
int min = num[i] - '0';

if (len % 2 != 0) // проверка наличия средней цифры
{
    int midNum = num[len / 2] - '0';    
    //Console.WriteLine("среднее " + num[len / 2 + 1]);
    while (i < len)
    {
        int convResult = num[i] - '0'; 
       // Console.WriteLine("Конверт " + convResult);

        if (convResult > max)
        {
            max = convResult; //Console.WriteLine("Макс " + max);
        }
        else if (convResult < min)
        {
            min = convResult; //Console.WriteLine("мин  " + max);
        }
        i++;
    }

    if (midNum == max - min)
    {
        Console.WriteLine("Число " + num + " интересное!");
    }
    else
    {
        Console.WriteLine("Число " + num + " не интересное!");
    }
}
else
{
    Console.WriteLine("Число " + num + " не имеет средней цифры");
}
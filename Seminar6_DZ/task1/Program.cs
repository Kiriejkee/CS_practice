// Задача 41: Пользователь вводит с клавиатуры M чисел.
//  Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3 //////4?

void CountNum()
{
    string num;
    bool isEmpty = false;
    int countNum = 0;
    Console.WriteLine($"Последовательно вводите числа или пустое значение, для остановки");
    do 
    {
        num = Console.ReadLine();
        isEmpty = String.IsNullOrEmpty(num);
        if (isEmpty == false)
        {
            int convertNum = Convert.ToInt32(num);
            if (convertNum > 0)
            {
                countNum++;
            }
        }

    } while (isEmpty == false);
    Console.WriteLine("Среди введенных вами чисел - " + countNum + " положительных");
}



CountNum();

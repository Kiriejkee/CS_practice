// Задача 42 (необязательно): Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10


string TransformToBinary(int num)
{
    string binaryForm = "";
    bool go = true;
    while (go == true)
    {
        if (num / 2 != 1)
        {
            binaryForm = Convert.ToString(num % 2) + binaryForm;
            num /= 2;
            
        }
        else
        {
            binaryForm = "1" + Convert.ToString(num % 2) + binaryForm;
            go = false;
        }
    }
    return binaryForm;
}

Console.WriteLine("Введите число, которое необходимо трансормировать в двоичную запись > ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Двоичная форма записи введенного числа: {TransformToBinary(num)}");
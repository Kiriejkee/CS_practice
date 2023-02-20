Console.WriteLine("Введите пятизначное число: ");
string num = Console.ReadLine();
if (num.Length == 5)
{
    int numInt = 0;
    bool isNum = int.TryParse(num, out numInt);
    if( isNum == true)
    {
        int[] array = new int[5];
        for (int i = 0; i < 5; i++)
        {
            array[i] = Convert.ToInt32(num[i]);
        }
        if (array[0] == array[4] && array [1] == array[3])
        {
            Console.WriteLine("Число является палиндромом");
        }
        else
        {
            Console.WriteLine("Число НЕ является палиндромом");
        }
    }
    else
    {
        Console.WriteLine("Введено не пятизначное число");
    }
}
else
{
    Console.WriteLine("Введено не пятизначное число");
}

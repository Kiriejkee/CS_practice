// Вид методов 1 (ничего не принимают и ничего не возвращают)

// void Method1()
// {
//     Console.WriteLine("Автор собсна я");
// }

// Method1();

// Вид методов 2 ничего не возвращают, только принимают

// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }
// Method2("Текст сообщения");

// void Method21(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }
// Method21(msg: "Текст сообщения", count: 2);
// Method21(count: 2, msg: "Текст сообщения");

// Вид методов 3 что-то возвращают, но не принимают

// int Method3()
// {
//     return DateTime.Now.Year;
// }

// int year = Method3();
// System.Console.WriteLine(year);

// Вид методов 4 что-то принимают и что-то возвращают

// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;
//     while (i<count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }

// string res = Method4(10, "qwer ");
// Console.WriteLine(res);

// === Обработка текста


// Дан текст. В тексте нужно все пробелы заменить черточками,
// маленькие буквы “к” заменить большими “К”, а большие “С” заменить
// маленькими “с”.

// string text = "— Я думаю, — сказал князь, улыбаясь, — что, "
//                 + "ежели бы вас послали вместо нашего милого "
//                 + "Винценгероде, вы бы взяли приступом согласие "
//                 + "прусского короля. Вы так красноречивы. Вы "
//                 + "дадите мне чаю?";

// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;
//     int len = text.Length;
//     for (int i = 0; i < len; i++)
//     {
//         if (text[i] == oldValue) result += $"{newValue}";
//         else result += $"{text[i]}";
//     }

//     return result;
// }

// string newText = Replace(text, ' ', '|');
// newText = Replace(newText, 'к', 'К');
// newText = Replace(newText, 'с', 'С');

// Console.WriteLine(newText);


// ====сортировка массива

int[] arr = { 1, 5, 13, 6, 7, 3, 4, 5, 5, 7 };

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length-1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }

        int temp = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temp;
    }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);
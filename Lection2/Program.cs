// int Max(int arg1, int arg2, int arg3)
// {
//     int result = arg1;
//     if(arg2> result) result = arg2;
//     if(arg3> result) result = arg3;
//     return result;
// }

// int a1 = 11;
// int b1 = 12;
// int c1 = 1333;
// int a2 = 21;
// int b2 = 222;
// int c2 = 23;
// int a3 = 32221;
// int b3 = 32;
// int c3 = 33;

// // int max = a1;
// // if(b1 > max) max = b1;
// // if (c1 > max) max = c1;

// // if (a2 > max) max = a2;
// // if (b2 > max) max = b2;
// // if (c2 > max) max = c2;

// // if (a3 > max) max = a3;
// // if (b3 > max) max = b3;
// // if (c3 > max) max = c3;

// // int max1 = Max(a1, b1, c1);
// // int max2 = Max(a2, b2, c2);
// // int max3 = Max(a3, b3, c3);

// int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));


// int Max(int arg1, int arg2, int arg3)
// {
//     int result = arg1;
//     if (arg2 > result) result = arg2;
//     if (arg3 > result) result = arg3;
//     return result;
// }

// int[] array = { 11, 21, 31, 41, 15, 16, 17, 18, 19 };

// array[0] = 12;
// Console.WriteLine(array[4]);

// int[] array = { 1, 2, 3, 18, 5, 6, 7, 18 };

// int n = array.Length;
// int find = 18;
// int index = 0;

// while (index < n)
// {
//     if (array[index] == find)
//     {
//         Console.WriteLine(index);
//         break;
//     }

//     index++;
// }

void FillArray (int[] collection)
{
    int length = collection.Length;
    int index = 0;

    while (index < length)
    {
        collection[index] = new Random().Next(1,10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);

Console.WriteLine();

int pos = IndexOf(array, 42);
Console.WriteLine(pos);

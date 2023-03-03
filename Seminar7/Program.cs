// int[] FillArray(int size, int min, int max)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(min, max + 1);
//     }
//     return array;
// }


// ====Задача 46====
// Задайте двумерный массив размером m×n,
//  заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1


// int[,] GetMatrix(int rows, int cols, int minValue, int maxValue)
// {
//     int[,] matrix = new int[rows, cols];
//     for (int i = 0; i < rows; i++) // строчки; rows = matrix.GetLenght(0)
//     {
//         for (int j = 0; j < cols; j++)// столбцы; cols = matrix.GetLength(0)
//         {
//             matrix[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return matrix;
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++) // строчки; rows = matrix.GetLenght(0)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)// столбцы; cols = matrix.GetLength(1)
//         {
//             Console.Write(matrix[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] resultMatrix = GetMatrix(5, 5, 0, 10);

// PrintMatrix(resultMatrix);

// ====Задача 48====
// Задайте двумерный массив размера m на n,
// каждый элемент в массиве находится по формуле:
// Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

// int[,] GetMatrix(int m, int n)
// {
//     int[,] matrix = new int[m, n];
//     for (int i = 0; i < m; i++) // строчки; rows = matrix.GetLenght(0)
//     {
//         for (int j = 0; j < n; j++)// столбцы; cols = matrix.GetLength(0)
//         {
//             matrix[i, j] = i + j;
//         }
//     }
//     return matrix;
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++) // строчки; rows = matrix.GetLenght(0)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)// столбцы; cols = matrix.GetLength(1)
//         {
//             Console.Write(matrix[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
// }


// int[,] resultMatrix = GetMatrix(5, 5);

// PrintMatrix(resultMatrix);



// ====Задача 49====
// Задайте двумерный массив.
// Найдите элементы, у которых оба индекса чётные,
// и замените эти элементы на их квадраты.

int[,] GetMatrix(int rows, int cols, int minValue, int maxValue)
{
    int[,] matrix = new int[rows, cols];
    for (int i = 0; i < rows; i++) // строчки; rows = matrix.GetLenght(0)
    {
        for (int j = 0; j < cols; j++)// столбцы; cols = matrix.GetLength(0)
        {
            matrix[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return matrix;
}

int[,] ChangeEvenMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++) // строчки; rows = matrix.GetLenght(0)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)// столбцы; cols = matrix.GetLength(1)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                matrix[i, j] *= matrix[i, j];
            }
        }

    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++) // строчки; rows = matrix.GetLenght(0)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)// столбцы; cols = matrix.GetLength(1)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int[,] matrix = GetMatrix(5, 5, 0, 10);

PrintMatrix(matrix);

Console.WriteLine("Результат");

PrintMatrix(ChangeEvenMatrix(matrix));
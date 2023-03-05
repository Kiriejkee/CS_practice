// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1(строчка) 7 (столбец) -> такого числа в массиве нет


double[,] GetDoubleMatrix(int m, int n)
{
    double[,] matrix = new double[m, n];
    for (int i = 0; i < m; i++) // строчки; rows = matrix.GetLenght(0)
    {
        for (int j = 0; j < n; j++)// столбцы; cols = matrix.GetLength(0)
        {
            matrix[i, j] = Math.Round(new Random().NextDouble() * new Random().Next(1, 10), 1);
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
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

void GetMatrixElement(double[,] matrix, int row, int col)
{
    if (row > matrix.GetLength(0) || col > matrix.GetLength(1) || row < 0 || col < 0)
    {
        Console.WriteLine("Такого элемента в массиве нет");
    }
    else Console.WriteLine($"Искомый элемент массива {matrix[row - 1, col - 1]}");
}

double[,] matrix = GetDoubleMatrix(5, 5);
PrintMatrix(matrix);
GetMatrixElement(matrix, 5,4);


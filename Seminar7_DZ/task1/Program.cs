// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

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

double[,] doubleMatrix = GetDoubleMatrix(5, 5);
PrintMatrix(doubleMatrix);
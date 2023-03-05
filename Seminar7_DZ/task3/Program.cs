// Задача 52. Задайте двумерный массив из целых чисел.
//  Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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


double[] GetColAvg(int[,] matrix)
{
    int cols = matrix.GetLength(1);
    int rows = matrix.GetLength(0);
    double[] average = new double[rows];
    for (int i = 0; i < cols; i++)
    {
        double sum = 0;
        for (int j = 0; j < rows; j++)
        {
            sum = sum + matrix[j, i];
        }
        average[i] = Math.Round(sum / rows,1);
    }
    return average;
}

int[,] matrix = GetMatrix(3, 3, 1, 10);
PrintMatrix(matrix);
Console.WriteLine($"Среднее арифметическое каждого столбца приведенной матрицы равняется[{String.Join(";", GetColAvg(matrix))}]");


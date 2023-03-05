// сумма элементов главной диагонали

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
        Console.WriteLine();
    }
}

int GetMainDiagSum(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int cols = matrix.GetLength(1);
    int i = 0;
    int j = 0;
    int sum = 0;
    while (i < rows && j < cols)
    {
        sum += matrix[i,j];
        i++;
        j++;
    }
    return sum;
}

int[,] matrix = GetMatrix(5,4,1,10);

PrintMatrix(matrix);

Console.WriteLine($"Сумма элементов главной диагонали приведенной матрицы равна {GetMainDiagSum(matrix)}");
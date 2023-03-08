// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] GetMatrix(int rows, int cols, int min, int max)
{
    int[,] matrix = new int[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            Console.Write(inputMatrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int FindBiggerSumRow(int[,] inputMatrix)
{
    int rows = inputMatrix.GetLength(0);
    int cols = inputMatrix.GetLength(1);
    int[] rowsSum = new int[rows];
    int max = int.MinValue;
    int maxIndex = 0;

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            rowsSum[i] = rowsSum[i] + inputMatrix[i, j];
        }
        //Console.WriteLine(rowsSum[i]);
    }

    for (int i = 0; i < rows; i++)
    {
        if (rowsSum[i] > max)
        {
            max = rowsSum[i];
            maxIndex = i;
        }
    }
    return maxIndex + 1;
}

int[,] matrix = GetMatrix(5, 3, 0, 10);
PrintMatrix(matrix);
Console.WriteLine($"Строка с наибольшей суммой элементов: {FindBiggerSumRow(matrix)}");
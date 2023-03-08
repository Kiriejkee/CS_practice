// == Задача 54== :
// Задайте двумерный массив.
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

void MatrixBubleRow(int[,] inputMatrix)
{
    int rows = inputMatrix.GetLength(0);
    int cols = inputMatrix.GetLength(1);
    int temp;
    for (int i = 0; i < rows; i++)
    {
        for (int k = 0; k < cols; k++)
        {
            for (int j = 0; j < cols-1; j++)
            {
                if (inputMatrix[i, j] > inputMatrix[i, j + 1])
                {
                    temp = inputMatrix[i, j];
                    inputMatrix[i, j] = inputMatrix[i, j + 1];
                    inputMatrix[i, j + 1] = temp;
                }
            }
        }
    }
}

int[,] matrix = GetMatrix(5, 5, 0, 10);
PrintMatrix(matrix);
Console.WriteLine();
MatrixBubleRow(matrix);
PrintMatrix(matrix);
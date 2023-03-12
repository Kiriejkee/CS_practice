// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// Число столбцов матрицы А должно совпадать с числом строк матрицы В. 

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
/// <summary>
/// Вычисляет произведение матриц, если количество столбцов матрицы 1 равно количеству строк матрицы 2
/// </summary>
/// <param name="matrA"> матрица 1</param>
/// <param name="matrB"> матрица 2</param>
/// <returns>возвращает произведение, если входящие матрицы подходят по условию или матрицу нулей, если не подходят</returns>
int[,] MatrixProduct(int[,] matrA, int[,] matrB)
{
    int rowsA = matrA.GetLength(0);
    int colsA = matrA.GetLength(1);
    int rowsB = matrB.GetLength(0);
    int colsB = matrB.GetLength(1);
    int sumOfProduct = 0;
    int[,] matrixProduct = new int[rowsB, colsB];
    if (colsA == rowsB)
    {
        
        for (int i = 0; i < colsB; i++)
        {
            for (int j = 0; j < rowsB; j++)
            {
                sumOfProduct = 0;
                for (int k = 0; k < colsA; k++)
                {
                    sumOfProduct = sumOfProduct + matrA[j, k] * matrB[k, i]; //+
                }
                matrixProduct[j, i] = sumOfProduct;
            }
        }
    }
    return matrixProduct;
}

int[,] matrA = GetMatrix(2, 2, 0, 1);
PrintMatrix(matrA);
Console.WriteLine();
int[,] matrB = GetMatrix(2, 1, 0, 1);
PrintMatrix(matrB);
Console.WriteLine();
int[,] product = MatrixProduct(matrA,matrB);
PrintMatrix(product);
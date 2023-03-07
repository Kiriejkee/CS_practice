// string correctString = String.Empty; // Задание пустой строчки (равносильно = "")

// int[] array = { 10, 50, 100, 200, 500, 1000, 2000, 5000 };

// int max = int.MinValue;
// int min = int.MaxValue;

int[,] resultMatrix = GetMatrix(4, 4, 0, 10);
PrintArray(resultMatrix);

/// <summary>
/// 
/// </summary>
/// <param name="rows">Количество строк</param>
/// <param name="cols">Количество столбцов</param>
/// <param name="min">Минимальное число для рандома</param>
/// <param name="max">Максимальное число для рандома</param>
/// <returns>Заполненный двумерный массив целых чисел</returns>
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

/// <summary>
/// Выводит матрицу в консоль
/// </summary>
/// <param name="matrix">Входная матрица</param>
void PrintArray(int[,] inputMatrix)
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
/// Метод меняет первую и последнюю строчку местами
/// </summary>
/// <param name="inputMatrix">Входная целочисленная матрица</param>
void ChangeRows(int[,] inputMatrix)
{
    int lastRow = inputMatrix.GetLength(0) - 1;
    int temporaryRowElement;
    for (int i = 0; i < inputMatrix.GetLength(1); i++)
    {
        temporaryRowElement=inputMatrix[0,i];
        inputMatrix[0,i]=inputMatrix[lastRow,i];
        inputMatrix[lastRow,i]=temporaryRowElement;
    }
}

ChangeRows(resultMatrix);
Console.WriteLine();
PrintArray(resultMatrix);

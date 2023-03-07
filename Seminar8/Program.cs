// string correctString = String.Empty; // Задание пустой строчки (равносильно = "")

// int[] array = { 10, 50, 100, 200, 500, 1000, 2000, 5000 };

// int max = int.MinValue;
// int min = int.MaxValue;



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
/// Метод меняет две выбранные строчки местами
/// </summary>
/// <param name="inputMatrix">Входная целочисленная матрица</param>
void ChangeRows(int[,] inputMatrix, int startRow, int endRow)
{
    int temporaryRowElement;
    for (int i = 0; i < inputMatrix.GetLength(1); i++)
    {
        temporaryRowElement = inputMatrix[startRow - 1, i];
        inputMatrix[startRow - 1, i] = inputMatrix[endRow - 1, i];
        inputMatrix[endRow - 1, i] = temporaryRowElement;
    }
}



/// <summary>
/// Создание перевернутой относительно главной диагонали матрицы
/// </summary>
/// <param name="inputMatrix">Исходная матрица</param>
/// <returns>Перевернутая матрица</returns>
int[,] GetTransMatrix(int[,] inputMatrix)
{
    int rows = inputMatrix.GetLength(0);
    int cols = inputMatrix.GetLength(1);
    int[,] copyMatrix = new int[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            copyMatrix[i, j] = inputMatrix[j, i];
        }
    }
    return copyMatrix;
}

// int[,] resultMatrix = GetMatrix(4, 4, 0, 10);
// PrintArray(resultMatrix);
// ChangeRows(resultMatrix, 1, 2);
// Console.WriteLine();
// PrintArray(resultMatrix);

// int[,] matr = GetTransMatrix(resultMatrix);
// Console.WriteLine();
// PrintArray(matr);



int min = int.MaxValue;
int indexMinRows = 0; // номер строчки с мин. элементом
int indexMinCols = 0; // номер столбца с мин. элементом
int rows = 4;
int cols = 4;
int[,] matrix = new int[rows, cols];
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        matrix[j, j] = new Random().Next(11);
        Console.Write(matrix[j, j] + "\t");
        if (min > matrix[i, j])
        {
            min = matrix[i, j];
            indexMinRows = i;
            indexMinCols = j;
        }
    }
    Console.WriteLine();
}
Console.WriteLine($"Мин. элемент: {min}, \n строка: {indexMinRows}, \n столбец: {indexMinCols}");

for (int i = 0; i < rows; i++)
{
    if(i != indexMinRows)
    {
        for (int j = 0; j < cols; j++)
        {
            if (j != indexMinCols)
            {
                Console.Write(matrix[i,j] + "\t");
            }
        }
        Console.WriteLine();
    }
}
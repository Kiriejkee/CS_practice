// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)



int GetNotEqualElement(int[,,] array, int min, int max)
{
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);
    int depth = array.GetLength(2);
    int num = new Random().Next(min, max + 1);
    for (int k = 0; k < depth; k++)
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (num == array[i, j, k]) num = GetNotEqualElement(array, min, max);
                
            }

        }
    }
    return num;
}

int[,,] GetNotEqualElementArray(int rows, int cols, int depth, int min, int max)
{
    int[,,] array = new int[rows, cols, depth];
    for (int k = 0; k < depth; k++)
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                array[i, j, k] = NotEqualElement(array, min, max);
            }
        }
    }

    return array;
}

void PrintArray(int[,,] array)
{
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);
    int depth = array.GetLength(2);
    for (int k = 0; k < depth; k++)
    {
        for (int i = 0; i < cols; i++)
        {
            for (int j = 0; j < rows; j++)
            {
                Console.Write($"{array[i, j, k]}({i},{j},{k})\t");
            }
            Console.WriteLine();
        }
    }

}

int[,,] result = GetNotEqualElementArray(2, 2, 2, 10, 99);

PrintArray(result);
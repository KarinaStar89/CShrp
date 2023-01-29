// *Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

Console.WriteLine($"Введите число строк в матрице");
int rowsCount = Convert.ToInt32(Console.ReadLine());

while (rowsCount < 1)
{
    Console.WriteLine($"Введите положительное целое число");
    rowsCount = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine($"Введите число столбцов в матрице");
int columnsCount = Convert.ToInt32(Console.ReadLine());

while (columnsCount < 1)
{
    Console.WriteLine($"Введите положительное целое число");
    columnsCount = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine($"Введите глубину в матрице");
int depthCount = Convert.ToInt32(Console.ReadLine());

while (depthCount < 1)
{
    Console.WriteLine($"Введите положительное целое число");
    depthCount = Convert.ToInt32(Console.ReadLine());
}

int[,,] matrix = CreateMatrixRndInt(rowsCount, columnsCount, depthCount);
PrintMatrix(matrix);

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(1); k++)
            {
                Console.Write($"{matrix[i, j, k]}({i},{j},{k}) ");
            }

        }
        Console.WriteLine("");
    }
}

int[,,] CreateMatrixRndInt(int rowsCount, int columnsCount, int depthCount)
{
    int[,,] matrix = new int[rowsCount, columnsCount, depthCount];
    int value = 10;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = value + 1;
                value++;
            }
        }
    }
    return matrix;
}

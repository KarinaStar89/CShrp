// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

Console.WriteLine($"Введите число строк элементов в массиве");
int rowsCount = Convert.ToInt32(Console.ReadLine());

while (rowsCount < 1)
{
    Console.WriteLine($"Введите положительное целое число");
    rowsCount = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine($"Введите число столбцов элементов в массиве");
int columnsCount = Convert.ToInt32(Console.ReadLine());

while (columnsCount < 1)
{
    Console.WriteLine($"Введите положительное целое число");
    columnsCount = Convert.ToInt32(Console.ReadLine());
}

double[,] matrix = CreateMatrixRndDouble(rowsCount, columnsCount, -99, 99);
PrintMatrix(matrix);

double[,] CreateMatrixRndDouble(int rowsCount, int columnsCount, int min, int max)
{
    double[,] matrix = new double[rowsCount, columnsCount];
    Random random = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round((random.NextDouble() * (max - min) + min), 2);
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1)
            {
                 Console.Write(matrix[i, j] + "  ");
            }
            else
            {
                 Console.Write(matrix[i, j]);
            }
        }
         Console.WriteLine("]");
    }
}
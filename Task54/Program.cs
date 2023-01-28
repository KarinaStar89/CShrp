// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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


int[,] matrix = CreateMatrixRndInt(rowsCount, columnsCount, -99, 99);

Console.WriteLine($"Задан массив: ");
PrintMatrix(matrix);
Console.WriteLine($"");

SortingMatrix(matrix);
Console.WriteLine($"Отсортированный массив: ");
PrintMatrix(matrix);


void SortingMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(1) - 1 - j; k++)
            {
                if (matrix[i, k] < matrix[i, k + 1])
                {
                    Swap(ref matrix[i, k], ref matrix[i, k + 1]);
                }
            }
        }
    }
}

void Swap(ref int aFirstArg, ref int aSecondArg)
{
    int tmpParam = aFirstArg;

    aFirstArg = aSecondArg;

    aSecondArg = tmpParam;
}

void PrintMatrix(int[,] matrix)
{
    string result = "";
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1)
            {
                Console.Write(matrix[i, j] + ", ");
            }
            else
            {
                Console.Write(matrix[i, j]);
            }
        }
        Console.WriteLine(" ]");
    }
}

int[,] CreateMatrixRndInt(int rowsCount, int columnsCount, int min, int max)
{
    int[,] matrix = new int[rowsCount, columnsCount];
    Random random = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = random.Next(min, max + 1);
        }
    }
    return matrix;
}

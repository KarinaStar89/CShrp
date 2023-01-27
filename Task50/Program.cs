// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1, 7 -> такого элемента в массиве нет



var matrix = CreateMatrixRndInt(4, 4, -99, 99);
PrintMatrix(matrix);

Console.WriteLine($"Введите номер строки в массиве");
int rowPos = Convert.ToInt32(Console.ReadLine());

while (rowPos < 1)
{
    Console.WriteLine($"Введите положительное целое число");
    rowPos = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine($"Введите номер столбца в массиве");
int columnPos = Convert.ToInt32(Console.ReadLine());

while (columnPos < 1)
{
    Console.WriteLine($"Введите положительное целое число");
    columnPos = Convert.ToInt32(Console.ReadLine());
}

FindPosInMatrix(matrix, rowPos, columnPos);

void FindPosInMatrix(int[,] matrix, int rowPos, int columnPos)
{
    if(rowPos > matrix.GetLength(0) || columnPos >matrix.GetLength(1))
    {
        Console.WriteLine($"Такого элемента строка = {rowPos}, столбец = {columnPos} у массива  нет");
        return;
    }

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j == (columnPos - 1) && i == (rowPos - 1))
            {
                 Console.WriteLine($"Значение позиции строка = {rowPos}, столбец = {columnPos} у массива равно {matrix[i, j]}");
                 return;
            }
        }
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

void PrintMatrix(int[,] matrix)
{
    var result = "";
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
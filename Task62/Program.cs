// *Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

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

int[,] matrix = CreateSnakeArray(rowsCount, columnsCount);

PrintMatrix(matrix);

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < 10)
            {
                Console.Write("0");
            }
            
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

int[,] CreateSnakeArray(int rowCount, int columnCount)
{
    int[,] massiv = new int[rowCount, columnCount];
    int row = 0, col = 0, dx = 1, dy = 0, dirChanges = 0, gran = columnCount;
    for (int i = 0; i < massiv.Length; i++)
    {
        massiv[row, col] = i + 1;
        if (--gran == 0)
        {
            gran = columnCount * (dirChanges % 2) + rowCount * ((dirChanges + 1) % 2) - (dirChanges / 2 - 1) - 2;
            int temp = dx;
            dx = -dy;
            dy = temp;
            dirChanges++;
        }
        col += dx;
        row += dy;
    }
    return massiv;
}
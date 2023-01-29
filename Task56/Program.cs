// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

(int,int) countRownsAndColumns = GetCountRownsAndColumns();
while (countRownsAndColumns.Item1 == countRownsAndColumns.Item2)
{
    Console.WriteLine($"Количество строк не должно быть равно количеству столбцов");
    countRownsAndColumns = GetCountRownsAndColumns();
}

int[,] matrix = CreateMatrixRndInt(countRownsAndColumns.Item1, countRownsAndColumns.Item2, -99, 99);

Console.WriteLine($"Задан массив: ");
PrintMatrix(matrix);
Console.WriteLine($"");

int[] sumRowArray = SumRowMatrix(matrix);
PrintSumArray(sumRowArray);

int minSumRowPos = MinSumRowPos(sumRowArray);
Console.WriteLine($"");
Console.WriteLine($"Cтрока с наименьшей суммой элементов: {minSumRowPos} строка");

int MinSumRowPos(int[] sumRowArray)
{
    int minValue = sumRowArray[0];
    int minPos = 0;

    for (int i = 0; i < sumRowArray.Length; i++)
    {
        if (sumRowArray[i] < minValue)
        {
            minValue = sumRowArray[i];
            minPos = i + 1;
        }
    }

    return minPos;
}

int[] SumRowMatrix(int[,] matrix)
{
    int[] sumRowArray = new int[matrix.GetLength(0)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sumRow = 0;

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumRow = sumRow + matrix[i, j];
        }

        sumRowArray[i] = sumRow;
    }

    return sumRowArray;
}

(int, int) GetCountRownsAndColumns()
{
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

    return (rowsCount, columnsCount);
}

void PrintSumArray(int[] sumArray)
{
    for (int i = 0; i < sumArray.GetLength(0); i++)
    {
        Console.WriteLine($"Сумма элементов в {i + 1} строке равна {sumArray[i]}");
    }
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

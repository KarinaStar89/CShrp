// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

(int, int) countRownsColumnsMatrix1 = GetCountRownsAndColumns();
(int, int) countRownsColumnsMatrix2 = GetCountRownsAndColumns();
while (countRownsColumnsMatrix1.Item2 != countRownsColumnsMatrix2.Item1)
{
    Console.WriteLine($"Число столбцов матрицы А не совпадает с числом строк матрицы В");
    countRownsColumnsMatrix1 = GetCountRownsAndColumns();
    countRownsColumnsMatrix2 = GetCountRownsAndColumns();
}

int[,] matrix1 = CreateMatrixRndInt(countRownsColumnsMatrix1.Item1, countRownsColumnsMatrix1.Item2, -99, 99);
int[,] matrix2 = CreateMatrixRndInt(countRownsColumnsMatrix2.Item1, countRownsColumnsMatrix2.Item2, -99, 99);

Console.WriteLine($"Задан массив 1: ");
PrintMatrix(matrix1);

Console.WriteLine($"");
Console.WriteLine($"Задан массив 2: ");
PrintMatrix(matrix2);

int[,] matrixMultiplication = MatrixMultiplication(matrix1, matrix2);

Console.WriteLine($"");
Console.WriteLine($"Результирующая матрица будет:");
PrintMatrix(matrixMultiplication);


int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
{
    if (matrixA.GetLength(1) != matrixB.GetLength(0))
    {
        throw new Exception("Умножение не возможно! Количество столбцов первой матрицы не равно количеству строк второй матрицы.");
    }

    var matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];

    for (var i = 0; i < matrixA.GetLength(0); i++)
    {
        for (var j = 0; j < matrixB.GetLength(1); j++)
        {
            matrixC[i, j] = 0;

            for (var k = 0; k < matrixA.GetLength(1); k++)
            {
                matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
            }
        }
    }

    return matrixC;
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

void PrintMatrix(int[,] matrix)
{
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
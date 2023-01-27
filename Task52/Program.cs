// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


var matrix = CreateMatrixRndInt(2, 5, -99, 99);
PrintMatrix(matrix);

var avgColumns = AvgInColumnMatrix(matrix);

Console.WriteLine($"Среднее арифметическое каждого столбца: {avgColumns}");

string AvgInColumnMatrix(int[,] matrix)
{
    string result = "";
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        double sumColumn = 0;

        for (int j = 0; j < matrix.GetLength(0); j++)
        {
           sumColumn = sumColumn + matrix[j , i];
        }

        double avgColumn = Math.Round(Convert.ToDouble((sumColumn / matrix.GetLength(0))), 2);

        if(i == 0)
        {
            result = result  +  avgColumn;
        }
        else
        {          
            result = result + ", " + avgColumn;
        }
    }

    return result;
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
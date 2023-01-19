// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

Console.WriteLine($"Введите количество элементов в массиве");
int size = Convert.ToInt32(Console.ReadLine());

while(size < 1)
{
    Console.WriteLine($"Введите положительное целое число");
    size = Convert.ToInt32(Console.ReadLine());
}

var array = CreateArrayRndDouble(size, 0, 99);
var printArray = PrintArray(array);

var diff = GetDiffMaxAndMin(array);

Console.WriteLine($"Разница между максимальным и минимальным элементов массива {printArray} равно {diff}");

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] array = new double[size];
    Random random = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.NextDouble()*(max - min) + min;
    }

    return array;
}

double GetDiffMaxAndMin(double[] array)
{
    double min = array[0];
    double max = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] <= min)
        {
            min = array[i];
        }

          if(array[i] >= max)
        {
            max = array[i];
        }
    }

    return max - min;
}

string PrintArray(double[] array)
{
    string result = "";
    for(var i = 0; i < array.Length; i++)
    {
        if(result != "")
        {
            result = $"{result}, {array[i]}";
        }
        else{
            result = $"{array[i]}";
        }
    }
    return $"[{result}]";
}
// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

Console.WriteLine($"Введите количество элементов в массиве");
int size = Convert.ToInt32(Console.ReadLine());

while(size < 1)
{
    Console.WriteLine($"Введите положительное целое число");
    size = Convert.ToInt32(Console.ReadLine());
}

var array = CreateArrayRndInt(size, -99, 99);
var printArray = PrintArray(array);

var sum = GetSumUnEvenPosition(array);

Console.WriteLine($"Сумма элементов стоящих на нечётных позициях массива {printArray} равно {sum}");

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random random = new Random();

    for (int i = 0; i < array.Length; ++i)
    {
        array[i] = random.Next(min, max + 1);
    }

    return array;
}

int GetSumUnEvenPosition(int[] array)
{
    var result = 0;
    for (int i = 0; i < array.Length; ++i)
    {
        if(i % 2 == 0)
        {
            result = result + array[i];
        }
    }

    return result;
}

string PrintArray(int[] array)
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
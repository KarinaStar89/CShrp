
Console.WriteLine($"Введите количество элементов в массиве");
int size = Convert.ToInt32(Console.ReadLine());

while(size < 1)
{
    Console.WriteLine($"Введите положительное целое число");
    size = Convert.ToInt32(Console.ReadLine());
}

var array = CreateArrayRndInt(size, 100, 999);
var printArray = PrintArray(array);

var count = GetCoutPositiveInt(array);

Console.WriteLine($"Количество положительных элементов массива {printArray} равно {count}");

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

int GetCoutPositiveInt(int[] array)
{
    var result = 0;
    for (int i = 0; i < array.Length; ++i)
    {
        if((array[i] % 2) == 0)
        {
            result++;
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
// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine($"Введите N");
int n = Convert.ToInt32(Console.ReadLine());

while (n < 1)
{
    Console.WriteLine($"Введите положительное целое число");
    n = Convert.ToInt32(Console.ReadLine());
}

int[] array =  new int[n];
FillRecursiveArray(array, n);
string printArray = PrintArray(array);

Console.WriteLine($"N = {n} -> {printArray}");

int[] FillRecursiveArray(int[] array, int n)
{
    int pos = array.Length - n;
    array[pos] = n;
    
    if (n > 1)
    {
        FillRecursiveArray(array, n - 1);
    }
    else if (n == 1)
    {
        return array;
    }
    return array;
}

string PrintArray(int[] array)
{
    string result = "";
    for (var i = 0; i < array.Length; i++)
    {
        if (result != "")
        {
            result = $"{result}, {array[i]}";
        }
        else
        {
            result = $"{array[i]}";
        }
    }
    return $"[{result}]";
}
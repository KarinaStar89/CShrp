// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine($"Введите от какого числа считать");
int from = Convert.ToInt32(Console.ReadLine());

while (from < 1)
{
    Console.WriteLine($"Введите положительное целое число");
    from = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine($"Введите до какого числа считать");
int to = Convert.ToInt32(Console.ReadLine());

while (to < 1)
{
    Console.WriteLine($"Введите положительное целое число");
    to = Convert.ToInt32(Console.ReadLine());
}

int[] array = new int[(to + 1) - from];

FillRecursiveArray(array, 0, from);
int sumArray = GetSumArray(array);

Console.WriteLine($"Сумма чисел от {from} до {to} равна {sumArray}");


int GetSumArray(int[] array)
{
    var result = 0;
    for (int i = 0; i < array.Length; ++i)
    {
        result = result + array[i];
    }

    return result;
}

void FillRecursiveArray(int[] array, int pos, int value)
{
    if (pos == array.Length)
    {
        return;
    }
    else
    {
        array[pos] = value;
        FillRecursiveArray(array, pos + 1, value + 1);
    }
}
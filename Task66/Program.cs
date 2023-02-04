// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


(int, int) readData = GetFromAndTo();

while (readData.Item1 > readData.Item2)
{
    Console.WriteLine($"До какого числа должна быть больше чем от какого числа");
    readData = GetFromAndTo();
}

int[] array = new int[(readData.Item2 + 1) - readData.Item1];

FillRecursiveArray(array, 0, readData.Item1);
int sumArray = GetSumArray(array);

Console.WriteLine($"Сумма чисел от {readData.Item1} до {readData.Item2} равна {sumArray}");


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

(int, int) GetFromAndTo()
{
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

    return (from, to);
}
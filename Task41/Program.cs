// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// -1, -7, 567, 89, 223-> 3

Console.WriteLine($"Введите количество элементов в массиве");
int size = Convert.ToInt32(Console.ReadLine());

while (size < 1)
{
    Console.WriteLine($"Введите положительное целое число");
    size = Convert.ToInt32(Console.ReadLine());
}

int[] array = CreateArrayRndInt(size);
string printArray = PrintArray(array);
int count = GetPositiveNumbers(array);
Console.WriteLine($"Количество элементов больше 0 в массиве {printArray} равно {count}");

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

int GetPositiveNumbers(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            result = result + 1;
        }
    }

    return result;
}

int[] CreateArrayRndInt(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < array.Length; ++i)
    {
        int pos = i + 1;
        array[i] = GetNumber($"Введите число {pos}");
    }

    return array;
}

int GetNumber(string text)
{
    Console.WriteLine(text);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
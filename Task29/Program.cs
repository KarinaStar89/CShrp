// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int[] array = new int[8];
FillNumber(array);
PrintArray(array);

void PrintArray(int[] collection)
{
    string result = "";
    for(var i = 0; i < collection.Length; i++)
    {
        if(result != "")
        {
            result = $"{result}, {collection[i]}";
        }
        else{
            result = $"{collection[i]}";
        }
    }
    Console.WriteLine($"Введенный массив равен [{result}]");
}

void FillNumber(int[] collection)
{
    for(var i = 0; i < collection.Length; i++)
    {
        collection[i] = GetNumber($"Введите число {i + 1}");
    }
}

int GetNumber(string text)
{
    Console.WriteLine(text);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
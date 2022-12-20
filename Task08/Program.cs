// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());

string evenNamber = "";
int i = 1;
while (i <= n)
{
    if (i % 2 == 0)
    {
        if (evenNamber == "")
        {
            evenNamber = $"{i}";
        }
        else
        {
            evenNamber = $"{evenNamber}, {i}";
        }
    }
    i++;
}
Console.WriteLine($"До числа {n} четные числа: {evenNamber}");

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

int a = GetNumber("Введите число");
int b = GetNumber("Введите степень числа");

int result = System.Math.Pow(a, b);

Console.WriteLine($"Число {a} в степени {b} равно {result}");

int GetNumber(string text)
{
    Console.WriteLine(text);
    double number = Convert.ToInt32(Console.ReadLine());
    while(number < 1)
    {
        Console.WriteLine($"Введите положительное целое число");
        number = Convert.ToInt32(Console.ReadLine());
    }
    return number;
}
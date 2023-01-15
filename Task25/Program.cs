// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

double a = GetNumber("Введите число");
double b = GetPower("Введите степень числа");

double result = System.Math.Pow(a, b);

Console.WriteLine($"Число {a} в степени {b} равно {result}");

double GetNumber(string text)
{
    Console.WriteLine(text);
    double number = Convert.ToDouble(Console.ReadLine());
    return number;
}

double GetPower(string text)
{
    Console.WriteLine(text);
    double number = Convert.ToDouble(Console.ReadLine());
    while(number < 1)
    {
        Console.WriteLine($"Введите положительное число");
        number = Convert.ToDouble(Console.ReadLine());
    }

    while (number % 1 != 0) {
        Console.WriteLine($"Введите целое число");
        number = Convert.ToDouble(Console.ReadLine());
    }
    return number;
}
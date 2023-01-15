
var a = GetNumber("Введите число");
var b = GetNumber("Введите степень числа");

var result = System.Math.Pow(a, b);

Console.WriteLine($"Число {a} в степени {b} равно {result}");

double GetNumber(string text)
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
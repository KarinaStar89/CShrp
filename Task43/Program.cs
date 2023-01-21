// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double b1 = InsertPosition($"Введите b1 первой прямой");

double k1 = InsertPosition($"Введите k1 первой прямой");

double b2 = InsertPosition($"Введите b2 второй прямой");

double k2 = InsertPosition($"Введите k2 второй прямой");

var pos = GetIntersectionLines(b1, k1, b2, k2);

Console.WriteLine($"Точка пересечения прямых y = {k1}x + {b1}, y = {k2}x + {b2} равно x = {pos.Item1} y = {pos.Item2}");

(double, double) GetIntersectionLines(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1)/(k1 - k2);

    double y = k1 * ((b2 - b1)/(k1 - k2)) + b1;

    return (x, y);
}

double InsertPosition(string text)
{
    Console.WriteLine(text);
    double pos = Convert.ToInt32(Console.ReadLine());
    return pos;
}
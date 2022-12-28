// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53
Console.WriteLine($"Введите координаты x первой точки");
double x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Введите координаты y первой точки");
double y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Введите координаты z первой точки");
double z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Введите координаты x второй точки");
double x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Введите координаты y второй точки");
double y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Введите координаты z второй точки");
double z2 = Convert.ToInt32(Console.ReadLine());

double distance = Distance(x1, y1, z1, x2, y2, z2);

Console.WriteLine($"Расстояние между точками: {distance}");

 double Distance(double x1, double y1, double z1, double x2, double y2, double z2)
    {
        return Math.Sqrt((x1 - x2) * (x1- x2) 
                         + (y1 - y2) * (y1- y2) 
                         + (z1 - z2) * (z1 - z2));
    }
// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

(int, int) readData = GetMAndN();
int akk = AkkermanFunc(readData.Item1, readData.Item2);
Console.WriteLine($"Функции Аккермана с помощью рекурсии чисел m = {readData.Item1} и n = {readData.Item2} равна {akk}");

int AkkermanFunc(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if (m > 0 && n == 0)
    {
        return AkkermanFunc(m - 1, 1);
    }
    return AkkermanFunc(m - 1, AkkermanFunc(m, n - 1));
}

(int, int) GetMAndN()
{
    Console.WriteLine($"Введите m");
    int m = Convert.ToInt32(Console.ReadLine());

    while (m < 1)
    {
        Console.WriteLine($"Введите положительное целое число");
        m = Convert.ToInt32(Console.ReadLine());
    }

    Console.WriteLine($"Введите n");
    int n = Convert.ToInt32(Console.ReadLine());

    while (n < 1)
    {
        Console.WriteLine($"Введите положительное целое число");
        n = Convert.ToInt32(Console.ReadLine());
    }

    return (m, n);
}
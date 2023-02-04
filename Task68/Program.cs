// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

(ulong, ulong) readData = GetMAndN();
ulong akk = AkkermanFunc(readData.Item1, readData.Item2);
Console.WriteLine($"Функции Аккермана с помощью рекурсии чисел m = {readData.Item1} и n = {readData.Item2} равна {akk}");

ulong AkkermanFunc(ulong m, ulong n)
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

(ulong, ulong) GetMAndN()
{
    Console.WriteLine($"Введите m");
    ulong m = Convert.ToUInt64(Console.ReadLine());

    while (m < 0)
    {
        Console.WriteLine($"Введите положительное целое число");
        m = Convert.ToUInt64(Console.ReadLine());
    }

    Console.WriteLine($"Введите n");
    ulong n = Convert.ToUInt64(Console.ReadLine());

    while (n < 0)
    {
        Console.WriteLine($"Введите положительное целое число");
        n = Convert.ToUInt64(Console.ReadLine());
    }

    return (m, n);
}
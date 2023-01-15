// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

int number = GetNumber("Введите число");
int result = GetSumNumber(number);
Console.WriteLine($"Сумма чисел числа {number} равно {result}");

int GetSumNumber(int number)
{
    number = Math.Abs(number);
    int result = 0;
    while(number > 0)
    {
        var itemNumber = number % 10;
        result = result + itemNumber;
        number = number / 10;
    }
    return result;
}

int GetNumber(string text)
{
    Console.WriteLine(text);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

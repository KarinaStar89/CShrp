// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.WriteLine("Введите число");

int inNumber = Convert.ToInt32(Console.ReadLine());
int result = 0;
int number = inNumber;
while (number > 0) {
    result *= 10;
    result += number % 10;
    number /= 10;
}

if(result == inNumber)
{
    Console.WriteLine($"Введенное число является палиндромом");
}
else
{
     Console.WriteLine($"Введенное число не является палиндромом");
}
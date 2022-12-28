// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125
Console.WriteLine($"Введите натуральное число :");
int number = Convert.ToInt32(Console.ReadLine());
Cube(number);

void Cube(int number)
{
    int index = 1;
    while(index <= number)
    {
        Console.WriteLine($"{index} -> {index * index * index}");
        index++;
    }
}
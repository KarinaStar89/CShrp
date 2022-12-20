// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число (день недели)");
int day = Convert.ToInt32(Console.ReadLine());

if(day == 1 || day == 2 || day == 3 || day == 4 || day == 5)
{
   Console.WriteLine("Этот день не является выходным");
}
else if(day == 6 || day == 7){
   Console.WriteLine("Это выходной день");
}
else{
   Console.WriteLine("Такого дня недели нет");
}
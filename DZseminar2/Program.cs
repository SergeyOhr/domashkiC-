﻿//Задача 10: Напишите программу, которая принимает на вход 
//трёхзначное число и на выходе показывает вторую цифру этого числа.

// Console.WriteLine("Введите число:");
// int X = Convert.ToInt32(Console.ReadLine());
// int x = X;
// if (X <= 99 || X > 999)
// {
//     Console.WriteLine("Вы ввели не трехзначное число");
// }
// else
// {
//     X = X / 10;
//     int res = X % 10;
//     Console.Write($"{res} является второй цифрой в числе {x}");
// }

//Задача 13: Напишите программу, которая выводит третью цифру 
//заданного числа или сообщает, что третьей цифры нет.

// Console.WriteLine("Введите число:");
// int X = Convert.ToInt32(Console.ReadLine());
// int x = X;
// if (X <= 99)
// {
//     Console.WriteLine("Третьей цифры нет");
// }
// else 
// {
//     while (X>999)
//     {
//         X = X / 10;
//     }
//     int res = X % 10;
//     Console.Write($"{res} является третьей цифрой от числа {x}");
// }

//Задача 15: Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введите цифру дня недели");
int x = Convert.ToInt32(Console.ReadLine());
if (x < 0 || x > 7)
{
    Console.WriteLine("Вы ввели не существующий день недели");
}
else if (x == 6 ||  x == 7)
{
    Console.WriteLine("Да, это выходной)");
}
else
{
    Console.WriteLine("Нет, это не выходной(");
}



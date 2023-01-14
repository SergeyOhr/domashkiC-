// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// try
// {
// Console.WriteLine("Введите целое число");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число обозначающее степень");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"{a} в степени {b} равно {St(a, b)}");
// }
// catch
// {
// Console.WriteLine("ошибка!");
// }

// int St(int z, int x)
// {
//     int res = 1;
//        for(int i = 1; i <= x; i++) res = res * z;

//     return res;
// }

///////////////////////////////////////////////////////////////
// Задача 27: Напишите программу, которая принимает на вход число и 
// выдаёт сумму цифр в числе. Через строку решать нельзя.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// try
// {
//     Console.WriteLine("Введите целое число");
//     int a = Convert.ToInt32(Console.ReadLine());

//     Console.WriteLine($"Сумма цифр в числе равна {Res(Razr(a), a)}");

// }
// catch
// {
//     Console.WriteLine("надо было вводить именно целое число");
// }

// int Razr(int b)
// {
//     int x = 0;
//     for (int i = 1; i < b; i = i * 10)
//     {
//         x += 1;
//     }
//     return x;
// }


// int Res(int z, int y)
// {
//     int c = 1;
//     int sum1 = 0;
//     int sum = 0;
//     while (c <= z)
//     {
//         sum = sum1 + y % 10;
//         c++;
//         y = y / 10;
//         sum1 = sum;
//     }
//     return sum1;
// }

/////////////////////////////////////////////////////
//Задача 29: Напишите программу, которая задаёт массив 
//из 8 целых чисел с клавиатуры и далее выводит массив на экран в одну строку.

// int[] array = new int[8];
// try
// {
// for (int i = 0; i < 8; i++)
// {
//     Console.Write($"Введите элемент массива под индексом {i}:");
//     array[i] = int.Parse(Console.ReadLine());
// }

// void Print(int[] col2)
// {
//     foreach (int item in col2) Console.Write(item + " ");
// }

// Print(array);
// }
// catch
// {
//     Console.WriteLine("надо было вводить именно целое число!");
// }

//Задача 27. - HARD необязательная Напишите программу, которая принимает 
//на вход целое или дробное число и выдаёт количество цифр в числе.

Console.WriteLine("Введите число");
double N = Convert.ToDouble(Console.ReadLine());
int a = 0; 


for (int i = 1; i < N; i = i * 10) 
{
    a += 1;
}

for (int i = 1; ((N * i) % 1) != 0; i = i * 10) 
{
    a += 1;
}

Console.WriteLine(a);
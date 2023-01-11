//Напишите программу, которая принимает на вход пятизначное число 
//и проверяет, является ли оно палиндромом. Через строку решать нельзя.
// Console.WriteLine("Введите пятизначное число:");
// int X = Convert.ToInt32(Console.ReadLine());
// int z = X;
// if (z <= 9999 || z > 99999)
// {
//     Console.WriteLine("Вы ввели не пятизначное число!");
// }
// else
// Console.WriteLine(pol(X));

// string pol(int y)
// {
// string res = "";
// if (y % 10 == y / 10000 && (y / 10) % 10 == (y / 1000) % 10) res = "Число является полиндромом";
// else res = "Число не полиндром";
// return res;
// }


//Напишите программу, которая принимает на вход координаты двух 
//точек и находит расстояние между ними в 3D пространстве.

// Console.WriteLine("Введите координату Х первой точки:");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату Y первой точки:");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату Z первой точки:");
// int z1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату Х второй точки:");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату Y второй точки:");
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату Z второй точки:");
// int z2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Dist(x1, y1, z1, x2, y2, z2));

// double Dist(int x1, int y1, int z1, int x2, int y2, int z2)
// {
//     Double d = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
//     return d;
// }

//////////Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine("Введите число (N)");
int a = Convert.ToInt32(Console.ReadLine());
for (int c = 1; c <=a; c++)
{
    Console.Write(c*c*c + " | ");
}
Console.WriteLine(" - таблица кубов чисел от 1 до " + a);

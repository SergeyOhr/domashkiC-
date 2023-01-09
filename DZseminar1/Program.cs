//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее
// Console.WriteLine("Введите первое число:");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число:");
// int y = Convert.ToInt32(Console.ReadLine());
// if (x>y)
// {
//     Console.WriteLine(x +" - число большее, "+ y + " - число меньшее");
// }
// else
// {
//     Console.WriteLine(y +" - число большее, "+ x + " - число меньшее");
// }

//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел
// Console.WriteLine("Введите первое число:");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число:");
// int y = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите третье число:");
// int z = Convert.ToInt32(Console.ReadLine());
// int max = x;
// if (y>x)
// {
//     max = y;
// }
// if (z>y)
// {
//     max = z;
// }
// Console.WriteLine("Максимальное число - "+max);

//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)
// Console.WriteLine("Введите число:");
// int x = Convert.ToInt32(Console.ReadLine());
// if (x % 2 == 0)
// {
// Console.WriteLine(x +" - четное число");
// }
// else
// {
//     Console.WriteLine(x +" - нечетное число");
// }

//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N
Console.WriteLine("Введите число:");
int x = Convert.ToInt32(Console.ReadLine());
int i = 1;
while (i <= x)
{
    if (i % 2 == 0)
    Console.Write(i + " ");
    i = i + 1;
}
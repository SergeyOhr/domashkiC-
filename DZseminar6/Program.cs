// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// Console.WriteLine("Сколько вы хотите ввести цифр?");
// int a = Convert.ToInt32(Console.ReadLine());


// void FillArray(int[] array)
// {
// for (int i = 0; i < a; i++)
// {
//     Console.WriteLine($"Введите {i + 1} число");
//     array[i] = Convert.ToInt32(Console.ReadLine());
// }
// }


// void Count(int[] array)
// {
//     int count = 0;
//     for(int i = 0; i < array.Length; i++)
//     {
//         if(array[i] > 0) count++;
//     }
//     Console.WriteLine($"Количество чисел больше 0: {count}");
// }


// int[] array = new int[a];
// FillArray(array);
// Count(array);

/////////////////////////////////////////////////////////

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5

Console.Write("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

double [] Intersec(double q, double w, double e, double r)
{
double x = -(w - r) / (q - e);
double y = q * x + w;

x = Math.Round(x, 2);
y = Math.Round(y, 2);
double [] array1 = {x, y};
return array1;
}

double[] array = Intersec(k1, b1, k2, b2);
Console.WriteLine($"Прямые пересекутся в точке ({array[0]}; {array[1]})");

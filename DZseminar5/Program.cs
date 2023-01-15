// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// void FillArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(100, 1000);
// }

// void PrintArray(int[] array)

// {
//     for (int i = 0; i < array.Length; i++)
//         Console.Write($"{array[i]} ");
//     Console.WriteLine();
// }

// void Count(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 2 == 0) count++;
//     }
//     Console.WriteLine($"Колво четных элементов : {count}");
// }



// Console.WriteLine("Введите размера массива");
// int N = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[N];
// FillArray(array);
// PrintArray(array);
// Count(array);

///////////////////////////////////////////////////////////////////////////

// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// void FillArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(10, 100);
// }

// void PrintArray(int[] array)

// {
//     for (int i = 0; i < array.Length; i++)
//         Console.Write($"{array[i]} ");
//     Console.WriteLine();
// }

// void Sum(int[] array)
// {
//     int sum = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i % 2 != 0) 
//         {
//             sum = sum + array[i];
//         }
//     }
//     Console.WriteLine($"Сумма элементов массива на нечетных позициях: {sum}");
// }

// Console.WriteLine("Введите размера массива");
// int N = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[N];
// FillArray(array);
// PrintArray(array);
// Sum(array);

//////////////////////////////////////////////////////////

//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.

void FillArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(10, 100)+ new Random().NextDouble();
}

void PrintArray(double[] array)

{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");
    Console.WriteLine();
}

void Diff(double[] array)
{
    double diff = 0;
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) 
        {
            min = array[i];
        }
        
    }
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) 
        {
            max = array[i];
        }
        
    }
    diff = max - min;
    Console.WriteLine($"Разница между максимальным и минимальным элементом равна: {diff}");
}

Console.WriteLine("Введите размера массива");
int N = Convert.ToInt32(Console.ReadLine());
double[] array = new double[N];
FillArray(array);
PrintArray(array);
Diff(array);
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Console.WriteLine("Введите m");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите n");
// int cols = Convert.ToInt32(Console.ReadLine());
// double [,] array = new double[rows,cols ];
// FillArray(array);
// PrintArray(array);


// void FillArray(double[,] array)
// {
//     for (int i=0;i<array.GetLength(0);i++)
//         for (int j=0;j<array.GetLength(1);j++)
//             array[i,j] = new Random().Next(-10, 11)+ new Random().NextDouble();

// }

// void PrintArray(double[,] array)
// {
//     for (int i=0;i<array.GetLength(0);i++)
//     {
//         for (int j=0;j<array.GetLength(1);j++)
//             Console.Write($"{Math.Round(array[i, j], 2),5} \t");
//         Console.WriteLine();
//     }
// }

//////////////////////////////////////////////////

// Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве, 
// и возвращает позицию этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// Console.WriteLine("Введите количество строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int cols = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[rows, cols];
// Console.WriteLine("Введите значение элемента");
// int x = Convert.ToInt32(Console.ReadLine());
// FillArray(array);
// PrintArray(array);
// FindEl(array);


// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             array[i, j] = new Random().Next(-10, 11);
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write($"{array[i, j],3} \t");
//         Console.WriteLine();
//     }
// }

// void FindEl(int[,] array)
// {
//     bool f = false;

//         for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i, j] == x)

//                 Console.WriteLine($"{x} на позиции ({i}, {j})");
//                 f = true;

//         }

//     if (f == false) Console.WriteLine($"Элемента равного {x} нет");

// }

/////////////////////////////////////////////////////////////////////////////

// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, cols];

FillArray(array);
PrintArray(array);
Console.Write("Среднее арифметическое каждого столбца: ");
ArithMean(array);


void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(-10, 11);
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j],3} \t");
        Console.WriteLine();
    }
}

void ArithMean(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
     
        Console.Write($"{j + 1}: {Math.Round(sum / array.GetLength(0), 2)}  ");
    }
}
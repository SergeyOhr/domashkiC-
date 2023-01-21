// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// Console.WriteLine("Введите количество строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int cols = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[rows, cols];
// FillArray(array);
// PrintArray(array);
// NewArray(array);
// Console.WriteLine();
// Console.WriteLine("Массив после упорядочивания элементов каждой строки по убыванию:");
// PrintArray(array);



// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             array[i, j] = new Random().Next(-99, 100);
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

// void NewArray(int[,] array)
// {
//         for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//         for (int q = 0; q < array.GetLength(1) - 1; q++)
//             {
//             if (array[i, q] < array[i, q + 1]) 
//             { int temp = array[i, q+1];
//             array [i, q + 1] = array [i, q];
//             array[i, q] = temp;
//             }
//             }
// }

/////////////////////////////////////////////////////////////////////////////////////////

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки 
// с наименьшей суммой элементов: 1 строка

// int[,] array = new int[5, 5];
// FillArray(array);
// PrintArray(array);
// Console.WriteLine();
// RowMinSum(array);


// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             array[i, j] = new Random().Next(-99, 100);
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

// void RowMinSum(int[,] array)
// {
//     int minSum = 0;
//     int minElRow = 0;
//     int sum = 0;
//     for (int i = 0; i < array.GetLength(0); i++) minElRow = array[0, i] + minElRow;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++) sum = array [i, j] + sum;
//         if (sum < minElRow)
//         {
//             minElRow = sum;
//             minSum = i;
//         }
//         sum = 0;
//     }
//     Console.WriteLine($"{minSum + 1} строка с наименьшей суммой");
// }

///////////////////////////////////////////////////////////////////////////////////////

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// Console.WriteLine("Введите количество строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int cols = Convert.ToInt32(Console.ReadLine());
// int[,] arrayOne = new int[rows, cols];
// int[,] arrayTwo = new int[rows, cols];
// int[,] array = new int[rows, cols];
// FillArray(arrayOne);
// Console.WriteLine("Первая матрица");
// PrintArray(arrayOne);
// Console.WriteLine("Вторая матрица");
// FillArray(arrayTwo);
// PrintArray(arrayTwo);
// Console.WriteLine("Произведение матриц");
// resultArray(arrayOne, arrayTwo);


// if (arrayOne.GetLength(0) != arrayTwo.GetLength(1))
// {
//     Console.WriteLine("Невозможно перемножить");
//     return;
// }

// void resultArray(int[,] arrayOne, int[,] arrayTwo)
// {
//     for (int i = 0; i < arrayOne.GetLength(0); i++)
//     {
//         for (int j = 0; j < arrayTwo.GetLength(1); j++)
//         {
//             array[i, j] = 0;
//             for (int k = 0; k < array.GetLength(1); k++)
//             {
//                 array[i, j] += arrayOne[i, k] * arrayTwo[k, j];
//             }
//         }

//     }
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write($"{array[i, j],3} \t");
//         Console.WriteLine();
//     }

// }

// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             array[i, j] = new Random().Next(0, 10);
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

////////////////////////////////////////////////////////////////////////

// Задача 60. ...Сформируйте трёхмерный массив из уникальных двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] array = new int[2, 2, 2];
FillArray(array);
PrintArray(array);

void FillArray(int[,,] array)
{
    int count = 10;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int q = 0; q < array.GetLength(2); q++)
            {
                array[q, i, j] += count;
                count += 3;
            }
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int q = 0; q < array.GetLength(2); q++)
            {
                Console.Write($"{array[i, j, q]}({i},{j},{q}) ");
            }
        }
    
}
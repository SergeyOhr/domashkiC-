// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Console.WriteLine("Введите натуральное  число"); 
// int N = Convert.ToInt32(Console.ReadLine()); 
// Console.WriteLine(AllNumber(N)); 


// string AllNumber(int N) 
// { 
//     if (N==1) return $" 1"; 
//     return  $" {N}" + AllNumber(N-1); 
// }

/////////////////////////////////////////////////////////////////////////
// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 36

// Console.WriteLine("Введите натуральное число N");
// int N = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите натуральное число M");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(summ(N, M));


// int summ(int N, int M)
// {
//     if (N==0) return 0;
//     return N + summ(N - 1, M);
// }

////////////////////////////////////////////////////////////////////////////

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

try
{
    Console.WriteLine("Введите натуральное число m");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите натуральное число n");
    int n = Convert.ToInt32(Console.ReadLine());
    if (m > 0 && n > 0) Console.WriteLine($"A(m,n) = {Akkerman(m, n)}");
    else Console.WriteLine("Надо было вводить именно положительное число!");
}

catch
{
    Console.WriteLine("Надо было вводить именно целое число!");
}


int Akkerman(int n, int m)
{
    if (n == 0) return m + 1;

    else if (m == 0 && n > 0) return Akkerman(n - 1, 1);

    else return (Akkerman(n - 1, Akkerman(n, m - 1)));

}

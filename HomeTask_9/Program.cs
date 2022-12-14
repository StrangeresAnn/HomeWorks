//  Задайте значение N. Напишите программу, которая выведет все 
//  натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// void ShowNums(int n)
// {
//     Console.Write(n + " ");
//     if(n > 1) ShowNums(n - 1);
// }

// Console.Write("Enter the number: ");
// int n = Convert.ToInt32(Console.ReadLine());

// ShowNums(n);

// Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.

// int SumElement(int n, int m)
// {
//     if(n < m)
//         return SumElement(n + 1, m) + n;
//     else if(m < n)
//         return SumElement(n, m + 1) + m;
//     else return n;
// }

// Console.Write("Enter the number n: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter the  number m: ");
// int m = Convert.ToInt32(Console.ReadLine());

// int res = SumElement(n, m);

// Console.WriteLine(res);

//  Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//  Даны два неотрицательных числа m и n.

// int AckermannFunction(int m, int n)
// {
//     if (m == 0)
//         return n + 1;
//     else if (m > 0 && n == 0)
//         return AckermannFunction(m - 1, 1);
//     else
//         return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
// }

// Console.Write("Enter the number m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter the  number n: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int res = AckermannFunction(m, n);

// Console.WriteLine(res);


// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// int PositiveNumbers(int numbers)
// {
//     int n = 0;
//     int count = 0;
//     while (count < numbers)
//     {
//         Console.WriteLine("Введите число: ");
//         int number = Convert.ToInt32(Console.ReadLine());
//         if(number > 0)
//         {
//             n++;
//         }
//         count++;
//     }
//     return n;
// }

// Console.WriteLine("Введите количество необходимых чисел для проверки: ");
// int numCount = Convert.ToInt32(Console.ReadLine());
// int positiveNum = PositiveNumbers(numCount);
// Console.WriteLine("Количество чисел больше 0: " + positiveNum);





// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных 
// уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.


// Console.WriteLine("Введите значение b1: ");
// int b1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите значение k1: ");
// int k1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите значение b2: ");
// int b2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите значение k2: ");
// int k2 = Convert.ToInt32(Console.ReadLine());

// string IntersectionPoint(double b1, double k1, double b2, double k2)
// {
//     if (k1 == k2)
//     {
//         if (b1 == b2)
//             return $"Одна и та же линия";

//         return $"Линии параллельны";
//     }
//     double x = (b2 - b1) / (k1 - k2);
//     double y = k1 * x + b1;
//     return $"({x}, {y})";
// }

// Console.WriteLine(IntersectionPoint(b1, k1, b2, k2));


//  Задача 2: Напишите программу, которая на вход принимает два числа  и выдаёт, какое число большее, а какое меньшее.
/*
Console.Write("Input a first number: ");
int first_number = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int second_number = Convert.ToInt32(Console.ReadLine());

if (first_number > second_number)
    Console.WriteLine($"{first_number} is greater than {second_number}");
else
    Console.WriteLine($"{second_number} is greater than {first_number}");
*/

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
Console.Write("Input a first number: ");
int first_number = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int second_number = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a third number: ");
int third_number = Convert.ToInt32(Console.ReadLine());

if (first_number > second_number && first_number > third_number)
    Console.WriteLine($"Max number:{first_number}");
else if (second_number > first_number && second_number > third_number)
    Console.WriteLine($"Max number:{second_number}");
else
    Console.WriteLine($"Max number:{third_number}"); 
*/

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*
Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 2 == 0)
    Console.WriteLine("The number is even");
else
    Console.WriteLine("The number is odd");
*/

// Задача 8: Напишите программу, которая на вход принимает число (N),а на выходе показывает все чётные числа от 1 до N.
/*
Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());
int i = 2;

if (number < 2)
    Console.WriteLine($"Please enter any number from 1");
else
    while (i <= number)
{
Console.WriteLine(i);
i = i + 2; 
}
*/
// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А

// int FindSum(int number)
// {
//     int sum = 0;

//     for(int current = 1; current <= number; current++)
//         sum += current;

//     return sum;
// }

// Console.Write("Input a number: ");
// int a = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"Sum of numbers from 1 to {a} is {FindSum(a)}");




// 1. Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

// int CountNumbers(int number)
// {
//     int count = 0;
//     if(number == 0) 
//         count = 1;
//     while(number != 0)
//     {
//         number /= 10;
//         count++; 
//     }
//     return count;
// }

// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Разряд числа{num} равен {CountNumbers(num)}");


// 2. Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

// int FindMul(int number)
// {
//     int mul = 1;

//     for (int current = 1; current <= number; ++current)
//         mul *= current;
//     return mul;
// }

// Console.Write("Input a number: ");
// int a = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"Mul of number from 1 to {a} is {FindMul(a)}");




// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями 
// и единицами в случайном порядке.

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];

//     for(int i =0; i < size; i++)
//         array[i] = new Random().Next(minValue, maxValue +1);
    
//     return array;
// }

// void ShowArray(int[] array)
// {
//     Console.Write("Array is: ");

//     for(int i =0; i < array.Length; i ++)
//         Console.Write(array[i] + " ");
//     Console.WriteLine(" :) / " );
// }

// Console.Write("Input number of elements: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min  possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(n, min, max);
// ShowArray(myArray);
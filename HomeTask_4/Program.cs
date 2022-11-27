// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A 
// в натуральную степень B.

//  Console.WriteLine("Введите число А: ");
//  int A = Convert.ToInt32(Console.ReadLine()); 
//  Console.WriteLine("Введите число В: ");
//  int B = Convert.ToInt32(Console.ReadLine());

//  int DegreeOfNumber(int num1, int num2)
//  {
//     int naturalDegree = Math.Abs(num2);
//     int res = num1;
//     for(int i = 1; i < naturalDegree; i++)
//     {   
//         res *= num1;  
        
//     }
//     return res;
//  }

//  Console.WriteLine($"{A} в натуральной степени {B} = {DegreeOfNumber(A, B)}");


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int CountDigit(int number)
// {
//     int res = 0;
    
//     while(number != 0)
//     {
//         res += number % 10;
//          number /= 10;
//     }
//     res = Math.Abs(res);
//     return res;
// }

// Console.WriteLine($"Ваше число: {num}.Сумма цифр в данном числе = {CountDigit(num)}");


// Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[]myArray = new int[size];

for(int i = 0; i < size; i++)
{
    Console.WriteLine("Введите цифру обозначающую элемент массива: ");
    myArray[i] = Convert.ToInt32(Console.ReadLine());
}

void ShowArray(int[] array)
{
    for(int i =0; i < array.Length; i ++)
        Console.Write(array[i] + " ");
}

ShowArray(myArray);

// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных элементов массива.

// int GetNegativeSum(int[] array)
// {
//     int sum = 0;

//     for(int i = 0; i < array.Length; i++)
//     {
//         if(array[i] < 0)
//             sum += array[i];
//     } 
//     return sum;
// } 

// Console.Write("Input a number of elements: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int [] myArray = CreateRandomArray(n, min,max);
// ShowArray(myArray);

// int negativSum = GetNegativeSum(myArray);
// Console.WriteLine("Sum of negativ elements is " + negativeSum);



// 1. Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

// bool IsNumberInArray(int[] array, int number)
// {
//     for (int i = 0; i < array.Length; i++)
//         if (array[i] == number) return true;
//     return false;
// }
//  int[] randArray = ReturnRandomArray(num, min, max);
// ShowArray(randomAreay);
// Console.Write("Enter the number to search: ");
// int enteredNumber = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Is number {enterNumber} in array: {IsNumberInArray(randArray, enteredNumber)}");

// 2. Задайте одномерный массив из m случайных чисел. Найдите количество элементов массива,
//  значения которых лежат в отрезке [a,b].

// int GetArrElsInRange(int[] array, int min, int max)
// {
//     int result = 0;
//     for(int i = 0; i < array.Length; i++)
//         if(array[i] <= max && array[i] >= min)
//             result++;
//     return result;

// }
//  int[] randArray = ReturnRandomArray(num, min, max);
//  ShowArray(randArray);
//  Console.Write("Enter minimal number of range: ");
//  int minValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter maximal number of range: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// int inRange = GetArrElsInRange(randArray, minValue, maxValue);
// Console.WriteLine($"In range [{minValue}, {maxValue}, is {inRange} element of arrae");


// 3. Напишите программу замена элементов массива: положительные элементы замените на 
// соответствующие отрицательные, и наоборот.

// void[] ReturnOppositeNegativArrayVelue(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//         array[i] = -array[i];

//     return array; 
// }


// int[] randArray = ReturnRandomArray(num, min, max);
// ShowArray(randArray);
// ReturnOppositeNegativArrayVelue(randArray);
// ShowArray(randArray);





// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.

// int EvenNumber(int[] array)
// {
//     int count = 0;
//     for(int i = 0; i < array.Length; i++)
//     {
//         if(array[i] % 2 == 0)
//         {
//             count++;
//         }
//     }
//     return count;
// }

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
// }

// Console.Write("Input number of elements: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int min = 100;
// int max = 999;

// int[] myArray = CreateRandomArray(n, min, max);
// ShowArray(myArray);
// int even = EvenNumber(myArray);

// Console.WriteLine("The number of even numbers in the given array " + even);



// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.


// int SumOfElements(int[] array)
// {
//     int sum = 0;
//     for(int i = 1; i < array.Length; i += 2)
//     {
//         sum += array[i];
//     }
//     return sum;
// }

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
// }

// Console.Write("Input number of elements: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min  possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(n, min, max);
// ShowArray(myArray);
// int sumElements = SumOfElements(myArray);

// Console.WriteLine("Sum of elements in odd positions" + sumElements);


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным 
// и минимальным элементов массива.

double DifferenceMaxAndMin(double[] array)
{
    double max = array[0];
    double min = array[0];
    double res = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > max)
        {
            max = array[i];
        }
        if(array[i] < min)
        {
            min = array[i];
        }

    }
    max = Math.Round(max);
    min = Math.Round(min);
    res = max - min;
    return Math.Round(res);
}

double[] CreateRandomMaterialArray(int size)
{
    double[] array = new double[size];

    for(int i =0; i < size; i++)
        array[i] = Math.Round(new Random().NextDouble());
    
    return array;
}

void ShowArray(double[] array)
{
    Console.Write("Array is: ");

    for(int i =0; i < array.Length; i++)
        Console.Write(array[i] + " ");
}

Console.Write("Input number of elements: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min  possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

double[] myArray = CreateRandomMaterialArray(n);
ShowArray(myArray);
double difference = DifferenceMaxAndMin(myArray);

Console.WriteLine("Sum of elements in odd positions" + difference);




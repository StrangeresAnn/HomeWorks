// int[,] ReturnRandom2DArray(int rows, int cols, int minValue, int maxValue)
// {
//     int[,] array = new int[rows, cols];

//     for (int i = 0; i < rows; i++)
//         for (int j = 0; j < cols; j++)
//             array[i, j] = new Random().Next(minValue, maxValue + 1);

//     return array;
// }

// void Show2DArray(int[,] array, string msg="Generated array:\n")
// {
//     Console.WriteLine(msg);

//     for (int i = 0; i < array.GetLength(0); i++)
//         {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write($"{array[i, j]}\t");

//         Console.WriteLine();
//         }

//     Console.WriteLine();
// }

// Console.Write("Enter a number of rows: ");
// int numX = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter a number of columns: ");
// int numY = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter a minimal possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter a maximal possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,] rand2DArr = ReturnRandom2DArray(numX, numY, min, max);
// Show2DArray(rand2DArr);

// int[,] squishedArray = SquishArray(rand2DArr);
// Show2DArray(squishedArray, "Squished array:");


//Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.

// void DescendingElements(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1) - 1; j++)
//             for (int k = j + 1; k < array.GetLength(1); k++)
//                 if (array[i, j] < array[i, k])
//                     {
//                         int temp = array[i, j];
//                         array[i, j] = array[i, k];
//                         array[i, k ] = temp;
//                     }
// }

// Console.Write("Enter a number of rows: ");
// int numX = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter a number of columns: ");
// int numY = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter a minimal possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter a maximal possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,] rand2DArr = ReturnRandom2DArray(numX, numY, min, max);
// Show2DArray(rand2DArr);

// DescendingElements(rand2DArr);
// Show2DArray(rand2DArr);



// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// int[] ArraySum(int[,] array)
// {
//     int[] sumStrArray = new int[array.GetLength(0)];
    
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         int sum = 0;

//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             sum += array[i, j];
//         }  
//         sumStrArray[i] = sum; 
//     }
//     return sumStrArray;
// }
// int StringSumMin(int[,] array)
// {
//     int[] sumStr = ArraySum(array);
//     int str = 0;
//     for (int i = 0; i < sumStr.Length; i++)
//     {
//         if (sumStr[i] < sumStr[str])
//         {
//             str = i;
//         }
//     }
//     return str + 1;
// }

// Console.Write("Enter a number of rows: ");
// int numX = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter a number of columns: ");
// int numY = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter a minimal possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter a maximal possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,] rand2DArr = ReturnRandom2DArray(numX, numY, min, max);
// Show2DArray(rand2DArr);

// int resStr = StringSumMin(rand2DArr);
// Console.WriteLine("Строка: " + resStr);

// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.

// int[,] MatrixProduct(int[,] matrix1, int[,] matrix2)
// {
//     int[,] resultMatrix = new int[matrix1.GetLength(0), matrix1.GetLength(1)];
//     if (matrix1.GetLength(0) == matrix2.GetLength(1))
//     {
//         for (int i = 0; i < matrix1.GetLength(0); i++)
//         {
//             for (int j = 0; j < matrix2.GetLength(1); j++)
//             {
//                 for (int k = 0; k < matrix2.GetLength(0); k++)
//                 {
//                     resultMatrix[i,j] += matrix1[i,k] * matrix2[k,j];
//                 }
//             }
//         }
//     }
//     return resultMatrix;
// }

// Console.WriteLine("First matrix data:");
// Console.Write("Enter a number of rows: ");
// int numX = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter a number of columns: ");
// int numY = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter a minimal possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter a maximal possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Second matrix data:");
// Console.Write("Enter a number of rows: ");
// int numX2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter a number of columns: ");
// int numY2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter a minimal possible value: ");
// int min2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter a maximal possible value: ");
// int max2 = Convert.ToInt32(Console.ReadLine());

// int[,] firstMatrix = ReturnRandom2DArray(numX, numY, min, max);
// Show2DArray(firstMatrix, "First matrix:");
// int[,] secondMatrix = ReturnRandom2DArray(numX2, numY2, min2, max2);
// Show2DArray(secondMatrix, "Second matrix:");
// int[,] resultMatrix = MatrixProduct(firstMatrix, secondMatrix);
// Show2DArray(resultMatrix, "Result matrix:");

// Задача 60.Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.

// int[] UniqueArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//     Random rand = new Random();
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = rand.Next(minValue, maxValue);
//         if (i != 0)
//         {
//             for (int j = 0; j < i; j++)
//                 while (array[j] == array[i])
//                 {
//                     array[i] = rand.Next(minValue, maxValue + 1);
//                     j = 0;
//                 }
//         }
//     }
//     return array;
// }
// int[,,] Unique3DArray(int xSize=2, int ySize=2, int zSize=2, int minValue=10, int maxValue=99)
// {
//     int[,,] array = new int[xSize, ySize, zSize];
//     int[] baseArray = UniqueArray(xSize * ySize * zSize, minValue, maxValue);
//     int baseIndex = 0;
//     for (int i = 0; i < xSize; i++)
//         for (int j = 0; j < ySize; j++)
//             for (int k = 0; k < zSize; k++)
//             {
//                 array[i, j, k] = baseArray[baseIndex];
//                 baseIndex++;
//             }
//     return array;
// }
// void Show3DArray(int[,,] array)
// {
//     for (int y = 0; y < array.GetLength(2); y++)
//     {
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             string output = string.Empty;
//             for (int j = 0; j < array.GetLength(1); j++)
//                 output += $"{array[i, j, y]}({i},{j},{y}) ";
//             Console.WriteLine(output);
//         }
//         Console.WriteLine();
//     }
// }

// Console.WriteLine("Enter three dimensions of the array (x * y * z <= 90)");
// Console.Write("Enter x dimension of the array: ");
// int arrayX = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter y dimension of the array: ");
// int arrayY = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter z dimension of the array: ");
// int arrayZ = Convert.ToInt32(Console.ReadLine());

// int[,,] rand3DArr = Unique3DArray(arrayX, arrayY, arrayZ);
// Show3DArray(rand3DArr);

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

// void FillingArray (int[,] array)
// {
//     int iStart = 0, iEnd = 0, jStart = 0, jEnd = 0;

//     int i = 0;
//     int j = 0;

//     for (int k = 0; k < array.Length; k++)
//     {
//         array[i, j] = k + 1;
//         if (i == iStart && j < array.GetLength(1) - jEnd - 1)
//             j++;
//         else if (j == array.GetLength(1) - jEnd - 1 && i < array.GetLength(0) - iEnd - 1)
//             i++;
//         else if (i == array.GetLength(0) - iEnd - 1 && j > jStart)
//             j--;
//         else
//             i--;

//         if ((i == iStart + 1) && (j == jStart) && (jStart != array.GetLength(1) - jEnd - 1)){
//             iStart++;
//             iEnd++;
//             jStart++;
//             jEnd++;
//         }
//     }
// }

// Console.Write("Enter a number of rows: ");
// int Rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter a number of columns: ");
// int Columns = Convert.ToInt32(Console.ReadLine());
// int[,] newArray = new int[Rows, Columns];

// Show2DArray(newArray);
// FillingArray(newArray);
// Show2DArray(newArray, "Filled array:");
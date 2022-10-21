// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).
/*
void ShowQuart(int quartNum)
{
if(quartNum >= 1 && quartNum <= 4)
{
    if(quartNum == 1) Console.WriteLine("x > 0 and y > 0");
    else if (quartNum == 2) Console.WriteLine("x < 0 and y > 0");
    else if (quartNum == 2) Console.WriteLine("x < 0 and y < 0");
    else Console.WriteLine("x > 0 and y < 0");
}
else
    Console.WriteLine("Wrong number!");
}

Console.Write("Input a number of quart: ");
int num = Convert.ToInt32(Console.ReadLine());

ShowQuart(num);
*/


// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

/*
int QuarterNumber(double x,double y)
{
    if(x > 0 && y > 0)   return 1;
    if(x < 0 && y > 0)   return 2;
    if(x < 0 && y < 0)   return 3;
    if(x > 0 && y < 0)   return 4;
    return 0;
}
Console.WriteLine("Введите координаты x и y");
double x = Convert.ToDouble(Console.ReadLine());
double y = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(QuarterNumber(x,y));
*/

// Напишите программу, которая принимает на вход координаты двух точек и находит 
// расстояние между ними в 2D пространстве.
/*
double Distance(double x1, double y1, double x2, double y2)
{
    double catet1 = x1 - x2;
    double catet2 = y1 - y2;
    double result3 = Math.Sqrt(result1*result1 + result2*result2);
    return result3;
}

Console.WriteLine("Введите координаты x1");
double num1 = Convert.ToDouble(ConsoleReadLine());
Console.WriteLine("Введите координаты y1");
double num2 = Convert.ToDouble(ConsoleReadLine());
Console.WriteLine("Введите координаты x2");
double num3 = Convert.ToDouble(ConsoleReadLine());
Console.WriteLine("Введите координаты y2");
double num4 = Convert.ToDouble(ConsoleReadLine());
Console.WriteLine($"Ответ: {Distanse(result1, result2, result3, result4)}");
*/


// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N. (void)
 /*
 void Table(int number)
 {
    int index = 1;
    while (index <= number)
    {
        double result = Math.Pow(index,2);
        Console.Write(result + " ");
        index++;
    }
 }
 Console.Write("Введите число: ");
 int res = Convert.ToInt32(Console.ReadLine());
 Table(res);
 */
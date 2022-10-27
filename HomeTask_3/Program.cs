// Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
void CubeTable(int num)
{
    int i = 1;
    while (i <= num)
    {
        Console.WriteLine(Math.Pow(i,3));
        i++;
    }
}

Console.WriteLine("Enter the number: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num <= 0)
    Console.WriteLine("Enter a number from 1");
else
    CubeTable(num);

*/

// Задача 19:
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
Console.WriteLine("Введите число или слово: ");
string arrayNumb = Console.ReadLine();
int rightIndex = arrayNumb.Length - 1;
int leftIndex = 0;
bool isPal = false;

bool Palindrome(string arrayNumb)
{
    while (arrayNumb[leftIndex] == arrayNumb[rightIndex])
    {
        leftIndex=+1; rightIndex=-1;

        if (leftIndex >= rightIndex)
        {
            isPal = true;        
            break;
        }
    }
    return isPal;
}

Palindrome(arrayNumb);

if (isPal)
{
    Console.WriteLine("Введенное вами является палиндромом");
}
else
{
    Console.WriteLine("Введенное вами не является палиндромом");
}
*/

// Задача 21:
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между 
// ними в 3D пространстве.

/*
double DistancePoints(int x1, int y1, int z1, int x2, int y2, int z2)
{
    return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
}

Console.WriteLine("Введите x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(DistancePoints(x1, y1, z1, x2, y2, z2));
*/

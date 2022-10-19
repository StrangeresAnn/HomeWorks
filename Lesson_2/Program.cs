// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
/*
int CutDigit(int number)
{
    int ed = number % 10;
    int sot = number / 100;

    int result = sot * 10 + ed;
    return result;
}

int randNum =new Random().Next(100, 1000);
int newNum = CutDigit(randNum);

Console.WriteLine($"New version of {randNum} is {newNum}");
*/

//Метод для вывода чет или нечет
/*
bool IsEven(int number) 
{
    if(number % 2 == 0)
        return true;
    else
        return false;
}

bool result = IsEven(newNum);
Console.WriteLine(result);
*/

// && - И 
// || - или



// Напишите программу, которая выводит случайное 
// число из отрезка [10, 99] и показывает наибольшую цифру числа.

/*
int NumMax(int number)
{
    int ed = number % 10;
    int des = number / 10;
    if (ed > des)
        return ed;
    else
        return des;
}

int num = new Random().Next(10, 100);
Console.WriteLine($"Max digit of {num} is {NumMax(num)}");
*/

// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
/*
bool CheckNumbers(int arg1, int arg2)
{
    if (arg1 * arg1 == arg2 || arg2 * arg2 == arg1)
        return true;
    else
        return false;
}

Console.Write("First ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Second ");
int num2 = Convert.ToInt32(Console.ReadLine());

bool res = CheckNumbers(num1, num2);
Console.WriteLine(res);
*/

// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому.
/*
bool Multiple(int arg1, int arg2)
{
    if (arg2 % arg1 == 0)
        return true;
    else
        return false;
}

Console.Write("First ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Second ");
int num2 = Convert.ToInt32(Console.ReadLine());

bool res = Multiple(num1, num2);
Console.WriteLine(res);
*/

// Напишите программу, которая принимает на три целых числа(a, m, n) и проверяет, кратно ли число a одновременно m и n.
/*
bool Multiple (int a1, int m1, int n1)
{
    if(a1 % n1 == 0 && a1 % m1 == 0)
        return true;
    else
        return false;
}

Console.Write("first num: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Second num: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Third num: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write(Multiple(a,m,n));
*/

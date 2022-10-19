// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
Console.Write("Enter a three-digit number: ");
int num = Convert.ToInt32(Console.ReadLine());

int SecondDigit (int number)
{
int ed = number % 10;
int sot = number / 100;
int result = (number - (sot*100) - ed) / 10;
return result;
}

int newNum = SecondDigit(num);
Console.WriteLine($"The second digit of {num} is {newNum}");
*/

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/* Решение через string:*/
/*
Console.Write("Enter a three-digit number: ");
string num = Console.ReadLine();
if (num.Length > 2 )
    Console.WriteLine(num[2]);
else
    Console.WriteLine("No third digit");
*/

// Решение через цикл:
/*
Console.Write("Enter a three-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());

int ThirdDigit (int num)
{
while (num >= 1000)
{
        num = num / 10;
}
if (num >= 100)
    num = num % 10;
else
    num = -1;

    return num;
}

int result = ThirdDigit(number);

if (result == -1)
    Console.WriteLine("No third digit");
else
    Console.WriteLine(result);
*/

// Задача 15: Напишите программу, которая принимает на вход цифру,обозначающую день недели, и проверяет, является ли этот день выходным.
/*
Console.Write("Enter a number from 1 to 7: ");
int number = Convert.ToInt32(Console.ReadLine());
bool DayWeek(int num)
{
if (num >= 6)
    return true;
else
    return false;
}
bool result = DayWeek(number);
if (number > 0 && number <= 7)
    Console.WriteLine(DayWeek(number));
else
    Console.WriteLine("You entered a number that is not in the range from 1 to 7");
*/
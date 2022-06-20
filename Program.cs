// 1. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
 void SecondNumWrite(int num)

{
    int result = num / 10 % 10;
    Console.WriteLine(result);
}

Console.WriteLine("Input integer three-digit number: ");
int n = Convert.ToInt32(Console.ReadLine());

SecondNumWrite(n);

// 2. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

 void ThirdNumWrite(int num)
 
 {
     int current = num;
     if (num < 100)
     {
         Console.WriteLine("Third number is absent");
        
     }
    
     else 
         {while (current > 999)
     {
         current = current / 10;
     }
    int result = current % 10; 
    Console.WriteLine("Third number is " + result);
    }
}

Console.WriteLine("Input integer number: ");
int n = Convert.ToInt32(Console.ReadLine());

ThirdNumWrite(n);

// 3. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

void CheckDayOff(int num)

{
    if (num == 6 || num == 7)
 {
    Console.WriteLine("This day is day off!");
        
 }
    else 
    {
        Console.WriteLine("This day is weekday ((");
    }
}

Console.WriteLine("Input the week's day number: ");
int n = Convert.ToInt32(Console.ReadLine());

CheckDayOff(n);

// 4.Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

void FindDoubleMultiply(int num)
{   
    int result1 = num % 7;
    int result2 = num % 23;
    if (result1 == 0 && result2 == 0)
    {   
        Console.WriteLine(num + " => Yes");
    }
    else 
    {
        Console.WriteLine(num + " => No");
    }
 }
 
Console.WriteLine("Input integer number: ");
int n = Convert.ToInt32(Console.ReadLine());

FindDoubleMultiply(n);

// 5. Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

void FindSquare(int num1,int num2)
{   
    int result = num2 * num2;
    if (result == num1)
    {   Console.WriteLine(num1 + " is a square of " + num2 + "!");
    }
    else 
    {
        Console.WriteLine(num2 + " is not a square of " + num2 + " (( ");
    }
 }
 
Console.WriteLine("Input integer number 1: ");
int n1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input integer number 2: ");
int n2 = Convert.ToInt32(Console.ReadLine());

FindSquare(n1,n2);
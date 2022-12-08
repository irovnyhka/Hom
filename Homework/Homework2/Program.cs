//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1

int TwoNumber(int num)
{
    int res = (num % 100) / 10;
    return res;
}
 int random = new Random().Next(100,1000);
 int newNumber = TwoNumber(random);
 Console.WriteLine($"New version of {random} is {newNumber}");

 // Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

//645 -> 5

//78 -> третьей цифры нет

//32679 -> 6

int ThirdDigit(int number)
{
    int third = -1;
    if (number >= 100)
    {
        while (number > 999)
        {
            number = number /10;   
        }
        third = number % 10;
    }
       return third;
}
Console.Write("Input three-digit number: ");
int number1 = Convert.ToInt32(Console.ReadLine());

if (ThirdDigit(number1) == -1)
Console.WriteLine("третьей цифры нет");
else
Console.WriteLine($"Third digit is {ThirdDigit(number1)}");




//: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет




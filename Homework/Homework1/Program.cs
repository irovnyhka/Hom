//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Input namber 1");  
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input namber 2");  
int num2 = Convert.ToInt32(Console.ReadLine());

int a = num1;
int b = num2;

int max = a;
int min = b;
    
if ( a > max) max = a;
{  
     Console.WriteLine($"{num1} > {num2}");  
}    

Console.Write(max);


   
 
 
 
 
  // Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Input namber 1");  
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input namber 2");  
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input namber 3");  
int num3 = Convert.ToInt32(Console.ReadLine());

int a = num1;
int b = num2;
int c = num3;

int max =a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max =c;
Console.Write("max = ");
Console.WriteLine(max);

  //программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).


Console.WriteLine("Input namber N");  
int N = Convert.ToInt32(Console.ReadLine());
int a = N;
if (a % 2 ==0)
{
    Console.WriteLine("An even number");
}
else
{
    Console.WriteLine("Odd number");
}



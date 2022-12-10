
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.


Console.Clear();
 
void PalindromicMirror(int number)
{
    if(number >= 10000)
    {
        int mirror1 = number / 10000;
        int remolt1 = number % 10;
 
            if(mirror1 == remolt1)
            {
                number = number / 10;
                int mirror2 = (number / 100) % 10;
                int remolt2 = number % 10;
                if(mirror2 == remolt2)
                    Console.WriteLine($"{number} -> Yes");
            }
            else 
            Console.WriteLine($"{number} -> No");
            
    }
    else
    Console.Write("Invalid number!");
}
 
Console.WriteLine("Введите пятизначное число:");
int NewNumber = int.Parse(Console.ReadLine()!);
PalindromicMirror(NewNumber);





//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125


void PartRed(int N )
{
   for (int i = 1; i <= N; i++)
   { 
      Console.Write($"{i*i*i} ");
   }
}
Console.WriteLine("Введите число N = ");
int N = Convert.ToInt32(Console.ReadLine());

PartRed(N);


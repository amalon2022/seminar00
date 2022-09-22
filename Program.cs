// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным 
// (делится ли оно на два без остатка).

// 4 -> да
// -3 -> не

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;                             
            Console.WriteLine("введите число: ");
            num1 = Convert.ToInt32(Console.ReadLine()); 
 
            if (num1 % 2 == 0)
            {
                Console.Write("четное число");
           
            }
            else
            {
                Console.Write("не четное число");
            }
             Console.ReadKey();
        }
     }
    }
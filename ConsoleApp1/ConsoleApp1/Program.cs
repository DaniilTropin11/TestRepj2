using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            string year1 = Console.ReadLine();

            //string year1 = Console.ReadLine();

            int number = int.Parse(year1);
            int number2 = number % 4;


            if (number2 != 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($" {year1}  Не високосный год");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($" {year1}  Високосный год");
            }
           
            





            Console.ReadKey();
        }
    }
}

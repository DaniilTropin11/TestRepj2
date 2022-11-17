using System;

namespace nasledclass
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void PrintName()
        {
            Console.WriteLine($"Мое имя {FirstName}{LastName}!");
        }


    }
    class Student : Person
    {
        public void Learn()
        {
            PrintName();
            Console.WriteLine(" я учусь!");

        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Student person = new Student { FirstName = "Daniil", LastName = "Tropin" };
            person.Learn();



        }
    }
}

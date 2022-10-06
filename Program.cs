using System;

namespace ConsoleApp1
{
    class Person
    {
        static void Main(string[] args) { }


        private string name; 
        private string surname;
        private int year;
        

        public Person(string name, string surname, int year)
        {
            this.name = name;
            this.surname = surname;
            if (year < 0)
                Console.WriteLine("вфыывфвфы");
            else
                this.year = year;

        }
        public Person()
        {
            name = "";
            surname = "";
            year = 0;
        }

        class Person1 : Person
        {
            public string ToFullString(string name, string surname, int year)
            {
                return name + surname + year;
               
            }
            public string ToShortString(string name, string surname)
            {
                return name + surname;
            }
        }

            
        
     }

            



}
    
        


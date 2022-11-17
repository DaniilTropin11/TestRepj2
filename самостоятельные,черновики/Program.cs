using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {

            Person std = new Person("Даниил", "Тропин", new DateTime(2001, 12, 22));
            Console.WriteLine(std.ToFullString());
            //Person std2 = new Person("Даниил", "Тропин", DateTime.Parse("December 22, 2001"));
            //Console.WriteLine(std.ToString(std.BDate.ToString("dd.MM")));
        }

        class Person
        {
            private

            string Name;
            string LastName;
            System.DateTime BDate;



            public Person(string studentName, string studentLastName, DateTime studentBDate)
            {
                Name = studentName;
                LastName = studentLastName;
                BDate = studentBDate;
            }


            public Person() : this("Default_Name", "Default_Sname", new DateTime(2001, 22, 12))
            { }



            string StdName
            {
                get
                {
                    return Name;
                }

            }

            string StdLastName
            {
                get
                {
                    return LastName;
                }

            }

            DateTime StdBDate
            {
                get
                {
                    return BDate;
                }

            }

            int intStdBdate
            {
                get
                {
                    return Convert.ToInt32(BDate);
                }
                set
                {
                    BDate = Convert.ToDateTime(value);
                }

            }



           
            public string ToFullString()
            {

                // return "имя " + Name + " Фамилия " +LastName;
                return $"имя {Name} Фамилия {LastName} Дата рождения {StdBDate:dd MMMM}";
                //return string.Format("имя {0} Фамилия {1} {0}",Name,LastName);


            }
        }               



            //public string ToShortString()
            //{
            //    return "\n" + "Имя: " + Name + "\n" + "Фамилия: " + LastName;
            //}
    }
}
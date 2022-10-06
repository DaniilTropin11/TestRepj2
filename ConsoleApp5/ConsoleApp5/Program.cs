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

            Person std = new Person("Даниил", "Тропин", new DateTime(2010, 10, 10));
            Console.WriteLine(std.ToShortString());
            //Person std2 = new Person("Даниил", "Тропин", "April 10, 2009");
            //Console.WriteLine(std2.ToString());
        }
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


        //public string ToFullString()
        //{
        //    return "\n" + "Имя: " + Name + "\n" + "Фамилия: " + LastName "\n" + "Дата рождения" + BDate;
        //}
        public override string ToString()
        {
            return string.Format("{0} {1}\nDate of birth: {2}", Name, LastName, BDate);
        }



        public string ToShortString()
        {
            return "\n" + "Имя: " + Name + "\n" + "Фамилия: " + LastName;
        }
    }
} 



using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}

enum Frequency { Weekly, Monthly, Yearly }


public class Person
{
    private string _name;
    private string _surname;
    public Person(string name, string surname)
    {
        _name = name;
        _surname = surname;
       
    }
}
class Article
{
    public Article(string name, double rating, Person author)
    {
        Name = name;
        Rating = rating;
        Author = author;
    }

    public Article()
    {
        Name = "Какой-то артикель";
    }
    public string Name { get; set; }
    public double Rating { get; set; }
    public Person Author { get; set; }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp3
{
    #region название региона
    class Program
    {
        static void Main(string[] args)
        {
            Article a = new Article();

            Console.WriteLine(a.ToFullString());
            Author author = new Author("","",new DateTime(2010,10,10), "",1,"222");
            Console.WriteLine(author.ToFullString());
        }
    }

    #endregion
    enum Frequency { Weekly, Monthly, Yearly }


    public class Author
    {


        public Author(string name, string surName, DateTime birthDate, string location, int amountPublication, string lastName)
        {
            Name = name;
            SurName = surName;
            BirthDate = birthDate;
            Location = location;
            AmountPublication = amountPublication;
            LastName = lastName;
        }

        public string Name { get; set; }
        public string SurName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Location { get; set; }
        public int AmountPublication { get; set; }
        public string LastName { get; set; }
        public string ToFullString()
        {
            return $"/n имя Автора{Name} /n Фамилия Автора{SurName} /n Дата рождение {BirthDate} /n Место рождение {Location} /n {AmountPublication} /n {LastName}";
        }

    }
    class Article
    {
        public Article(string name, double rating, Author author)
        {
            Name = name;
            Rating = rating;
            Author = author;
        }

        public Article()
        {
            Name = "Какой-то артикель";
            Rating = 3.5;
            Author = new Author("name", "surname", new DateTime(2000, 12, 1), "location", 2007, "lastName");

        }
        public string Name { get; set; }
        public double Rating { get; set; }
        public Author Author { get; set; }

        public string ToFullString()
        {
            return $"имя Артикля {Name} Рейтинг {Rating} Автор {Author}";
        }
    }
}
       

            











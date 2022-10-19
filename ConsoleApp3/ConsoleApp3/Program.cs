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
            Magazine magazine = new Magazine("", 2, new DateTime(2010, 10, 10), 3, "");
            Console.WriteLine(magazine.ToFullString());
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
            return $"/n Лев {Name} /n Толстой{SurName} /n 09.09.1828 {BirthDate} /n Российская империя {Location} /n 1863  {AmountPublication} /n {LastName}";
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
            Rating = 10;
            Author = new Author("name", "surname", new DateTime(2000, 12, 1), "location", 2007, "lastName");

        }
        public string Name { get; set; }
        public double Rating { get; set; }
        public Author Author { get; set; }

        public string ToFullString()
        {
            return $"Война и мир {Name} Рейтинг {Rating} Л.Н. Толстой {Author}";
        }
    }


    public class Magazine
    {

        public Magazine(string name, int frequency, DateTime publicationDate, int circulation, string article)
        {
            Name = name;
            Frequency = frequency;
            PublicationDate = publicationDate;
            Circulation = circulation;
            Article = new Article[]
                { new Article("Выход 1",2,new Author("Семен", "Иванович", 10,2009,"Ivanovo",3,"abc")),
                  new Article("Статья 2", 2,new Author("Семен", "Иванович", 10,2009,"Ivanovo",3,"abc"))
                };

        }

        public string Name { get; set; }
        public int Frequency { get; set; } // Частота
        public DateTime PublicationDate { get; set; }
        public int Circulation { get; set; } // номер тиража 
        public string Article { get; set; }


        public string ToFullString()
        {
            return $"/n Русская правда {Name} /n Каждый месяц{Frequency}  {PublicationDate} /n тираж журнала {Circulation} /n списком статей в журнале {Article}";
        }

       
       
}
   
    }

















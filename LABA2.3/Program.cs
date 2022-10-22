using System;
using System.Linq;

namespace laba

{
    enum Frequency { Weekly, Monthly, Yearly }
    class Program
    {
        private static void Main()
        {
            Article[] articles = new Article[3];
            Person o = new Person("", "");
        }
    }

    public class Person
    {
        public string Name { get; }
        public string Surname { get; }

        public Person(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }
        public string FullName => $"{Surname} {Name}";

    }
    public class Article
    {
        public Person Author { get; }
        public string Title { get; }
        public double Rating { get; }

        public Article(Person author, string title, double rating)
        {
            Author = author;
            Title = title;
            Rating = rating;
        }
        public Article()
        {
            Author = new Person("Даниил", "Тропин");
            Title = "УЧИМ ПРОГРАММИРОВАНИЕ";
            Rating = 10;
        }
        public string ToFullString()
        {
            return $"{Author.Name} {Author.Surname} - {Title}. Рейтинг: {Rating}"; // описание 
        }
    }
    public class Magazine
    {
        private string _name;
        private Frequency _frequency;
        private DateTime _release;
        private int _amountSells;
        private Article[] _articles;
        private Magazine(string name, Frequency frequency, DateTime release, int amountSells)
        {
            _name = name;
            _frequency = frequency;
            _release = release;
            _amountSells = amountSells;
        }
        public Magazine()
        {
            _name = "Журнал правда";
            _frequency = Frequency.Weekly;
            _release = new DateTime(2022, 10, 20);
            _amountSells = 100232;
            _articles = new[] { new Article() };
        }
        public string Name { get { return _name; } set { _name = value; } }
        private Frequency Frequency { get { return _frequency; } set { _frequency = value; } }
        public DateTime Release { get { return _release; } set { _release = value; } }
        public int AmountSells { get { return _amountSells; } set { _amountSells = value; } }
        public Article[] Articles { get { return _articles; } set { _articles = value; } }
        public void AddArticles(params Article[] newArticles)
    {
            
    }

        public double? MiddleRating
        {
            get
            {
                if (_articles is null)
                {
                    return null;
                }
                return _articles.Sum(x => x.Rating) / _articles.Length;
            }
        }
    }
}



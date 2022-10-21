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
        private static void Main()
        {
            Magazine magazine = new();
            Console.WriteLine(magazine.ToFullString());
        }
    }

    #endregion
    enum Frequency { Weekly, Monthly, Yearly }// перечисление 


    public class Person
    {
        public string Surname { get; }
        public string Name { get; }
        public Person(string surname, string name)
        {
            Surname = surname;
            Name = name;
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
            Author = new("Акакий", "Виктор");
            Title = "Как стать успешным за 0 дней";
            Rating = 4.7;
        }
        public string ToFullString()
        {
            return $"{Author.Name} {Author.Surname} - {Title}. Рейтинг: {Rating}.";
        }
    }


    public class Magazine
    {
        private readonly string _name;
        private readonly Frequency _frequency;
        private readonly DateTime _release;
        private readonly int _amountSells;
        private Article[]? _articles;
        public Magazine(string name, Frequency frequency, DateTime release, int amountSells)
        {
            _name = name;
            _frequency = frequency;
            _release = release;
            _amountSells = amountSells;
        }
        public Magazine()
        {
            _name = "Журнал Акакия";
            _frequency = Frequency.Weekly;
            _release = new(2022, 10, 20, 20, 41, 23);
            _amountSells = 100232;
            _articles = new[] { new Article() };
        }
        public string Name => _name;
        public Frequency Frequency => _frequency;
        public DateTime Release => _release;
        public int AmountSells => _amountSells;
        public Article[] Articles => _articles;
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
        public void AddArticles(params Article[] articles)
        {
            _articles = articles;
        }
        public string ToFullString(bool isArticles = true)
        {
            StringBuilder builder = new();
            string baseString = $"Название журнала: {Name}\n" +
                $"Частота выпуска: {Frequency}\n" +
                $"Дата выпуска: {Release.ToLongDateString()}\n" +
                $"Кол-во продаж: {AmountSells}";
            if (isArticles)
            {
                builder.Append(baseString);
                for (int i = 0; i < Articles.Length; i++)
                {
                    builder.Append($"\nСтатья {i + 1}) {Articles[i].ToFullString()}");
                }
                return builder.ToString();
            }
            return baseString;
        }
        public string ToShortString()
        {
            return $"{ToFullString(false)}\n" +
                $"Средний рейтинг: {MiddleRating}";
        }
    }
}
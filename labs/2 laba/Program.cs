using System;
namespace laba

{
    class Program
    {
        private static void Main() //+ в мейне по заданию больше действий нужно
        {
            Article[] ar = { new Article(), new Article() };
            Magazine magazine = new Magazine();
            Console.WriteLine(magazine.Articles.Length);
            magazine.AddArticles(ar);
            Console.WriteLine(magazine.Articles.Length);
            Console.WriteLine(magazine.ToFullString());
           
        }
    }// Всё наверное
    public enum Frequency { Weekly, Monthly, Yearly }

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
            Author = new("Даниил", "Тропин");
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
        private readonly string _name;
        private readonly Frequency _frequency;
        private readonly DateTime _release;
        private readonly int _amountSells;
        private Article[] _articles;
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
    public void AddArticles( Article[] ArticlesToAdd) // неправильно реализован public void AddArticles(params Article[] articles), он не добавляет статьи в массив, а перезаписывает его
        {
            //_articles = articles;
            int _OldSize = _articles.Length;
            Array.Resize(ref _articles, _OldSize + ArticlesToAdd.Length);
            ArticlesToAdd.CopyTo(_articles, _OldSize);
        }
       

            public string ToFullString(bool isArticles = true)
    {
            return $"Название журнала: {Name}\n Частота выпуска: {Frequency}\n Дата выпуска " +
                $"{Release.ToLongDateString()}\n Кол-во продаж: {AmountSells}";
         
    }
    public string ToShortString()
    {
        return $"{ToFullString(false)}\n" +
            $"Средний рейтинг: {MiddleRating}";
    }
    }
}
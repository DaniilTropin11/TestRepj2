using System;
using System.ComponentModel.DataAnnotations;

namespace laba

{
    class Program
    {
        private static void Main() //+ в мейне по заданию больше действий нужно
        {
            Article[] ar = 
            {
                new Article(new Person("Ivanov", "Ivan" , new DateTime (22.12.2001)),
                new Article(new Person()))
            };
            // массив статей с 2-мя статьями 
            Person p = new Person();
            p.Firstname= "gggg";
            Magazine magazine = new Magazine();
            //Console.WriteLine($"Публикаций в журнале  :{magazine.Articles.Length} \n ");
            magazine.AddArticles(ar);
            Console.WriteLine(magazine.ToFullString());
            //magazine.AddArticles(ar);
            //Console.WriteLine($" \n Кол-во статей в журнале : {magazine.Articles.Length}\n");
            Console.WriteLine(magazine.ToShortString()); // который формирует строку со значениями всех полей класса без списка статей, но со значением среднего рейтинга статей.

        }
    }// Всё наверное
    public enum Frequency { Weekly, Monthly, Yearly }

     public class Person
    {
        private string _firstname;
        private string _lastname;
        private System.DateTime _dateOfBirth;

        public Person(string name, string lname, DateTime dob)
        {
            if (name.Trim().Length > 0)
                _firstname = name;
            else
                _firstname = "Ivan";
            if (lname.Trim().Length > 0)
                _lastname = lname;
            else
                _lastname = "Ivanov";
            if (dob.Year > 1990)
                _dateOfBirth = dob;
            else
                _dateOfBirth = new DateTime(2000, 1, 1);
        }
        public Person()
        {
            _firstname = "Ivan";
            _lastname = "Ivanov";
            _dateOfBirth = new DateTime(2003, 6, 20);
        }
        public string Firstname
        {
            get { return _firstname; }
            set { _firstname = value; }
        }
        public string Lastname
        {
            get { return _lastname; }
            set { _lastname = value; }
        }
        public DateTime DateOfBirth
        {
            get { return _dateOfBirth; }
            set { _dateOfBirth = value; }
        }
        private int YearOfBirth
        {
            get { return _dateOfBirth.Year; }
            set { _dateOfBirth = new DateTime(value, _dateOfBirth.Month, _dateOfBirth.Day);}
        }        
    }

    public class Article
    {
        public Person Author { get; set; }

        public string Title { get; set;  }
        public double Rating { get; set;  }

        public Article(Person author, string title, double rating)
        {
            Author = author;
            Title = title;
            Rating = rating;
        }
        public Article()
        {
            Author = new("Даниил", "Тропин" , new DateTime (2001, 12, 22) );
            Title = "УЧИМ ПРОГРАММИРОВАНИЕ";
            Rating = 10;
        }
        public string ToFullString()
        {
            return $"{Author.Firstname} {Author.Lastname} - {Title}. Рейтинг: {Rating}"; // описание 

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


        public void AddArticles(Article[] ArticlesToAdd)
        {
            int _OldSize = _articles.Length;
            Array.Resize(ref _articles, _OldSize + ArticlesToAdd.Length);
            ArticlesToAdd.CopyTo(_articles, _OldSize);

        }


        public string ToFullString()

        {
            string articles = "";
            foreach (Article a in this.Articles)
            {
                articles += a.ToFullString() + '\n';
            }
            return  $"Название журнала: {Name}\n Частота выпуска: {Frequency}\n Дата выпуска " +
           $"{Release.ToLongDateString()}\n Кол-во продаж: {AmountSells} \n Статьи в журнале:\n{articles}";

        }
        public string ToShortString()
        {
            return $" Название журнала :{Name}\n Частота выпуска:{Frequency}\n Дата выпуска:{Release.ToLongDateString()}\n Кол-во продаж:{AmountSells}\n" +
                $"Средний рейтинг статей : {MiddleRating}";
        }
    }
}


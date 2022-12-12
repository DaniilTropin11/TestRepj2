using System;
using System.ComponentModel.DataAnnotations;

namespace laba

{
    class Program
    {
        private static void Main() //+ в мейне по заданию больше действий нужно
        {
            var Author = new Person("Андрей", "Петров", new DateTime(2022, 10, 20));
            var magaz = new Magazine("Охота и рыбалка", Frequency.Monthly, new DateTime(2022, 12, 14), 1);
            magaz.AddArticles(new[] { new Article() });
            Console.WriteLine(magaz.ToShortString());
            magaz.Name = "Охота без рыбалки";
            magaz.Frequency = Frequency.Yearly;
            magaz.AmountSells++;
            magaz.Release = new DateTime(2022, 12, 2);
            Console.WriteLine(magaz.ToString());
            magaz.AddArticles(new Article[] { new Article(Author, "История Сибири", 6) });
            Console.WriteLine(magaz.ToFullString());

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

        public string ToFullString()
        {
            return "Имя" + _firstname + "\n" + "Фамилия" + _lastname + "\n" + "Дата рождения" + _dateOfBirth.ToLongDateString();
        }
        public string ToShortString()
        {
            return "Имя" + _firstname + "\n" + "Фамилия" + _lastname ;
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
        private  string _name;
        private  Frequency _frequency;
        private  DateTime _release;
        private  int _amountSells;
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
            Articles = new[] { new Article() };

        }
        public string Name { get; set; }
        public Frequency Frequency { get; set; }
        public DateTime Release { get; set; }
        public int AmountSells { get; set; }
        public Article[] Articles { get { return _articles; } set { _articles = value; } }
        public double? MiddleRating
        {
            get
            {
                if (Articles is null)
                {
                    return null;
                }
                return Articles.Sum(x => x.Rating) / Articles.Length;
            }
        }


        public void AddArticles(Article[] ArticlesToAdd)
        {
            if (Articles == null) // Если в журнале еще нет статей, то мы сразу их добавим
            {
                Articles = ArticlesToAdd;
            }
            else // Иначе мы расширим массив и добавим статьи туда
            {
                int _OldSize = Articles.Length;
                Array.Resize(ref _articles, _OldSize + ArticlesToAdd.Length);
                ArticlesToAdd.CopyTo(Articles, _OldSize);
            }
        }


        public string ToFullString()

        {
            string articles = "";
            foreach (Article a in Articles)
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

        public override string ToString()
        {
            return ToFullString() + $"\nСредний рейтинг:{MiddleRating}";
        }
    }
}


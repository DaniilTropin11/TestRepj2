using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = File.ReadAllLines(@"input.txt");

            var Regexes = new Dictionary<string, Regex>(); // Dictionary<K, V> типизируется двумя типами:
                                                           // параметр K представляет тип ключей, а параметр V предоставляет тип значений.
            Regexes["«a»"] = new Regex(@"^a$");
            Regexes["«aaaaaa»"] = new Regex(@"^a{6}$");
            Regexes["«a aa a»"] = new Regex(@"^a aa a$");
            Regexes["не менее 5 алфавитно-цифровых символов"] = new Regex(@"^[\w]{5,}$");
            Regexes["email"] = new Regex(@"^[\w-]+@((\w+)|(\w[\w-]+))\.\w+$");

            Regexes[" "] = new Regex(@"^(?:[гГ][гГ]\.\s+)?([а-яА-яёЁ]+(?:-[а-яА-ЯёЁ]+)?):?\s+(?:(\d+\.\d+)\s?){2}");
            Regexes["fio"] = new Regex(@"^([А-ЯЁ][а-яё]+)\s+([А-ЯЁ][а-яё]+)(\s+[А-ЯЁ][а-яё]+)?\s?$"); // ФИО 

            //var arr = new[] {
            // "-------@msil.ti",
            // "sssssss@mail.ru",
            // "sss#ssss@mail.ru",
            // "ssss$sss@mail.ru",
            // "ss__fff@mail.ru",
            //};
            //foreach (string mail in arr)
            //{
            //    Console.WriteLine($"mail: {mail}, is mmatch? {Regexes["email"].IsMatch(mail)}");

            //}


            //Console.WriteLine("-----------------------");
            //Console.WriteLine("Проверка почты по ключу:");
            //string email = "";
            //email = Console.ReadLine();
            //if (Regexes["email"].IsMatch(email))
            //{
            //    var groups = Regexes["email"].Split(email);
            //    Console.WriteLine(email);
            //}
            //else
            //    Console.WriteLine("не прввильный Email");



            //Console.WriteLine("=======================================");
            //Console.WriteLine("Проверка ФИО  по ключу:");
            //string search = "";
            // search = Console.ReadLine();
            //if (Regexes["fio"].IsMatch(search))

            //{
            //    var groups = Regexes["fio"].Split(search);
            //    Console.WriteLine($"Имя: {groups[1]}\n Фамилия {groups[2]}\n Отчество {groups[3]}");
            //}
            //else
            //Console.WriteLine("Не является неймом по формату ключа, имя пишется с большой Буквы ");
            //Console.WriteLine("=======================================");

            //^(?:[гГ][гГ]\.\s+)?([а-яА-яёЁ]+(?:-[а-яА-ЯёЁ]+)?):?\s+(?:(\d+\.\d+)(\s*)){2}

         
            var CityReg = new Regex(@"^(\w+):\s+[Шш]ирота\s+(\d+\.\d+),\s+[Дд]олгота\s(\d+\.\d+)$");
            var City = Console.ReadLine();
            var Groups = CityReg.Split(City);
            if (CityReg.IsMatch(City))
            {
                Console.WriteLine($"Город: {Groups[1]}\nШирота:{Groups[2]}\nДолгота:{Groups[3]}");
            }
            else
            {
                Console.WriteLine("не найдено");

            }
        }
    }
}
          


//            var CityReg = new Regex(@"^(?:[гГ][гГ]\.\s+)?([а-яА-яёЁ]+(?:-[а-яА-ЯёЁ]+)?):?\s+(\d+\.\d+)\s+(\d+\.\d+)");   
//            var City = Console.ReadLine();
//            var Groups = CityReg.Split(City);
//            //int count = 0;
//            if (CityReg.IsMatch(City))
//            {
//                Console.WriteLine($"Город: {Groups[1]}\nШирота:{Groups[2]}\nДолгота:{Groups[3]}");

//            }
//            else
//            {
//                Console.WriteLine("Не найдено");
//            }
//            Console.WriteLine("=======================================");
//        }
//    }
//}
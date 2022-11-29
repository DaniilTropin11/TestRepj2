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

            var Regexes = new Dictionary<string, Regex>();
            Regexes["«a»"] = new Regex(@"^a$");
            Regexes["«aaaaaa»"] = new Regex(@"^a{6}$");
            Regexes["«a aa a»"] = new Regex(@"^a aa a$");
            Regexes["не менее 5 алфавитно-цифровых символов"] = new Regex(@"^[\w]{5,}$");
            Regexes["email простого вида"] = new Regex(@"^[\w-]+@((\w+)|(\w[\w-]+))\.\w+$");
            Regexes[" "] = new Regex(@"^(?:[гГ][гГ]\.\s+)?([а-яА-яёЁ]+(?:-[а-яА-ЯёЁ]+)?):?\s+(?:(\d+\.\d+)\s?){2}");

            foreach (KeyValuePair<string, Regex> kvp in Regexes)
            {
                for (int i = 0; i < input.Length; ++i)
                {
                    //if (kvp.Value.IsMatch(input[i]))
                    //    System.Console.WriteLine($"Регулярка {kvp.Key}: {input[i]}\nСтрока:{i + 1}");


                }
            }

            //^(?:[гГ][гГ]\.\s+)?([а-яА-яёЁ]+(?:-[а-яА-ЯёЁ]+)?):?\s+(?:(\d+\.\d+)(\s*)){2}
            var CityReg = new Regex(@"^(?:[гГ][гГ]\.\s+)?([а-яА-яёЁ]+(?:-[а-яА-ЯёЁ]+)?):?\s+(\d+\.\d+)\s+(\d+\.\d+)");   
            var City = Console.ReadLine();
            var Groups = CityReg.Split(City);
            //int count = 0;
            if (CityReg.IsMatch(City))
            {
                Console.WriteLine($"Город: {Groups[1]}\nШирота:{Groups[2]}\nДолгота:{Groups[3]}");

            }
            else
            {
                Console.WriteLine("Не найдено");
            }
            Console.WriteLine("=======================================");
        }
    }
}
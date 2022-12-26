using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _5laba
{
    public enum YearType
    {
        LeapYear,
        NotLeapYear
    }

    public static class Proverka
    {
        static Regex regex = new Regex(@"^\w+([_\-\.]\w+)*@(\w+\.)+[a-zA-Z]{2}$");

        public static bool CheckEmail(string email)
        {
            if (email == null)
                throw new ArgumentException();

            return (regex.IsMatch(email)) ;
        }

        public static YearType CheckYear(int year)
        {
            //if (year < 1)
            //    throw new ArgumentException();

            year = year % 4;


            if (year != 0)
            {
                return YearType.NotLeapYear;
            }
            else
                return YearType.LeapYear;
        }
    }




}

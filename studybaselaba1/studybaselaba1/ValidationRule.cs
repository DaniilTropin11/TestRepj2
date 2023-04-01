using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;

namespace studybaselaba1
{

    class OcenkaValidationRule : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo) 
        {
            string str = (string)value;
            if (string.IsNullOrWhiteSpace(str))
            {
                return new ValidationResult(false, "Строка не может быть пустой!");
            }
            else if (Regex.IsMatch(str, @"^[0-9]+$|^-$") == false) // ^[А-ЯЁ][а-яё]{2}\-\d{2}$ 
            {
                return new ValidationResult(false, "Строка содержит недопустимые символы!");
            }
            return new ValidationResult(true, null);
        }
    }


}

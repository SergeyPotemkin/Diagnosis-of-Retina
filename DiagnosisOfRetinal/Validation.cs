using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DiagnosisOfRetinal
{
    class Validation
    {
        public static bool isText(String text)
        {
            if (Regex.IsMatch(text.ToString(), @"^[а-яА-ЯёЁ]+$"))
            {
                return true;
            }
            return false;
        }

        public static bool isNumber(String number)
        {
            if (Regex.IsMatch(number.ToString(), @"^[0-9]+$"))
            {
                return true;
            }
            return false;
        }

    }
}

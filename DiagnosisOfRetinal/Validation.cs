/*
    Copyright 2016,2017 Sergey Potemkin
    This file is part of the DOR.
   (Diagnosis of Retina)

   DOR is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License v3.0.
    
    You should have received a copy of the GNU General Public License v3.0
    along with DOR.  If not, see <http://www.gnu.org/licenses/>.
*/
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

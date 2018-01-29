using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pairing_Project
{

    public class Converter
    {
        public string ToRoman(int input)
        {
            var units = input % 10;
            input -= units;
            var tens = input % 100;
            input -= tens;
            var hundreds = input % 1000;
            
            

            var result = "";
            var calculate = new RomanDigits();

            if (hundreds > 0)
            {
                if (hundreds > 500 && hundreds < 900)
                {
                    result += calculate.CalculateRomanDigits(500);
                    hundreds = hundreds - 500;
                }
              result +=  calculate.CalculateRomanDigits(hundreds);
            }

            if (tens > 0)
            {
                if (tens > 50 && tens < 90)
                {
                    result += calculate.CalculateRomanDigits(50);
                    tens = tens - 50;
                }
                result += calculate.CalculateRomanDigits(tens);
            }

            if (units > 0)
            {
                if (units > 5 && units < 9)
                {
                    result += calculate.CalculateRomanDigits(5);
                    units = units - 5;
                }
                result +=  calculate.CalculateRomanDigits(units);
            }

            return result;
        }
    }


}

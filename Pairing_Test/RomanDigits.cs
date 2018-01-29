using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Pairing_Project
{
    public class RomanDigits
    {

        public string CalculateRomanDigits(int input)
        {
            var digitsList = new Dictionary<int, string>
            {
                [1000] = "M",
                [900] = "CM",
                [500] = "D",
                [100] = "C",
                [90] = "XC",
                [50] = "L",
                [10] = "X",
                [9] = "IX",
                [5] = "V",
                [4] = "IV",
                [1] = "I"
            };

            var result = "";
            var current = 0;
            while (input >= current)
            {
                foreach (var digit in digitsList)
                {
                    if (digit.Key <= input)
                    {
                        current = digit.Key;
                        break;
                    }
                }

                result += digitsList[current];
                input -= current;
            }



            return result;
        }
    }
}
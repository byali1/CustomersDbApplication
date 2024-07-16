using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Utilities.SpecialFunctions
{
    public static class ControlFunctions
    {


        public static bool CheckStartsWithNumber(string text)
        {
            if (char.IsDigit(text[0]))
            {
                return true;
            }

            return false;
        }


        public static bool IsContainsSpace(string text)
        {
            if (text.Contains(" "))
            {
                return true;
            }
            return false;
        }

        public static bool IsNullOrWhiteSpace(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                return true;
            }
            return false;
        }

        public static string RemoveSpaces(string text)
        {
            return text.Replace(" ", string.Empty);
        }
    }
}

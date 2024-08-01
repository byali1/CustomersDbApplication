using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Business.Utilities.SpecialFunctions
{
    public static class ControlFunctions
    {

        public static bool IsNullOrEmptyCustomerInformation(params string[] customerInfos)
        {
            foreach (string info in customerInfos)
            {
                if (string.IsNullOrEmpty(info))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool CheckStartsWithNumber(string text)
        {
            if (char.IsDigit(text[0]))
            {
                return true;
            }

            return false;
        }

        public static bool CheckStartsWithZero(string text)
        {
            return text[0] == '0';
        }




        //public static bool IsValidEmail(string text)
        //{
        //    if (text.Contains("@"))
        //    {
        //        return true;
        //    }

        //    return false;
        //}

        public static bool IsValidEmail(string email)
        {
            try
            {
                MailAddress mailAddress = new MailAddress(email);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
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

        public static bool IsNullOrEmpty(string text)
        {
            if (string.IsNullOrEmpty(text))
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

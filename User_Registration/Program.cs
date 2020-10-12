using System;
using System.Collections.Concurrent;
using System.Text.RegularExpressions;

namespace User_Registration
{
    public class Pattern
    {
        public static string REGEX_FIRST_NAME = "^[A-Z][a-zA-Z]{2,}$";
        public bool validateFirstName(string firstName)
        {
            return Regex.IsMatch(firstName, REGEX_FIRST_NAME);
        }



        public static string REGEX_LAST_NAME = "^[A-Z][a-zA-Z]{2,}$";
        public bool validateLastName(string lastName)
        {
            return Regex.IsMatch(lastName, REGEX_LAST_NAME);
        }


        public static string REGEX_EMAIL = "^[a-zA-Z0-9]+([.][a-zA-Z0-9]+)*[@][a-zA-Z0-9]+[.][a-zA-Z]+([.][a-zA-Z]{2})*$";
        public bool validateEmail(string email)
        {
            return Regex.IsMatch(email, REGEX_EMAIL);
        }


        public static string REGEX_MOBILE = @"\d{2}\s{1}[0-9]{10}";
        public bool validateMobile(string mobile)
        {
            return Regex.IsMatch(mobile, REGEX_MOBILE);
        }


        public static string REGEX_PASSWORD_R1 = @"^[a-zA-Z0-9]{8,}$";
        public bool validatePasswordrule1(string password)
        {
            return Regex.IsMatch(password, REGEX_PASSWORD_R1);
        }

        public static string REGEX_PASSWORD_RULE2 = @"^(?=.*[A-Z])[a-zA-Z\d]{8,}$";
        public bool validatePasswordWithUppercase(string password)
        {
            return Regex.IsMatch(password, REGEX_PASSWORD_RULE2);
        }


        public static string REGEX_PASSWORD_RULE3 = @"^(?=.*[A-Z\d])[a-zA-Z\d]{8,}$";
        public bool validatePasswordWithNumeric(string password)
        {
            return Regex.IsMatch(password, REGEX_PASSWORD_RULE3);
        }
    }
    class Program
    {

        static void Main(string[] args)
        {

        }
    }
}

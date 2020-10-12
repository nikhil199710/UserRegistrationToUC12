using System;
using System.Collections.Concurrent;
using System.Text.RegularExpressions;

namespace User_Registration
{
    public class Pattern
    {
        public static string REGEX_ENTRY = "^[A-Z][a-zA-Z]{2,}$";
        public bool validateFirstName(string firstName)
        {
            return Regex.IsMatch(firstName, REGEX_ENTRY);
        }
    }
    class Program
    {

        static void Main(string[] args)
        {

        }
    }
}

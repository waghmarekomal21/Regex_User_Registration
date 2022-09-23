using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexUser
{
    public class FirstName
    {
        public static void ValidFirstName()
        {
            Console.WriteLine("Enter your name");
            string firstName = Console.ReadLine();

            string pattern = "^[A-Za-z]{5}$";

            if (Regex.IsMatch(firstName, pattern))
            {
                Console.WriteLine("Valid First Name");
            }
            else
            {
                Console.WriteLine("Invalid First Name");
            }
        }
    }
}
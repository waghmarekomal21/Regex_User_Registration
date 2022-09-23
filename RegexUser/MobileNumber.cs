using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexUser
{
    internal class MobileNumber
    {
        public static void ValidateMobileNumber()
        {
            Console.WriteLine("Enter mobile number");
            string mobileNumber = Console.ReadLine();

            string pattern = "^[+][91]{2}[: :][0-9]{10}$";

            if (Regex.IsMatch(mobileNumber, pattern))
            {
                Console.WriteLine("Mobile number is valid");
            }
            else
            {
                Console.WriteLine("Mobile number is not valid... Please give a valid mobile number");
            }
        }
    }
}
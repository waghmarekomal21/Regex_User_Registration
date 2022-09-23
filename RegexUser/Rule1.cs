using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexUser
{
    internal class Rule1
    {
        public static void ValidatePassword(string password)
        {
            var Character = new Regex("^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[!@#$%^&*()_+=\\[{\\]};:<>|./?,-]).{8,}$");

            if (!Character.IsMatch(password))
            {
                Console.WriteLine("Password should have 8 characters ");
            }
            else
            {
                Console.WriteLine("Password is valid");
            }
        }
    }
}

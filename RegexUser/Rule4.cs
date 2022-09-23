﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexUser
{
    internal class Rule4
    {
        public static void ValidatePassword(string password)
        {
            var LowerCase = new Regex(@"[a-z]+");
            var UpperCase = new Regex(@"[A-Z]+");
            var Length = new Regex(@".{8,}");
            var Number = new Regex(@"[0-9]+");
            var SpecialCharacter = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");

            if (!Length.IsMatch(password))
            {
                Console.WriteLine("Password at least have minimum 8 characters");
            }
            else if (!LowerCase.IsMatch(password))
            {
                Console.WriteLine("Password should have at least 1 lower character");
            }
            else if (!Number.IsMatch(password))
            {
                Console.WriteLine("Password should have at least 1 Numeric value");
            }
            else if (!UpperCase.IsMatch(password))
            {
                Console.WriteLine("Password should have at least 1 upper character");
            }
            else if (!SpecialCharacter.IsMatch(password))
            {
                Console.WriteLine("Password should have at least 1 special character");
            }
            else
            {
                Console.WriteLine("Password is valid");
            }
        }
    }
}
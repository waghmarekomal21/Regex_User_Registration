﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexUser
{
    internal class LastName
    {
        public static void ValidateLastName()
        {
            Console.WriteLine("Enter the Last Name");
            string lastName = Console.ReadLine();

            string pattern = "^[A-Z]{1}[a-z]{2,}$";
            if (Regex.IsMatch(lastName, pattern))
            {
                Console.WriteLine("Last name is valid");
            }
            else
            {
                Console.WriteLine("Invalid last name");
            }
        }
    }
}

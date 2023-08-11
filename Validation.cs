using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationMTest
{
    class Validation
    {
        public static Func<string, bool> ValidateFirstName = input =>
        Regex.IsMatch(input, @"^[A-Z][a-zA-Z]{2,}$");

        public static Func<string, bool> ValidateLastName = input =>
            Regex.IsMatch(input, @"^[A-Z][a-zA-Z]{2,}$");

        public static Func<string, bool> ValidateEmail = input =>
            Regex.IsMatch(input, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");

        public static Func<string, bool> ValidateMobile = input =>
            Regex.IsMatch(input, @"^91 \d{10}$");

        public static Func<string, bool> ValidatePassword = input =>
            Regex.IsMatch(input, @"^(?=.*[A-Z])(?=.*\d)(?=.*[^A-Za-z0-9]).{8,}$");
    }
}

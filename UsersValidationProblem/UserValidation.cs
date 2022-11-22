using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UsersValidationProblem
{
    public class UserValidation
    {
        public const string FIRST_NAME_REGEX = "^[A-Z][a-zA-Z]{2}$";
        public void ValidationFirstName(string firstname)
        {
            Regex regex = new Regex(FIRST_NAME_REGEX);
            bool result = regex.IsMatch(firstname);
            Console.WriteLine(result);
        }
        //UC2
        //LastName the First Letter Should Capital and minimum 3 Characters
        public const string LASTNAME_REGEX = "^[A-Z][a-zA-Z]{2}$";
        public void ValidationLastName(string lastname)
        {
            Regex regex = new Regex(LASTNAME_REGEX);
            bool result = regex.IsMatch(lastname);
            Console.WriteLine(result);
        }
    }
}
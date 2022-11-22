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
    }
}
    

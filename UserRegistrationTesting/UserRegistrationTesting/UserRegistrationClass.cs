using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationTesting
{
    public class UserRegistrationClass
    {
        public string firstNamePattern = "^[A-Z]{1}[a-z]{2,}$";
        public bool ValidateFirstName(string firstName)
        {
            return Regex.IsMatch(firstName, firstNamePattern);
        }

        public string lastNamePattern = "^[A-Z]{1}[a-z]{2,}$";
        public bool ValidateLastName(string lastName)
        {
            return Regex.IsMatch(lastName, lastNamePattern);
        }

        public string emailPattern = @"^([a][b][c])([_\.\+\-])([a-zA-Z0-9]+)\@([b][l])\.([c][o])\.([a-z]{2})*$";
        public bool ValidateEmail(string email)
        {
            return Regex.IsMatch(email, emailPattern);
        }
    }
}

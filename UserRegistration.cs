using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ReviewSession_4
{
    //8.Test User Registration: Validate user input(name, email, age) using NUnit tests.
    public class UserRegistration
    {
        public bool ValidateUserName(string name)
        {
            string userNamePattern = @"^[a-zA-Z\s]+$";
            return Regex.IsMatch(name, userNamePattern);
        }


        public bool ValidateEmail(string email)
        {
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, emailPattern);
        }

        public bool ValidateAge(string age)
        {
            string agePattern = @"^(1[89]|[2-7][0-9]|8[0-5])$"; 
            return Regex.IsMatch(age, agePattern);
        }


    }
}

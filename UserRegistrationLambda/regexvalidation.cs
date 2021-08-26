using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationRegex
{
    public class ValidationRegex
    {
        public static string NAME_REGEX = @"^[A-Z]{1}[A-Za-z]{3,}$";
        public static string MOBILENUMBER_REGEX = @"\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})";
        public static string EMAIL_REGEX = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
        public static string PASSWORD_REGEX = @"^.*(?=.{8,})(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[!*@#$%^&+=]).*$";
        


        public bool ValidateFirstName(string name)
        {            

            Regex regex = new Regex(NAME_REGEX);
            return ValidateFirstName(name);

            bool ValidateFirstName(string name) => regex.IsMatch(name) ? true : throw new InvalidNameException("Your Name is Invalid");

        }

        public bool ValidateMobileNumber(string mobileNumber)
        {
            Regex regex = new Regex(MOBILENUMBER_REGEX);
            return ValidateMobileNumber(mobileNumber);

            bool ValidateMobileNumber(string mobileNumber) => regex.IsMatch(mobileNumber) ? true : throw new InvalidMobileNumberException("Your Number is Invalid");
        }

        public bool validateEmail(string email)
        {

            Regex regex = new Regex(EMAIL_REGEX);
            return validateEmail(email);

            bool validateEmail(string email) => regex.IsMatch(email) ? true : throw new InvalidEmailException("Your email is Invalid");

        }

        public bool ValidatedPassword(string password)
        {

            Regex regex = new Regex(PASSWORD_REGEX);
            return ValidatedPassword(password);

            bool ValidatedPassword(string password) => regex.IsMatch(password) ? true : throw new InvalidPasswordException("Your password is Invalid");
        }

    }
}

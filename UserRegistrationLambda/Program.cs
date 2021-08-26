using System;
using UserRegistrationRegex;
namespace UserRegistrationLambda
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ValidationRegex regex = new ValidationRegex();
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();

            try
            {
                bool validResultName = regex.ValidateFirstName(name);
                if (validResultName == true)
                    Console.WriteLine("The name is valid");

            }
            catch (InvalidNameException e)
            {
                Console.WriteLine(e.Message);

            }

            Console.WriteLine("Enter your Mobile number");
            string mobileNumber = (Console.ReadLine());
            try
            {
                bool validResultNumber = regex.ValidateMobileNumber(mobileNumber);
                if (validResultNumber == true)
                    Console.WriteLine("The Number is valid");

            }
            catch (InvalidMobileNumberException e)
            {
                Console.WriteLine(e.Message);
            }



            Console.WriteLine("Enter your email");
            string email = Console.ReadLine();
            try
            {
                bool validResultEmail = regex.validateEmail(email);
                if (validResultEmail == true)
                    Console.WriteLine("The Email is valid");
            }
            catch (InvalidEmailException e)
            {
                Console.WriteLine(e.Message);
            }


            Console.WriteLine("Enter your password");
            string password = Console.ReadLine();
            try
            {
                bool validPassword = regex.ValidatedPassword(password);
                if (validPassword == true)
                    Console.WriteLine("The Password is valid");
                else
                    Console.WriteLine("The password is invalid");
            }
            catch (InvalidPasswordException e)
            {
                Console.WriteLine(e.Message);
            }


        }
    }
}

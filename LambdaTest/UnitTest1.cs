using NUnit.Framework;
using UserRegistrationRegex;
namespace LambdaTest
{
    public class Tests
    {
        ValidationRegex regexval;
        [SetUp]
        public void Setup()
        {
            regexval = new ValidationRegex();
        }

        [Test]
        [TestCase("Sagar")]


        public void TestName(string inputOne)
        {

            bool outputOne = regexval.ValidateFirstName(inputOne);
            Assert.IsTrue(outputOne);

        }

        [Test]
        [TestCase("sagar")]
        public void FirstNameExceptionTest(string input)
        {
            InvalidNameException ex = Assert.Throws<InvalidNameException>(() => regexval.ValidateFirstName(input));
            Assert.AreEqual("Your Name is Invalid", ex.Message);
        }

        [Test]
        [TestCase("7506074980")]

        public void TestNumbner(string inputTwo)
        {

            bool outputTwo = regexval.ValidateMobileNumber(inputTwo);
            Assert.IsTrue(outputTwo);
        }


        [Test]
        [TestCase("999999999")]
        public void PhoneNumberExceptionTest(string input)
        {
            InvalidMobileNumberException ex = Assert.Throws<InvalidMobileNumberException>(() => regexval.ValidateMobileNumber(input));
            Assert.AreEqual("Your Number is Invalid", ex.Message);
        }


        [Test]
        [TestCase("sagar123@gmail.com")]
        public void TestEmail(string inputThree)
        {
            bool outputThree = regexval.validateEmail(inputThree);
            Assert.IsTrue(outputThree);
        }

        [Test]
        [TestCase("sagar123")]
        public void EmailExceptionTest(string input)
        {
            InvalidEmailException ex = Assert.Throws<InvalidEmailException>(() => regexval.validateEmail(input));
            Assert.AreEqual("Your email is Invalid", ex.Message);
        }

        [Test]
        [TestCase("Morningstar123@")]
        public void TestPassword(string inputFour)
        {
            bool outputFour = regexval.ValidatedPassword(inputFour);
            Assert.IsTrue(outputFour);
        }

        
        [Test]
        [TestCase("morningstar123")]
        public void PasswordExceptionTest(string input)
        {
            InvalidPasswordException ex = Assert.Throws<InvalidPasswordException>(() => regexval.ValidatedPassword(input));
            Assert.AreEqual("Your password is Invalid", ex.Message);
        }
    }
}
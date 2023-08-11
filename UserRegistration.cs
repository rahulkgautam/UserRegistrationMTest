using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UserRegistrationMTest
{
    [TestClass]
    public class UserRegistration
    {
        [TestMethod]
        public void TestFirstNameValidation()
        {
            var validationFunction = Validation.ValidateFirstName;
            Assert.IsTrue(validationFunction("BridgeLabz"));
            Assert.IsFalse(validationFunction("Rahul Kumar"));
        }

        [TestMethod]
        public void TestLastNameValidation()
        {
            var validationFunction = Validation.ValidateLastName;
            Assert.IsTrue(validationFunction("Gautam"));
            Assert.IsFalse(validationFunction("Gautam1212"));
        }

        [TestMethod]
        public void TestEmailValidation()
        {
            var validationFunction = Validation.ValidateEmail;
            Assert.IsTrue(validationFunction("abc.xyz@gmail.co.in"));
            Assert.IsFalse(validationFunction("invalidemail"));
        }

        [TestMethod]
        public void TestMobileValidation()
        {
            var validationFunction = Validation.ValidateMobile;
            Assert.IsTrue(validationFunction("91 9638837773"));
            Assert.IsFalse(validationFunction("123"));
            
        }

        [TestMethod]
        public void TestPasswordValidation()
        {
            var validationFunction = Validation.ValidatePassword;
            Assert.IsTrue(validationFunction("Passwrd@123"));
            Assert.IsFalse(validationFunction("password"));            
        }
    }
}

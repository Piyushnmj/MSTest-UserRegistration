using System.Text.RegularExpressions;

namespace UserTesting
{
    [TestClass]
    public class Testing
    {
        [TestMethod]
        public void TestFirstName()
        {
            UserRegistrationTesting.UserRegistrationClass objTest= new UserRegistrationTesting.UserRegistrationClass();

            objTest.ValidateFirstName("Piyush");
            string name = @"^[A-Z]{1}[a-z]{2,}$";
            var regex = new Regex(name);
            StringAssert.Matches("Piyush", regex);
        }

        [TestMethod]
        public void TestLastName()
        {
            UserRegistrationTesting.UserRegistrationClass objTest = new UserRegistrationTesting.UserRegistrationClass();

            objTest.ValidateLastName("Nimje");
            string name = @"^[A-Z]{1}[a-z]{2,}$";
            var regex = new Regex(name);
            StringAssert.Matches("Nimje", regex);
        }
    }
}
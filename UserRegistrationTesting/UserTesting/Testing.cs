using System.Text.RegularExpressions;

namespace UserTesting
{
    [TestClass]
    public class Testing
    {
        [TestMethod]
        public void TestMethod1()
        {
            UserRegistrationTesting.UserRegistrationClass objTest= new UserRegistrationTesting.UserRegistrationClass();

            objTest.ValidateFirstName("Piyush");
            string name = @"^[A-Z]{1}[a-z]{2,}$";
            var regex = new Regex(name);
            StringAssert.Matches("Piyush", regex);
        }
    }
}
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

        [TestMethod]
        public void TestEmail()
        {
            UserRegistrationTesting.UserRegistrationClass objTest = new UserRegistrationTesting.UserRegistrationClass();

            objTest.ValidateEmail("abc.piyush@bl.co.in");
            string name = @"^([a][b][c])([_\.\+\-])([a-zA-Z0-9]+)\@([b][l])\.([c][o])\.([a-z]{2})*$";
            var regex = new Regex(name);
            StringAssert.Matches("abc.xyz@bl.co.in", regex);
        }
    }
}
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
            string email = @"^([a][b][c])([_\.\+\-])([a-zA-Z0-9]+)\@([b][l])\.([c][o])\.([a-z]{2})*$";
            var regex = new Regex(email);
            StringAssert.Matches("abc.xyz@bl.co.in", regex);
        }

        [TestMethod]
        public void TestMobileNumber()
        {
            UserRegistrationTesting.UserRegistrationClass objTest = new UserRegistrationTesting.UserRegistrationClass();

            objTest.ValidateMobileNumber("+91 1234567890");
            string mobileNum = @"^\+[1-9]{1}[0-9]{0,2}\s[1-9]{1}[0-9]{9}";
            var regex = new Regex(mobileNum);
            StringAssert.Matches("+91 1234567890", regex);
        }

        [TestMethod]
        public void TestPasswordRule1()
        {
            UserRegistrationTesting.UserRegistrationClass objTest = new UserRegistrationTesting.UserRegistrationClass();

            objTest.ValidatePassword("Piyushhhh");
            string password = @"^[A-Za-z]{1}[A-Za-z0-9]{7,}";
            var regex = new Regex(password);
            StringAssert.Matches("Piyushhh", regex);
        }

        [TestMethod]
        public void TestPasswordRule2()
        {
            UserRegistrationTesting.UserRegistrationClass objTest = new UserRegistrationTesting.UserRegistrationClass();

            objTest.ValidatePassword("PiyusHHhh");
            string password = @"^(?=.*[a-z])(?=.*[A-Z]).{8,}$";
            var regex = new Regex(password);
            StringAssert.Matches("PiyusHHhh", regex);
        }

        [TestMethod]
        public void TestPasswordRule3()
        {
            UserRegistrationTesting.UserRegistrationClass objTest = new UserRegistrationTesting.UserRegistrationClass();

            objTest.ValidatePassword("PiyusH11Hhh");
            string password = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,}$";
            var regex = new Regex(password);
            StringAssert.Matches("PiyusHH11hh", regex);
        }

        [TestMethod]
        public void TestPasswordRule4()
        {
            UserRegistrationTesting.UserRegistrationClass objTest = new UserRegistrationTesting.UserRegistrationClass();

            objTest.ValidatePassword("PiyusH11Hhh");
            string password = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*\D\W).\S{8,15}$";
            var regex = new Regex(password);
            StringAssert.Matches("PiyusHH11hh#", regex);
        }
    }
}
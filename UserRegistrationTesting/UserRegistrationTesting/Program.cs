using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace UserRegistrationTesting
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Testing Problem");

            UserRegistrationClass objUser = new UserRegistrationClass();
            Console.WriteLine("\nEnter First Name: ");
            string firstName = Console.ReadLine();
            objUser.ValidateFirstName(firstName);

            Console.WriteLine("\nEnter Last Name: ");
            string lastName = Console.ReadLine();
            objUser.ValidateLastName(lastName);

            Console.WriteLine("\nEnter Email: ");
            string email = Console.ReadLine();
            objUser.ValidateEmail(email);
        }
    }
}
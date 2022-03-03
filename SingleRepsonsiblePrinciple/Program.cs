using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleRepsonsiblePrinciple
{
    public class Program
    {
        static void Main(string[] args)
        {
            Messege.ShowWelcomeMsg();

            User user = Account.GetUserData();

            var isValid = Validate.ValidateUser(user);
            if (isValid != true)
            {
                Console.ReadLine();
            }

            Account.CreateAccount(user);
            Console.ReadLine();
        }
    }

    public static class Account 
    {
        public static User GetUserData() 
        {
            User user = new User();
            Console.Write("What is your first name: ");
            user.FirstName = Console.ReadLine();

            Console.Write("What is your last name: ");
            user.LastName = Console.ReadLine();
            return user;
        }

        public static void CreateAccount(User user) 
        {
            Console.WriteLine($"Your username is { user.FirstName.Substring(0, 1) }{ user.LastName }");
        }
    }

    public static class Validate 
    {
        public static bool ValidateUser(User user) 
        {
            if (string.IsNullOrWhiteSpace(user.FirstName))
            {
                Messege.ShowErrorMsg(user.FirstName);
                return false;
            }

            if (string.IsNullOrWhiteSpace(user.LastName))
            {
                Messege.ShowErrorMsg(user.LastName);
                return false;
            }
            return true;
        }
    }

    public static class Messege 
    {
        public static void ShowWelcomeMsg() 
        {
            Console.WriteLine("Welcome to my application!");
        }

        public static void ShowErrorMsg(string field)
        {
            Console.WriteLine($"You did not give us a valid {field}!");
        }
    }

    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}

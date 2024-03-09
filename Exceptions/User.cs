using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class User : Account
    {
        private static int _idCounter = 0;

        public int Id { get; }
        public string Fullname { get; set; }
        public string Email { get; set; }
        private string _password;

        public User(string fullname, string email, string password)
        {
            Id = ++_idCounter;
            Fullname = fullname;
            Email = email;

            if (!PasswordChecker(password))
            {
                throw new IncorrectPasswordException("Password does not meet the requirements.");
            }

            _password = password;
        }

        public override bool PasswordChecker(string password)
        {
            if (password.Length < 8)
                return false;
            if (!password.Any(char.IsUpper))
                return false;
            if (!password.Any(char.IsLower))
                return false;
            if (!password.Any(char.IsDigit))
                return false;

            return true;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"User ID: {Id}");
            Console.WriteLine($"Fullname: {Fullname}");
            Console.WriteLine($"Email: {Email}");
        }
    }
}

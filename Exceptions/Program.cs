using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                User user1 = new User("Ulvi Asadov", "ulviasadovv@gmail.com", "djsdjlsd");
                user1.ShowInfo();

                User user2 = new User("Kimse Kimse", "kimdse@gmail.com", "nese");
                user2.ShowInfo();
            }
            catch (IncorrectPasswordException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}

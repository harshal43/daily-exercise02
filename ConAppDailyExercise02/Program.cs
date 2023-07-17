using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConAppDailyExercise02
{
    public class OurCustomEx : Exception
    {
        public OurCustomEx(string msg):base(msg) { }
    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            string username;
            string password;

            Console.WriteLine("Enter username");
            username = Console.ReadLine();
            Console.WriteLine("Enter password");
            password = Console.ReadLine();

            Registration(username, password);

            Console.ReadKey();
        }
        public static void Registration(string username, string password)
        {
            try
            {
                if (username.Length >= 6 && password.Length >= 6)
                {
                    Console.WriteLine("You are successfully Loged in!");
                }
                else
                {
                    throw new OurCustomEx("\nInvalid username and password");
                }
            }
            catch(OurCustomEx e){
                Console.WriteLine("Custom Exception" + e.Message);
            }
            catch(Exception e) {
                Console.WriteLine("Error"+e.Message);
            }
        }

    }
}

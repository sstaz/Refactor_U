using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactor_U
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to Toi Ohomai               ");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("");

            Console.WriteLine("Please enter your first name :");
            string fname = Console.ReadLine();

            Console.WriteLine("Please enter your last name  :");
            string lname = Console.ReadLine();


            Random rnd = new Random();

            string studentid = rnd.Next(1000, 9999).ToString();

            Console.Clear();

            Console.WriteLine("Welome to Toi Ohomai               ");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("");

            Console.WriteLine("Your name is       : {0} {1}", fname, lname);
            Console.WriteLine("Your student id is : {0}", studentid);

            Console.ReadLine();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variable
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("What's your name ?");
            Console.WriteLine("My name is : ");
            string firstname = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine($"Oh!... I know many {firstname}'s. What is your last name?");
            Console.WriteLine("My last name is:");
            string lastname = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine($"Hey {firstname} {lastname}, it's a pleasure to meet you. I hope you have a great day.");
            Console.WriteLine("Press any Key to close");
            Console.ReadKey();

        }
    }
}

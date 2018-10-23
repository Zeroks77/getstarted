using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes__Methods_and_Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Person stranger = new Person();
            stranger.name = getname();
            stranger.age = getage(stranger.name);
            stranger.bday = getbday(stranger.age);
            Console.WriteLine("So let me create your Profile");
            printprofil(stranger);
            Console.ReadKey();
        }
        private static void printprofil(Person stranger)
        {
            Console.Clear();
            Console.WriteLine("Your Profile");
            Console.WriteLine($"Name : {stranger.name}");
            Console.WriteLine($"Age : {stranger.age}");
            Console.WriteLine($"Born : {stranger.bday}");
        }
        private static DateTime getbday(int age)
        {
            Console.WriteLine($"Hey, now that i know you, i want to gether more information about you" +
                " to create a profile for you.");
            Console.WriteLine();
            Console.Write($"So you are {age} years old, can you tell me please when your Birthday is?" +
                " Like dd/mm/yyyy : ");
            DateTime.TryParse(Console.ReadLine(), out DateTime bday);
            return bday;

        }
        private static int getage(string name)
        {
            Console.WriteLine($"Wow, {name} now, where i know how old you are i allmost finished your profil");
            Console.Write($"So, {name} how old are you ?");
            int.TryParse(Console.ReadLine(), out int age);
            return age;
        }
        private static string getname()
        {
            Console.WriteLine("Hello here i will try to merge my knowledge about Classes and Methods");
            Console.Write("At First please tell me your first name:");
            string name = Console.ReadLine();
            Console.Write($"Oh nice to meet you. Do you know how many {name}'s i already know.." +
                "Do you mind to tell me your last name too ?");
            name += " " + Console.ReadLine();
            return name;
        }
    }

    class Person
    {
        public string name { get; set; }
        public int age { get; set; }
        public DateTime bday { get; set; }
    }
}

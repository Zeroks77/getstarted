using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess_the_Number
{
    class Program
    {
        enum difficulty { Easy = 100, Normal = 500, Hardcore = 1000 }
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int ret = GetDifficulty();
            int cheat = -322;
            int dif = 0;
            string diff = "";
            switch (ret)
            {
                case 1:
                    diff = "Easy";
                    dif = Convert.ToInt16(difficulty.Easy);
                    break;
                case 2:
                    diff = "Normal";
                    dif = Convert.ToInt16(difficulty.Normal);
                    break;
                case 3:
                    diff = "Hardcore";
                    dif = Convert.ToInt16(difficulty.Hardcore);
                    break;
                default:
                    Console.WriteLine("Wrong input.");
                    break;
            }
            int rand = rnd.Next(1, dif);
            Console.WriteLine($"{diff} Mode | Guess between 1 and {dif}");
            Console.WriteLine("Ok than guess what number i am thinking about : ");
            int guess = Convert.ToInt16(Console.ReadLine());
            int counter = 1;
            while (guess != rand && guess != cheat)
            {

                Console.WriteLine("Try again");
                if (guess < rand)
                    Console.WriteLine("Your guess is smaller than the number i think off");
                else Console.WriteLine("Your guess is bigger than the number i think off");

                guess = Convert.ToInt32(Console.ReadLine());
                counter++;
            }
            Console.WriteLine($"Congratulation you found my number. You only did {counter} guesses!");
            Console.WriteLine("Press 1 to restart and 2 to Close");
            tryagain();
        }
        static int GetDifficulty()
        {
            Console.WriteLine("Wellcome to Guess the Number");
            Console.WriteLine("Choose the Difficulty. Press 1 for easy, 2 for normal and 3 for hardcore");
            string c = Console.ReadLine();
            int.TryParse(c, out int dif);
            return dif;
        }
        static void tryagain()
        {
            string retry = Console.ReadLine();
            if (retry == "1")
            {
                Console.Clear();
                Main(null);
            }
        }
    }
}

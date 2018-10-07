using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess_the_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            MyGame.Play();
        }

    }
     class MyGame
    {
      enum difficulty { Easy = 100, Normal = 500, Hardcore = 1000 }

        public static void  Play()
        {
            Random rnd = new Random();
            difficulty ret = GetDifficulty();
            int cheat = -322;

            int rand = rnd.Next(1, Convert.ToInt16(ret);
            Console.WriteLine($"{ret.ToString("G")} Mode | Guess between 1 and {ret}");
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
            Console.WriteLine("Press 1 to restart and any Button to Close");
            tryagain();
        }
       private static difficulty GetDifficulty()
        {
            Console.WriteLine("Wellcome to Guess the Number");
            Console.WriteLine("Choose the Difficulty. Press 1 for easy, 2 for normal and 3 for hardcore");
            string c = Console.ReadLine();
            int.TryParse(c, out int dif);
            switch (dif)
            {
                case 1:
                    return difficulty.Easy;
                case 2:
                    return difficulty.Normal;
                case 3:
                    return difficulty.Hardcore;
                default:
                    Console.WriteLine("Wrong input.");
                    break;
            }
            return difficulty.Easy;
        }
        static void tryagain()
        {
            string retry = Console.ReadLine();
            if (retry == "1")
            {
                Console.Clear();
                Play();
            }
        }


    }
}

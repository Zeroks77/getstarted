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
            Console.WriteLine("Wellcome to Guess the Number");
            Console.WriteLine("Choose the Difficulty. Press 1 for easy, 2 for normal and 3 for hardcore");
            string c = Console.ReadLine();
            int dif;
            int cheat = -322;

            if (int.TryParse(c, out dif) && dif >= 1 && dif <= 3) ;

            if (dif == 1)
            {
                Random rnd = new Random();
                int rand = rnd.Next(1, 100);

                Console.Clear();
                Console.WriteLine("Easy Mode | Guess between 1 and 100");
                Console.WriteLine("Ok than guess what number i am thinking about : ");
                int guess = Convert.ToInt32(Console.ReadLine());
                int counter = 1;
                while (guess != rand && guess != -322)
                {


                    counter++;
                    Console.WriteLine("Try again");
                    if (guess < rand)
                    {
                        Console.WriteLine("Your guess is smaller than the number i think off");
                    }
                    else Console.WriteLine("Your guess is bigger than the number i think off");


                    guess = Convert.ToInt32(Console.ReadLine());


                }
                    Console.WriteLine($"Congratulation you found my number. You only did {counter} guesses!");
                    Console.WriteLine("To close press any key");
                    Console.ReadKey();
                
            }
            else if (dif == 2)
            {
                Random rnd = new Random();
                int rand = rnd.Next(1, 500);

                Console.Clear();
                Console.WriteLine("Normal Mode | Guess between 1 and 500");
                Console.WriteLine("Ok than guess what number i am thinking about : ");
                int guess = Convert.ToInt32(Console.ReadLine());
                int counter = 1;
                while (guess != rand && guess != -322)
                {


                    counter++;
                    Console.WriteLine("Try again");
                    if (guess < rand)
                    {
                        Console.WriteLine("Your guess is smaller than the number i think off");
                    }
                    else Console.WriteLine("Your guess is bigger than the number i think off");


                    guess = Convert.ToInt32(Console.ReadLine());


                }
                Console.WriteLine($"Congratulation you found my number. You only did {counter} guesses!");
                Console.WriteLine("To close press any key");
                Console.ReadKey();
            }
            else if (dif == 3)
            {
                Random rnd = new Random();
                int rand = rnd.Next(1, 1000);

                Console.Clear();
                Console.WriteLine("Hardcore Mode | Guess between 1 and 1000");
                Console.WriteLine("Ok than guess what number i am thinking about : ");
                int guess = Convert.ToInt32(Console.ReadLine());
                int counter = 1;
                while (guess != rand && guess != -322)
                {


                    counter++;
                    Console.WriteLine("Try again");
                    if (guess < rand)
                    {
                        Console.WriteLine("Your guess is smaller than the number i think off");
                    }
                    else Console.WriteLine("Your guess is bigger than the number i think off");


                    guess = Convert.ToInt32(Console.ReadLine());


                }
                Console.WriteLine($"Congratulation you found my number. You only did {counter} guesses!");
                Console.WriteLine("To close press any key");
                Console.ReadKey();
            }
            }
        
    }
}

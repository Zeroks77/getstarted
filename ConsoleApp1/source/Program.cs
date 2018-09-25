using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public int[] array;


        static void Main(string[] args)
        {
            int[] array = new int[10];
            int number;
            int number2;
            int counter = array.Length;
            Random rnd = new Random();

            for (int i = 0; i < array.Length; i++) // filling
            {
                array[i] = rnd.Next(1, array.Length);
                Console.WriteLine(array[i]);
                //Console.ReadKey();


            }

            while (counter != 0)
            {
                for (int i = 0; i < counter - 1; i++)
                {
                    number = array[i];
                    number2 = array[i + 1];
                    if (number > number2)
                    {
                        //Console.WriteLine(number + " is greater than " + number2);
                        array[i] = number2;

                        array[i + 1] = number;

                    } //else Console.WriteLine(number + " is less than " + number2);

                
            }
            counter--;
                        }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < array.Length; i++)
            { 
                Console.WriteLine (array[i]);
                Console.ReadKey();

            }
        }
    }
}

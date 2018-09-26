<<<<<<< HEAD
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Bubblesort
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++) // filling arrray with random numbers
            {
                array[i] = rnd.Next(1, array.Length);
                Console.WriteLine(array[i]);
            }
            makespace();
            sortmyarray(array);
            
            for (int i = 0; i < array.Length; i++) //output the sorted Array
            { 
                Console.WriteLine (array[i]);
            }
            Console.ReadKey();

        }
        static void sortmyarray(int[] array)
        {
            int counter = array.Length;
            int number;
            int number2;
            while (counter != 0)  //algorithm to sort the array
            {
                for (int i = 0; i < counter - 1; i++)
                {
                    number = array[i];
                    number2 = array[i + 1];
                    if (number > number2)
                    {
                        array[i] = number2;
                        array[i + 1] = number;
                    }
                }
                counter--;
            }
        }
        static void makespace()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
    
}
=======
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
>>>>>>> 418e3cfc95fd10684c4286d23faabec024e27095

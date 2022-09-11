using System;
using System.Threading;
using System.Globalization;
// using Nakov.IO;
using System.Linq;
using System.Collections.Generic;

namespace Chapter6ExercisesSolutions
{

    class MainClass
    {
        public static void Main(string[] args)
        {
            // Chapter 6 Exercise

            // Factorial Finder Program with do-while loop
            Console.Write("n = ");
            int number = int.Parse(Console.ReadLine());

            decimal factorial = 1;

            do
            {
                if (number < 1)
                {
                    break;
                }
                factorial *= number;
                number--;
            } while (number > 0);
            Console.WriteLine("number! = " + factorial);

            // Factorial Finder Program with while loop
            /*

                int number = int.Parse(Console.ReadLine());

                int factorial = 1;

                while (true)
                {
                    if (number <= 1)
                    {
                        break;
                    }

                    factorial *= number;
                    number--;
                }
                Console.WriteLine("number! = " + factorial);
            */
        }
    }
}


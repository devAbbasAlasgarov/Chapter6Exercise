// Chapter 6

using System;
using System.Threading;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;

namespace Chapter6Exercises
{

    class MainClass
    {

        public static void Main(string[] args)
        {

            // Chapter 6 Exercise

            // Factorial Finder Program with do-while loop

            
            Console.Write("n = ");
            int number = int.Parse(Console.ReadLine());

            BigInteger factorial = 1;

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

            /*
            int number = int.Parse(Console.ReadLine());
            int divider = 2;
            int maxDivider = (int)Math.Sqrt(number);
            bool prime = true;

            while(prime && (divider <= maxDivider))
            {
                if(number % divider == 0)
                {
                    prime = false;
                }
                divider++;
            }

            Console.WriteLine("Prime? " + prime);
            */

            /*
            Console.Write("Number = ");
            int number = int.Parse(Console.ReadLine());

            int counter = 1;
            int sum = 1;
            Console.Write("The sum 1");
            while (counter < number)
            {
                counter++;
                sum += counter;
                Console.Write(" + " + counter);
            }

            Console.WriteLine(" = " + sum);
            */

            /*
            int counter = 0;

            while(counter<=9)
            {
                Console.WriteLine("Number : " + counter);
                counter++;
            }
            */
        }
    }
}



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

            // Lottery 6/49
            /*
            for(int i1 = 1; i1 <= 44; i1++)
            {
                for(int i2 = i1 + 1; i2 <= 45; i2++)
                {
                    for(int i3 = i2 + 1; i3 <= 46; i3++)
                    {
                        for (int i4 = i3 + 1; i4 <= 47; i4++)
                        {
                            for (int i5 = i4 + 1; i5 <= 48; i5++)
                            {
                                for (int i6 = i5 + 1; i6 <= 49; i6++)
                                {
                                    Console.WriteLine(i1 + " " + i2 + " " +
                                        i3 + " " + i4 + " " + i5 + " " + i6);
                                }
                            }
                        }
                    }
                }
            }
            Console.Read();
            */

            // Luck numbers ABCD A+B = C+D
            /*
            for(int a = 0; a <= 9; a++)
            {
                for(int b = 1; b <= 9; b++)
                {
                    for(int c = 1; c <= 9; c++)
                    {
                        for(int d = 1; d <= 9; d++)
                        {
                            if((a+b) == (c+d))
                            {
                                Console.WriteLine(a + " " + b + " " + c + " " + d);
                            }
                        }
                    }
                }
            }
            Console.Read();
            */

            // Prime Numbers in an Interval
            /*
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("m = ");
            int m = int.Parse(Console.ReadLine());

            for(int num = n; num <= m; num++)
            {
                bool prime = true;
                int divider = 2;
                int maxDivider = (int)Math.Sqrt(num);
                while(divider <= maxDivider)
                {
                    if(num % divider ==0)
                    {
                        prime = false;
                        break;
                    }
                    divider++;
                }
                if (prime)
                {
                    Console.WriteLine(" " + num);
                }
            }
            Console.Read();
            */

            // Nested Loops
            // Printing a triangle with numbers
            /*
            int n = int.Parse(Console.ReadLine());

            for(int row = 1; row <= n; row++)
            {
                for(int col = 1; col <= row; col++)
                {
                    Console.Write(col + " ");
                }
                Console.WriteLine();
            }
            Console.Read();
            */

            // foreach loop
            /*
            int[] numbers = { 2, 3, 5, 7, 11, 13, 17, 19 };
            foreach(int i in numbers)
            {
                Console.WriteLine(" " + i);
            }
            Console.WriteLine();

            string[] towns = { "London", "Paris", "Milan", "New York" };
            foreach(string town in towns)
            {
                Console.WriteLine(" " + town);
            }

            Console.Read();
            */

            // Operator "continue"
            // input 10 output 18 when it is continue
            // input 10 output 9 when it is break
            /*
            int n = int.Parse(Console.ReadLine());

            int sum = 0;

            for(int i = 1; i <= n; i += 2)
            {
                if (i % 7 == 0)
                {
                    continue;
                    // break;
                }
                sum += i;
            }
            Console.WriteLine("sum = " + sum); 
            Console.Read();
            */

            // For loop with several variables
            /*
            for(int small = 1, large = 10; small < large; small++, large--)
            {
                Console.WriteLine(small + " " + large);
            }
            Console.Read();
            */

            // Calculating N^M
            /*
            Console.WriteLine("n = ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("m = ");
            int m = int.Parse(Console.ReadLine());

            decimal result = 1;
            for (int i = 0; i < m; i++)
            {
                result *= n;
            }
            Console.WriteLine("n^m = " + result);
            Console.Read();
            */

            // For loop with several variables
            /*
            for(int i = 1, sum = 1; i <= 128; i = i * 2, sum += i)
            {
                Console.WriteLine("i = {0}, sum = {1} ", i, sum);
            }
            Console.Read();
            */

            // infinite Abbas
            /*
            for (bool i = true; i = true;)
            {
                Console.WriteLine("Abbas");
            }
            */

            // infinite Abbas
            /*
            for (; ;)
            {
                Console.WriteLine("Abbas");
            }
            */

            // Product in Range[N...M]
            /*
            Console.Write("Number 1 = ");
            int numberOne = int.Parse(Console.ReadLine());

            Console.Write("Number 2 = ");
            int numberTwo = int.Parse(Console.ReadLine());

            int iterator = numberOne;
            BigInteger product = 1;

            do
            {
                product *= iterator;
                iterator++;

            } while (iterator <= numberTwo);
            // Unchecked code will silently overflow and the code above will produce
            // incorrect output instead of showing an error. To overcome this, you may
            // surround the line holding the multiplication by the checked keyword.
            // double d = product; // 5 * 10^9
            // Console.WriteLine(d); // 5000000000
            // int i = checked((int)d); // System.OverflowException Console.WriteLine(i);
            // Console.WriteLine(i);

            Console.WriteLine("Production[Number 1 ... Number 2] = " + product);
            Console.Read();
            */

            // Factorial Finder Program with do-while loop
            /*
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
            */

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


            // Prime Number
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



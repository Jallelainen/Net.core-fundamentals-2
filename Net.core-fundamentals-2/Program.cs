using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Net.core_fundamentals_2
{
    class Program
    {

        static void Main(string[] args)
        {
            // Arrays();
            // PrimitivNumber();


            AskForNumber();

        }

        private static void AskForNumber()
        {
            bool notNumber = false;

            do
            {
                Console.WriteLine("please input number");

                double number = 0;

                try
                {
                    number = double.Parse(Console.ReadLine());
                    //will not go past here if there is an exception.
                    notNumber = false;
                } 
                catch (ArgumentNullException)
                {
                    Console.WriteLine("did not get input.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("The number was too damn high");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Was unable to read the number.\nYou cannot use text");
                }
                catch
                {
                    Console.WriteLine("sumting went wrong.");
                    notNumber = true;
                }
                finally // will allways execute
                {
                    //Console.WriteLine("Number was:" + number);
                    //Console.WriteLine("Number was: {0}", number);
                    Console.WriteLine($"Number was: {number}");
                }

            } while (notNumber);
        }

        static void PrimitivNumber()
        {
            double number = 0.0;

            Console.WriteLine(number);

            CountUpNumber(number);
        }

        static void CountUpNumber(double num)
        {
            for (int i = 0; i < 5; i++)
            {
                num++;
            }
        }

        //--------------------------------------------------------------------------------------

        static void Arrays()
        {
            int[,] multiTable = new int[5, 5];

            foreach (var item in multiTable)
            {
                Console.WriteLine(item);
            }

            SetMultiNumbers(multiTable);

            Console.WriteLine("after method call");

            foreach (var item in multiTable)
            {
                Console.WriteLine(item);
            }

        }

        static void SetMultiNumbers(int[,] table)
        {
            for (int y= 0; y < 10; y++)
            {
                for (int x = 0; x < 10; x++)
                {
                    table[y, x] = (y + 1) * (x + 1); 
                }
            }
        }
        //----------------------------------------------------------------------------
        static void ListMethod()
        {
            List<double> numbersList = new List<double>();

            numbersList.Add(5.5);
        }
    }


}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text; // req. for stringbuilder

namespace Net.core_fundamentals_2
{
    class Program
    {

        static void Main(string[] args)
        {
            // Arrays();
            // PrimitivNumber();
            // AskForNumber();

            bool keepLooping = true;
            List<double> numberList = new List<double>();

            while (keepLooping)
            {
                Console.WriteLine("-----------Menu----------");
                Console.WriteLine("1: Print list");
                Console.WriteLine("2: Add to list");
                Console.WriteLine("3: Speed test");
                Console.WriteLine("4: Random Example");
                Console.WriteLine("-1: Exit");

                double selection = AskForNumber();

                switch (selection)
                {
                    case 1:
                        PrintList(numberList);
                        break;
                    case 2:
                        numberList.Add(AskForNumber());
                        break;
                    case 3:
                        SpeedDifStringVSStringBuilder();
                        break;
                    case 4:
                        RandomEx();
                        break;
                    case -1:
                        keepLooping = false;
                        Console.WriteLine("Thank you");
                            break;

                    default:
                        Console.WriteLine("Not a valid selection.");
                        break;
                }

            }

        }

        static void RandomEx()
        {
            Random random = new Random();
            Random random2 = new Random();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(random.Next(1, 5)); // 1-4. 5 is exclusive
            }

            Console.WriteLine("---------------------");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(random2.Next(1, 5)); // 1-4. 5 is exclusive
            }


        }

        static void PrintList(List<double> numbers)
        {
            Console.WriteLine("------List------");

            foreach (var aNum in numbers)
            {
                Console.WriteLine(aNum);
            }
        }

        static void TextEx()
        {
            string someText = "";

            StringBuilder stringBuilder = new StringBuilder();//use this to remember guesses

            stringBuilder.Append("some text");
            stringBuilder.Append("some other text");

            Console.WriteLine(stringBuilder);

        }

        static void SpeedDifStringVSStringBuilder()
        {

            string star = "";

            DateTime stringStart = DateTime.Now;
            for (int i = 0; i < 100_000; i++)
            {
                star = star + "*";
            }
            DateTime stringEnd = DateTime.Now;

            StringBuilder stringBuilder_star = new StringBuilder();

            DateTime sbStart = DateTime.Now;
            for (int i = 0; i < 100_000; i++)
            {
                stringBuilder_star.Append("*");
            }
            DateTime sbEnd = DateTime.Now;

            Console.WriteLine("String time: " + (stringEnd - stringStart));
            Console.WriteLine("SB time: " + (sbStart - sbEnd));


        }

        private static double AskForNumber()
        {
            bool notNumber = false;
            double number = 0;

            do
            {
                Console.WriteLine("please input number: ");


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

            return number;
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

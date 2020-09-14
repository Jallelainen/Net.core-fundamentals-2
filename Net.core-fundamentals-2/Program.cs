using System;
using System.Runtime.CompilerServices;

namespace Net.core_fundamentals_2
{
    class Program
    {

        static void Main(string[] args)
        {
            Arrays();

        }

        static void Arrays()
        {
            int[,] multiTable = new int[10, 10];

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
    }
}

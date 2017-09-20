using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitwiseOperations
{
    class Program
    {
        [Flags]
        public enum Priority
        {
            None = 0,
            VeryLow = 1,
            Low = 2,
            Medium = 4,
            High = 8,
            VeryHigh = 16
        }

        static void Main(string[] args)
        {
            Priority p = Priority.None | Priority.High;
            Console.WriteLine(p.ToString());

            DisplayEven(20);

            DisplayOdd(20);

            XORDemo(12,127);

            Console.ReadKey();
        }

        static void DisplayEven(UInt32 counter)
        {
            for (int i = 0; i <= counter; i++)
            {
                if ((i & 0x1) == 0)// if zero bit of i is 0 - i is even number
                {
                    Console.WriteLine(i);
                    //Console.WriteLine(i & 0xFFFFFFFE);// Set zero bit of i to zero
                }
            }
        }

        static void DisplayOdd(UInt32 counter)
        {
            for (int i = 0; i < counter; i++)
            {
                if ((i & 1)==1)// if zero bit of i is 1 - i is an odd number
                {
                    Console.WriteLine(i);
                }
            }
        }

        static void XORDemo(int x, int y)
        {
            Console.WriteLine($"x: {x}");
            Console.WriteLine($"y: {y}");
            x = x ^ y;
            Console.WriteLine($"x ^ y: {x}");
            x = x ^ y;
            Console.WriteLine($"x ^ y: {x}");
            y = x ^ y;
            Console.WriteLine($"x ^ y: {y}");
            y = x ^ y;
            Console.WriteLine($"x ^ y: {y}");
        }
    }
}

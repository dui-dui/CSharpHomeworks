using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace program3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[100];
            for (int i = 0; i < 100; i++) 
            {
                numbers[i] = i + 1;
            }
            int b = 2;
            for (int a = 100; a > b; a--) 
            {
                if (a % b == 0) 
                {
                    numbers[a - 1] = 1;
                }
                if (a == (b + 1) )
                {
                    b += 1;
                    a = 100;
                }
            }
            for (int c = 0; c < 100; c++)
            {
                if (numbers[c] != 1)
                {
                    Console.WriteLine(numbers[c] + "\t");
                }
            }
        }
    }
}

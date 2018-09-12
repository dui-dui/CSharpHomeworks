using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace program1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "";
            int a = 0, b = 0;
            Console.Write("Please input an number:");
            s = Console.ReadLine();
            a = Int32.Parse(s);
            Console.Write("Please input an number:");
            s = Console.ReadLine();
            b = Int32.Parse(s);
            Console.WriteLine("a+b=" + (a + b));
        }
    }
}

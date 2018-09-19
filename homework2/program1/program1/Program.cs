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
            Console.WriteLine("请输入一个数");
            string s = "";
            s = Console.ReadLine();
            int n = 0；
            n = int.Parse(s);
            for (int i=2; i <= n; i++) 
            {
                if (n % i == 0)
                {
                    n = n / i;
                    Console.WriteLine(i);
                    i = 1;
                }
            }
        }
    }
}

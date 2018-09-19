using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace program2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 2, 36, 4, 28, 57, 10, 1, 13, 9 };
            Array.Sort(numbers);
            int a=numbers.Length-1;
            Console.WriteLine(numbers[a] + "\t");//输出数组最大值
            Console.WriteLine(numbers[0] + "\t");//输出数组最小值
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++) 
            {
                sum += numbers[i];
            }
            Console.WriteLine(sum + "\t");
        }
    }
}

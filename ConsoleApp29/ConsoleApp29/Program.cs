using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29
{
    internal class Program
    {
        static int SumToN(int n)
        {
            if(n <= 0)
            {
                return 0;
            }
            return n + SumToN(n - 1);
        }
        static void Main(string[] args)
        {
            int sum = SumToN(10);
            Console.WriteLine("1 + 2 + .....10 = " + sum);
        }
    }
}

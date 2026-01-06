using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int a = 5, b = 3;
            //int sum = a + b;
            //bool isEqual = (a == b);

            //Console.WriteLine($"합 : {sum}");
            //Console.WriteLine($"a와 b가 같은가? {isEqual}");

            //int number = 5;
            //Console.WriteLine(+number);
            //Console.WriteLine(-number);

            //bool flag = true;
            //Console.WriteLine(!flag);

            //int a = 10, b = 3;

            //Console.WriteLine(a + b);
            //Console.WriteLine(a - b);
            //Console.WriteLine(a * b);
            //Console.WriteLine(a / b);
            //Console.WriteLine(a % b);

            //string firstName = "Choi";
            //string lastName = "YuJin";

            //Console.WriteLine(firstName + " " + lastName);

            int a = 5;
            int b = 4;

            //a = a + b;
            //Console.WriteLine("합계 : " + a);
            //a = 5;
            //a = a - b;
            //Console.WriteLine("합계 : " + a);
            //a = 5;
            //a = a * b;
            //Console.WriteLine("합계 : " + a);
            //a = 5;
            //a = a / b;
            //Console.WriteLine("합계 : " + a);

            a += b;
            Console.WriteLine("a + b : " + a);
            a = 5;
            a -= b;
            Console.WriteLine("a - b : " + a);
            a = 5;
            a *= b;
            Console.WriteLine("a * b : " + a);
            a = 5;
            a /= b;
            Console.WriteLine("a / b : " + a);
            a = 5;
            a %= b;
            Console.WriteLine("a % b : " + a);
            a = 5;
        }
    }
}

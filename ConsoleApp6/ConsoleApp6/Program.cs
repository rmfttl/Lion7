using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //float singPrecision = 3.14f;
            //double doublePrecision = 3.1415926535;
            //decimal highPrecision = 3.1415926535587932384626433833m;

            //Console.WriteLine(singPrecision);
            //Console.WriteLine(doublePrecision);
            //Console.WriteLine(highPrecision);

            //int intgerValue = 100;
            //long longValue = 100L;
            //float floatValue = 3.14f;
            //double doubleValue = 3.14;
            //decimal decimalValue = 3.14m;

            //Console.WriteLine(intgerValue);
            //Console.WriteLine(longValue);
            //Console.WriteLine(floatValue);
            //Console.WriteLine(doubleValue);
            //Console.WriteLine(decimalValue);

            //char letter = 'A';
            //char symbol = '#';
            //char number = '9';

            //Console.WriteLine(letter);
            //Console.WriteLine(symbol);
            //Console.WriteLine(number);

            float flo = 5.5f;
            double dou = 1.25;
            decimal dec = 12.99m;

            Console.WriteLine("=== 캐릭터 능력치 ===");
            Console.WriteLine($"이동 속도 : {flo}");
            Console.WriteLine($"공격 속도 : {dou}");
            Console.WriteLine($"아이템 가격 : {dec}");
        }
    }
}

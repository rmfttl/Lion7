using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
            //Console.WriteLine("┃             Game start             ┃");
            //Console.WriteLine("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");

            int HP = 1450;
            int FP = 74;
            int stamina = 101;
            double Maxweight = 57.7;
            int mental = 38;
            int discovery = 109;

            Console.WriteLine("기초력");
            Console.WriteLine($"┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
            Console.WriteLine($"┃                                    ┃");
            Console.WriteLine($"┃   HP                        {HP}   ┃");
            Console.WriteLine($"┃   FP                          {FP}   ┃");
            Console.WriteLine($"┃   스태미나                   {stamina}   ┃");
            Console.WriteLine($"┃                                    ┃");
            Console.WriteLine($"┃   최대 장비 중량            {Maxweight}   ┃");
            Console.WriteLine($"┃                                    ┃");
            Console.WriteLine($"┃   강인도                      {mental}   ┃");
            Console.WriteLine($"┃   발견력                     {discovery}   ┃");
            Console.WriteLine($"┃                                    ┃");
            Console.WriteLine($"┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");
        }
    }
}

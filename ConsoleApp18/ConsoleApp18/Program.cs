using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 1; i <= 3; i++)
            //{
            //    for (int j = 1; j <= 3; j++)
            //    {
            //        Console.WriteLine($"i:{i} j:{j}");
            //    }
            //    Console.WriteLine();
            //}

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            //for (int i = 1; i <= 3; i++)
            //{
            //    for(int j = 1; j <= 3; j++)
            //    {
            //        Console.Write("⬜");
            //    }
            //    Console.WriteLine();
            //}

            //for (int i = 1; i <= 3; i++)
            //{
            //    for (int j = 1; j <= 3; j++)
            //    {
            //        Console.Write(j);
            //    }
            //    Console.WriteLine();
            //}

            //for (int i = 0; i <= 2; i++)
            //{
            //    for (int j = 0; j <= 2; j++)
            //    {
            //        Console.Write($"({j}, {i})");
            //    }
            //    Console.WriteLine();
            //}

            //for (int i = 0; i <= 4; i++)
            //{
            //    for (int j = 0; j <= i; j++)
            //    {
            //        Console.Write("⭐");
            //    }
            //    Console.WriteLine();
            //}

            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        if(i == j)
            //        {
            //            Console.Write("⭐");
            //        }
            //        else
            //        {
            //            Console.Write("  ");
            //        }
            //    }
            //    Console.WriteLine();
            //}

            //for (int i = 1; i < 4; i++)
            //{
            //    for (int j = 1; j < 4; j++)
            //    {
            //        Console.Write($"{i}X{j}={i*j} ");
            //    }
            //    Console.WriteLine();
            //}

            int max = 4;
            for (int i = 1; i <= max; i++)
            {
                for (int j = 1; j <= max; j++)
                {
                    if(i == 1 && j == 1)
                    {
                        Console.Write("🏠 ");
                    }
                    else if(i == max && j == max)
                    {
                        Console.Write("🎯 ");
                    }
                    else
                    {
                        Console.Write("🟩 ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}

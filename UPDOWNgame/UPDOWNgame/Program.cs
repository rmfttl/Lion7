using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UPDOWNgame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int number = random.Next(1,11);
            for(int i = 0; i != number;)
            {
                Console.Write("숫자 입력 : ");
                string input = Console.ReadLine();
                i = int.Parse(input);
                if(i == number)
                {
                    Console.Clear();
                    Console.WriteLine($"정답! {number}");
                }
                else
                {
                    Console.Clear();
                    if(i > number)
                    {
                        Console.WriteLine("down!");
                    }
                    else if(i < number)
                    {
                        Console.WriteLine("up!");
                    }
                }
            }
        }
    }
}

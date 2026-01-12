using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    internal class Program
    {
        //static void Attack(ref int a)
        //{
        //    Console.WriteLine($"공격력 : {a}");
        //    a++;
        //}
        static void Attack(out int attack, out int defanse)
        {
            attack = 10;
            defanse = 20;
            attack++;
            defanse++;
        }
        static void Main(string[] args)
        {
            //int a = 10;
            //Console.WriteLine($"a 값 : {a}");
            //Attack(ref a); < 이건 하나만 out은 여러개
            //Console.WriteLine($"a 값 : {a}");

            int attack;
            int defanse;

            Attack(out attack, out defanse);

            Console.WriteLine($"공격력 : {attack}");
            Console.WriteLine($"방어력 : {defanse}");
        }
    }
}

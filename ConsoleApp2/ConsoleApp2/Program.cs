using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int health;
            health = 100;

            int maxhealth = 100;
            int damage = 15;

            Console.WriteLine("체력 : " + health + " / " + maxhealth);
            Console.WriteLine("데미지수치 " + damage);
        }
    }
}

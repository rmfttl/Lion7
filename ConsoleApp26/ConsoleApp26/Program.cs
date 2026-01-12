using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    internal class Program
    {
        static void CastFireBall(string target, int damage = 100, int manaCost = 30)
        {
            Console.WriteLine("파이어볼 시전!");
            Console.WriteLine($"대상 : {target}");
            Console.WriteLine($"데미지 : {damage}");
            Console.WriteLine($"마나 소모 : {manaCost}");
        }
        static void UseItam(string potion, int HP = 100)
        {
            Console.WriteLine($"💊 {potion} 사용!");
            Console.WriteLine($"회복량: {HP} HP\n");
        }
        static void SummonMagic(string summon, int level = 50, int amount = 3)
        {
            Console.WriteLine($"✨ {summon} 소환!");
            Console.WriteLine($"레벨 : {level}");
            Console.WriteLine($"수량 : {amount}마리\n");
        }
        static void Main(string[] args)
        {
            //CastFireBall("고블린", 150, 40);
            //Console.WriteLine();
            //CastFireBall("오크", 20);
            //Console.WriteLine();
            //CastFireBall("드래곤");
            //Console.WriteLine();

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("=== 아이템 사용 ===\n");
            UseItam("회복 포션", 50);
            UseItam("고급 회복 포션");

            Console.WriteLine("=== 소환 마법 ===\n");
            SummonMagic("슬라임", 1, 1);
            SummonMagic("고블린", 5, 1);
            SummonMagic("드래곤");
        }
    }
}

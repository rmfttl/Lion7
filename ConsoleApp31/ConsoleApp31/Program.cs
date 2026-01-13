using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    internal class Program
    {
        class Character
        {
            // 필드 (Field): 클래스의 데이터
            public string name;
            public int level;
            public int hp;
            public int maxHP;
            public int mp;
            public int maxMP;

            // 메서드 (Method): 클래스의 기능
            public void ShowInfo()
            {
                Console.WriteLine($"━━━━━━━━━━━━━━━━━━━━");
                Console.WriteLine($"이름: {name}");
                Console.WriteLine($"레벨: {level}");
                Console.WriteLine($"HP: {hp}/{maxHP}");
                Console.WriteLine($"MP: {mp}/{maxMP}");
                Console.WriteLine($"━━━━━━━━━━━━━━━━━━━━");
            }
            public void TakeDamage(int damage)
            {
                hp -= damage;
                if (hp < 0) hp = 0;

                Console.WriteLine($"⚔️ {name}이(가) {damage} 데미지를 받았습니다!");
                Console.WriteLine($"   남은 HP: {hp}/{maxHP}");
            }

            public void Heal(int amount)
            {
                hp += amount;
                if (hp > maxHP) hp = maxHP;

                Console.WriteLine($"💚 {name}의 HP가 {amount} 회복되었습니다!");
                Console.WriteLine($"   현재 HP: {hp}/{maxHP}");
            }
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            Character player1 = new Character();

            player1.name = "홍길동";
            player1.level = 10;
            player1.hp = 150;
            player1.maxHP = 150;
            player1.mp = 80;
            player1.maxMP = 80;

            player1.ShowInfo();

            player1.TakeDamage(50);

            player1.Heal(30);

            Character player2 = new Character();
            player2.name = "김영희";
            player2.level = 15;
            player2.hp = 200;
            player2.maxHP = 200;
            player2.mp = 120;
            player2.maxMP = 120;

            player2.ShowInfo();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////캐릭터 스탯 계산
            //int baseAttack = 50;
            //int weaponDamage = 30;
            //int totalAttack = baseAttack + weaponDamage;

            //Console.WriteLine("=== 공격력 계산 ===");
            //Console.WriteLine($"기본 공격력 : {baseAttack}");
            //Console.WriteLine($"무기 데미지 : {weaponDamage}");
            //Console.WriteLine($"총 공격력 : {totalAttack}");

            ////데미지 계산
            //int playerHealth = 100;
            //int damage = 25;
            //playerHealth = playerHealth - damage;

            //Console.WriteLine("\n === 데미지 계산 ===");
            //Console.WriteLine($"받은 데미지: {damage}");
            //Console.WriteLine($"남은 체력: {playerHealth}");


            ////경험치 계산
            //int monsterSkilled = 5;
            //int expPerMonster = 100;
            //int totalExp = monsterSkilled * expPerMonster;

            //Console.WriteLine("\n=== 경험치 획득 ===");
            //Console.WriteLine($"처치한 몬스터: {monsterSkilled}마리");
            //Console.WriteLine($"몬스터당 경험치: {expPerMonster}");
            //Console.WriteLine($"총 경험치: {totalExp}");

            ////아이템 분배
            //int totalGold = 1000;
            //int playerCount = 4;
            //int goldPerPlayer = totalGold / playerCount;
            //int remainingGold = totalGold % playerCount;


            //Console.WriteLine("\n===골드 분배===");
            //Console.WriteLine($"총 골드: {totalGold}");
            //Console.WriteLine($"플레이어 수 : {playerCount}명");
            //Console.WriteLine($"1인당 골드 : {goldPerPlayer}");
            //Console.WriteLine($"남은골드: {remainingGold}");

            //int b = 3;
            //b++; //후위 증가
            //Console.WriteLine(b);

            //--b; //전위 감소
            //Console.WriteLine(b);

            //int KillCount = 0;

            //Console.WriteLine("=== 몬스터 처치 ===");
            //Console.WriteLine($"고블린 처치! (킬 카운트 : {++KillCount})");
            //Console.WriteLine($"오크 처치! (킬 카운트 : {++KillCount})");
            //Console.WriteLine($"드래곤 처치! (킬 카운트 : {++KillCount})");
            //Console.WriteLine($"총 처치 수 : {KillCount}마리)");

            //int bullet = 30;

            //Console.WriteLine("\n=== 사격 ===");
            //Console.WriteLine($"남은 탄약 : {bullet}");
            //Console.WriteLine($"발사! 남은 탄약 : {--bullet}");
            //Console.WriteLine($"발사! 남은 탄약 : {--bullet}");
            //Console.WriteLine($"발사! 남은 탄약 : {--bullet}");

            //int count = 3;

            //Console.WriteLine("\n=== 카운트다운 ===");
            //Console.WriteLine(count);
            //Console.WriteLine(--count);
            //Console.WriteLine(--count);
            //Console.WriteLine("발사!");

            ////관계형 연산자
            //int x = 5;
            //int y = 10;

            //Console.WriteLine(x < y);
            //Console.WriteLine(x > y);
            //Console.WriteLine(x <= y);
            //Console.WriteLine(x >= y);
            //Console.WriteLine(x == y); //같냐? f
            //Console.WriteLine(x != y); //같지않지않냐? t

            //bool a = true;
            //bool b = true;


            //Console.WriteLine(a && b);
            //a = false;
            //b = true;
            //Console.WriteLine(a && b);
            //a = true;
            //b = false;
            //Console.WriteLine(a && b);
            //a = false;
            //b = false;
            //Console.WriteLine(a && b);

            //bool a = false, b = false;
            //Console.WriteLine(a || b);
            //a = false; b = true;
            //Console.WriteLine(a || b);
            //a = true; b = false;
            //Console.WriteLine(a || b);
            //a = true; b = true;
            //Console.WriteLine(a || b);

            //bool a = false;

            //Console.WriteLine(!a);

            //int x = 5;
            //int y = 3;

            //string binary = Convert.ToString(x & y, 2);

            //Console.WriteLine($"8비트 : {binary.PadLeft(8, '0')}");

            //binary = Convert.ToString(x | y, 2);
            //Console.WriteLine($"8비트 : {binary.PadLeft(8, '0')}");

            //binary = Convert.ToString(x ^ y, 2);
            //Console.WriteLine($"8비트 : {binary.PadLeft(8, '0')}");

            //binary = Convert.ToString(~x, 2);
            //Console.WriteLine($"8비트 : {binary.PadLeft(8, '0')}");

            //int value = 4; //0100

            //string binary = Convert.ToString(value << 1, 2);
            ////<< >>
            //Console.WriteLine($"8비트 : {binary.PadLeft(8, '0')}");
            //binary = Convert.ToString(value >> 1, 2);
            ////<< >>
            //Console.WriteLine($"8비트 : {binary.PadLeft(8, '0')}");

            //int inventory = 0; // 0000 0000 

            //Console.WriteLine($"초기 인벤토리: {Convert.ToString(inventory, 2).PadLeft(8, '0')}");

            ////슬롯 번호
            //int slot1 = 1; //활
            //int slot2 = 2; //지팡이

            ////슬롯 0에 활을 추가
            //inventory = inventory | (1 << slot1); // 2번째로 1추가
            //Console.WriteLine($"슬롯 {slot1}에 활 추가");
            //Console.WriteLine($"초기 인벤토리: {Convert.ToString(inventory, 2).PadLeft(8, '0')}");

            ////슬롯 0에 활을 추가
            //inventory = inventory | (1 << slot2); // 2번째로 1추가
            //Console.WriteLine($"슬롯 {slot2}에 지팡이 추가");
            //Console.WriteLine($"초기 인벤토리: {Convert.ToString(inventory, 2).PadLeft(8, '0')}");

            Console.WriteLine("문제1 : RPG체력 계산기");

            int cHP = 80;
            int mHP = 100;

            Console.WriteLine($"\n초기 출력 : {cHP}/{mHP}");
            Console.WriteLine($"데미지 -25 : {cHP-=25}/{mHP}");
            Console.WriteLine($"회복 +30 : {cHP+=30}/{mHP}");
            Console.WriteLine($"독 데미지 -5 : {cHP-=5}/{mHP}");

            Console.WriteLine("\n문제2 : 경험치와 레벨 계산");

            int expPerMonster = 150;
            int monstersKilled = 3;
            int expForLevelUp = 500;

            Console.WriteLine($"\n처지한 몬스터 : {monstersKilled}마리");
            Console.WriteLine($"획득 경험치 : {expPerMonster*3}");
            Console.WriteLine($"레벨업까지 필요 : {expForLevelUp-expPerMonster}");

            Console.WriteLine("\n문제3 : 아이템 분배 시스템");

            int totalGold = 1234;
            int partyMembers = 5;

            Console.WriteLine($"\n총 골드 : {totalGold}");
            Console.WriteLine($"파티원 : {partyMembers}명");
            Console.WriteLine($"1인당 골드 : {totalGold/partyMembers}");
            Console.WriteLine($"남은 골드 : {totalGold%partyMembers}");

            Console.WriteLine("\n문제4 : 던전 입장 가능 여부");

            int playerLevel = 35;
            int requiredLevel = 30;
            bool hasKey = true;
            int currentHP = 60;
            int maxHP = 100;

            Console.WriteLine("\n=== 던전 입장 조건 ===");
            Console.WriteLine($"레벨 조건(30 이상) : {playerLevel >= requiredLevel}");
            Console.WriteLine($"열쇠 보유 : {hasKey}");
            Console.WriteLine($"체력 조건(50% 이상) : {currentHP >= maxHP}");
            Console.WriteLine($"입장 가능 : {currentHP >= maxHP || playerLevel >= requiredLevel || hasKey}");

            Console.WriteLine("\n문제5 : 상점 할인 계산기");

            int originalPrice = 5000;
            bool isVIP = true;
            bool hasCoupon = true;

            Console.WriteLine($"\n원가 : {originalPrice}골드");
            if (isVIP == true)
            {
                Console.WriteLine($"VIP할인(20%) : {originalPrice * 0.8}골드");
            }
            else
            {
                Console.WriteLine($"원가 : {originalPrice}골드");
            }
            if (hasCoupon == true)
            {
                Console.WriteLine($"쿠폰 할인(-500) : {originalPrice * 0.8 - 500}골드");
            }
            else
            {
                Console.WriteLine($"원가 : {originalPrice}골드");
            }
            Console.WriteLine($"최종 가격 : {originalPrice * 0.8 - 500}골드");
        }
    }
}
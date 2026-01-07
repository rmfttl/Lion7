using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int a = 10, b = 20;
            //int max =  (a > b) ? a : b;
            //Console.WriteLine(max);
            ////(조건) ? (조건이 참일때 출력될 값) : (조건이 거짓일때 출력될 값);

            //Console.Write("시험점수 입력 : ");
            //string input = Console.ReadLine();
            //int score = int.Parse(input);
            //string result = (score >= 60) ? "합격" : "불합격";

            //Console.WriteLine("\n=== 시험 결과 ===");
            //Console.WriteLine($"점수 : {score}");
            //Console.WriteLine($"결과 : {result}");

            //Console.Write("레벨 입력 : ");
            //string input = Console.ReadLine();
            //int level = int.Parse(input);

            //string grade = (level >= 50) ? "고급" :
            //               (level >= 30) ? "중급" : "초급";
            ////string grade;
            ////if (level >= 50)
            ////{
            ////    grade = "고급";
            ////}
            ////else
            ////{
            ////    grade = (level <= 30) ? "초급" : "중급";
            ////}
            //Console.WriteLine("\n=== 플레이어 등급 ===");
            //Console.WriteLine($"레벨 : {level}");
            //Console.WriteLine($"등급 : {grade}");

            //int health = 30;
            //int maxhealth = 100;

            //string haelthStatus = (health > maxhealth) ? "체력 최대치는 100이하입니다" :
            //                      (health >= maxhealth * 0.7) ? "안전" :
            //                      (health >= maxhealth * 0.3) ? "주의" : "위험";

            //Console.WriteLine("=== 건강 상태 ===");
            //Console.WriteLine($"현재 체력 : {health/maxhealth}");
            //Console.WriteLine($"상태 : {haelthStatus}");


            ////우선 순위
            //int result = 10 + 2 * 5;
            //Console.WriteLine(result);

            //int adjustedResult = (10 + 2) * 5;
            //Console.WriteLine(adjustedResult);

            //// 예제 2: 데미지 계산
            //int baseDamage = 50;
            //int bonusDamage = 20;
            //double criticalMultiplier = 1.5;

            //// 잘못된 계산
            //double damage1 = baseDamage + bonusDamage * criticalMultiplier;
            //// 올바른 계산
            //double damage2 = (baseDamage + bonusDamage) * criticalMultiplier;

            //Console.WriteLine("\n=== 크리티컬 데미지 계산 ===");
            //Console.WriteLine($"기본 데미지: {baseDamage}");
            //Console.WriteLine($"보너스 데미지: {bonusDamage}");
            //Console.WriteLine($"크리티컬 배율: {criticalMultiplier}");
            //Console.WriteLine($"잘못된 계산: {damage1}");  // 80.0
            //Console.WriteLine($"올바른 계산: {damage2}");  // 105.0

            //제어문
            Console.Write("시험 점수 : ");
            string input = Console.ReadLine();
            int score = int.Parse(input);
            if (score >= 90)
            {
                Console.WriteLine("\nA학점");
            }
            else if(score >= 80)
            {
                Console.WriteLine("\nB학점");
            }
            else if (score >= 70)
            {
                Console.WriteLine("\nC학점");
            }
            else
            {
                Console.WriteLine("\nF학점");
            }
            //int number = 10;
            //if (number > 15)
            //{
            //    Console.WriteLine("15보다 큽니다");
            //}
            //else
            //{
            //    Console.WriteLine("15보다 작거나 같습니다");
            //}
        }
    }
}

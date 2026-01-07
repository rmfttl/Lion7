using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("천마연산신공"); //엄청길게 캐스팅해야하는 구절
            //}

            //Console.WriteLine("=== 몬스터 웨이브 시작 ===");
            //for (int i = 1; i < 6; i++)
            //{
            //    Console.WriteLine($"고블린 #{i} 생성!");
            //}
            //Console.WriteLine($"총 5마리 생성 완료!");

            //Console.WriteLine("=== 게임 시작 카운트다운 ===");
            //for (int i = 5; i > 0; i--)
            //{
            //    Console.WriteLine($"{i}...");
            //}
            //Console.WriteLine("🎮 게임 시작!");

            //// Random 객체 생성
            //Random random = new Random();

            //// 주요 메서드
            //int number1 = random.Next();           // 0 ~ int.MaxValue
            //int number2 = random.Next(10);         // 0 ~ 9
            //int number3 = random.Next(1, 7);       // 1 ~ 6 (주사위)
            //double number4 = random.NextDouble();  // 0.0 ~ 1.0

            //Console.WriteLine(number1);
            //Console.WriteLine(number2);
            //Console.WriteLine(number3);
            //Console.WriteLine(number4);


            ////무기 뽑기
            //string sword = "무한의 대검";
            //Console.WriteLine("당신은 20번 뽑기가 가능합니다. 지금 실행합니다.");

            //Random rand = new Random();
            //int random = 0;

            //for(int i = 0; i < 20;  i++)
            //{
            //    random = rand.Next(1, 101);

            //    if (random >= 1 && random <= 10)
            //    {
            //        sword = "무한의 대검";
            //    }
            //    else if (random >= 11 && random <= 30)
            //    {
            //        sword = "카타나";
            //    }
            //    else if (random >= 31 && random <= 60)
            //    {
            //        sword = "엑스칼리버";
            //    }
            //    else if (random >= 61 && random <= 100)
            //    {
            //        sword = "정기정검";
            //    }
            //    Console.WriteLine(sword);
            //    Thread.Sleep(500);
            //}

            //Console.WriteLine("문제1 : 온도에 따른 옷차림 추천");
            //Console.Write("오늘의 온도 : ");
            //string input = Console.ReadLine();
            //int temperature = int.Parse(input);

            //if(temperature >= 30)
            //{
            //    Console.WriteLine("매우 더워요! 반팔과 반바지를 입으세요.");
            //}
            //else if (temperature >= 20)
            //{
            //    Console.WriteLine("적당해요! 긴팔 티셔츠를 입으세요.");
            //}
            //else if (temperature >= 10)
            //{
            //    Console.WriteLine("쌀쌀해요! 가디건이나 자켓을 챙기세요.");
            //}
            //else if (temperature >= 0)
            //{
            //    Console.WriteLine("추워요! 코트를 입으세요.");
            //}
            //else if (temperature < 0)
            //{
            //    Console.WriteLine("매우 추워요! 패딩과 목도리가 필요해요.");
            //}
        }
    }
}

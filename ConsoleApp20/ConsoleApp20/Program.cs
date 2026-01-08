using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ConsoleApp20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            //광석 판매점 위치
            const int targetX = 78;
            const int targetY = 3;

            Console.SetWindowSize(80, 25); //콘솔 창 크기 설정 (가능 80, 세로 25)
            Console.SetBufferSize(80, 25); //버퍼 크기도 동일하게 설정 (스크롤 방지)
            Console.OutputEncoding = Encoding.UTF8;
            int x = 1, y = 3;

            ConsoleKeyInfo keyInfo; //키관련된 정보
            Console.CursorVisible = false;

            int Gold = 0;
            int input; // 메뉴 선택

            //광석 캐기
            int ore = 0;
            int star = 0;
            int starspx;
            int starspy;

            //뽑기
            int rnd;
            int SSS = 0;
            int AAA = 0;
            int BBB = 0;
            int CCC = 0;
            int FFF = 0;

            //도박
            int inp;
            int half;
            string yorn;

            while (true)
            {
                Menu:
                Console.Clear();

                Console.WriteLine($"소지금 : {Gold} | 장비 뽑기 비용 : 10,000원");
                Console.WriteLine($"마검 : {SSS} | 성검 : {AAA} | 보급형 검 : {BBB} | 낡은 검 : {CCC} | 나뭇가지 : {FFF}");
                Console.WriteLine("================================================================================");
                Console.WriteLine("1. 광석 줍기");
                Console.WriteLine("2. 장비 뽑기");
                Console.WriteLine("3. 도박하기");
                Console.Write("입력 : ");
                input = int.Parse(Console.ReadLine());
                if(input == 1)
                {
                    //광석캐기 > 직접 움직여서 캐고 판매, 시간이 지나면 리젠. 팔지 못한건 나가면 리셋or유지, 처음 광석에 광석 몇개 있음.
                    while (true)
                    {
                        mine:
                        Console.Clear();  //화면지우기
                        Console.WriteLine($"소지금 : {Gold} | 광석 o : {ore} | 희귀 광석 * : {star}");
                        Console.Write("판매 상점🏠 | 가격 | 광석 : 500원 | 희귀 광석 : 10,000");
                        Console.Write("\n================================================================================");

                        Console.SetCursorPosition(x, y); //좌표

                        Console.Write("●"); //현재 위치 출력

                        Console.SetCursorPosition(targetX, targetY);
                        Console.Write("🏠");

                        Console.SetCursorPosition(targetX, 5);
                        Console.Write("o");

                        starspx = rand.Next(1, 70);
                        starspy = rand.Next(3, 20);

                        Console.SetCursorPosition(starspx, starspy);
                        Console.Write("*");

                        if(x == targetX && y == 5)
                        {
                            ore += 1;
                        }

                        if(x == starspx &&  y == starspy)
                        {
                            star += 1;
                            starspx = rand.Next(1, 70);
                            starspy = rand.Next(3, 20);

                            Console.SetCursorPosition(starspx, starspy);
                            Console.Write("*");
                        }

                        if(x == targetX && y == targetY)
                        {
                            Console.Clear();
                            Console.WriteLine("판매가 완료되었습니다.");
                            Gold += ore * 500 + star * 10000;
                            ore = 0;
                            star = 0;
                            Console.WriteLine($"현재 소지금 : {Gold}");
                            Console.WriteLine("메뉴로 돌아가기 m | 뒤로 가기 x");
                            Console.Write("입력칸 : ");
                            string str = Console.ReadLine();
                            if(str == "m")
                            {
                                x--;
                                goto Menu;
                            }
                            else if(str == "x")
                            {
                                x--;
                                goto mine;
                            }
                                break;
                        }


                        keyInfo = Console.ReadKey(true); //키 입력 받기 (화면 출력 x)

                        //방향키 입력에 따른 좌표 변경
                        switch (keyInfo.Key)
                        {
                            case ConsoleKey.UpArrow: if (y > 3) y--; break;
                            case ConsoleKey.DownArrow: if (y < Console.WindowHeight - 1) y++; break;
                            case ConsoleKey.LeftArrow: if (x > 0) x--; break;
                            case ConsoleKey.RightArrow: if (x < Console.WindowWidth - 1) x++; break;
                        }

                    }
                }
                else if(input == 2)
                {
                    if(Gold < 10000)
                    {
                        Console.WriteLine("돈이 부족합니다.");
                    }
                    else
                    {
                        Gold -= 10000;
                        for(int i = 1; i <= 10; i++)
                        {
                            rnd = rand.Next(1, 1001);
                            if(rnd == 1)
                            {
                                Console.WriteLine("최상급 마검");
                                SSS += 1;
                            }
                            else if(rnd >= 2 &&  rnd <= 100)
                            {
                                Console.WriteLine("상급 성검");
                                AAA += 1;
                            }
                            else if (rnd >= 101 && rnd <= 500)
                            {
                                Console.WriteLine("중급 보급형 검");
                                BBB += 1;
                            }
                            else if (rnd >= 501 && rnd <= 989)
                            {
                                Console.WriteLine("하급 낡은 검");
                                CCC += 1;
                            }
                            else if (rnd >= 990 && rnd <= 1000)
                            {
                                Console.WriteLine("나뭇가지");
                                FFF += 1;
                            }
                            Thread.Sleep(500);
                        }
                    }
                    Thread.Sleep(1000);
                    goto Menu;
                }
                else if(input == 3)
                {
                    GameMenu:
                    Console.Clear();
                    Console.WriteLine("1. 50% 확률로 2배 혹은 0.5배");
                    Console.WriteLine("2. 업다운 게임");
                    Console.WriteLine("3. 메뉴로 돌아가기");
                    Console.Write("입력 : ");
                    inp = int.Parse(Console.ReadLine());
                    if(inp == 1)
                    {
                        half = rand.Next(1, 3);
                        if(half == 1)
                        {
                            Console.Clear();
                            Gold = Gold * 2;
                            Console.WriteLine($"도박 성공! 현재 소지금 : {Gold}");
                            Thread.Sleep(1000);
                            goto GameMenu;
                        }
                        else if(half == 2)
                        {
                            Console.Clear();
                            Gold = Gold / 2;
                            Console.WriteLine($"도박 실패... 현재 소지금 : {Gold}");
                            Thread.Sleep(1000);
                            goto GameMenu;
                        }
                    }
                    else if(inp == 2)
                    {
                        Console.Clear();
                        Console.WriteLine("=== Up & Down Game! ===");
                        Console.WriteLine("기회는 총 5번! 맞춘다면 5배고, 맞추지 못한다면 돈을 다 잃습니다.");
                        Console.WriteLine("숫자 범위는 1-100사이입니다! 플레이하시겠습니까? Y/N");
                        yorn = Console.ReadLine();
                        if(yorn == "y")
                        {
                            Console.Clear();
                            int number = rand.Next(1, 101);
                            int j = 0;
                            for (j = 1; j <= 5; j++)
                            {
                                Console.Write("숫자 입력 : ");
                                string num = Console.ReadLine();
                                int i = int.Parse(num);
                                if (i == number)
                                {
                                    Console.Clear();
                                    Console.WriteLine($"정답! {number}");
                                    Gold = Gold * 5;
                                    Thread.Sleep(1000);
                                    goto Menu;
                                }
                                else if(j < 5)
                                {
                                    Console.Clear();
                                    if (i > number)
                                    {
                                        Console.WriteLine("down!");
                                    }
                                    else if (i < number)
                                    {
                                        Console.WriteLine("up!");
                                    }
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine($"땡! 답은 {number}!");
                                    Gold = Gold * 0;
                                    Thread.Sleep(1000);
                                    goto Menu;
                                }
                            }
                        }
                        else
                        {
                            goto GameMenu;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("해당하는 메뉴가 없습니다.");
                    Thread.Sleep(1000);
                    goto Menu;
                }
            }
        }
    }
}

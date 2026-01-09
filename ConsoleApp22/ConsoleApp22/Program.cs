using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    internal class Program
    {
        [DllImport("msvcrt.dll")]
        static extern int _getch();  //c언어 함수 가져옴
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);

            string[] player = new string[]
            {
                "->",
                ">>>",
                "->"
            };
            string bullet = "->";
            List<int[]> bullets = new List<int[]>();

            int playerX = 0;
            int playerY = 12;

            Console.CursorVisible = false;

            int dwTime = Environment.TickCount;

            while (true)
            {
                if (dwTime + 50 < Environment.TickCount)
                {
                    dwTime = Environment.TickCount;

                    Console.Clear();

                    // 키 영역
                    int pressKey;

                    if (Console.KeyAvailable) //키가 눌렸는지 체크
                    {
                        pressKey = _getch();  //아스키값 왼쪽 오른쪽
                        if (pressKey == 224)
                            pressKey = _getch();

                        switch (pressKey)
                        {

                            case 72:  //위쪽방향 아스키코드                    
                                playerY--;
                                if (playerY < 1)
                                    playerY = 1;
                                break;
                            case 75:
                                //왼쪽 화살표키
                                playerX--;
                                if (playerX < 0)
                                    playerX = 0;
                                break;
                            case 77:
                                //오른쪽
                                playerX++;
                                if (playerX > 75)
                                    playerX = 75;
                                break;
                            case 80: //아래
                                playerY++;
                                if (playerY > 21)
                                    playerY = 21;
                                break;
                            case 32: //미사일
                                int[] bulletPos = new int[2];
                                bulletPos[0] = playerX + 1;
                                bulletPos[1] = playerY + 1;
                                bullets.Add(bulletPos);
                                break;

                        }


                    }

                    for (int i = 0; i < player.Length; i++)
                    {
                        //콘솔좌표 설정 플레이어X 플레이어Y
                        Console.SetCursorPosition(playerX, playerY + i);
                        //문자열배열 출력
                        Console.WriteLine(player[i]);
                    }

                    for (int j = 0; j < bullets.Count; j++)
                    {
                        Console.SetCursorPosition(bullets[j][0], bullets[j][1]);
                        Console.Write(" ");

                        int nextPosX = bullets[j][0] + 1;
                        int nextPosY = bullets[j][1];

                        if (nextPosX < Console.WindowWidth - 1)
                        {
                            Console.SetCursorPosition(nextPosX, nextPosY);
                            Console.Write(bullet);
                            bullets[j][0] = nextPosX;
                            bullets[j][1] = nextPosY;
                        }

                        else
                        {
                            bullets.Remove(bullets[j]);
                        }

                    }
                }
            }
        }
    }
}

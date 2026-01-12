using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    internal class Program
    {
        static void SayHello()
        {
            Console.WriteLine("안녕하세요, 용사님");
            Console.WriteLine("모험을 시작합니다.");
        }

        static void ShowGameStart()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("╔═══════════════════════════════════╗");
            Console.WriteLine("║        ⚔ RPG 게임 시작 ⚔       ║");
            Console.WriteLine("╚═══════════════════════════════════╝");
        }
        static void PrintSeparator()
        {
            Console.WriteLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");
        }
        static void Main(string[] args)
        {
            ShowGameStart();
            Console.WriteLine();

            SayHello();
            PrintSeparator();

            Console.WriteLine("게임 메뉴를 불러옵니다.....");

            PrintSeparator();

            Console.WriteLine("게임 종료");

            PrintSeparator();
        }
    }
}

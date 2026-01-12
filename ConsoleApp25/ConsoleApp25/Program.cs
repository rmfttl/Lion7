using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp25
{
    internal class Program
    {
        //반환값이 있는함수 3단계

        //정수반환
        static int GetNumber() //정수반환
        {
            return 42;
        }

        static string ConnectMessage(string name)
        {
            return name + "님 접속하셨습니다.";
        }
        static void Attack(string skillName, string target, int damage)
        {
            Console.WriteLine($"✨ 스킬 발동: {skillName}");
            Console.WriteLine($"⚔️ {target}에게 {damage} 데미지!");
        }
        static void Main(string[] args)
        {
            //string cm = ConnectMessage("닉넴"); //cm에 = 뒤를 적용시킨 =뒤에 함수를
            //Console.WriteLine(cm); //출력한다.
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            Attack("파이어볼", "고블린", 30);
            Console.WriteLine();
            Attack("아이스스톰", "오크", 70);

        }
    }
}
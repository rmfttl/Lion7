using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("이름을 입력하세요 : ");
            //string userName = Console.ReadLine();

            //Console.WriteLine($"안녕하세요, {userName}님!");

            //Console.WriteLine("나이를 입력하세요 : ");
            //string input = Console.ReadLine();
            //int age = int.Parse(input);

            //Console.WriteLine($"내년에는 {age + 1}살이 되시겠군요!");

            //Console.WriteLine("2진수를 입력하세요 :");
            //string binaryInput = Console.ReadLine();
            //int decimalValue = Convert.ToInt32(binaryInput, 2);

            //string binaryOutput = Convert.ToString(decimalValue, 2);

            //Console.WriteLine($"입력한 이진수 : {binaryInput}");
            //Console.WriteLine($"십진수로 변환 : {decimalValue}");
            //Console.WriteLine($"다시 이진수로 변환 : {binaryOutput}");

            //Console.WriteLine("=== 캐릭터 생성 ===");

            //Console.WriteLine("캐릭터 이름을 입력하세요 : ");
            //string userName = Console.ReadLine();

            //Console.WriteLine($"환영합니다, {userName}님!");

            //Console.WriteLine("시작 레벨을 입력하세요 : ");
            //string input = Console.ReadLine();
            //int level = int.Parse(input);

            //Console.WriteLine($"홍길동님의 시작 레벨은 {level}입니다

            //var name = "Alice";
            //var age = 25;
            //var isStudent = true;
            //Console.WriteLine($"이름 : {name}, 나이 : {age}, 학생 여부 : {isStudent}");

            //int defaultInt = default;
            //string defaultString = default;
            //bool defaultBool = default;

            //Console.WriteLine($"정수 기본값 : {defaultInt}");
            //Console.WriteLine($"문자열 기본값 : {defaultString}");
            //Console.WriteLine($"논리값 기본값 : {defaultBool}");

            //int smallNumber = 100;
            //long bigNumber = smallNumber;
            //double doubleNumber = smallNumber;

            //Console.WriteLine("=== 임시적 변환 ===");
            //Console.WriteLine($"int : {smallNumber}");
            //Console.WriteLine($"long : {bigNumber}");
            //Console.WriteLine($"double : {doubleNumber}");
            //Console.WriteLine($"int : {smallNumber.GetType()}");
            //Console.WriteLine($"long : {bigNumber.GetType()}");
            //Console.WriteLine($"double : {doubleNumber.GetType()}");

            ////int형식으로 바꾸는거
            //double pi = 3.14159;
            //int intPi = (int)pi;

            //Console.WriteLine("\n=== 명시적 변환 ===");
            //Console.WriteLine($"double : {pi}");
            //Console.WriteLine($"int로 변환 : {intPi}");

            //string scoreText = "95";
            //int score = int.Parse(scoreText);

            //string priceText = "19.99";
            //double price = double.Parse(priceText);

            //Console.WriteLine("\n\n=== 문자열 변환 ===");
            //Console.WriteLine($"정수(문자열) : {scoreText} -> 숫자 : {score}");
            //Console.WriteLine($"가격(문자열) : {priceText} -> 숫자 : {price}");

            //int playerLevel = 50;
            //string levelText = playerLevel.ToString();

            //Console.WriteLine("\n=== 숫자를 문자열로 ===");
            //Console.WriteLine($"레벨(숫자) : {playerLevel} -> 문자열 : {levelText}");

            // 1. 명시적 변환 시 데이터 손실
            double value = 9.8;
            int result = (int)value;  // 9.8 → 9 (소수점 버려짐!)

            // 2. 범위 초과
            int bigValue = 300;
            byte smallValue = (byte)bigValue;  // 오버플로우 발생!

            // 3. 잘못된 문자열 변환
            string text = "abc";
            // int num = int.Parse(text);  // ❌ 런타임 오류!

            // 안전한 변환: TryParse 사용
            if (int.TryParse(text, out int num))
            {
                Console.WriteLine($"변환 성공: {num}");
            }
            else
            {
                Console.WriteLine("변환 실패!");
            }
        }
    }
}

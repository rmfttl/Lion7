using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] scores = new int[5];

            //int[] number = new int[] { 10, 20, 30, 40, 50 };
            //int[] values = { 1, 2, 3, 4, 5 };

            //scores[0] = 1;
            //scores[1] = 2;
            //scores[2] = 3;
            //scores[3] = 4;
            //scores[4] = 5;

            //for(int i = 0; i < scores.Length; i++)
            //{
            //    Console.WriteLine(scores[i]);
            //}

            ////인벤토리
            //string[] inventory = new string[5];

            //inventory[0] = "회복 포션";
            //inventory[1] = "마나 포션";
            //inventory[2] = "강철 검";
            //inventory[3] = "가죽 갑옷";
            //inventory[4] = "마법 반지";

            //Console.WriteLine("=== 인벤토리 ===");

            //for(int i = 0; i < inventory.Length; i++)
            //{
            //    Console.WriteLine($"[{i+1}] {inventory[i]}");
            //}

            ////인벤토리
            //string[] inventory = new string[5];

            //Console.WriteLine("=== 인벤토리 ===");

            //for (int i = 0; i < inventory.Length; i++)
            //{
            //    Console.Write($"인벤토리 {i+1}번째 칸에 넣을 아이템을 입력하세요 : ");
            //    inventory[i] = Console.ReadLine();
            //    Console.WriteLine($"[{i + 1}] {inventory[i]}");
            //}

            ////인벤토리 시스템 (최대 5개)
            //string[] inventory = new string[5];

            ////아이템 추가
            //inventory[0] = "회복 포션";
            //inventory[1] = "마나 포션";
            //inventory[2] = "강철 검";
            //inventory[3] = "가죽 갑옷";
            //inventory[4] = "마법 반지";


            ////인벤토리 출력
            //Console.WriteLine("=== 인벤토리 ====");

            //for (int i = 0; i < inventory.Length; i++)
            //{
            //    Console.WriteLine($"[{i + 1}] {inventory[i]}");
            //}


            ////특정 아이템 사용
            //Console.WriteLine($"{inventory[0]}를 사용했습니다!");
            //inventory[0] = "(비어있음)";

            //for (int i = 0; i < inventory.Length; i++)
            //{
            //    Console.WriteLine($"[{i + 1}] {inventory[i]}");
            //}

            //Console.WriteLine("=== 캐릭터 스탯===");
            //int[] stats = { 100, 50, 80, 60, 45 };
            //string[] statNames = { "HP", "MP", "공격력", "방어력", "민첩" };

            //for (int i = 0; i < stats.Length; i++)
            //{
            //    Console.WriteLine($"{statNames[i]}: {stats[i]}");
            //}

            //Console.OutputEncoding = System.Text.Encoding.UTF8;
            //Console.InputEncoding = System.Text.Encoding.UTF8;

            //Console.WriteLine("=== 일일 퀘스트 진행도 ===");
            //int[] stats = { 5, 3, 8, 2, 7 };
            //string[] statNames = { "고블린", "오크", "슬라임", "드래곤", "좀비" };

            //for (int i = 0; i < stats.Length; i++)
            //{
            //    Console.Write($"{statNames[i]} : {stats[i]}/5 ");
            //    if (stats[i] >= 5)
            //    {
            //        Console.WriteLine("✅ 완료");
            //    }
            //    else
            //    {
            //        Console.WriteLine("⏳ 진행중");
            //    }
            //}



            //int[] scores = { 85, 92, 78, 95, 88 };

            //Console.WriteLine("총 점수 개수 : " + scores.Length);
            //Console.WriteLine("개별 점수");
            //for(int i = 0; i < scores.Length; i++)
            //{
            //    Console.WriteLine($"플레이어 {i+1} : {scores[i]}점");
            //}

            //int sum = 0;

            //for (int i = 0; i < scores.Length; i++)
            //{
            //    sum += scores[i];
            //}

            //Console.WriteLine($"총점 : {sum}점");
            //Console.WriteLine($"평균 : {(float)sum / (float)scores.Length}점");

            //int max = 0;
            //for(int i = 0; i < scores.Length; i++)
            //{
            //    if (scores[i] > max)
            //    {
            //        max = scores[i];
            //    }
            //}
            //Console.WriteLine($"최고점 : {max}점");

            //int low = 100;
            //for (int i = 0; i < scores.Length; i++)
            //{
            //    if (scores[i] < low)
            //    {
            //        low = scores[i];
            //    }
            //}
            //Console.WriteLine($"최저점 : {low}점");

            ////Array 클래스 메서드 활용
            //Console.WriteLine("=== Array 메서드 ===");

            ////정렬
            //int[] sortedScores = (int[])scores.Clone();  //복사본 생성
            //Array.Sort(sortedScores);
            //Console.WriteLine("정렬 후: ");

            ////for (int i = 0; i < sortedScores.Length; i++)
            ////{
            ////    Console.WriteLine(sortedScores[i]);
            ////}

            ////반복문 foreach
            //foreach (int score in sortedScores)
            //{
            //    Console.WriteLine(score);
            //}




            ////85, 92, 78, 95, 88

            ////역순정렬
            //Array.Reverse(sortedScores);
            //Console.WriteLine("역순: ");

            ////for (int i = 0; i < sortedScores.Length; i++)
            ////{
            ////    Console.WriteLine(sortedScores[i]);
            ////}

            ////foreach (int score in sortedScores)
            ////{
            ////    Console.WriteLine(score);
            ////}

            ////검색
            //int searchScore = 92;
            //int index = Array.IndexOf(scores, searchScore);
            //Console.WriteLine($"{searchScore}점의 위치: 인덱스 {index}");
            //Console.WriteLine("찾은값 : " + scores[index]);


            ////방법 1: 크기만 지정
            //int[,] grid = new int[3, 4];  // 3행 4열

            //// 방법 2: 선언과 동시에 초기화
            //int[,] numbers = new int[2, 3]
            //{
            //    { 1, 2, 3 },
            //    { 4, 5, 6 }
            //};

            //// 방법 3: new 생략 (간단한 초기화)
            //int[,] scores =
            //{
            //    { 90, 85, 88 },
            //    { 92, 78, 95 },
            //    { 87, 91, 84 }
            //};

            //int[,] array = new int[3, 4];

            //// 전체 요소 개수
            //int totalElements = array.Length;  // 12 (3 x 4)

            //// 특정 차원의 길이
            //int rows = array.GetLength(0);     // 3 (행 개수)
            //int cols = array.GetLength(1);     // 4 (열 개수)

            //// Rank: 배열의 차원 수
            //int dimensions = array.Rank;       // 2

            //int[,] seat = new int[3, 3];
            //char[] seatname = { 'A', 'B', 'C' };

            //for (int i = 0; i < seat.GetLength(0); i++)
            //{
            //    for(int j = 0; j < seat.GetLength(1); j++)
            //    {
            //        Console.Write($"[{seatname[i]}{j + 1}]");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine("첫번째 좌석 : " + seat[0,0]);
            //Console.WriteLine("두번째 좌석 : " + seat[1,1]);
            //Console.WriteLine("세번째 좌석 : " + seat[2,2]);

            ////2D 게임맵
            //int[,] map = new int[5, 5]
            //{
            //    { 0,0,1,0,0},
            //    { 0,2,1,0,3},
            //    { 0,0,1,0,0},
            //    { 1,1,1,0,0},
            //    { 0,0,0,0,9},
            //};

            //Console.WriteLine("==던전맵==");
            //Console.WriteLine("0: 통로 1: 벽 2: 몬스터 3: 보물 9: 출구\n");
            //Console.OutputEncoding = Encoding.UTF8;

            ////맵 출력
            //for (int y = 0; y < map.GetLength(0); y++)
            //{
            //    for (int x = 0; x < map.GetLength(1); x++)
            //    {
            //        switch (map[y, x])
            //        {
            //            case 0:
            //                Console.Write("⬜ ");
            //                break;
            //            case 1:
            //                Console.Write("⬛ ");
            //                break;
            //            case 2:
            //                Console.Write("👹 ");
            //                break;
            //            case 3:
            //                Console.Write("💎 ");
            //                break;
            //            case 9:
            //                Console.Write("🚪 ");
            //                break;
            //        }

            //    }
            //    Console.WriteLine();
            //}

            //int[,] scores = new int[3, 4]
            //{
            //    { 85, 90, 88, 92 },
            //    { 78, 85, 90, 87 },
            //    { 92, 88, 95, 90 }
            //};
            //string[] students = { "김철수", "이영희", "박민수" };
            //string[] subjects = { "국어", "영어", "수학", "과학" };

            //Console.WriteLine("=== 성적표 ===\n");
            //Console.Write("이름\t");
            //foreach (string subject in subjects) //과목s에 넣은 변수를 과목에 차례대로 하나씩 넣어서 출력
            //{
            //    Console.Write($"{subject}\t");
            //}
            //Console.WriteLine("평균");
            //Console.WriteLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");

            //for (int i = 0; i < scores.GetLength(0); i++)
            //{
            //    Console.Write($"{students[i]}\t");
            //    int sum = 0;
            //    for (int j = 0; j < scores.GetLength(1); j++)
            //    {
            //        Console.Write($"{scores[i, j]}\t");
            //        sum += scores[i, j];
            //    }

            //    double average = (double)sum / scores.GetLength(1);
            //    Console.WriteLine($"{average:F1}");
            //}

            //Console.WriteLine("\n=== 과목별 평균 ===");
            //for (int subject = 0; subject < scores.GetLength(1); subject++)
            //{
            //    int sum = 0;
            //    for (int student = 0; student < scores.GetLength(0); student++)
            //    {
            //        sum += scores[student, subject];
            //    }
            //    double avg = (double)sum / scores.GetLength(0);
            //    Console.WriteLine($"{subjects[subject]}: {avg:F1}점");
            //}

            ////기반 배열
            //string[][] raid = new string[3][];

            //raid[0] = new string[] { "전사", "힐러", "마법사", "궁수" };
            //raid[1] = new string[] { "도적", "전사", "힐러" };
            //raid[2] = new string[] { "마법사", "궁수", "힐러", "전사", "탱커" };

            //Console.WriteLine("=== 레이드 파티 구성 ===");
            //for(int i =0; i < raid.Length; i++)
            //{
            //    Console.WriteLine($"파티 {i + 1} ({raid[i].Length}명):");
            //    for (int j = 0; j < raid[i].Length; j++)
            //    {
            //        Console.WriteLine($" - {raid[i][j]}");
            //    }
            //}

            //// 선언 방법
            //List<int> numbers = new List<int>();           // 빈 리스트
            //List<string> names = new List<string>();       // 문자열 리스트
            //List<float> prices = new List<float>();        // 실수 리스트

            //// 초기값과 함께 선언
            //List<int> scores = new List<int> { 85, 90, 78, 95 };
            //List<string> items = new List<string> { "검", "방패", "포션" };

            //// C# 3.0 이후 간단한 초기화
            //var players = new List<string> { "철수", "영희", "민수" };

            //List<string> items = new List<string>();

            //// Add: 끝에 추가
            //items.Add("회복 포션");
            //items.Add("마나 포션");

            ////list생성
            //List<string> inventory = new List<string>();
            //Console.WriteLine("== 도적 인벤토리 시스템 ==");

            ////아이템추가
            //inventory.Add("회복 포션");
            //inventory.Add("마나 포션");
            //inventory.Add("강철 검");
            //Console.WriteLine("아이템 3개 추가!\n");

            ////현재 인벤
            //Console.WriteLine($"= 인벤토리 ({inventory.Count}개) =");

            //for (int i = 0; i < inventory.Count; i++)
            //{
            //    Console.WriteLine($"[{i+1}] {inventory[i]}");
            //}

            //inventory[0] = "초록 포션";
            //inventory.Add("분홍 포션");

            //Console.WriteLine();
            //Console.WriteLine($"= 인벤토리 ({inventory.Count}개) =");

            //for (int i = 0; i < inventory.Count; i++)
            //{
            //    Console.WriteLine($"[{i+1}] {inventory[i]}");
            //}

            ////아이템 삭제
            //inventory.Remove("초록 포션");

            //Console.WriteLine();
            //Console.WriteLine($"= 인벤토리 ({inventory.Count}개) =");

            //for (int i = 0; i < inventory.Count; i++)
            //{
            //    Console.WriteLine($"[{i + 1}] {inventory[i]}");
            //}

            ////인덱스로 삭제
            //inventory.RemoveAt(1);

            //Console.WriteLine();
            //Console.WriteLine($"= 인벤토리 ({inventory.Count}개) =");

            //for (int i = 0; i < inventory.Count; i++)
            //{
            //    Console.WriteLine($"[{i + 1}] {inventory[i]}");
            //}

            //Dictionary<string, int> stats = new Dictionary<string, int>();

            //stats.Add("HP", 150);
            //stats.Add("MP", 80);
            //stats.Add("공격력", 75);
            //stats.Add("방어력", 50);
            //stats.Add("민첩", 60);

            //Console.WriteLine("=== 캐릭터 스탯 ===");

            //foreach (KeyValuePair<string, int> stat in stats)
            //{
            //    Console.WriteLine($"{stat.Key}: {stat.Value}");
            //}

            ////키 존재 확인
            //string searchStat = "방어력";

            //if (stats.ContainsKey(searchStat))
            //{
            //    Console.WriteLine(stats[searchStat]);
            //}
            //else
            //{
            //    Console.WriteLine("해당스탯이 없습니다.");
            //}

            //Dictionary<string, int> itemPrice = new Dictionary<string, int>();

            //itemPrice.Add("회복 포션", 50);
            //itemPrice.Add("마나 포션", 40);
            //itemPrice.Add("강철 검", 500);
            //itemPrice.Add("가죽 갑옷", 300);
            //itemPrice.Add("마법 반지", 1000);

            //Console.WriteLine("=== 상점 아이템 ===");

            //foreach (KeyValuePair<string, int> item in itemPrice)
            //{
            //    Console.WriteLine($"{item.Key}: {item.Value}골드");
            //}
            //string searchItem = "강철 검";

            //Console.OutputEncoding = System.Text.Encoding.UTF8;
            //Console.InputEncoding = System.Text.Encoding.UTF8;

            //if (itemPrice.ContainsKey(searchItem))
            //{
            //    Console.WriteLine($"\n✅ '{searchItem}' 구매 성공!");
            //    Console.WriteLine("남은 골드 : 100");
            //}
            //else
            //{
            //    Console.WriteLine("해당 아이템은 없습니다.");
            //} // 밑에는 강사님이 하신거

            Console.WriteLine("\n=== 상점 아이템 ===");
            Dictionary<string, int> shop = new Dictionary<string, int>
        {
            { "회복 포션", 50 },
            { "마나 포션", 40 },
            { "강철 검", 500 },
            { "가죽 갑옷", 300 },
            { "마법 반지", 1000 }
        };

            foreach (var item in shop)
            {
                Console.WriteLine($"{item.Key}: {item.Value}골드");
            }

            // 구매 시스템
            string buyItem = "강철 검";
            int playerGold = 600;

            if (shop.ContainsKey(buyItem))
            {
                int price = shop[buyItem];
                if (playerGold >= price)
                {
                    playerGold -= price;
                    Console.WriteLine($"\n✅ '{buyItem}' 구매 성공!");
                    Console.WriteLine($"남은 골드: {playerGold}");
                }
                else
                {
                    Console.WriteLine($"\n❌ 골드가 부족합니다!");
                }
            }
        }
    }
}

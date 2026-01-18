using System;
using System.Collections.Generic;
using System.Threading;
using System.Text;

class Program
{
    const int WIDTH = 80;
    const int HEIGHT = 25;
    const int UI_HEIGHT = 2;

    static int playerX = 40;
    static int playerY = 15;

    static int money = 0;
    static int material = 0;
    static int ore = 0;

    static List<(int x, int y)> ores = new List<(int x, int y)>();
    static DateTime lastOreTime = DateTime.Now;

    // false = □, true = ■
    static Dictionary<(int x, int y), bool> heartBlocks =
        new Dictionary<(int x, int y), bool>();

    static bool gameEnded = false;

    static Random rand = new Random();

    // 상점 위치
    static int shopX = WIDTH - 3;
    static int shopY = UI_HEIGHT;

    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.CursorVisible = false;
        Console.SetWindowSize(WIDTH, HEIGHT);
        Console.SetBufferSize(WIDTH, HEIGHT);

        InitHeart();
        StartScreen();
        GameLoop();
    }

    // ================= 시작 =================

    static void StartScreen()
    {
        Console.Clear();
        Console.SetCursorPosition(30, 12);
        Console.Write("| 엔터를 눌러 시작 |");
        while (Console.ReadKey(true).Key != ConsoleKey.Enter) { }
    }

    // ================= 메인 루프 =================

    static void GameLoop()
    {
        Console.Clear();
        DrawAll();

        while (!gameEnded)
        {
            GenerateOre();
            DrawUI();
            DrawShop();

            if (Console.KeyAvailable)
            {
                ConsoleKey key = Console.ReadKey(true).Key;

                MovePlayer(key);
                CheckOreCollision();
                CheckHeartCollision();
                CheckShopEnter();      // ✅ 상점 진입 검사
                CheckEndingCondition();
            }

            Thread.Sleep(50);
        }

        ShowEnding();
    }

    // ================= UI =================

    static void DrawUI()
    {
        Console.SetCursorPosition(0, 0);
        Console.Write(
            string.Format("돈:{0}  자재:{1}  광석:{2}                ",
            money, material, ore));

        Console.SetCursorPosition(0, 1);
        Console.Write("□에 닿으면 자재를 소모해 ■로 바꿀 수 있습니다");
    }

    // ================= 상점 =================

    static void DrawShop()
    {
        Console.SetCursorPosition(shopX, shopY);
        Console.Write("⌂");
    }

    static void CheckShopEnter()
    {
        if (playerX == shopX && playerY == shopY)
        {
            SellOre();
            ShopMenu();
            Console.Clear();
            DrawAll();
        }
    }

    static void SellOre()
    {
        if (ore > 0)
        {
            money += ore * 1000;
            ore = 0;
        }
    }

    static void ShopMenu()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("⌂ 상점");
            Console.WriteLine("---------------");
            Console.WriteLine("돈: " + money);
            Console.WriteLine();
            Console.WriteLine("1. 자재 구매 (개당 500원)");
            Console.WriteLine("2. 도박");
            Console.WriteLine("X. 나가기");

            ConsoleKey key = Console.ReadKey(true).Key;

            if (key == ConsoleKey.D1)
                BuyMaterial();
            else if (key == ConsoleKey.D2)
                Gamble();
            else if (key == ConsoleKey.X)
                break;
        }
    }

    static void BuyMaterial()
    {
        Console.Clear();
        Console.Write("구매할 자재 수량: ");

        int count;
        if (!int.TryParse(Console.ReadLine(), out count))
            return;

        int cost = count * 500;

        if (money < cost)
        {
            Console.WriteLine("돈이 부족합니다!");
            Console.ReadKey();
            return;
        }

        money -= cost;
        material += count;
    }

    static void Gamble()
    {
        Console.Clear();
        int roll = rand.Next(100);

        if (roll < 40)
            Console.WriteLine("아무 일도 일어나지 않았다!");
        else if (roll < 60)
        {
            money /= 2;
            Console.WriteLine("돈이 절반이 되었다!");
        }
        else if (roll < 80)
        {
            money *= 2;
            Console.WriteLine("돈이 2배가 되었다!");
        }
        else if (roll < 90)
        {
            money = 0;
            Console.WriteLine("모든 돈을 잃었다!");
        }
        else
        {
            money *= 5;
            Console.WriteLine("대박! 돈이 5배!");
        }

        Console.WriteLine("엔터를 누르세요");
        while (Console.ReadKey(true).Key != ConsoleKey.Enter) { }
    }

    // ================= 하트 =================

    static void InitHeart()
    {
        int cx = 40;
        int cy = 12;

        (int x, int y)[] shape = new (int, int)[]
        {
            (-2, -1), (-1, -1), (1, -1), (2, -1),
            (-3, 0), (-2, 0), (-1, 0), (0, 0), (1, 0), (2, 0), (3, 0),
            (-2, 1), (-1, 1), (0, 1), (1, 1), (2, 1),
            (-1, 2), (0, 2), (1, 2)
        };

        foreach (var p in shape)
            heartBlocks.Add((cx + p.x, cy + p.y), false);
    }

    static void DrawHeart()
    {
        foreach (var h in heartBlocks)
        {
            Console.SetCursorPosition(h.Key.x, h.Key.y);
            Console.Write(h.Value ? "■" : "□");
        }
    }

    static void CheckHeartCollision()
    {
        var pos = (playerX, playerY);

        if (heartBlocks.ContainsKey(pos) &&
            !heartBlocks[pos] &&
            material > 0)
        {
            heartBlocks[pos] = true;
            material--;
        }
    }

    static void CheckEndingCondition()
    {
        foreach (bool filled in heartBlocks.Values)
            if (!filled) return;

        gameEnded = true;
    }

    // ================= 플레이어 =================

    static void MovePlayer(ConsoleKey key)
    {
        int nx = playerX;
        int ny = playerY;

        if (key == ConsoleKey.LeftArrow) nx--;
        if (key == ConsoleKey.RightArrow) nx++;
        if (key == ConsoleKey.UpArrow) ny--;
        if (key == ConsoleKey.DownArrow) ny++;

        if (nx < 0 || nx >= WIDTH) return;
        if (ny < UI_HEIGHT || ny >= HEIGHT) return;

        RestoreTile(playerX, playerY);

        playerX = nx;
        playerY = ny;

        Console.SetCursorPosition(playerX, playerY);
        Console.Write("●");
    }

    static void RestoreTile(int x, int y)
    {
        if (heartBlocks.ContainsKey((x, y)))
        {
            Console.SetCursorPosition(x, y);
            Console.Write(heartBlocks[(x, y)] ? "■" : "□");
        }
        else
        {
            Console.SetCursorPosition(x, y);
            Console.Write(" ");
        }
    }

    // ================= 광석 =================

    static void GenerateOre()
    {
        if ((DateTime.Now - lastOreTime).TotalSeconds >= 3 &&
            ores.Count < 5)
        {
            int x = rand.Next(0, WIDTH);
            int y = HEIGHT - 1;

            ores.Add((x, y));
            Console.SetCursorPosition(x, y);
            Console.Write("⌖");

            lastOreTime = DateTime.Now;
        }
    }

    static void CheckOreCollision()
    {
        for (int i = ores.Count - 1; i >= 0; i--)
        {
            if (ores[i].x == playerX && ores[i].y == playerY)
            {
                ores.RemoveAt(i);
                ore++;
            }
        }
    }

    // ================= 엔딩 =================

    static void ShowEnding()
    {
        Console.Clear();

        Console.SetCursorPosition(38, 12);
        Console.Write("| END |");

        Console.ReadKey();
    }

    // ================= 전체 그리기 =================

    static void DrawAll()
    {
        DrawUI();
        DrawHeart();
        DrawShop();
        Console.SetCursorPosition(playerX, playerY);
        Console.Write("●");
    }
}

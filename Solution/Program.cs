using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Инициализация позиции игрока
            int playerX = 0;
            int playerY = 0;
            // Основной игровой цикл
            bool isRunning = true;
            while (isRunning)
            {
                DrawGameField(playerX, playerY);

                ConsoleKeyInfo key = Console.ReadKey(true);
                switch (key.Key)
                {
                    case ConsoleKey.W:
                        playerY--;
                        break;
                    case ConsoleKey.S:
                        playerY++;
                        break;
                    case ConsoleKey.A:
                        playerX--;
                        break;
                    case ConsoleKey.D:
                        playerX++;
                        break;
                    case ConsoleKey.Escape:
                        isRunning = false;
                        break;
                }
            }
        }

        static void DrawGameField(int x, int y)
        {
            Console.Clear();
            Console.WriteLine($"Позиция: X={x}, Y={y}");
            Console.WriteLine("Игрок перемещается клавишами WASD");
            Console.WriteLine("-------------------------------");

            // Поле
            for (int i = -10; i <= 10; i++)
            {
                for (int j = -10; j <= 10; j++)
                {
                    if (j == x && i == y)
                        Console.Write("@ "); 
                    else
                        Console.Write("  "); 
                }
                Console.WriteLine();
            }
        
        }
    }
}
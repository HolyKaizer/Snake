using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(Console.LargestWindowWidth , Console.LargestWindowHeight);
            Console.OutputEncoding = Encoding.UTF8;

            Walls walls = new Walls(80, 25);
            walls.Drow();

            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.Right);
            snake.Drow();

            FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();

            while (true)
            {
                if (walls.IsHit(snake) || snake.IsHitTail())
                {
                    break;
                }

                if(snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }

                Thread.Sleep(100);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
            }

            Console.SetCursorPosition(40, 25);
            Console.WriteLine("You Lose!!");
        }

    }
}
    
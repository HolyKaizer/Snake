using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    enum Direction
    {
        Left,
        Right,
        Up,
        Down
    }
    class Snake : Figure
    {
        public Direction direction;
        public Snake(Point tail, int length, Direction direction)
        {
            pList = new List<Point>();
            this.direction = direction;
            for(int i = 0; i < length; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                pList.Add(p);
            }
        }

        internal void Move()
        {
            Point tail = pList.First();
            pList.Remove(tail);
            Point head = GetNextPoint();
            pList.Add(head);

            tail.Clear();
            head.Draw();
        }

        public Point GetNextPoint()
        {
            Point head = pList.Last();
            Point nextPoint = new Point(head);

            nextPoint.Move(1, direction);
            return nextPoint;
        }

        public void HandleKeys()
        {
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    switch (key.Key)
                    {
                        case ConsoleKey.LeftArrow:
                            direction = Direction.Left;
                            break;
                        case ConsoleKey.DownArrow:
                            direction = Direction.Down;
                            break;
                        case ConsoleKey.UpArrow:
                            direction = Direction.Up;
                            break;
                        case ConsoleKey.RightArrow:
                            direction = Direction.Right;
                            break;
                        default:
                            continue;
                    }
                }
                Thread.Sleep(100);
                Move();
            }
        }
    }
}

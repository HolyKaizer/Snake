using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
        public int x;
        public int y;
        public char sym;

        public Point()
        {
            Console.WriteLine("Создается новая точка");
        }

        public Point(int x, int y, char sym)
        {
            this.x = x;
            this.y = y;
            this.sym = sym;
        }

        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }

        public void Move(int offset, Direction direction)
        {
            if (direction == Direction.Right)
                x += offset;
            else if (direction == Direction.Left)
                x -= offset;
            else if (direction == Direction.Up)
                y -= offset;
            else if (direction == Direction.Down)
                y += offset;
        }

        public override string ToString()
        {
            return x + ", " + y + ", " + sym;
        }


        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }

        public void Clear()
        {
            sym = ' ';
            Draw();
        }
    }
}

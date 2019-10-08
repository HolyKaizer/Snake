using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(Console.LargestWindowWidth , Console.LargestWindowHeight);
            Console.OutputEncoding = Encoding.UTF8;

            //Отрисовка рамочки
            HorizontalLine upLine = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine downLine = new HorizontalLine(0, 78, 24, '+');
            VerticalLine leftLine = new VerticalLine(0, 24, 0, '+');
            VerticalLine rightLine = new VerticalLine(0, 24, 78, '+');
            leftLine.Drow();
            rightLine.Drow();
            upLine.Drow();
            downLine.Drow();

            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.Right);
            snake.Drow();
            snake.Move();


            Console.ReadLine();
        }

    }
}

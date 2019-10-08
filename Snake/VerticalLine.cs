using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLine : Figure
    {
        public VerticalLine(int yLower, int yUpper, int x, char sym)
        {
            pList = new List<Point>();
            for (int y = yLower; y <= yUpper; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }

        }
    }
}

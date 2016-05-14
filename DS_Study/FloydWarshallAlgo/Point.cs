using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloydWarshallAlgo
{
    class Point
    {
        private int x;
        private int y;

        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public Point()
        {
            X = 0;
            Y = 0;
        }

        public Point(int ix, int iy)
        {
            X = ix;
            Y = iy;
        }

        public double Distance(Point sPoint)
        {
            return Math.Sqrt((X - sPoint.x) * (X - sPoint.x) + (Y - sPoint.y) * (Y - sPoint.y));
        }
    }
}

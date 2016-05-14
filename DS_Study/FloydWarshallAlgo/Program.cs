using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloydWarshallAlgo
{
    class Program
    {
        static void Main(string[] args)
        {

            Point[] allPoints = new Point[7] { new Point(0, 0),new Point(0, 0), new Point(1, 0), new Point(1, 1), new Point(2, 1), new Point(2, 2), new Point(1, 2) };
            Algo aRun = new Algo(allPoints);

        }
    }
}

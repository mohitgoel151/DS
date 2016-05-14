using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloydWarshallAlgo
{
    class Algo
    {
        private double[,] matrix;

        Point[] allPoints = null;
        private Point StartPoint;
        private Point EndPoint;

        public Algo(Point[] pts) 
        {
            if (pts.Length > 1)
            {
                allPoints = pts;
                //matrix = new double[allPoints.Length, allPoints.Length];
                matrix = new double[7,7]
                {
                    {0,8,int.MaxValue,int.MaxValue,10,int.MaxValue, int.MaxValue},
                    {8,0,3,2,5,int.MaxValue, int.MaxValue},
                    {int.MaxValue,3,0,2,int.MaxValue,int.MaxValue,2},
                    {int.MaxValue,2,2,0,5,10,5},
                    {10,5,int.MaxValue,5,0,13,int.MaxValue},
                    {int.MaxValue,int.MaxValue,int.MaxValue,10,13,0,9},
                    {int.MaxValue,int.MaxValue,2,5,int.MaxValue,9,0}
                };
                //InitializeMatrix();
                RunQuery();
                StartPoint = allPoints[0];
                EndPoint = allPoints[1];
            }
        }

        public void InitializeMatrix()
        {
            for (int i = 0; i < allPoints.Length; i++)
            {
                for (int j = 0; j < allPoints.Length; j++)
                {
                    if (i == j)
                    {
                        matrix[i, j] = 0;
                    }
                    else
                    {
                        double a = allPoints[i].Distance(allPoints[j]);
                        matrix[i, j] = int.MaxValue;
                    }
                }
            }

            RunQuery();
        }

        public void RunQuery()
        {
            for (int k = 0; k < allPoints.Length; k++)
            {
                for (int i = 0; i < allPoints.Length; i++)
                {
                    for (int j = 0; j < allPoints.Length; j++)
                    {
                        matrix[i, j] = Math.Min(matrix[i, j], matrix[i, k] + matrix[k, j]);
                    }
                }
            }

            Debug.WriteLine("path length = " + matrix[0, 5]);
        }

    }

}

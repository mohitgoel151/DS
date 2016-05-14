using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixChainMultiplication
{
    class Program
    {
        static void Main(string[] args)
        {


            int[,] mat1 = new int[10,15];
            int[,] mat2 = new int[10, 15];
            int[,] mat3 = new int[10, 15];
            int[,] mat4 = new int[10, 15];
            int[,] mat5 = new int[10, 15];
            //int[,] mat1 = new int[10, 15];
            //int[,] mat1 = new int[10, 15];

            Multiplication m = new Multiplication(mat1, mat2, mat3, mat4, mat5);
            m.GetLeastValue();

        }
    }
}

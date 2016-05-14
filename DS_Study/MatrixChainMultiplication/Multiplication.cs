using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixChainMultiplication
{
    class Multiplication
    {
        private int[,] mat1;
        private int[,] mat2;
        private int[,] mat3;
        private int[,] mat4;
        private int[,] mat5;

        int[,] array;


        public Multiplication()
        {

        }

        public Multiplication(int[,] mat1, int[,] mat2, int[,] mat3, int[,] mat4, int[,] mat5)
        {
            this.mat1 = mat1;
            this.mat2 = mat2;
            this.mat3 = mat3;
            this.mat4 = mat4;
            this.mat5 = mat5;

            array = new int[5, 5];


            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    array[i, j] = 0; 
                }
            }

            Perform();

        }

        private void Perform()
        {
            for (int i = 1; i < array.GetLength(0); i++)
            {
                int start = 1;

                for (int j = i + 1; j < array.GetLength(1); j++)
                {
                    array[start, j] = Math.Min(array[start, j - 1], array[start + 1, j]);
                        start++;

                }
            }


        }


        internal void GetLeastValue()
        {
            
        }
    }
}

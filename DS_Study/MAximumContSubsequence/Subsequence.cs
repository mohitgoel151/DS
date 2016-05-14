using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAximumContSubsequence
{
    class Subsequence
    {
        private int[] arr;

        int maxSum = int.MinValue;
        int intermediateSum = 0;
        int startIndex = 0;
        int tempstartIndex = 0;
        int endIndex = 0;

        public Subsequence(int[] arr)
        {
            this.arr = arr;
            PerformOperation();
        }

        private void PerformOperation()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (0 == intermediateSum)
                    tempstartIndex = i;

                int a = intermediateSum + arr[i];

                if(a > 0)
                {
                    intermediateSum = a;

                    if(a > maxSum)
                    {
                        startIndex = tempstartIndex;
                        maxSum = intermediateSum;
                        endIndex = i;
                    }
                    
                }
                else if(a < 0)
                {
                    intermediateSum = 0;
                }

            }

        }

        

    }
}

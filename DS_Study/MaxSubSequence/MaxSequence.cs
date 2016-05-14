using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSubSequence
{
    class MaxSequence
    {
        private string str1;
        private string str2;

        int[,] array;


        public MaxSequence(string str1, string str2)
        {
            this.str1 = str1;
            this.str2 = str2;

            array = new int[str1.Length + 1, str2.Length + 1];

            for (int i = 0; i < str1.Length + 1; i++)
            {
                for (int j = 0; j < str2.Length + 1; j++)
                {
                    array[i, j] = 0;
                }
            }

            FindSequence();
        }

        private void FindSequence()
        {
            for (int i = 0; i < str1.Length; i++)
            {
                for (int j = 0; j < str2.Length; j++)
                {
                    if(str1[i] == str2[j])
                    {
                        array[i + 1, j + 1] = array[i, j] + 1;
                    }
                    else
                    {
                        array[i + 1, j + 1] = Math.Max(array[i, j + 1], array[i + 1, j]);
                    }
                }
                
            }
        }

        internal string GetSequence()
        {
            String aStr = "";
            aStr = Backtrace(str1.Length, str2.Length, aStr);
            return aStr;
        }

        private String Backtrace(int i, int j, string aStr)
        {
            if (i == 0 || j == 0)
                return aStr;

            if (str1[i-1] == str2[j-1])
            {
                aStr = str1[i-1] + aStr;
                aStr = Backtrace(i - 1, j - 1, aStr);
            }
            else
            {
                if(array[i-1,j] > array[i, j-1])
                {
                    aStr = Backtrace(i - 1, j, aStr);
                }
                else
                {
                    aStr = Backtrace(i, j - 1, aStr);
                }
            }

            return aStr;

        }
    }
}

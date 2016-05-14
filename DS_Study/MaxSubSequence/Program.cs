using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSubSequence
{
    class Program
    {
        static void Main(string[] args)
        {


            String str1 = "dcbabdcabcb";
            String str2 = "abcabdabc";

            MaxSequence seq = new MaxSequence(str1, str2);
            String MaxString = seq.GetSequence();


        }
    }
}

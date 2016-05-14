using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissingNumberProblem
{
    class Program
    {
        static void Main(string[] args)
        {

            string astr = string.Empty;

            astr = "960961962964";
            astr = "12345789";
            astr = "99100101103104";
            astr = "1213121512161217";
            astr = "123457891011";
            astr = "99101";

            FindMissing a = new FindMissing(astr);
            int miss = a.missingNo;

        }
    }
}

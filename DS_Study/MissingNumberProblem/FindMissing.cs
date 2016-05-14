using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissingNumberProblem
{
    class FindMissing
    {
        private string astr;
        public int missingNo = -1;

        public FindMissing(string astr)
        {
            this.astr = astr;
            Perform();
        }

        private void Perform()
        {
            int i = 0;
            for (; i < astr.Length/2 ; i++)
            {
                int abc = Convert.ToInt16(astr.Substring(0, i+1));

                bool a = DoCheck(abc.ToString().Length, abc + 1, true);
                if (true == a)
                    break;
                
            }
        }

        private bool DoCheck(int startIndex, int expectedNo, bool isLastok)
        {
            int abc = Convert.ToInt16(astr.Substring(startIndex, expectedNo.ToString().Length));

            bool isCont = (expectedNo == abc) ? true : false;

            if (false == isCont)
                missingNo = expectedNo;

            if (isCont == false && isLastok == false)
            {
                return false;
            }
            else
            {
                if (startIndex + expectedNo.ToString().Length < astr.Length)
                {
                    if (true == DoCheck(startIndex + expectedNo.ToString().Length, abc+1, isCont))
                        return true;
                }
                else
                    return true;
            }

            return false;
        }

    }
}

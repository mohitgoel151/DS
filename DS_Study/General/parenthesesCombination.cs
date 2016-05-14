using System.Diagnostics;

namespace General
{
    class parenthesesCombination
    {
        public parenthesesCombination()
        {

            PrintParenthesis(3, 3, "");
        }


        public void PrintParenthesis(int leftAvailable, int rightAvailable, string str)
        {
            if (leftAvailable == 0 && rightAvailable == 0)
            {
                Debug.WriteLine(str);
                return;
            }
            if (leftAvailable > 0)
                PrintParenthesis(leftAvailable - 1, rightAvailable, str + "(");
            if (rightAvailable > leftAvailable)
                PrintParenthesis(leftAvailable, rightAvailable - 1, str + ")");
        }
    }
}

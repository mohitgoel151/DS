using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    class Diameter
    {
        public int CalcDiameter(Node node)
        {
            int Dia = 0;
            return FindDia(node, ref Dia);
        }

        private int FindDia(Node aNode, ref int iHeight)
        {
            if (aNode == null)
                return 0;

            int lh = 0, rh = 0, ld = 0, rd = 0;

            ld = FindDia(aNode.left, ref lh);
            rd = FindDia(aNode.right, ref rh);

            iHeight = 1 + Math.Max(lh, rh);

            return Math.Max(lh + rh + 1, Math.Max(ld, rd));

        }
    }
}

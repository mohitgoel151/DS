using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    public class Node
    {
        public Node left;
        public Node right;
        public Node parent;
        public int value;

        public Node(int ivalue)
        {
            left = null;
            right = null;
            parent = null;
            value = ivalue;
        }

        public Node()
        {

        }

    }
}

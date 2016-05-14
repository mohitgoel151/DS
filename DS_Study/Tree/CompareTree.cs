using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    public class CompareTree
    {

        public CompareTree()
        {

        }


        public bool IsSame(Node tree, Node secoundTree)
        {
            if (tree != null && secoundTree != null)
            {
                if (tree.value != secoundTree.value)
                {
                    return false;
                }
                else
                {
                    return IsSame(tree.left, secoundTree.left) && IsSame(tree.right, secoundTree.right);
                }
            }
            else if(tree == null && secoundTree == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

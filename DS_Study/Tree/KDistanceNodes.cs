using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    class KDistanceNodes
    {

        public KDistanceNodes()
        {

        }

        public void PrintNodes(Node Root, int requiredNode, int iDistance)
        {
            PrintNodesAtKDistance(Root, requiredNode, iDistance);
        }

        public int PrintNodesAtKDistance(Node root, int requiredNode, int iDistance)
        {
            if ((root == null) || (iDistance < 0))
                return -1;
               
            int lPath = -1, rPath = -1;

            if(root.value == requiredNode)
            {
                PrintChildNodes(root, iDistance);
                return iDistance - 1;
            }

            lPath = PrintNodesAtKDistance(root.left, requiredNode, iDistance);
            rPath = PrintNodesAtKDistance(root.right, requiredNode, iDistance);

            if (lPath > 0)
            {
                PrintChildNodes(root.right, lPath - 1);
                return lPath - 1;
            }
            else if(lPath == 0)
            {
                Debug.WriteLine(root.value);
            }

            if(rPath > 0)
            {
                PrintChildNodes(root.left, rPath - 1);
                return rPath - 1;
            }
            else if (rPath == 0)
            {
                Debug.WriteLine(root.value);
            }

            return -1;
        }

        public void PrintChildNodes(Node aNode, int iDistance)
        {
            if (aNode == null)
                return;

            if(iDistance == 0)
            {
                Debug.WriteLine(aNode.value);
            }

            PrintChildNodes(aNode.left, iDistance - 1);
            PrintChildNodes(aNode.right, iDistance - 1);
        }



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    public class Closestansestor
    {
        public Closestansestor()
        {

        }

        public Node GetClosestAnsestor(Node rootNode)
        {
            Node firstNode = Helper.FindNode(rootNode, 35);
            Node secoundNode = Helper.FindNode(rootNode, 36);

            int FirstNodeHeight = GetNodeHeight(rootNode, firstNode);
            int SecoundNodeHeight = GetNodeHeight(rootNode, secoundNode);

            Node largeNode = null;
            Node smallNode = null;

            if (FirstNodeHeight > SecoundNodeHeight)
            {
                largeNode = firstNode;
                smallNode = secoundNode;
            }
            else
            {
                largeNode = secoundNode;
                smallNode = firstNode;
            }

            for (int i = 0; i < Math.Abs(FirstNodeHeight-SecoundNodeHeight) ; i++)
            {
                largeNode = largeNode.parent;
            }

            while (largeNode != smallNode)
            {
                largeNode = largeNode.parent;
                smallNode = smallNode.parent;
            }

            return largeNode;
        }

        private int GetNodeHeight(Node rootNode, Node searchNode)
        {
            if (rootNode != null)
            {
                if (rootNode == searchNode)
                {
                    return 0;
                }
                else
                {
                    if (searchNode.value < rootNode.value)
                    {
                        return 1 + GetNodeHeight(rootNode.left, searchNode);
                    }
                    else
                    {
                        return 1 + GetNodeHeight(rootNode.right, searchNode); 
                    }
                }
            }
            else
            {
                return int.MaxValue;
            }
        }


    }
}

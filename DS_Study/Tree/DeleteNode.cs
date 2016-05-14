using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    public class DeleteNode
    {
        private Node root;

        public DeleteNode(Node objRoot)
        {
            root = objRoot;
            Node aNode = Helper.FindNode(root, 8);

            if (null == aNode)
                Debug.Assert(false, "Node is null in delete");
            else
                Delete(ref root, aNode);

            Helper.PrintInOrder(root);
        }

        private void Delete(ref Node root, Node aNode)
        {

            int childCount = Helper.ChildrenCount(aNode);
            bool? isRight = Helper.IsRight(aNode.parent, aNode);

            switch (childCount)
            {
                case 0:

                    if (isRight.HasValue == true)
                    {
                        if (isRight.Value == true)
                            aNode.parent.right = null;
                        else
                            aNode.parent.left = null;
                    }
                    else
                    {
                        aNode = null;
                        root = null;
                    }

                    break;

                case 1:
                    Node NodeToTag = null;

                    if (aNode.left != null)
                    {
                        NodeToTag = aNode.left;
                    }
                    else
                    {
                        NodeToTag = aNode.right;
                    }

                    if (isRight.HasValue == true)
                    {
                        if (isRight.Value == true)
                            aNode.parent.right = NodeToTag;
                        else
                            aNode.parent.left = NodeToTag;

                        NodeToTag.parent = aNode.parent;
                    }
                    else
                    {
                        Node temp = root;
                        root = NodeToTag;
                        NodeToTag.parent = null;
                    }

                    break;

                case 2:

                    Node successorNode = Helper.Successor(aNode);
                    if (null != successorNode)
                    {
                        aNode.value = successorNode.value;
                        Delete(ref root, successorNode);
                    }

                    break;

                default:
                    break;
            }
        }
    }
}

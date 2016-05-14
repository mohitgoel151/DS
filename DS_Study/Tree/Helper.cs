using System;
using System.Diagnostics;

namespace Tree
{
    public static class Helper
    {
        public static Node FindNode(Node node, int p)
        {
            if (node != null)
            {
                if (node.value == p)
                    return node;
                else
                {
                    if (node.value < p)
                    {
                        return FindNode(node.right, p);
                    }
                    else
                    {
                        return FindNode(node.left, p);
                    }
                }
            }
            else
            {
                return null;
            }
        }

        public static Node Successor(Node node)
        {
            if (node == null)
            {
                return null;
            }
            else
            {
                if (node.right != null)
                {
                    return MinOftree(node.right);
                }
                else
                {
                    while (node.parent != null && node.parent.right == node)
                    {
                        node = node.parent;
                    }
                    return node.parent;
                }
            }
        }

        public static Node MinOftree(Node node)
        {
            while (node != null && node.left != null)
            {
                node = node.left;
            }
            return node;
        }

        public static int ChildrenCount(Node p)
        {
            if (p == null || (p.left == null && p.right == null) )
            {
                return 0;
            }
            else if ((p.left == null && p.right != null) || (p.left != null && p.right == null))
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }

        public static bool? IsRight(Node parent, Node child)
        {
            if (parent == null || child == null)
            {
                return null;
            }
            else if (parent.right == child)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static int CalcHeight(Node node)
        {
            if (node != null)
            {
                return 1 + Math.Max(CalcHeight(node.left), CalcHeight(node.right));
            }
            return 0;
        }

        public static void PrintPreorder(Node p)
        {
            if (p == null)
                return;

            else
            {
                Debug.WriteLine("  " + p.value);
                PrintPreorder(p.left);
                PrintPreorder(p.right);
            }
        }

        public static void PrintInOrder(Node p)
        {
            if (p == null)
                return;

            else
            {
                PrintInOrder(p.left);
                Debug.WriteLine("  " + p.value);
                PrintInOrder(p.right);
            }
        }
    }
}

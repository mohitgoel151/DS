using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    class PrintZigZag
    {

        public PrintZigZag(Node RootNode)
        {
            if (RootNode == null)
                return;

            Stack<Node> s1 = new Stack<Node>();
            Stack<Node> s2 = new Stack<Node>();
            bool useS1 = true;
            s1.Push(RootNode);

            while (s1.Count > 0 || s2.Count > 0)
            {
                if (true == useS1)
                {
                    while (s1.Count > 0)
                    {
                        Node aNode = s1.Pop();
                        Console.WriteLine(aNode.value);

                        if (null != aNode.left)
                            s2.Push(aNode.left); 

                        if (null != aNode.right)
                            s2.Push(aNode.right);

                    }
                    useS1 = false;
                }
                else
                {
                    while (s2.Count > 0)
                    {
                        Node aNode = s2.Pop();
                        Console.WriteLine(aNode.value);

                        if (null != aNode.right)
                            s1.Push(aNode.right);

                        if (null != aNode.left)
                            s1.Push(aNode.left);

                    }
                    useS1 = true;
                }
            }
        }

    }
}

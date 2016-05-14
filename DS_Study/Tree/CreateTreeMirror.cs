using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    public class CreateTreeMirror
    {

        public CreateTreeMirror()
        {

        }

        public Node CreateMirror(Node rootNode)
        {
            if (rootNode != null)
            {
                Node newNode = new Node();
                newNode.value = rootNode.value;
                newNode.parent = rootNode.parent;
                newNode.left = CreateMirror(rootNode.right);
                newNode.right = CreateMirror(rootNode.left);
                return newNode;
            }
            return null;
        }
    }
}

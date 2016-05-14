using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class CreateList
    {
        Node header;

        public CreateList()
        {
            push(7);
            push(6);
            push(5);
            push(4);
            push(3);
            push(2);
            push(1);
        }

        private void push(int ival)
        {
            Node aNode = new Node(ival);

            Node temp = header;
            header = aNode;
            aNode.Next = temp;

        }

        internal Node GetList()
        {
            return header;
        }
    }
}

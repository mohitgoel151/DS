using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {

            CreateList aList = new CreateList();
            Node header = aList.GetList();

            ReverseKNodes reverse = new ReverseKNodes();
            reverse.ReverseNode(header, 4);
        }
    }
}

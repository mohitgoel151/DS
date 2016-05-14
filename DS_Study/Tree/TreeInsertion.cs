
namespace Tree
{
    class TreeInsertion
    {

        public void Insert(ref Node p, int pValue)
        {
            Node newNode = new Node(pValue);

            if (p == null)
            {
                p = newNode;
                return;
            }

            if (p.value > pValue)  // has to be on the left
            {
                if (p.left != null)
                {
                    Insert(ref p.left, pValue);
                }
                else
                {
                    p.left = newNode;
                    newNode.parent = p;
                }
            }
            else
            {
                if (p.right != null)
                {
                    Insert(ref p.right, pValue);
                }
                else
                {
                    p.right = newNode;
                    newNode.parent = p;
                }
            }
        }

    }
}

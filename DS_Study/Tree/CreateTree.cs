
namespace Tree
{
    class CreateTree
    {
        Node root;
        public Node Root
        {
            get { return root; }
            set { root = value; }
        }

        public CreateTree()
        {
            root = null;

            TreeInsertion insertNode = new TreeInsertion();
            insertNode.Insert(ref root, 15);
            insertNode.Insert(ref root, 8);
            insertNode.Insert(ref root, 7);
            insertNode.Insert(ref root, 10);
            insertNode.Insert(ref root, 14);
            insertNode.Insert(ref root, 12);
            insertNode.Insert(ref root, 45);
            insertNode.Insert(ref root, 30);
            insertNode.Insert(ref root, 35);
            insertNode.Insert(ref root, 36);
            insertNode.Insert(ref root, 11);
            insertNode.Insert(ref root, 13);
            insertNode.Insert(ref root, 37);
            insertNode.Insert(ref root, 9);
            insertNode.Insert(ref root, 38);
        }

    }
}

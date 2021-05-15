namespace BST
{
    public class Root
    {
        public Node root;

        public Root()
        {
            root = null;
        }

        public void Insert(int inKey, string inData)
        {
            if (root == null)
            {
                root = new Node(inKey, inData);
            }
            else
            {
                root.Insert(inKey, inData);
            }
        }

        public void Delete(int inKey)
        {
            Node parent = root;
            Node temp = root;
            while (inKey != temp.key)
            {
                if (inKey < temp.key)
                {
                    parent = temp;
                    temp = temp.leftNode;
                }
                if (inKey > temp.key)
                {
                    parent = temp;
                    temp = temp.rightNode;
                }
            }
            if (temp.key == root.key)
            {
                if (root.leftNode == null && root.rightNode == null)
                {
                    root = null;
                }
                else if (root.leftNode != null && root.rightNode != null)
                {

                }
                else if (root.leftNode == null && root.rightNode != null)
                {
                    root = root.rightNode;
                }
                else if (root.rightNode == null & root.leftNode != null)
                {
                    root = root.leftNode;
                }
            }
            if (temp.rightNode == null && temp.leftNode == null)
            {
                if (temp.key < parent.key)
                {
                    parent.leftNode = null;
                }
                if (temp.key > parent.key)
                {
                    parent.rightNode = null;
                }
            }
            else if (temp.rightNode != null && temp.leftNode != null)
            {
                parent = temp.rightNode;
                while (parent.leftNode != null)
                {
                    parent = parent.leftNode;
                }
                temp = parent;
                parent = parent.rightNode;
            }
            else if (temp.rightNode == null && temp.leftNode != null)
            {
                if (temp.key < parent.key)
                {
                    parent.leftNode = temp.leftNode;
                }
                if (temp.key > parent.key)
                {
                    parent.rightNode = temp.leftNode;
                }
            }
            else if (temp.leftNode == null && temp.rightNode != null)
            {
                if (temp.key < parent.key)
                {
                    parent.leftNode = temp.rightNode;
                }
                if (temp.key > parent.key)
                {
                    parent.rightNode = temp.rightNode;
                }
            }
        }

        public Node Search(int inKey)
        {
            try
            {
                Node temp = root;
                while (inKey != temp.key)
                {
                    if (inKey < temp.key)
                    {
                        temp = temp.leftNode;
                    }
                    if (inKey > temp.key)
                    {
                        temp = temp.rightNode;
                    }
                }
                return temp;
            }
            catch (System.Exception e)
            {
                return null;
            }
        }

        public void Update(int inKey, string inData)
        {
            Node temp = root;
            while (inKey != temp.key)
            {
                if (inKey < temp.key)
                {
                    temp = temp.leftNode;
                }
                if (inKey > temp.key)
                {
                    temp = temp.rightNode;
                }
            }
            temp.data = inData;
        }
    }
}

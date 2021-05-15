namespace BST
{
    public class Node
    {
        public int key;
        public string data;
        public Node leftNode;
        public Node rightNode;

        public Node(int inKey, string inData)
        {
            key = inKey;
            data = inData;
            leftNode = null;
            rightNode = null;
        }

        public void Insert(int inKey, string inData)
        {
            if (inKey < key)
            {
                if (leftNode == null)
                {
                    leftNode = new Node(inKey, inData);
                }
                else
                {
                    leftNode.Insert(inKey, inData);
                }
            }
            if (inKey > key)
            {
                if (rightNode == null)
                {
                    rightNode = new Node(inKey, inData);
                }
                else
                {
                    rightNode.Insert(inKey, inData);
                }
            }
            if (inKey == key)
            {
                System.Console.WriteLine("ERROR: Duplicate Value");
            }
        }
    }
}
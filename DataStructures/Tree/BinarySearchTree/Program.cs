// A binary search tree is a data structure that consists of a tree of nodes,
// where each node has at most two child nodes (left and right),
// and the value of each node is greater than or equal to the value of its left child node,
// and less than or equal to the value of its right child node.
// Binary search trees can be implemented using a custom Node class and a BinarySearchTree class
// that provides methods for adding, removing, and searching nodes in the tree.

namespace BinarySearchTreeExample
{
    class Node
    {
        public int value;
        public Node leftChild;
        public Node rightChild;

        public Node(int value)
        {
            this.value = value;
        }
    }

    class BinarySearchTree
    {
        private Node root;

        public void Add(int value)
        {
            Node newNode = new Node(value);

            if (root == null)
            {
                root = newNode;
                return;
            }

            Node current = root;
            while (true)
            {
                if (value < current.value)
                {
                    if (current.leftChild == null)
                    {
                        current.leftChild = newNode;
                        break;
                    }
                    current = current.leftChild;
                }
                else
                {
                    if (current.rightChild == null)
                    {
                        current.rightChild = newNode;
                        break;
                    }
                    current = current.rightChild;
                }
            }
        }

        public bool Contains(int value)
        {
            Node current = root;

            while (current != null)
            {
                if (value < current.value)
                {
                    current = current.leftChild;
                }
                else if (value > current.value)
                {
                    current = current.rightChild;
                }
                else
                {
                    return true;
                }
            }

            return false;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree tree = new BinarySearchTree();

            tree.Add(10);
            tree.Add(5);
            tree.Add(15);
            tree.Add(3);
            tree.Add(7);

            Console.WriteLine("Contains 7: " + tree.Contains(7));
            Console.WriteLine("Contains 12: " + tree.Contains(12));

            Console.ReadLine();
        }
    }
}

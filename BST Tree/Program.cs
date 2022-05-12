using System;

namespace BST_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi, there!");
            var array = new int[] {7, 5, 1, 8, 3, 6, 0, 9, 4, 2};
            BST tree = new BST();
            foreach (var item in array)
            {
             tree.Insert(item);   
            }
            tree.PreOrder(tree.Root);
        }
    }

    public class Node
    {
        public int Data { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }

        public void DisplayValue() => Console.Write(Data + " ");
    }

    public class BST
    {
        public Node Root { get; set; }

        public Node Find(int value, Node rootNode)
        {
            if (rootNode is null) return null;
            if (value == rootNode.Data) return Root;
            else if (value < rootNode.Data) return Find(value, rootNode.Left);
            else return Find(value, rootNode.Right);
        }

        public void Insert(int value)
        {


            if (Root is null) Root = new Node {Data = value};
            else
            {
                            
                Node current = Root;
                Node parent;
                while (true)
                {
                    parent = current;
                    if (value < current.Data)
                    {
                        current = current.Left;
                        if (current is null)
                        {
                            parent.Left = new Node {Data = value};
                            return;
                        }
                    }
                    else
                    {
                        current = current.Right;
                        if (current is null)
                        {
                            parent.Right = new Node {Data = value};
                            return;
                        }
                    }
                }
            }
        }

        public void PreOrder(Node node)
        {
            if (node is not null)
            {
                node.DisplayValue();
                PreOrder(node.Left);
                PreOrder(node.Right);
            }
        }
    }
}
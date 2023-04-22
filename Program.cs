using System;
using System.Collections;

namespace Lab9_Binary_tree
{
    class Node
    {
        public Node LeftNode { get; set; }
        public Node RightNode { get; set; }
        public int Data { get; set; }
    }
    class BinaryTree
    {
        public Node Root { get; set; }
        public ArrayList valueArray { get; set; }

        public bool Add(int value)
        {
            Node before = null, after = this.Root;

            while (after != null)
            {
                before = after;
                if (value < after.Data) after = after.LeftNode;
                else if (value > after.Data) after = after.RightNode;
                else
                {
                    return false;
                }
            }

            Node newNode = new Node();
            newNode.Data = value;

            if (this.Root == null) this.Root = newNode;
            else
            {
                if (value < before.Data) before.LeftNode = newNode;
                else before.RightNode = newNode;
            }
            return true;
        }

        public void TraverseTree()
        {
            this.Traverse(this.Root);
        }

        public void Traverse(Node parent)
        {
            if (parent != null)
            {
                Traverse(parent.LeftNode);
                Console.Write(parent.Data + " ");
                Traverse(parent.RightNode);
            }
        }
        /*
        public void TraverseList(Node parent)
        {
            if (parent != null)
            {
                Traverse(parent.LeftNode);
                ListAddValue(parent.Data);
                Traverse(parent.RightNode);
            }
        }
        public void ListAddValue(int data)
        {
            this.valueArray.Add(data);
        }
        public interface IEnumerator GetEnumerator()
        {
            this.valueArray = null;
            TraverseList(Root);
        }
        */
    }
    class Program
    {
        static void Main()
        {
            BinaryTree binaryTree = new BinaryTree();

            binaryTree.Add(2);
            binaryTree.Add(5);
            binaryTree.Add(9);
            binaryTree.Add(2);
            binaryTree.Add(17);
            binaryTree.Add(8);
            binaryTree.Add(9);

            Console.WriteLine("Traversing tree");
            binaryTree.TraverseTree();

        }
    }
}

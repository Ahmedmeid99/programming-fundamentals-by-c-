using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree_Datastruture
{
    public class BinaryTreeNode<T>
    {
        public T Value { get; set; }
        
        // Sub Tree Nodes 
        public BinaryTreeNode<T> Left { get; set; }
        public BinaryTreeNode<T> Right { get; set; }

        public BinaryTreeNode(T value)
        {
            this.Value = value;
            this.Left = null;
            this.Right = null;
        }


    }
    public class BinaryTree<T>
    {
       public BinaryTreeNode<T> Root { get; private set; }

        public BinaryTree()
        {
            Root = null;
        }

        public BinaryTree(T value)
        {
            Root = new BinaryTreeNode<T>(value) ;
        }

        // Over Loading
        public void PrintTree()
        {
            PrintTree(Root, 0);
        }

        private void PrintTree(BinaryTreeNode<T> root ,int space)
        {
            int SPACE_COUNT = 10;

            // base state
            if (root == null)
                return;

            space += SPACE_COUNT;

            PrintTree(root.Right, space);

            Console.WriteLine();
            for (int i = SPACE_COUNT; i < space; i++)
            {
                Console.Write(" ");
            }

            Console.WriteLine(root.Value);
            PrintTree(root.Left, space);
        }
      
        public void Insert(T value)
        {
            // create node
            var newNode = new BinaryTreeNode<T>(value);

            // base case
            if (Root == null)
            {
                Root = newNode;
                return;
            }

            // store nodes in order in queue to for Create Balanced Tree
            Queue<BinaryTreeNode<T>> queue = new Queue<BinaryTreeNode<T>>();

            // Tree has Root so add it to queue
            queue.Enqueue(Root);

            // Create Balanced Tree full from Left to Right
            while (queue.Count > 0)
            {
                var current = queue.Dequeue(); // will poop the first node added in order [IN EACH ROUND]

                if(current.Left == null)
                {
                    current.Left = newNode;
                    return;
                }
                else
                    queue.Enqueue(current.Left);
                

                if (current.Right == null)
                {
                    current.Right = newNode;
                    return;
                }
                else
                    queue.Enqueue(current.Right);
            }


        }

        public void PreOrderTraversal()
        {
            this.PreOrderTraversal(Root);
        }

        private void PreOrderTraversal(BinaryTreeNode<T> node)
        {
            if (node == null)
                return;

            Console.WriteLine(node.Value);
            PreOrderTraversal(node.Left);
            PreOrderTraversal(node.Right);
        }

        public void PostOrderTraversal()
        {
            this.PostOrderTraversal(Root);
        }

        private void PostOrderTraversal(BinaryTreeNode<T> node)
        {
            if (node == null)
                return;

            PreOrderTraversal(node.Left);
            PreOrderTraversal(node.Right);
            Console.WriteLine(node.Value);
        }

        public void InOrderTraversal()
        {
            this.InOrderTraversal(Root);
        }

        private void InOrderTraversal(BinaryTreeNode<T> node)
        {
            if (node == null)
                return;

            PreOrderTraversal(node.Left);
            Console.WriteLine(node.Value);
            PreOrderTraversal(node.Right);
        }

    }
}

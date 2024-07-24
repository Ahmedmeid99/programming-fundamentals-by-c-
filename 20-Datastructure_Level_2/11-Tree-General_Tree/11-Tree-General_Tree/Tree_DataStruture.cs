using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Tree_General_Tree
{
    public class TreeNode<T>
    {
        public T Value { get; set; }
        public List<TreeNode<T>> Children { get; set; }

        public TreeNode(T value)
        {
            this.Value = value;
            this.Children = new List<TreeNode<T>>();
        }

        public void AddChild(TreeNode<T> node)
        {
            Children.Add(node);
        }

        public TreeNode<T> Find(T value)
        {
            // base case check if this value of the current 
            if (EqualityComparer<T>.Default.Equals(Value, value))
                return this;

            // search in Children
            foreach (TreeNode<T> child in Children)
            {
                var Found = child.Find(value);
                if (Found != null)
                    return child;
            }

            return null;
        }

    }
    public class Tree<T>
    {
       public TreeNode<T> Root { get; private set; }

        public Tree(T value)
        {
            Root = new TreeNode<T>(value) ;
        }

        public void PrintTree(string indent = " ")
        {
            this.PrintTree(this.Root, indent);
        }

        private void PrintTree(TreeNode<T> node,string indent=" ")
        {
            Console.WriteLine(indent + node.Value);// print parent
            foreach (var child in node.Children)
            {
                PrintTree(child, indent + indent);
            }


        }


    }

}

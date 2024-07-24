// See https://aka.ms/new-console-template for more information

using BinaryTree_Datastruture;

var binaryTree = new BinaryTree<byte>();
Console.WriteLine("Value to be Inserted: 5,3,1,4,6,9 \n");

binaryTree.Insert(5);
binaryTree.Insert(3);
binaryTree.Insert(8);
binaryTree.Insert(1);
binaryTree.Insert(4);
binaryTree.Insert(6);
binaryTree.Insert(9);

binaryTree.PrintTree();
Console.WriteLine("\n PreOrderTraversal ( Root => Left => Right )");
binaryTree.PreOrderTraversal();
Console.WriteLine("\n PostOrderTraversal (  Left => Right => Root )");
binaryTree.PostOrderTraversal();
Console.WriteLine("\n InOrderTraversal (  Left => Root => Right )");
binaryTree.InOrderTraversal();







Console.WriteLine("Hello, World!");

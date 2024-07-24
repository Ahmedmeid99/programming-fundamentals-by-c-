
using _11_Tree_General_Tree;

var FamilyTree = new Tree<string>("Eid Ali");
var F1 = new TreeNode<string>("Mohamed Eid");
var F2 = new TreeNode<string>("Ahmed Eid");
var F3 = new TreeNode<string>("Mostafa");

FamilyTree.Root.AddChild(F1);
FamilyTree.Root.AddChild(F2);
FamilyTree.Root.AddChild(F3);

F1.Children.Add(new TreeNode<string>("Ahmed"));
F1.Children.Add(new TreeNode<string>("Hassan"));
F1.Children.Add(new TreeNode<string>("Eid"));

F2.Children.Add(new TreeNode<string>("Mohamed"));
F2.Children.Add(new TreeNode<string>("Ali"));
F2.Children.Add(new TreeNode<string>("Adel"));

F3.Children.Add(new TreeNode<string>("Ibrahem"));
F3.Children.Add(new TreeNode<string>("Hanaa"));
F3.Children.Add(new TreeNode<string>("Ammar"));



FamilyTree.PrintTree(" "); // "-"

// Eid Ali
//  Mohamed Eid
//    Ahmed
//    Hassan
//    Eid
//  Ahmed Eid
//    Mohamed
//    Ali
//    Adel
//  Mostafa
//    Ibrahem
//    Hanaa
//    Ammar

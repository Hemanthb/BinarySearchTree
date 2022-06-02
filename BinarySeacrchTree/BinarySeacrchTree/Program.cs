Binary_Search_Tree.BinarySearchTree<int> binaryTree = new Binary_Search_Tree.BinarySearchTree<int>(56);
binaryTree.Insert(30);
binaryTree.Insert(70);
binaryTree.Insert(22);
binaryTree.Insert(40);
binaryTree.Insert(11);
binaryTree.Insert(3);
binaryTree.Insert(16);
binaryTree.Insert(60);
binaryTree.Insert(95);
binaryTree.Insert(65);
binaryTree.Insert(63);
binaryTree.Insert(67);
binaryTree.Display();
binaryTree.size();
bool yes = binaryTree.Search(30,binaryTree);
if(yes)
{
    Console.WriteLine("Given value is found in the tree");
}
else
{
    Console.WriteLine("Given value is not found in the tree");
}
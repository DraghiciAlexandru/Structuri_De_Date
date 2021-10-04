using System;

namespace Structuri_De_Date_Generice
{
    class Program
    {
        static void Main(string[] args)
        {
            BST<int> bst = new BST<int>();

            bst.insert(30);
            bst.insert(15);
            bst.insert(60);
            bst.insert(7);
            bst.insert(22);
            bst.insert(17);
            bst.insert(27);
            bst.insert(45);
            bst.insert(75);

            //Console.WriteLine(bst.ToString());


            bst.inorder(bst.Root);


        }
    }
}

using System;

namespace Structuri_De_Date_Generice
{
    class Program
    {
        static void Main(string[] args)
        {
            BST<int> bst = new BST<int>();

            bst.insert(12);
            bst.insert(10);
            bst.insert(18);
            bst.insert(8);
            bst.insert(11);
            bst.insert(9);
            bst.insert(15);
            bst.insert(20);
            bst.insert(16);
            bst.insert(17);

            bst.delete(bst.Root, 15);

            bst.preorder(bst.Root);

        }
    }
}

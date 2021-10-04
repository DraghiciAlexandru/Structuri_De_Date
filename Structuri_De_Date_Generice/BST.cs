using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Structuri_De_Date_Generice
{
    class BST<T> where T : IComparable
    {
        private TreeNode<T> root = null;

        public TreeNode<T> Root
        {
            get { return root; }
        }

        private void insert(TreeNode<T> node, T data)
        {
            if (node.Data.CompareTo(data) < 0)
            {

                if (node.Right == null)
                {

                    node.Right = new TreeNode<T> { Data = data, Left = null, Right = null };
                }
                else
                {

                    insert(node.Right, data);
                }
            }
            else
            {
                if (node.Left == null)
                {
                    node.Left = new TreeNode<T> { Data = data, Left = null, Right = null };
                }
                else
                {
                    insert(node.Left, data);
                }
            }


        }

        public void insert(T data)
        {
            if (root == null)
            {
                root = new TreeNode<T> { Data = data, Left = null, Right = null };
            }
            else
            {
                insert(root, data);
            }
        }

        public override string ToString()
        {
            String text = "";

            Queue<TreeNode<T>> queue = new Queue<TreeNode<T>>();

            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                if (queue.Peek().Left != null)
                {
                    queue.Enqueue(queue.Peek().Left);
                }
                if (queue.Peek().Right != null)
                {
                    queue.Enqueue(queue.Peek().Right);
                }

                text += queue.Dequeue().Data.ToString() + ";";
            }

            return text;
        }

        public void preorder(TreeNode<T> node)
        {

            if (node == null)
            {
                return;
            }

            Console.WriteLine(node.Data);

            preorder(node.Left);
            preorder(node.Right);

        }

        public void inorder(TreeNode<T> node)
        {
            if (node == null)
            {
                return;
            }

            inorder(node.Left);

            Console.WriteLine(node.Data);

            inorder(node.Right);
        }

        public void postorder(TreeNode<T> node)
        {
            if (node == null)
            {
                return;
            }
            
        }
    }
}

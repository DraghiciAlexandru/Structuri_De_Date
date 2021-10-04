using System;
using System.Collections.Generic;
using System.Text;

namespace Structuri_De_Date_Generice
{
    class Ierarhie<T> where T : IComparable<T>
    {
        TreeNode<T> root;

        public Ierarhie(T data)
        {

            root = new TreeNode<T> { Data = data, Left = null, Right = null };

        }

        private TreeNode<T> find(TreeNode<T> node, T data)
        {
            if (node == null)
            {
                return null;
            }

            if (node.Data.Equals(data))
            {
                return node;
            }

            TreeNode<T> left= find(node.Left, data);

            if (left != null)
            {
                return left;
            }


            return find(node.Right, data);
        }

        public bool addSubordinate(T manager, T subordonat)
        {
            TreeNode<T> node = find(root, manager);

            if (node == null)
            {
                return false;
            }

            if (node.Left != null && node.Right != null)
            {
                return false;
            }

            if (node.Left == null)
            {
                node.Left = new TreeNode<T> { Data = subordonat, Left = null, Right = null };
                return true;
            }
            else
            {
                node.Right = new TreeNode<T> { Data = subordonat, Left = null, Right = null };
                return true;
            }
        }

        public void afisare()
        {
            Queue<TreeNode<T>> queue = new Queue<TreeNode<T>>();

            queue.Enqueue(root);

            while (queue.Count != 0)
            {
                if (queue.Peek().Left != null) 
                {
                    queue.Enqueue(queue.Peek().Left);
                }
                if (queue.Peek().Right != null) 
                {
                    queue.Enqueue(queue.Peek().Right);
                }

                Console.Write(queue.Peek().Data);

                queue.Dequeue();
            }

        }

    }
}

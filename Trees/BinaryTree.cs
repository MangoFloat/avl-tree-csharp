using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryAssignment
{
    public class BinaryTree<T> where T : IComparable
    {
        protected Node<T> root; // Protected variable

        public BinaryTree() // Constructor
        {
            root = null;
        }

        public BinaryTree(Node<T> node) // Constructor
        {
            root = node;
        }

        ///// IN ORDER
        public void InOrder(ref StringBuilder buffer)
        {
            inOrder(root, ref buffer);
        }

        private void inOrder(Node<T> tree, ref StringBuilder buffer)
        {
            if (tree != null)
            {
                inOrder(tree.Left, ref buffer);
                buffer.Append(tree.Data.ToString() + ",");
                inOrder(tree.Right, ref buffer);
            }
        }

        ///// PRE ORDER
        public void PreOrder(ref StringBuilder buffer)
        {
            preOrder(root, ref buffer);
        }

        public void preOrder(Node<T> tree, ref StringBuilder buffer)
        {
            if (tree != null)
            {
                buffer.Append(tree.Data.ToString() + ",");
                preOrder(tree.Left, ref buffer);
                preOrder(tree.Right, ref buffer);
            }
        }

        ///// POST ORDER
        public void PostOrder(ref StringBuilder buffer)
        {
            postOrder(root, ref buffer);
        }

        public void postOrder(Node<T> tree, ref StringBuilder buffer)
        {
            if (tree != null)
            {
                postOrder(tree.Left, ref buffer);
                postOrder(tree.Right, ref buffer);
                buffer.Append(tree.Data.ToString() + ",");
            }
        }

        ///// Copy
        public void Copy(BinaryTree<T> tree2)
        {
            copy(ref root, tree2.root);
        }

        private void copy(ref Node<T> tree, Node<T> tree2)
        {
            if (tree == null && tree2 != null)
            {
                tree = new Node<T>(tree2.Data);
            }
            if (tree != null && tree2 != null)
            {
                tree.Data = tree2.Data;
                copy(ref tree.Left, tree2.Left);
                copy(ref tree.Right, tree2.Right);
            }
        }

        ///// Count
        public int Count()
        {
            int counter = 0;
            count(root, ref counter);
            return counter;
        }

        private void count(Node<T> tree, ref int counter)
        {
            if (tree != null)
            {
                counter++;
                count(tree.Left, ref counter);
                count(tree.Right, ref counter);
            }
        }
    }
}

using System;

namespace CountryAssignment
{
    public class AVLTree<T> : BinarySearchTree<T> where T : IComparable
    {
        public AVLTree() // Constructor
        {
            root = null;
        }

        public AVLTree(Node<T> root) // Constructor
        {
            this.root = root;
        }

        public new void InsertItem(T item) // Insertion method
        {
            insertItem(item, ref root);
        }

        private void insertItem(T item, ref Node<T> tree)
        {
            if (tree == null) // If node is null, then add new node
            {
                tree = new Node<T>(item);
            }
            else if (item.CompareTo(tree.Data) < 0) // Go Left if item is smaller than tree's data.
            {
                insertItem(item, ref tree.Left);
            }
            else if (item.CompareTo(tree.Data) > 0) // Go Right if item is larger than tree's data.
            {
                insertItem(item, ref tree.Right);
            }
            balanceTree(ref tree);
        }

        public new void RemoveItem(T item) // Removal method
        {
            removeItem(item, ref root);
        }

        private void removeItem(T item, ref Node<T> tree)
        {
            if (tree != null)
            {
                if (item.CompareTo(tree.Data) < 0)
                {
                    removeItem(item, ref tree.Left);
                }
                else if (item.CompareTo(tree.Data) > 0)
                {
                    removeItem(item, ref tree.Right);
                }
                else if (item.CompareTo(tree.Data) == 0) // Rotations
                {
                    if (tree.Left == null) // Check if left tree is null
                    {
                        tree = tree.Right; // Make node of right tree new node.
                    }
                    else if (tree.Right == null) // Check if right tree is null
                    {
                        tree = tree.Left; // Make node of left tree new node.
                    }
                    else
                    {
                        T newRoot = leastItem(tree.Right);  // get least item in terms of CompareTo, on the right tree, i.e. the left most.
                        tree.Data = newRoot; // make node with the least item the new root.
                        removeItem(newRoot, ref tree.Right); 
                    }
                }
            }
            else
            {
                return;
            }
            balanceTree(ref tree);
        }

        private void balanceTree(ref Node<T> tree)
        {
            if (tree != null) // for when it's called from the removeItem, tree may become null
            {
                tree.BalanceFactor = height(tree.Left) - height(tree.Right);
                if (tree.BalanceFactor <= -2)
                {
                    rotateLeft(ref tree);
                }
                if (tree.BalanceFactor >= 2)
                {
                    rotateRight(ref tree);
                }
            }
        }

        private void rotateLeft(ref Node<T> tree)
        {
            if (tree.Right.BalanceFactor > 0) // Double rotation
            {
                rotateRight(ref tree.Right);
            }

            Node<T> oldRoot = tree;
            Node<T> newRoot = tree.Right;
            
            oldRoot.Right = newRoot.Left;
            newRoot.Left = oldRoot;

            tree = newRoot;
        }

        private void rotateRight(ref Node<T> tree)
        {
            if (tree.Left.BalanceFactor < 0) // Double rotation
            {
                rotateLeft(ref tree.Left);
            }

            Node<T> oldRoot = tree;
            Node<T> newRoot = tree.Left;

            oldRoot.Left = newRoot.Right;
            newRoot.Right = oldRoot;

            tree = newRoot;
        }
    }
}
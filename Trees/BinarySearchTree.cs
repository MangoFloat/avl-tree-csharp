using System;

namespace CountryAssignment
{
   public class BinarySearchTree<T> : BinaryTree<T> where T : IComparable
    {
        public BinarySearchTree()
        {
            root = null;
        }

        public BinarySearchTree(Node<T> root)
        {
            this.root = root;
        }

        public void InsertItem(T item)
        {
            insertItem(item, ref root);
        }

        private void insertItem(T item, ref Node<T> tree)
        {
            if (tree == null)
            {
                tree = new Node<T>(item);
            }
            else if (item.CompareTo(tree.Data) < 0)
            {
                insertItem(item, ref tree.Left);
            }
            else if (item.CompareTo(tree.Data) > 0)
            {
                insertItem(item, ref tree.Right);
            }
        }

        // HEIGHT
        public int Height()
        {
            return height(root);
        }

        protected int height(Node<T> tree)
        {
            if (tree == null)
            {
                return 0;
            }
            else
            {
                return 1 + max(height(tree.Left), height(tree.Right));
            }
        }

        private int max(int x, int y)
        {
            if (x > y)
            {
                return x;
            }
            else
            {

                return y;
            }
        }

        public Boolean Contains(T item)
        {
            return contains(root, item);
        }

        private Boolean contains(Node<T> tree, T item)
        {
            if (tree != null)
            {
                if (item.Equals(tree.Data))
                    return true;
                if(item.CompareTo(tree.Data) < 0)
                {
                    return contains(tree.Left, item);
                }
                else
                {
                    return contains(tree.Right, item);
                }
            }
            else
            {
                return false;
            }
        }

        public void RemoveItem(T item)
        {
            removeItem(item, ref root);
        }

        private void removeItem(T item, ref Node<T> tree)
        {
            if (tree == null)
            {
                return;
            }
            else if (item.CompareTo(tree.Data) < 0)
            {
                removeItem(item, ref tree.Left);
            }
            else if (item.CompareTo(tree.Data) > 0)
            {
                removeItem(item, ref tree.Right);
            }

            if (item.CompareTo(tree.Data) == 0)
            {
                if (tree.Left == null)
                {
                    tree = tree.Right;
                }
                else if (tree.Right == null)
                {
                    tree = tree.Left;
                }
                else
                {
                    T newRoot = leastItem(tree.Right);
                    tree.Data = newRoot;
                    removeItem(newRoot, ref tree.Right);
                }
            }
        }

        protected T leastItem(Node<T> tree) // Get the least item from the tree, i.e. the leftmost tree.
        {
            if (tree.Left == null)
            {
                return tree.Data;
            }
            else
            {
                return leastItem(tree.Left);
            }
        }
    }
}

using NUnit.Framework;

namespace CountryAssignment.NUnit_Tests
{

    [TestFixture(Author = "jaictinjune@gmail.com", Category = "Tree", Description = "Testing the BinarySearchTree class.")]
    public class TestBinarySearchTree
    {
        [Test(Author = "jaictinjune@gmail.com", Description = "Test the initiation of the Binary Search Tree.")]
        public void NewBSTree()
        {
            BinarySearchTree<int> tree = new BinarySearchTree<int>();
            tree.InsertItem(1);
            tree.InsertItem(2);
            tree.InsertItem(3);
            tree.InsertItem(4);
            tree.InsertItem(5);
            tree.InsertItem(6);
            tree.InsertItem(7);
            tree.InsertItem(8);
            tree.InsertItem(9);

            Assert.IsInstanceOf<BinarySearchTree<int>>(tree);
        }

        [Test(Author = "jaictinjune@gmail.com", Description = "Test the Height function in the Binary Search Tree.")]
        public void TestHeight()
        {
            BinarySearchTree<int> tree = new BinarySearchTree<int>();
            tree.InsertItem(1);
            tree.InsertItem(2);
            tree.InsertItem(3);
            tree.InsertItem(4);
            tree.InsertItem(5);
            tree.InsertItem(6);
            tree.InsertItem(7);
            tree.InsertItem(8);
            tree.InsertItem(9);
            tree.InsertItem(0);

            Assert.AreEqual(tree.Height(), 9);
        }

        [Test(Author = "jaictinjune@gmail.com", Description = "Test the Contains function in the Binary Search Tree.")]
        public void TestContains()
        {
            BinarySearchTree<int> tree = new BinarySearchTree<int>();
            tree.InsertItem(1);
            tree.InsertItem(2);
            tree.InsertItem(3);
            tree.InsertItem(4);
            tree.InsertItem(5);
            tree.InsertItem(6);
            tree.InsertItem(7);
            tree.InsertItem(8);
            tree.InsertItem(9);
            tree.InsertItem(0);

            Assert.AreEqual(tree.Contains(0), true);
            Assert.AreEqual(tree.Contains(1), true);
            Assert.AreEqual(tree.Contains(10), false);
        }

        [Test(Author = "jaictinjune@gmail.com", Description = "Test the Remove function in the Binary Search Tree.")]
        public void TestRemove()
        {
            BinarySearchTree<int> tree = new BinarySearchTree<int>();
            tree.InsertItem(1);
            tree.InsertItem(2);
            tree.InsertItem(3);
            tree.InsertItem(4);
            tree.InsertItem(5);
            tree.InsertItem(6);
            tree.InsertItem(7);
            tree.InsertItem(8);
            tree.InsertItem(9);
            tree.InsertItem(0);

            tree.RemoveItem(7);
            tree.RemoveItem(1);

            Assert.AreEqual(tree.Contains(7), false);
            Assert.AreEqual(tree.Contains(1), false);
        }
    }
}

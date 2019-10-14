using NUnit.Framework;

namespace CountryAssignment.NUnit_Tests
{
   
    [TestFixture]
    class TestBSTree
    {
        [Test]
        public void NewBSTree()
        {
            BSTree<int> tree = new BSTree<int>();
            tree.InsertItem(1);
            tree.InsertItem(2);
            tree.InsertItem(3);
            tree.InsertItem(4);
            tree.InsertItem(5);
            tree.InsertItem(6);
            tree.InsertItem(7);
            tree.InsertItem(8);
            tree.InsertItem(9);

            Assert.IsInstanceOf<BSTree<int>>(tree);
        }

        [Test]
        public void TestHeight()
        {
            BSTree<int> tree = new BSTree<int>();
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

        [Test]
        public void TestContains()
        {
            BSTree<int> tree = new BSTree<int>();
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

        [Test]
        public void TestRemove()
        {
            BSTree<int> tree = new BSTree<int>();
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

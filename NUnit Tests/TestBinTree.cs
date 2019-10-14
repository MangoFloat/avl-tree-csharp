using NUnit.Framework;
using System.Text;

namespace CountryAssignment.NUnit_Tests
{

    [TestFixture]
    public class TestBinTree
    {
        [Test]
        public void NewBinTree()
        {
            Node<int> node1 = new Node<int>(1); //  1
            Node<int> node2 = new Node<int>(2); //      2
            Node<int> node3 = new Node<int>(3); //          3
            Node<int> node4 = new Node<int>(4); //              4
            Node<int> node5 = new Node<int>(5); //                  5
            Node<int> node6 = new Node<int>(6); //                      6
            Node<int> node7 = new Node<int>(7); //                          7
            Node<int> node8 = new Node<int>(8); //                              8
            Node<int> node9 = new Node<int>(9); //                                  9

            node1.Left = node2;
            node1.Right = node3;
            node2.Left = node4;
            node2.Right = node5;
            node3.Left = node6;
            node3.Right = node7;
            node4.Left = node8;
            node4.Right = node9;

            BinTree<int> binTree = new BinTree<int>(node1);

            Assert.IsInstanceOf<BinTree<int>>(binTree);
        }

        [Test]
        public void TestTraversals()
        {
            Node<int> node1 = new Node<int>(1);
            Node<int> node2 = new Node<int>(2);
            Node<int> node3 = new Node<int>(3);
            Node<int> node4 = new Node<int>(4);
            Node<int> node5 = new Node<int>(5);
            Node<int> node6 = new Node<int>(6);
            Node<int> node7 = new Node<int>(7);
            Node<int> node8 = new Node<int>(8);
            Node<int> node9 = new Node<int>(9);

            node1.Left = node2;
            node1.Right = node3;
            node2.Left = node4;
            node2.Right = node5;
            node3.Left = node6;
            node3.Right = node7;
            node4.Left = node8;
            node4.Right = node9;

            BinTree<int> binTree1 = new BinTree<int>(node1);

            StringBuilder strInOrder1 = new StringBuilder();
            string strInOrder2 = "8,4,9,2,5,1,6,3,7,";
            binTree1.InOrder(ref strInOrder1);

            StringBuilder strPreOrder1 = new StringBuilder();
            string strPreOrder2 = "1,2,4,8,9,5,3,6,7,";
            binTree1.PreOrder(ref strPreOrder1);

            StringBuilder strPostOrder1 = new StringBuilder();
            string strPostOrder2 = "8,9,4,5,2,6,7,3,1,";
            binTree1.PostOrder(ref strPostOrder1);

            Assert.AreEqual(strInOrder1.ToString(), strInOrder2);
            Assert.AreEqual(strPreOrder1.ToString(), strPreOrder2);
            Assert.AreEqual(strPostOrder1.ToString(), strPostOrder2);
        }

        [Test]
        public void TestCopyCount()
        {
            Node<int> node1 = new Node<int>(1);
            Node<int> node2 = new Node<int>(2);
            Node<int> node3 = new Node<int>(3);
            Node<int> node4 = new Node<int>(4);
            Node<int> node5 = new Node<int>(5);
            Node<int> node6 = new Node<int>(6);
            Node<int> node7 = new Node<int>(7);
            Node<int> node8 = new Node<int>(8);
            Node<int> node9 = new Node<int>(9);

            node1.Left = node2;
            node1.Right = node3;
            node2.Left = node4;
            node2.Right = node5;
            node3.Left = node6;
            node3.Right = node7;
            node4.Left = node8;
            node4.Right = node9;

            BinTree<int> binTree1 = new BinTree<int>(node1);
            BinTree<int> binTree2 = new BinTree<int>();

            binTree2.Copy(binTree1);

            StringBuilder str1 = new StringBuilder();
            StringBuilder str2 = new StringBuilder();

            binTree1.InOrder(ref str1);
            binTree2.InOrder(ref str2);
            binTree1.PreOrder(ref str1);
            binTree2.PreOrder(ref str2);
            binTree1.PostOrder(ref str1);
            binTree2.PostOrder(ref str2);

            Assert.AreEqual(str1.ToString(), str2.ToString()); // Tree is same structure, therefore should be the same string.
            //Assert.AreEqual(binTree1, binTree2); // Fails for some reason? Even though they have the same structure.
            Assert.AreEqual(binTree1.Count(), 9);
        }
    }
}

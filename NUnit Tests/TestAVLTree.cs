using NUnit.Framework;
using System.Text;

namespace CountryAssignment.NUnit_Tests
{

    [TestFixture(Author = "jaictinjune@gmail.com", Category = "Tree", Description = "Testing the AVLTree class.")]
    public class TestAVLTree
    {
        [Test(Author = "jaictinjune@gmail.com", Description = "Test the initiation of the AVL Tree.")]
        public void NewAVLTree()
        {
            AVLTree<int> tree = new AVLTree<int>();
            tree.InsertItem(1); //                  4
            tree.InsertItem(2); //        2                    6 
            tree.InsertItem(3); //  1           3        5           8
            tree.InsertItem(4); //                                 7   9
            tree.InsertItem(5); //
            tree.InsertItem(6); //
            tree.InsertItem(7); //
            tree.InsertItem(8); //
            tree.InsertItem(9); //

            Assert.IsInstanceOf<AVLTree<int>>(tree);
        }

        [Test(Author = "jaictinjune@gmail.com", Description = "Test the rotation of the tree, checking if the orders are correct when adding/removing nodes to the tree.")]
        public void TestRotations()
        {
            AVLTree<int> tree = new AVLTree<int>();
            tree.InsertItem(1); //                  4
            tree.InsertItem(4); //        2                   7 
            tree.InsertItem(6); //   1         3         6         8
            tree.InsertItem(2); //                     5             9
            tree.InsertItem(8); //
            tree.InsertItem(3); //
            tree.InsertItem(7); //
            tree.InsertItem(5); //
            tree.InsertItem(9); //

            // Using AVL Tree visualiser.
            StringBuilder strInOrder1 = new StringBuilder();
            string strInOrder2 = "1,2,3,4,5,6,7,8,9,";
            tree.InOrder(ref strInOrder1);
            
            StringBuilder strPreOrder1 = new StringBuilder();
            string strPreOrder2 = "4,2,1,3,7,6,5,8,9,";
            tree.PreOrder(ref strPreOrder1);

            StringBuilder strPostOrder1 = new StringBuilder();
            string strPostOrder2 = "1,3,2,5,6,9,8,7,4,";
            tree.PostOrder(ref strPostOrder1);
        
            Assert.AreEqual(strInOrder1.ToString(), strInOrder2);
            Assert.AreEqual(strPreOrder1.ToString(), strPreOrder2);
            Assert.AreEqual(strPostOrder1.ToString(), strPostOrder2);

            tree.RemoveItem(7); //                  4
                                //        2                   8 
                                //   1         3         6         9
                                //                     5     

            strInOrder1.Clear();
            string strInOrder3 = "1,2,3,4,5,6,8,9,";
            tree.InOrder(ref strInOrder1);

            strPreOrder1.Clear();
            string strPreOrder3 = "4,2,1,3,8,6,5,9,";
            tree.PreOrder(ref strPreOrder1);

            strPostOrder1.Clear();
            string strPostOrder3 = "1,3,2,5,6,9,8,4,";
            tree.PostOrder(ref strPostOrder1);

            Assert.AreEqual(strInOrder1.ToString(), strInOrder3);
            Assert.AreEqual(strPreOrder1.ToString(), strPreOrder3);
            Assert.AreEqual(strPostOrder1.ToString(), strPostOrder3);

            tree.RemoveItem(9); //                  4
                                //        2                   6 
                                //   1         3         5         8

            strInOrder1.Clear();
            string strInOrder4 = "1,2,3,4,5,6,8,";
            tree.InOrder(ref strInOrder1);

            strPreOrder1.Clear();
            string strPreOrder4 = "4,2,1,3,6,5,8,";
            tree.PreOrder(ref strPreOrder1);

            strPostOrder1.Clear();
            string strPostOrder4 = "1,3,2,5,8,6,4,";
            tree.PostOrder(ref strPostOrder1);

            Assert.AreEqual(strInOrder1.ToString(), strInOrder4);
            Assert.AreEqual(strPreOrder1.ToString(), strPreOrder4);
            Assert.AreEqual(strPostOrder1.ToString(), strPostOrder4);
        }
    }
}

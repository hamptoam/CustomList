using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListProject;
namespace CustomListClassTest
{
    [TestClass]
    public class CustomList
    {

        [TestMethod]
        public void Add_AddToEmptyList_ItemShouldGoToIndexZero()
        {
            CustomList<int> test = new CustomList<int>();
            int expected = 8;
            int actual;

            test.Add(8);

            actual = test[0];

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_AddToEmptyList_CountShouldIncreaseToOne()
        {
            CustomList<int> test = new CustomList<int>();
            int expected = 1;
            int actual;

            test.Add(8);

            actual = test.count;

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public static void Add_AddingItemToFullArray_ItemStillAccepted()
        {
            CustomList<int> test = new CustomList<int>();
            int expected = 9;
            int actual;
          
            test.Add(1);
            test.Add(1);
            test.Add(1);
            test.Add(1);
            test.Add(1);
            test.Add(1);
            test.Add(1);
            test.Add(1);
            test.Add(1);

            actual = test.Count;

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public static void Add_AddToPopulatedList_IndexShouldGoToCount()
        {

            CustomList<int> test = new CustomList<int>();

            int expected = 2;
            int actual;

            test.Add(1);
            test.Add(1);

            actual = test.count;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public static void Remove_RemoveFromList_CountShouldReduce()
        {
            CustomList<int> test = new CustomList<int>();

            int expected = 3;
            int actual;


            test.Add(1);
            test.Add(1);
            test.Add(1);
            test.Add(1);
            test.Remove(1);

            actual = test. count;

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public static void Remove_RemoveFromPopulatedList_IndexShouldShiftWhenSomethingRemoved()
        {
            CustomList<int> test = new CustomList<int> { 0, 1, 2, 3 };

            int expected = 3;
            int actual;

            test.Remove(2);
            actual = test[2];

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public static void Remove_RemoveFromList_IndexShouldGoTo0()
        {

            CustomList<int> test = new CustomList<int>();
            int expected = 0;
            int actual;

            test.Add(1);
            test.Add(1);
            test.Remove(1);
            test.Remove(1);

            actual = test[0];
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public static void Remove_RemoveFromEmptyList_CountRemain0()
        {
            CustomList<int> test = new CustomList<int>();

            int expected = 0;
            int actual; 

            test.Add(1);
            test.Remove(1);
            test.Remove(1); 

            actual = test[0];
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public static void Indexer_FindAnObjectInAList_GetRightObject()
        {
            CustomList<int> test = new CustomList<int>();

            int expected = 8;
            int actual;


            test.Add(1);
            test.Add(2);
            test.Add(3);
            test.Add(4);
            test.Add(5);
            test.Add(6);
            test.Add(7);
            test.Add(8);

            actual = test.Count;
            Assert.AreEqual(expected, actual);

        }

        

        [TestMethod]
        public static void Zip_TieTwoArrays_ItemsWereZippedSuccessfully()
        {
            CustomList<int> test = new CustomList<int>();
            test.Add(1);
            test.Add(2);
            test.Add(3);
            test.Add(4);


            CustomList<int> test2 = new CustomList<int>();
            test2.Add(5);
            test2.Add(6);
            test2.Add(7);
            test2.Add(8);

            test.Zip(test2);

            actual = 
        }

    }      
}

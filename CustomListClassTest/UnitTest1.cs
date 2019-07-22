using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListProject;
namespace CustomListClassTest
{
    [TestClass]
    public class CustomList
    {
        // if i add something to a populated customlist, it should go to final count
        // if i add something to customlist whose inner array is full, it should still add the item
        [TestMethod]
        public void Add_AddToEmptyList_ItemShouldGoToIndexZero()
        {
            // arrange
            CustomList<int> test = new CustomList<int>();
            int expected = 8;
            int actual;
            // act
            test.Add(8);
            actual = test[0];
            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_AddToEmptyList_CountShouldIncreaseToOne()
        {
            // arrange
            CustomList<int> test = new CustomList<int>();
            int expected = 1;
            int actual;
            // act
            test.Add(8);
            actual = test.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public static void Add_AddingItemToFullArray_ItemStillAccepted()
        {
            CustomList<int> test = new CustomList<int>();
            int expected = 9;
            int actual;
            //act

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

            //assert

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public static void Add_AddToPopulatedList_IndexShouldGoToCount()
        {

            CustomList<int> test = new CustomList<int>();


            int expected = 2;
            int actual;
            // act
            test.Add(1);
            test.Add(1);


            actual = test.Count;
            // assert
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

            actual = test.Count;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]

        public static void Remove_RemoveFromList_IntsShouldShiftTo0WhenSomethingRemoved()
        {
            CustomList<int> test = new CustomList<int>();

            int expected = 4;
            int actual;

            test.Add(1);
            test.Add(1);
            test.Add(1);
            test.Add(4);
            test.Remove(1);

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

            actual = test.Count;
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public static void Remove_RemoveFromEmptyLIst_CountRemain0()
        {
            CustomList<int> test = new CustomList<int>();

            test.Add(1);
            test.Add(1);

            
        }

        [TestMethod]

      public static void Indexer_FindAnObjectInAList_GetRightObject()
        {
            CustomList<int> test = new CustomList<int>();

            int expected = 1;
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
    }      
}

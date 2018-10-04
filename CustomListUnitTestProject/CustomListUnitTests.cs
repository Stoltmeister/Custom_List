using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Custom_List_Project;

namespace CustomListUnitTestProject
{
    [TestClass]
    public class CustomListUnitTests
    {

        // ***Add() Tests***

        [TestMethod]
        public void Add_IntParamForEmptyList_FirstIndexIsSameInt()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int value = 16;

            //Act
            customList.Add(value);

            //Assert
            Assert.AreEqual(value, customList[0]);
        }
        [TestMethod]
        public void Add_OneValueToEmptyList_CountIsOne()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int value = 16;
            int countValue = 1;

            //Act
            customList.Add(value);

            //Assert
            Assert.AreEqual(customList.Count, countValue);
        }
        [TestMethod]
        public void Add_TwoInts_FirstIndexEqualsLastIntAdded()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int value = 16;
            int value1 = 20;

            //Act
            customList.Add(value);
            customList.Add(value1);

            //Assert
            Assert.AreEqual(value, customList[0]);
        }
        [TestMethod]
        public void Add_TwoIntsToEmptyList_SecondIndexEqualsLastIntAdded()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int value = 16;
            int value1 = 20;

            //Act
            customList.Add(value);
            customList.Add(value1);

            //Assert
            Assert.AreEqual(value1, customList[1]);
        }
        [TestMethod]
        public void Add_TwoInts_CountEqualsTwo()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int value = 16;
            int value1 = 20;
            int expected = 2;

            //Act
            customList.Add(value);
            customList.Add(value1);
            int actual = customList.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        // ***Remove() Tests***

        [TestMethod]
        public void Remove_IntIncludedInList_OtherIntIsOnlyOneRemaining()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int value = 16;
            int value1 = 20;
           
            //Act
            customList.Add(value);
            customList.Add(value1);
            customList.Remove(value);

            //Assert
            Assert.AreEqual(value1, customList[0]);
        }
        [TestMethod]
        public void Remove_OnlyValueIntInList_ListCountIsZero()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int value = 16;
            int expected = 0;

            //Act
            customList.Add(value);
            customList.Remove(value);
            int actual = customList.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_IntInFirstIndex_IntInSecondIndexIsNowInFirstIndex()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int value = 16;
            int expected = 22;

            //Act
            customList.Add(value);
            customList.Add(expected);
            customList.Remove(value);
            int actual = customList[0];

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_IntInSecondIndex_IntThatWasFirstIndexIsStillFirstIndex()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int expected = 16;
            int value = 22;
            int value1 = 40;
            //Act
            customList.Add(expected);
            customList.Add(value);
            customList.Add(value1);
            customList.Remove(value);
            int actual = customList[0];

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_OneInt_CountIsOneLessThanBefore()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int expected = 2;
            int value = 22;
            int value1 = 40;
            //Act
            customList.Add(expected);
            customList.Add(value);
            customList.Add(value1);
            customList.Remove(value);
            int actual = customList.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        // *** Count Tests ***

        [TestMethod]
        public void Count_OneIntInList_CountEqualsOne()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int expected = 1;
            int value = 22;
            //Act
            customList.Add(value);
            int actual = customList.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Count_EmptyList_CountEqualsZero()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int expected = 0;
            //Act
            int actual = customList.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Count_AddAnotherValueToList_CountGoesUpOne()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int value = 10;
            int value1 = 22;
            
            int expected = 2;

            //Act
            customList.Add(value);
            customList.Add(value1);
            int actual = customList.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Count_RemoveAElementFromList_CountGoesDownOne()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int value = 10;
            int value1 = 22; 
            
            int expected = 1;

            //Act
            customList.Add(value);
            customList.Add(value1);
            customList.Remove(value1);
            int actual = customList.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Count_RemoveAElementThenAddAnother_CountIsTheSame()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int value = 10;
            int value1 = 22;
            int value2 = 33;
            
            int expected = 2;

            //Act
            customList.Add(value);
            customList.Add(value1);
            customList.Remove(value1);
            customList.Add(value2);
            int actual = customList.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        // *** Indexing Tests ***

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Indexer_EmptyListIndexZero_ArgumentOutOfRangeExceptionThrown()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int index = 2;
            //Act
            customList.Remove(index);            
        }

        [TestMethod]
        public void Indexer_ListWithOneElement_IndexZeroGivesUsTheOneElement()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int index = 0;
            int expected = 11;
            //Act
            customList.Add(expected);
            int actual = customList[index];

            //Assert
            Assert.AreEqual(expected, actual);
        }        

        [TestMethod]
        public void Indexer_ListWithTwoElement_IndexZeroGivesUsTheFirstElement()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int index = 0;
            int expected = 11;
            int value = 20;
            //Act
            customList.Add(expected);
            customList.Add(value);
            int actual = customList[index];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Indexer_ListWithTwoElement_IndexOneGivesUsLastElement()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int index = 1;
            int expected = 11;
            int value = 20;
            //Act
            customList.Add(value);
            customList.Add(expected);
            int actual = customList[index];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Indexer_ListWithMultipleElements_IndexOfListCountMinusOneGivesUsLastElement()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int expected = 11;
            int value = 20;
            //Act
            customList.Add(value);
            customList.Add(expected);
            int index = 1; 
            int actual = customList[index];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        // *** '+' Operator Overload Tests ***

        [TestMethod]
        public void PlusOverload_TwoListsT_NewListCountEqualsSumOfTwoListsCounts()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            CustomList<int> customList1 = new CustomList<int>();
            CustomList<int> newList = new CustomList<int>();
            int expected = 4;
            int value = 11;
            int value1 = 2;

            //Act
            customList.Add(value);
            customList.Add(value1);
            customList1.Add(value1);
            customList1.Add(value);
            newList = customList + customList1;
            int actual = newList.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void PlusOverload_TwoListsT_NewListContainsAllValuesOfEachList()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>() { 11, 2 };
            CustomList<int> customList1 = new CustomList<int>() { 4, 9 };
            CustomList<int> newList = new CustomList<int>();
            CustomList<int> expected = new CustomList<int>() { 11, 2, 4, 9 };

            //Act
            newList = customList + customList1;            

            //Assert
            Assert.AreEqual(expected, newList);
        }
        [TestMethod]
        public void PlusOverload_ThreeListsT_NewListContainsAllValuesOfEachList()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>() { 11, 2 };
            CustomList<int> customList1 = new CustomList<int>() { 4, 9 };
            CustomList<int> customList2 = new CustomList<int>() { 55, 66 };
            CustomList<int> expected = new CustomList<int>() { 11, 2, 4, 9, 55, 66 };
            CustomList<int> newList = new CustomList<int>();

            //Act
            newList = customList + customList1 + customList2;

            //Assert
            Assert.AreEqual(expected, newList);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void PlusOverload_TwoNullLists_()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            CustomList<int> customList1 = new CustomList<int>();
            CustomList<int> newList = new CustomList<int>();

            //Act
            newList = customList + customList1;
        }

        // *** '-' Operator Overload Tests ***

        [TestMethod]
        public void MinusOverload_TwoIdenticalListsSubtracted_NewListEmpty()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>() { 11, 2 };
            CustomList<int> customList1 = new CustomList<int>() { 2, 11 };
            CustomList<int> actual = new CustomList<int>();
            CustomList<int> expected = new CustomList<int>();
            //Act
            actual = customList - customList1;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MinusOverload_TwoCompletelyDifferntListsSubtracted_NewListEqualsFirstList()
        {
            //Arrange
            CustomList<int> expected = new CustomList<int>() { 11, 2 };
            CustomList<int> customList1 = new CustomList<int>() { 7, 44 };
            CustomList<int> actual = new CustomList<int>();
            //Act
            actual = expected - customList1;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MinusOverload_TwoListsWithOneSameValue_NewListEqualsFirstListMinusMatchingValues()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>() { 11, 2 };
            CustomList<int> customList1 = new CustomList<int>() { 2, 44 };
            CustomList<int> expected = new CustomList<int>() { 11 };
            CustomList<int> actual = new CustomList<int>();
            //Act
            actual = customList - customList1;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MinusOverload_ThreeListsWithSomeSameValue_NewListEqualsFirstListMinusMatchingValuesOfOtherLists()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>() { 11, 2, 7, 8 };
            CustomList<int> customList1 = new CustomList<int>() { 2, 44, 66, 77};
            CustomList<int> customList2 = new CustomList<int>() { 9, 8, 23 };
            CustomList<int> expected = new CustomList<int>() { 11, 7 };
            CustomList<int> actual = new CustomList<int>();
            //Act
            actual = customList - customList1 - customList2;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MinusOverload_ThreeListsWithSomeSameValue_NewListEqualsFirstListMinusMatchingValuesOfOtherLists()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>() { 11, 2, 7, 8 };
            CustomList<int> customList1 = new CustomList<int>() { 2, 44, 66, 77 };
            CustomList<int> customList2 = new CustomList<int>() { 9, 8, 23 };
            CustomList<int> expected = new CustomList<int>() { 11, 7 };
            CustomList<int> actual = new CustomList<int>();
            //Act
            actual = customList - customList1 - customList2;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        // *** List Zip Tests ***

    }
}

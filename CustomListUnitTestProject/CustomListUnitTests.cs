using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Custom_List_Project;

namespace CustomListUnitTestProject
{
    [TestClass]
    public class CustomListUnitTests
    {

        // ***Add Tests***

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

        // ***Remove Tests***

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
    }
}

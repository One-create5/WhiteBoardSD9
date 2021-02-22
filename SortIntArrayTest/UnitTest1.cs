using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortIntArray;
using System;

namespace SortIntArrayTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_1_4_3_9_2()
        {
            int[] array = {1,4,3,9,2 };
            int[] sortArr = { 1, 4, 3, 9, 2 };
            SortIntArray.SortIntArray.SortArray(array);
            Array.Sort(sortArr);
            for (int i = 0; i < array.Length; i++)
            {
                Assert.AreEqual(sortArr[i], array[i]);
            }
            //Assert.AreEqual( sortArr,SortIntArray.SortIntArray.SortArray(array));
        }

        [TestMethod]
        public void Test_1_4_3_9_2_10_3_1()
        {
            int[] array = { 1, 4, 3, 9, 2,10,3,1 };
            int[] sortArr = { 1, 4, 3, 9, 2, 10, 3, 1 };
            SortIntArray.SortIntArray.SortArray(array);
            Array.Sort(sortArr);
            for (int i = 0; i < array.Length; i++)
            {
                Assert.AreEqual(sortArr[i], array[i]);
            }
            //Assert.AreEqual( sortArr,SortIntArray.SortIntArray.SortArray(array));
        }

        [TestMethod]
        public void Test_2_neg1_neg5_12_0_100_neg3()
        {
            int[] array = {2, -1, -5, 12, 0, 100, -3};
            int[] sortArr = { 2, -1, -5, 12, 0, 100, -3 };
            SortIntArray.SortIntArray.SortArray(array);
            Array.Sort(sortArr);
            for (int i = 0; i < array.Length; i++)
            {
                Assert.AreEqual(sortArr[i], array[i]);
            }
            //Assert.AreEqual( sortArr,SortIntArray.SortIntArray.SortArray(array));
        }
    }
}

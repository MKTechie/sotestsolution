using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SO_TEST_1_2;
namespace SO_TESTCASE_1_2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod_ForGameTask()
        {
            Game game = new Game();
            Assert.AreEqual(game.MacroPolo(20), "1,2,3,macro,5,6,polo,macro,9,10,11,macro,13,polo,15,macro,17,18,19,macro");
            Assert.AreEqual(game.MacroPolo(0), "Invalid range");
            Assert.AreEqual(game.MacroPolo(3), "1,2,3");
        }
        [TestMethod]
        public void TestMethod_ForArraySorting()
        {
            int[] arr1 = { 1, 3, 4, 6, 8 };
            int[] arr2 = { 2, 5, 7, 9, 10 };
            int[] arr3 = { };
            int[] arr4 = { -5, -2, -4, -3, -1, 0 };
            ArraySorting arraySorting = new ArraySorting();

            Assert.IsTrue(IsEqual(arraySorting.SortAndMergeArray(arr1, arr2), new Int32[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }));
            Assert.IsTrue(IsEqual(arraySorting.SortAndMergeArray(arr1, arr3), new Int32[] { 1, 3,4,6,8 }));
            Assert.IsTrue(IsEqual(arraySorting.SortAndMergeArray(arr1, arr4), new Int32[] {-5,-4,-3,-2,-1,0 ,1, 3, 4, 6, 8 }));

        }
        private bool IsEqual(int[] arr, int[] compare)
        {

            if (arr.Length != compare.Length)
            {
                return false;
            }
            else
            {
                int i = 0, j = compare.Length;
                while ((i++) <= (--j))
                {
                    if (arr[i] == compare[i] && arr[j] == compare[j])
                        continue;
                    else
                        return false;
                }
                return true;
            }
        }
    }
}

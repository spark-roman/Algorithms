using Algorithms.Sortings;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgoTests.Sortings
{
    [TestClass]
    public class QuickSortingTests : SertingTests
    {
        [TestMethod]
        public void Sort_PassEmptyArray_ReturnEmptyArray()
        {
            var quickSorting = new QuickSorting();
            var sortedArray = quickSorting.Sort(_emptyArray, 0, _emptyArray.Length - 1);

            CollectionAssert.AreEqual(sortedArray, _emptyArray);
        }

        [TestMethod]
        public void Sort_PassOneElementArray_ReturnOneElementArray()
        {
            var quickSorting = new QuickSorting();
            var sortedArray = quickSorting.Sort(_oneElementArray, 0, _oneElementArray.Length - 1);

            CollectionAssert.AreEqual(sortedArray, _oneElementArray);
        }

        [TestMethod]
        public void Sort_PassValidArray_ReturnSortedArray()
        {
            var quickSorting = new QuickSorting();
            var sortedArray = quickSorting.Sort(_toSortArray, 0, _toSortArray.Length - 1);

            CollectionAssert.AreEqual(sortedArray, _referenceSortedArray);
        }
    }
}

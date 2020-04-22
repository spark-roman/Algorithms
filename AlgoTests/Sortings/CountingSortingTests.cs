using Algorithms.Sortings;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgoTests.Sortings
{
    [TestClass]
    public class CountingSortingTests : SertingTests
    {
        [TestMethod]
        public void Sort_PassEmptyArray_ReturnEmptyArray()
        {
            var countingSorting = new CountingSorting();
            var sortedArray = countingSorting.Sort(_emptyArray, 0, _emptyArray.Length - 1, maxValue: 9);

            CollectionAssert.AreEqual(sortedArray, _emptyArray);
        }

        [TestMethod]
        public void Sort_PassOneElementArray_ReturnOneElementArray()
        {
            var countingSorting = new CountingSorting();
            var sortedArray = countingSorting.Sort(_oneElementArray, 0, _oneElementArray.Length - 1, maxValue: 9);

            CollectionAssert.AreEqual(sortedArray, _oneElementArray);
        }

        [TestMethod]
        public void Sort_PassValidArray_ReturnSortedArray()
        {
            var countingSorting = new CountingSorting();
            var sortedArray = countingSorting.Sort(_toSortArray, 0, _toSortArray.Length - 1, maxValue: 9);

            CollectionAssert.AreEqual(sortedArray, _referenceSortedArray);
        }
    }
}

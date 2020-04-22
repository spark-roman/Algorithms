using Algorithms.Sortings;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgoTests.Sortings
{
    [TestClass]
    public class RadixSortingTests : SortingTests
    {
        [TestMethod]
        public void Sort_PassEmptyArray_ReturnEmptyArray()
        {
            var radixSorting = new RadixSorting();
            var sortedArray = radixSorting.Sort(_emptyArray, 0, _emptyArray.Length - 1, radix: 10);

            CollectionAssert.AreEqual(sortedArray, _emptyArray);
        }

        [TestMethod]
        public void Sort_PassOneElementArray_ReturnOneElementArray()
        {
            var radixSorting = new RadixSorting();
            var sortedArray = radixSorting.Sort(_oneElementArray, 0, _oneElementArray.Length - 1, radix: 10);

            CollectionAssert.AreEqual(sortedArray, _oneElementArray);
        }

        [TestMethod]
        public void Sort_PassValidArray_ReturnSortedArray()
        {
            var radixSorting = new RadixSorting();
            var sortedArray = radixSorting.Sort(_toSortArray, 0, _toSortArray.Length - 1, radix: 10);

            CollectionAssert.AreEqual(sortedArray, _referenceSortedArray);
        }
    }
}

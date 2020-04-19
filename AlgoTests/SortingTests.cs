using Algorithms.Sortings;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgoTests
{
    [TestClass]
    public class SortingTests
    {
        private int[] _emptyArray = new int[0];
        private int[] _oneElementArray = new int[1] { 131 };
        private int[] _nullArray = null;
        private int[] _toSortArray;
        private int[] _referenceSortedArray = new int[] { 3, 6, 15, 17, 28, 97, 100, 127 };

        [TestInitialize]
        public void TestInitialize()
        {
            _toSortArray = new int[] { 100, 97, 3, 28, 15, 17, 6, 127 };
        }

        [TestCleanup]
        public void TestCleanup()
        {
            
        }

        [TestMethod]
        public void Sort_PassEmptyArray_ReturnEmptyArray()
        {
            var insertSorting = new InsertionSort();
            var sortedArray = insertSorting.Sort(_emptyArray, 0, _emptyArray.Length - 1);

            CollectionAssert.AreEqual(sortedArray, _emptyArray);
        }

        [TestMethod]
        public void Sort_PassOneElementArray_ReturnOneElementArray()
        {
            var insertSorting = new InsertionSort();
            var sortedArray = insertSorting.Sort(_oneElementArray, 0, _oneElementArray.Length - 1);

            CollectionAssert.AreEqual(sortedArray, _oneElementArray);
        }

        [TestMethod]
        public void Sort_PassValidArray_ReturnSortedArray()
        {
            var insertSorting = new InsertionSort();
            var sortedArray = insertSorting.Sort(_toSortArray, 0, _toSortArray.Length - 1);

            CollectionAssert.AreEqual(sortedArray, _referenceSortedArray);
        }
    }
}

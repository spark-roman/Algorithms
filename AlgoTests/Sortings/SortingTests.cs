using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgoTests.Sortings
{
    public abstract class SortingTests
    {
        protected int[] _emptyArray = new int[0];
        protected int[] _oneElementArray = new int[1] { 131 };
        protected int[] _nullArray = null;
        protected int[] _toSortArray;
        protected int[] _referenceSortedArray = new int[] { 3, 6, 15, 17, 28, 97, 100, 127 };

        [TestInitialize]
        public void TestInitialize()
        {
            _toSortArray = new int[] { 100, 97, 3, 28, 15, 17, 6, 127 };
        }

        [TestCleanup]
        public void TestCleanup()
        {
            
        }
    }
}

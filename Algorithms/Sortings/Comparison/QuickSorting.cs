using System.Diagnostics.CodeAnalysis;
using Algorithms.Utils;

namespace Algorithms.Sortings
{
    public class QuickSorting : ICompareSortable
    {
        private int SortPartition(int[] array, int first, int last)
        {
            var boundary = array[first];

            var left = first;
            var right = last;

            while (left < right)
            {
                while(array[left] < boundary)
                {
                    left++;
                }

                while(array[right] > boundary)
                {
                    right--;
                }

                if (left < right)
                {
                    RelatedActionsHelper.Swap(ref array[left], ref array[right]);
                }
            }

            return left;
        }

        public int[] Sort([NotNull] int[] array, int first, int last)
        {
            if (first < last)
            {
                var boundary = SortPartition(array, first, last);
                Sort(array, first, boundary);
                Sort(array, boundary + 1, last);
            }

            return array;
        }
    }
}

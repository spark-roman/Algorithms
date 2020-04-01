using System.Diagnostics.CodeAnalysis;
using Algorithms.Utils;

namespace Algorithms.Sortings
{
    public class QuickSort : ISortable
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

        private int[] QuickSortInternal(int[] array, int first, int last)
        {
            if (first < last)
            {
                var boundary = SortPartition(array, first, last);
                QuickSortInternal(array, first, boundary);
                QuickSortInternal(array, boundary + 1, last);
            }

            return array;
        }

        public int[] Sort([NotNull] int[] array)
        {
            return QuickSortInternal(array, 0, array.Length - 1);
        }
    }
}

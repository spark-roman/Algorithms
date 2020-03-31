using System;
using System.Diagnostics.CodeAnalysis;

namespace Algorithms.Sorts
{
    public class MergeSort : ISortable
    {
        private void Merge([NotNull]int[] array, int first, int middle, int last)
        {
            int left = first;
            int right = middle + 1;
            int sortedIndex = 0;

            var sorted = new int[last - first + 1];

            while ((left <= middle) && (right <= last))
            {
                if (array[left] < array[right])
                {
                    sorted[sortedIndex] = array[left];
                    left++;
                }
                else
                {
                    sorted[sortedIndex] = array[right];
                    right++;
                }

                sortedIndex++;
            }

            for (var i = left; i <= middle; i++)
            {
                sorted[sortedIndex] = array[i];
                sortedIndex++;
            }

            for (var i = right; i <= last; i++)
            {
                sorted[sortedIndex] = array[i];
                sortedIndex++;
            }

            for (var i = 0; i < sorted.Length; i++)
            {
                array[first + i] = sorted[i];
            }
        }

        private Array MergeSortInternal([NotNull]int[] array, int first, int last)
        {
            if (first < last)
            {
                var middle = (first + last) / 2;

                MergeSortInternal(array, first, middle);
                MergeSortInternal(array, middle + 1, last);
                Merge(array, first, middle, last);
            }

            return array;
        }

        public int[] Sort([NotNull]int[] array)
        {
            MergeSortInternal(array, 0, array.Length - 1);

            return array;
        }
    }
}
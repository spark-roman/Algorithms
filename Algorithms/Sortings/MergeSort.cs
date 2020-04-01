using System.Diagnostics.CodeAnalysis;

namespace Algorithms.Sortings
{
    public class MergeSort : ISortable
    {
        private void Merge([NotNull]int[] array, int first, int middle, int last)
        {
            var left = first;
            var right = middle + 1;
            var sortedIndex = 0;

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

        public int[] Sort([NotNull]int[] array, int first, int last)
        {
            if (first < last)
            {
                var middle = (first + last) / 2;

                Sort(array, first, middle);
                Sort(array, middle + 1, last);
                Merge(array, first, middle, last);
            }

            return array;
        }
    }
}
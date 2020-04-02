using System.Diagnostics.CodeAnalysis;
using Algorithms.Utils;

namespace Algorithms.Sortings
{
    public class HeapSort : ISortable
    {
        public int[] Sort([NotNull] int[] array, int first, int last)
        {
            var length = last - first + 1;

            for (var i = length / 2 - 1; i >= 0; i--)
            {
                Heapify(array, length, i);
            }

            for (var i = length - 1; i >= 0; i--)
            {
                RelatedActionsHelper.Swap(ref array[0], ref array[i]);
                Heapify(array, i, 0);
            }

            return array;
        }

        private void Heapify(int[] array, int numOfElements, int index)
        {
            var largest = index;
            var left = 2 * index + 1;
            var right = 2 * index + 2;

            if (left < numOfElements && array[left] > array[largest])
            {
                largest = left;
            }

            if (right < numOfElements && array[right] > array[largest])
            {
                largest = right;
            }

            if (largest != index)
            {
                RelatedActionsHelper.Swap(ref array[largest], ref array[index]);
                Heapify(array, numOfElements, largest);
            }
        }
    }
}

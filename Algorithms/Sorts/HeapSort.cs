using System.Diagnostics.CodeAnalysis;
using Algorithms.Utils;

namespace Algorithms.Sorts
{
    public class HeapSort : ISortable
    {
        public int[] Sort([NotNull] int[] array)
        {
            for (int i = array.Length / 2 - 1; i >= 0; i--)
            {
                Heapify(array, array.Length, i);
            }

            for (int i = array.Length - 1; i >= 0; i--)
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

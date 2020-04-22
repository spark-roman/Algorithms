using System.Diagnostics.CodeAnalysis;
using Algorithms.Utils;

namespace Algorithms.Sortings
{
    public class BubbleSorting : ICompareSortable
    {
        public int[] Sort([NotNull]int[] array, int first, int last)
        {
            var length = last - first + 1;

            for (var n = length - 1; 0 < n; n--)
            {
                for (var j = 0; j < length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        RelatedActionsHelper.Swap(ref array[j], ref array[j + 1]);
                    }
                }
            }

            return array;
        }
    }
}
using System;
using System.Diagnostics.CodeAnalysis;

namespace Algorithms.Sortings
{
    public class CountingSort : ICountingSortable
    {
        public int[] Sort([NotNull] int[] array, int first, int last, int maxValue)
        {
            var sortedIndexes = new int[maxValue];

            for (var i = 0; i < maxValue; i++)
            {
                sortedIndexes[i] = 0;
            }

            var length = last - first + 1;

            for (var i = 0; i < length; i++)
            {
                sortedIndexes[array[i] - 1] += 1;
            }

            for (var i = 1; i < length; i++)
            {
                sortedIndexes[i] += sortedIndexes[i - 1];
            }

            var sortedArray = new int[maxValue];
            
            for (var i = length - 1; i >= 0; i--)
            {
                var sortedIndex = sortedIndexes[array[i] - 1] - 1;
                sortedIndexes[array[i] - 1] -= 1;
                
                sortedArray[sortedIndex] = array[i];
            }

            return sortedArray;
        }
    }
}

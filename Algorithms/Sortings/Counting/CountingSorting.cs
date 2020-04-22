using System.Diagnostics.CodeAnalysis;

namespace Algorithms.Sortings
{
    public class CountingSorting : ICountingSortable
    {
        public int[] Sort([NotNull] int[] array, int first, int last, int maxValue)
        {
            var frequencies = new int[maxValue];

            for (var i = 0; i < maxValue; i++)
            {
                frequencies[i] = 0;
            }

            var length = last - first + 1;

            for (var i = 0; i < length; i++)
            {
                frequencies[array[i] - 1] += 1;
            }

            for (var i = 1; i < maxValue; i++)
            {
                frequencies[i] += frequencies[i - 1];
            }

            var sortedArray = new int[length];
            
            for (var i = length - 1; i >= 0; i--)
            {
                var sortedIndex = frequencies[array[i] - 1] - 1;
                frequencies[array[i] - 1] -= 1;
                
                sortedArray[sortedIndex] = array[i];
            }

            return sortedArray;
        }
    }
}

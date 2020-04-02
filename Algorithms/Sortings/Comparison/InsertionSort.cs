using System.Diagnostics.CodeAnalysis;

namespace Algorithms.Sortings
{
    public class InsertionSort : ISortable
    {
        public int[] Sort([NotNull]int[] array, int first, int last)
        {
            var length = last - first + 1;

            for (var j = first + 1; j < length; j++)
            {
                var key = array[j];
                var i = j - 1;

                while (i >= 0 && array[i] > key)
                {
                    array[i + 1] = array[i];
                    i--;
                }

                array[i + 1] = key;
            }

            return array;
        }
    }
}
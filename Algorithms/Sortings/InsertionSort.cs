using System.Diagnostics.CodeAnalysis;

namespace Algorithms.Sortings
{
    public class InsertionSort : ISortable
    {
        public int[] Sort([NotNull]int[] array)
        {
            for (var j = 1; j < array.Length; j++)
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
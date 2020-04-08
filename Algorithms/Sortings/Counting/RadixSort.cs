using System.Diagnostics.CodeAnalysis;
using Algorithms.Utils;

namespace Algorithms.Sortings
{
    public class RadixSort : ICountingSortable
    {
        public int[] Sort([NotNull] int[] array, int first, int last, int radix)
        {
            var length = last - first + 1;
            var auxiliary = new int[radix, radix];

            var maxValue = RelatedActionsHelper.Max(array);

            for (var divider = 1; maxValue / divider > 0; divider *= 10)
            {
                var frequencies = new int[radix];
                var placeValue = 0;

                for (var i = 0; i < length; i++)
                {
                    placeValue = (array[i] / divider) % 10;
                    auxiliary[placeValue, frequencies[placeValue]] = array[i];
                    frequencies[placeValue] += 1;
                }

                for (int i = 0, index = 0; i <= radix - 1; i++)
                {
                    for (var j = 0; j < frequencies[i]; j++, index++)
                    {
                        array[index] = auxiliary[i, j];
                        auxiliary[i, j] = 0;
                    }
                }
            }

            return array;
        }
    }
}

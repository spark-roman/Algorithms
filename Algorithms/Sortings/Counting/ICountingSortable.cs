using System.Diagnostics.CodeAnalysis;

namespace Algorithms.Sortings
{
    public interface ICountingSortable
    {
        int[] Sort([NotNull]int[] array, int first, int last, int maxValue);
    }
}